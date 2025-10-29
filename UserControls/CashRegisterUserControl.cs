using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SellUp.Models;
using SellUp.UserControls;
using SellUp.Utils;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace SellUp.Forms
{
    public partial class CashRegisterUserControl : UserControl
    {
        private AddProductUserControl? addProductUserControl;
        private DeleteProductUserControl? deleteProductUserControl;
        private ReturnProductUserControl? returnProductUserControl;
        private ProcessDeliveryUserControl? processDeliveryUserControl;
        private DataGridViewControl dataGridView;

        public List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)> selectedProductsForSale = new List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)>();

        public CashRegisterUserControl()
        {
            InitializeComponent();
            dataGridView = new DataGridViewControl();
            addProductUserControl = new AddProductUserControl();
            deleteProductUserControl = new DeleteProductUserControl();
            returnProductUserControl = new ReturnProductUserControl();
            processDeliveryUserControl = new ProcessDeliveryUserControl();
        }

        private void CashRegisterUserControl_Load(object sender, EventArgs e)
        {
            if (addProductUserControl != null)
            {
                addProductUserControl.ProductSaved += AddProductUserControl_ProductSaved;
            }

            if (deleteProductUserControl != null)
            {
                deleteProductUserControl.ProductDeleted += DeleteProductUserControl_ProductDeleted;
            }

            if (processDeliveryUserControl != null)
            {
                processDeliveryUserControl.StockUpdated += ProcessDeliveryUserControl_StockUpdated;
            }

            if (returnProductUserControl != null)
            {
                returnProductUserControl.productReturned += ReturnProductUserControl_productReturned;
            }

            ProductManager.ProductListChanged += ProductManager_ProductListChanged;

            UpdateDataGridView(dataGridView);
        }
        public void BindTimer(ElapsedTimer timer)
        {
            timer.SecondsElapsed += (s, seconds) =>
            {
                TimerLabel.Text = "Session Time: " + TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
            };
        }

        private void ReturnProductUserControl_productReturned(object? sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ProductManager_ProductListChanged(object? sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void UpdateDataGridView(DataGridViewControl dataGridView)
        {
            var products = ProductManager.Products;
            var loadedProducts = ProductManager.LoadedProductsFromCSV;

            var allProducts = products.Concat(loadedProducts).DistinctBy(p => p.Id).OrderBy(p => p.Id).ToList();
            dataGridView.LoadProductsIntoGrid(allProducts);
            DataGridPanelCR.Controls.Clear();
            DataGridPanelCR.Controls.Add(dataGridView);
            dataGridView.Dock = DockStyle.Fill;
        }

        private void RefreshDataGridView()
        {
            if (dataGridView != null)
            {
                UpdateDataGridView(dataGridView);
                dataGridView.ProductsDataGridView.Refresh();
            }
        }

        private void AddProductUserControl_ProductSaved(object? sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void DeleteProductUserControl_ProductDeleted(object? sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void ProcessDeliveryUserControl_StockUpdated(object? sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();
            DataGridView productsDataGridView = dataGridView.ProductsDataGridView;

            bool anyProductFound = SearchHelper.PerformSearch(productsDataGridView, searchText);

            if (!anyProductFound)
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddToCartBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView?.ProductsDataGridView?.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.ProductsDataGridView.SelectedRows[0];
                var productName = selectedRow.Cells["Name"]?.Value?.ToString();
                var productStock = selectedRow.Cells["Stock"]?.Value != null ? Convert.ToInt32(selectedRow.Cells["Stock"].Value) : 0;
                var productID = Convert.ToInt32(selectedRow.Cells["Id"]?.Value);
                var productPrice = selectedRow.Cells["Price"]?.Value != null ? Convert.ToDouble(selectedRow.Cells["Price"].Value) : 0.0;

                if (!string.IsNullOrEmpty(productName))
                {
                    var addProductToCartControl = new AddProductToCartUserControl();
                    this.Controls.Add(addProductToCartControl);
                    CenterControlInPanel(addProductToCartControl, DataGridPanelCR);
                    addProductToCartControl.BringToFront();

                    addProductToCartControl.ProductIDText = productID.ToString();
                    addProductToCartControl.QuantityText = "1";

                    addProductToCartControl.ProductSavedToCart += (s, args) =>
                    {
                        var saveArgs = args as AddProductToCartUserControl.ProductSaveEventArgs;
                        if (saveArgs != null)
                        {
                            int inputProductID = saveArgs.ProductID;
                            int quantity = saveArgs.Quantity;

                            if (inputProductID == productID && quantity > 0 && quantity <= productStock)
                            {
                                CartListBox.Items.Add($"{productName} - {quantity}X");

                                int uniqueSaleID = ProductManager.GenerateUniqueSaleID(productID);
                                selectedProductsForSale.Add((productID, uniqueSaleID, quantity, productPrice, DateTime.Now));

                                MessageBox.Show($"{quantity}X {productName} added to cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Controls.Remove(addProductToCartControl);
                            }
                            else if (quantity > productStock)
                            {
                                MessageBox.Show("Quantity exceeds available stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Invalid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    };
                }
            }
            else
            {
                MessageBox.Show("Please select a product to add to the cart.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RmvFromCartBtn_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedItem != null)
            {
                var selectedItem = CartListBox.SelectedItem.ToString();
                var result = MessageBox.Show($"Are you sure you want to remove '{selectedItem}' from the cart?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    CartListBox.Items.Remove(selectedItem);
                    MessageBox.Show($"'{selectedItem}' has been removed from the cart.", "Item Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No items in the cart to process.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void ProcessSaleBtn_Click(object sender, EventArgs e)
        {
            if (selectedProductsForSale.Count == 0)
            {
                MessageBox.Show("No items in the cart to process.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var selectedProduct in selectedProductsForSale)
            {
                var product = ProductManager.Products.FirstOrDefault(p => p.Id == selectedProduct.ProductID) ??
                              ProductManager.LoadedProductsFromCSV.FirstOrDefault(p => p.Id == selectedProduct.ProductID);

                if (product != null && product.Stock < selectedProduct.Quantity)
                {
                    MessageBox.Show($"Not enough stock for {product.Name}.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            double totalCheckout = selectedProductsForSale.Sum(p => p.Price * (p.Quantity));
            CheckoutPriceLabel.Text = $"${totalCheckout:F2}";

            var result = MessageBox.Show("Do you want a bill for this purchase?", "Generate Bill", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                GenerateBillPdf(selectedProductsForSale, totalCheckout);
            }

            foreach (var selectedProduct in selectedProductsForSale)
            {
                ProductManager.UpdateStockAfterSale(selectedProduct.ProductID, selectedProduct.Quantity);
            }

            CartListBox.Items.Clear();

            var previousSales = ProductManager.ReadSalesFromCsv();
            var updatedSalesList = previousSales.Concat(selectedProductsForSale).ToList(); 

            ProductManager.SaveSalesToCsv(updatedSalesList);
            selectedProductsForSale.Clear();
            MessageBox.Show("Sale processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GenerateBillPdf(List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime dateOfSale)> soldProducts, double total)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Bill";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Create a new PDF document
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Bill Receipt";

                    // Create an empty page
                    PdfPage page = document.AddPage();
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Verdana", 12, XFontStyleEx.Regular);

                    double yPoint = 40;
                    gfx.DrawString("Bill Receipt From SellUP", new XFont("Verdana", 14, XFontStyleEx.Bold), XBrushes.Black, new XRect(0, yPoint, page.Width, 20), XStringFormats.TopCenter);
                    yPoint += 40;

                    foreach (var product in soldProducts)
                    {
                        var productDetails = ProductManager.Products.Concat(ProductManager.LoadedProductsFromCSV).First(p => p.Id == product.ProductID);
                        int quantity = product.Quantity;
                        string line = $"{productDetails.Name} ({product.uniqueSaleID}) with {quantity} items at ${product.Price:F2} each, sold on {product.dateOfSale:yyyy-MM-dd}";
                        gfx.DrawString(line, font, XBrushes.Black, new XRect(40, yPoint, page.Width - 80, 20), XStringFormats.TopLeft);
                        yPoint += 25;
                    }

                    yPoint += 10;
                    gfx.DrawString($"Total: ${total:F2}", new XFont("Verdana", 12, XFontStyleEx.Bold), XBrushes.Black, new XRect(40, yPoint, page.Width - 80, 20), XStringFormats.TopLeft);

                    // Save the document
                    document.Save(filePath);
                    MessageBox.Show("Bill has been saved successfully.", "Bill Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void CenterControlInPanel(Control control, Panel panel)
        {
            control.Location = new Point(
                (panel.Width - control.Width) / 2,
                (panel.Height - control.Height) / 2
            );
            panel.Controls.Add(control);
        }

        private void ReturnSaleBtn_Click(object sender, EventArgs e)
        {
            if (returnProductUserControl != null)
            {
                if (!DataGridPanelCR.Controls.Contains(returnProductUserControl))
                {
                    DataGridPanelCR.Controls.Add(returnProductUserControl);
                }
                returnProductUserControl.Visible = true;
                CenterControlInPanel(returnProductUserControl, DataGridPanelCR);
                returnProductUserControl.BringToFront();
                returnProductUserControl.Refresh();
            }
        }
    }
}
