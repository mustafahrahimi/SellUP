using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SellUp.Models
{
    public static class ProductManager
    {
        private static string solutionPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)?.Parent?.Parent?.Parent?.FullName ?? "";
        private static string databaseFolderPath = Path.Combine(solutionPath, "Database");
        private static string csvFilePath = Path.Combine(databaseFolderPath, "products.csv");
        private static string salesCsvFilePath = Path.Combine(databaseFolderPath, "soldProducts.csv");

        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static BindingList<Product> LoadedProductsFromCSV { get; set; } = new BindingList<Product>();
        public static List<ProductHistoryLog> ProductHistoryLog { get; set; } = new();

        public static event EventHandler? ProductListChanged;
        public static int GenerateUniqueSaleID(int productID)
        {
            Random random = new Random();
            int salt = random.Next(1000, 10000);
            return productID + salt;
        }

        public static async Task UpdateProductsFromAPI()
        {
            try
            {
                using HttpClient client = new HttpClient();
                string xmlString = await client.GetStringAsync("https://hex.cse.kau.se/~jonavest/csharp-api/");

                XDocument doc = XDocument.Parse(xmlString);
                var productElements = doc.Descendants().Where(p =>
                    p.Name == "book" || p.Name == "game" || p.Name == "movie");

                foreach (var element in productElements)
                {
                    int id = int.Parse(element.Element("id")?.Value ?? "-1");
                    double newPrice = double.Parse(element.Element("price")?.Value ?? "0");
                    int newStock = int.Parse(element.Element("stock")?.Value ?? "0");

                    string? typeNameFromAPI = element.Name.LocalName switch
                    {
                        "book" => "Book",
                        "movie" => "Film",
                        "game" => "ComputerGame",
                        _ => null
                    };

                    if (typeNameFromAPI == null) continue;

                    var loadedProduct = LoadedProductsFromCSV.FirstOrDefault (
                        p => p.Id == id && p.GetType().Name == typeNameFromAPI
                    );

                    if (loadedProduct != null)
                    {
                        loadedProduct.Price = newPrice;
                        loadedProduct.Stock = newStock;

                        ProductHistoryLog.Add(new ProductHistoryLog
                        {
                            ProductId = id,
                            ProductType = loadedProduct.GetType().Name,
                            Timestamp = DateTime.Now,
                            Price = newPrice,
                            Stock = newStock,
                        });
                    }

                    var runtimeProduct = Products.FirstOrDefault(
                        p => p.Id == id && p.GetType().Name == typeNameFromAPI
                    );


                    if (runtimeProduct != null)
                    {
                        runtimeProduct.Price = newPrice;
                        runtimeProduct.Stock = newStock;

                        ProductHistoryLog.Add(new ProductHistoryLog
                        {
                            ProductId = id,
                            ProductType = runtimeProduct.GetType().Name,
                            Timestamp = DateTime.Now,
                            Price = newPrice,
                            Stock = newStock,
                        });
                    }
                }

                ProductListChanged?.Invoke(doc, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                throw new Exception("Could not fetch the product information from the central.", ex);
            }
        }

        public static async Task<(bool, string errorMessage)> UpdateProductStockInAPI(Product product)
        {
            try
            {
                string url = $"https://hex.cse.kau.se/~jonavest/csharp-apci/?action=update&id={product.Id}&stock={product.Stock}";

                using HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                string responseContent = await response.Content.ReadAsStringAsync();

                string[] knownErrors = {
                    "no new stock provided",
                    "stock not an integer",
                    "no product id provided",
                    "id not an integer"
                };

                bool responseHasKnownErrors = knownErrors.Any(
                    err => responseContent.IndexOf(err, StringComparison.OrdinalIgnoreCase) >= 0
                );


                if (response.IsSuccessStatusCode && !responseHasKnownErrors)
                {
                    return (true, string.Empty);
                }
                else
                {
                    return (false, $"ID {product.Id}: {responseContent.Trim()}");
                }
            }
            catch{
                return (false, string.Empty);
            }
        }

        public static async Task<(int successCount, int failCount)> SyncAllLocalStocksToAPI()
        {

            var allProducts = Products.Concat(LoadedProductsFromCSV).DistinctBy(p => p.Id);

            int success = 0;
            int fail = 0;
            List<string> errors = new List<string>();

            foreach (var product in allProducts)
            {
                var (isSuccess, error) = await UpdateProductStockInAPI(product);
                if (isSuccess)
                    success++;
                else
                {
                    fail++;
                    errors.Add(error);
                }
            }
            return (success, fail);
        }

        public static void AddProduct(Product product)
        {
            Products.Add(product);
            ProductListChanged?.Invoke(null, EventArgs.Empty);
        }
        public static void DeleteProduct(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id) ?? LoadedProductsFromCSV.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                if (Products.Contains(product))
                    Products.Remove(product);
                else if (LoadedProductsFromCSV.Contains(product))
                    LoadedProductsFromCSV.Remove(product);

                ProductListChanged?.Invoke(null, EventArgs.Empty);
            }
        }
        public static void UpdateStockAfterDelivery(int id, int quantity)
        {
            var product = Products.FirstOrDefault(p => p.Id == id) ?? LoadedProductsFromCSV.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                product.Stock += quantity;
                ProductListChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static void UpdateStockAfterSale(int id, int quantity)
        {
            var product = Products.FirstOrDefault(p => p.Id == id) ?? LoadedProductsFromCSV.FirstOrDefault(p => p.Id == id);
            if (product != null && product.Stock >= quantity)
            {
                product.Stock -= quantity;
                ProductListChanged?.Invoke(null, EventArgs.Empty);
            }
        }

        public static void SaveToCSV()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(csvFilePath, append: false))
                {
                    writer.WriteLine("Id,Type,Name,Price,Stock,Author,Genre,Format,Language,RunningTime,Platform");

                    var allProducts = Products.Concat(LoadedProductsFromCSV).DistinctBy(p => p.Id).OrderBy(p => p.Id);

                    foreach (var product in allProducts)
                    {
                        string type = product.GetType().Name;
                        string line = $"{product.Id},{type},{product.Name},{product.Price.ToString(CultureInfo.InvariantCulture)},{product.Stock},";

                        if (product is Book book)
                        {
                            line += $"{book.Author},{book.Genre},{book.Format},{book.Language},,";
                        }
                        else if (product is Film film)
                        {
                            line += $",,,,{film.Format},{film.RunningTime.ToString(CultureInfo.InvariantCulture)},";
                        }
                        else if (product is ComputerGame game)
                        {
                            line += $",,,,,,{game.platform}";
                        }

                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task LoadProductsFromAPI()
        {
            try
            {
                using HttpClient client = new HttpClient();
                string xmlString = await client.GetStringAsync("https://hex.cse.kau.se/~jonavest/csharp-api/");

                XDocument doc = XDocument.Parse(xmlString);

                var productElements = doc.Descendants("book")
                    .Concat(doc.Descendants("game"))
                    .Concat(doc.Descendants("movie"));

                Products = new BindingList<Product>();

                foreach (var element in productElements)
                {
                    int id = int.Parse(element.Element("id")?.Value ?? "-1");
                    string name = element.Element("name")?.Value ?? "Unnamed";
                    double price = double.Parse(element.Element("price")?.Value ?? "0", CultureInfo.InvariantCulture);
                    int stock = int.Parse(element.Element("stock")?.Value ?? "0");

                    Product? product = null;

                    switch (element.Name.LocalName.ToLower())
                    {
                        case "book":
                            product = new Book
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                Genre = element.Element("genre")?.Value ?? "",
                                Format = element.Element("format")?.Value ?? "",
                                Language = element.Element("language")?.Value ?? ""
                            };
                            break;

                        case "movie":
                            product = new Film
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                Format = element.Element("format")?.Value ?? "",
                                RunningTime = double.TryParse(
                                    element.Element("playtime")?.Value,
                                    NumberStyles.Any,
                                    CultureInfo.InvariantCulture,
                                    out double time) ? time : 0
                            };
                            break;

                        case "game":
                            product = new ComputerGame
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                platform = element.Element("platform")?.Value ?? ""
                            };
                            break;
                    }

                    if (product != null)
                    {
                        Products.Add(product);
                    }
                }

                ProductListChanged?.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading from API: " + ex.Message, "API Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadFromCSV()
        {
            if (!File.Exists(csvFilePath))
                return;

            try
            {
                string[] lines = File.ReadAllLines(csvFilePath);

                Products = new BindingList<Product>();
                LoadedProductsFromCSV = new BindingList<Product>();

                foreach (var line in lines.Skip(1))
                {
                    var parts = line.Split(',');

                    if (parts.Length < 11) continue;

                    int id = int.Parse(parts[0]);
                    string type = parts[1];
                    string name = parts[2];
                    double price = double.Parse(parts[3], CultureInfo.InvariantCulture);
                    int stock = int.Parse(parts[4]);

                    Product? product = null;

                    switch (type)
                    {
                        case "Book":
                            product = new Book
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                Author = parts[5],
                                Genre = parts[6],
                                Format = parts[7],
                                Language = parts[8]
                            };
                            break;

                        case "Film":
                            product = new Film
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                Format = parts[7],
                                RunningTime = double.Parse(parts[10], CultureInfo.InvariantCulture)
                            };
                            break;

                        case "ComputerGame":
                            product = new ComputerGame
                            {
                                Id = id,
                                Name = name,
                                Price = price,
                                Stock = stock,
                                platform = parts[11]
                            };
                            break;
                    }

                    if (product != null)
                    {
                        LoadedProductsFromCSV.Add(product);
                    }
                }

                ProductListChanged?.Invoke(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading from CSV: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SaveSalesToCsv(List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)> soldProducts)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(salesCsvFilePath, append: false))
                {
                    writer.WriteLine("ProductID,UniqueSaleID,Quantity,Price,DateOfSale");

                    foreach (var sale in soldProducts)
                    {
                        string line = $"{sale.ProductID},{sale.uniqueSaleID},{sale.Quantity},{sale.Price.ToString(CultureInfo.InvariantCulture)},{sale.DateOfSale:yyyy-MM-dd}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Could not save sales to CSV.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)> ReadSalesFromCsv()
        {
            var soldProducts = new List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)>();

            if (!File.Exists(salesCsvFilePath))
                return soldProducts;

            var lines = File.ReadAllLines(salesCsvFilePath);

            // Skip header
            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');

                if (parts.Length != 5)
                    continue;

                if (int.TryParse(parts[0], out int productId) &&
                    int.TryParse(parts[1], out int uniqueSaleID) &&
                    int.TryParse(parts[2], out int quantity) &&
                    double.TryParse(parts[3], NumberStyles.Float, CultureInfo.InvariantCulture, out double price) &&
                    DateTime.TryParseExact(parts[4], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateOfSale))
                {
                    soldProducts.Add((productId, uniqueSaleID, quantity, price, dateOfSale));
                }
            }

            return soldProducts;
        }
        public static List<int> ExtractProductIds()
        {
            return LoadedProductsFromCSV
            .Concat(Products)
            .Select(product => product.Id)
            .Distinct()
            .ToList();
        }
        public static int GenerateNewProductId()
        {
            var productIds = ExtractProductIds();
            return (productIds.Count == 0) ? 1 : productIds.Max() + 1;
        }
    }
}
