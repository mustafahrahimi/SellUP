using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SellUp.Forms;
using SellUp.Models;
using SellUp.UserControls;
using SellUp.Utils;

namespace SellUp
{
    public partial class InventoryUserControl : UserControl
    {
        private AddProductUserControl addProductUserControl;
        private DeleteProductUserControl deleteProductUserControl;
        private ProcessDeliveryUserControl processDeliveryUserControl;
        private DataGridViewControl dataGridView;

        public InventoryUserControl()
        {
            InitializeComponent();
            addProductUserControl = new AddProductUserControl();
            deleteProductUserControl = new DeleteProductUserControl();
            processDeliveryUserControl = new ProcessDeliveryUserControl();
            dataGridView = new DataGridViewControl();
        }

        private void InventoryUserControl_Load(object sender, EventArgs e)
        {
            if (addProductUserControl != null)
            {
                addProductUserControl.Visible = false;
                addProductUserControl.ProductSaved += AddProductUserControl_ProductSaved;
            }

            if (deleteProductUserControl != null)
            {
                deleteProductUserControl.Visible = false;
                deleteProductUserControl.ProductDeleted += DeleteProductUserControl_ProductDeleted;
            }

            if (processDeliveryUserControl != null)
            {
                processDeliveryUserControl.Visible = false;
                processDeliveryUserControl.StockUpdated += ProcessDeliveryUserControl_StockUpdated;
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

        private void ResetSearchHighlighting(DataGridViewControl dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.ProductsDataGridView.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
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
            DataGridPanel.Controls.Clear();
            DataGridPanel.Controls.Add(dataGridView);
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

        private void AddProdBtn_Click(object sender, EventArgs e)
        {
            if (!DataGridPanel.Controls.Contains(addProductUserControl))
            {
                DataGridPanel.Controls.Add(addProductUserControl);
            }

            addProductUserControl.Visible = true;

            CenterControlInPanel(addProductUserControl, DataGridPanel);
            addProductUserControl.BringToFront();
            addProductUserControl.Refresh();
        }

        private void CenterControlInPanel(Control control, Panel panel)
        {
            control.Location = new Point(
                (panel.Width - control.Width) / 2,
                (panel.Height - control.Height) / 2
            );
            panel.Controls.Add(control);
        }

        private void RemoveProdBtn_Click(object sender, EventArgs e)
        {
            if (!DataGridPanel.Controls.Contains(deleteProductUserControl))
            {
                DataGridPanel.Controls.Add(deleteProductUserControl);
            }

            deleteProductUserControl.Visible = true;
            CenterControlInPanel(deleteProductUserControl, DataGridPanel);
            deleteProductUserControl.BringToFront();
            deleteProductUserControl.Refresh();
        }

        private void ProcessDeliveryBtn_Click(object sender, EventArgs e)
        {
            if (!DataGridPanel.Controls.Contains(processDeliveryUserControl))
            {
                DataGridPanel.Controls.Add(processDeliveryUserControl);
            }

            processDeliveryUserControl.Visible = true;
            CenterControlInPanel(processDeliveryUserControl, DataGridPanel);
            processDeliveryUserControl.BringToFront();
            processDeliveryUserControl.Refresh();
        }

        public void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = SearchTextBox.Text.Trim();
            DataGridView productsDataGridView = dataGridView.ProductsDataGridView;

            bool anyProductFound = SearchHelper.PerformSearch(productsDataGridView, searchText);

            if (!anyProductFound)
            {
                MessageBox.Show("No matching product found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void InventoryUserControl_Disposed(object sender, EventArgs e)
        {
            ProductManager.ProductListChanged -= ProductManager_ProductListChanged;
        }

        private void SalesOverViewBtn_Click(object sender, EventArgs e)
        {
            var soldProducts = ProductManager.ReadSalesFromCsv();

            var now = DateTime.Now;
            var currentMonth = now.Month;
            var currentYear = now.Year;

            // Filter sales for the current month and year  
            var monthlySales = soldProducts
                .Where(p => p.DateOfSale.Month == currentMonth && p.DateOfSale.Year == currentYear)
                .ToList();

            var yearlySales = soldProducts
                .Where(p => p.DateOfSale.Year == currentYear)
                .ToList();

            // Calculate total sales amount  
            double monthTotal = monthlySales.Sum(p => p.Price * p.Quantity);
            double yearTotal = yearlySales.Sum(p => p.Price * p.Quantity);

            // Show totals in a custom message box  
            CustomMessageBox.Show($"Total Monthly Sales: {monthTotal:F2}", $"Total Yearly Sales: {yearTotal:F2}", "Sales Overview");

            // Get top 10 selling products this month  
            var topProducts = monthlySales
                .GroupBy(p => p.ProductID)
                .Select(group => new
                {
                    ProductID = group.Key,
                    TotalQuantitySold = group.Sum(p => p.Quantity)
                })
                .OrderByDescending(p => p.TotalQuantitySold)
                .Take(10)
                .ToList();

            var allProducts = ProductManager.Products.Concat(ProductManager.LoadedProductsFromCSV).ToList();

            TopTenListBox.Items.Clear();

            foreach (var product in topProducts)
            {
                var productName = allProducts.FirstOrDefault(p => p.Id == product.ProductID)?.Name ?? "Unknown Product";
                string text = $"{productName} ({product.TotalQuantitySold}) sold".ToUpper();
                TopTenListBox.Items.Add(text);
            }
        }

        private async void FetchfromCentralBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await ProductManager.UpdateProductsFromAPI();
                MessageBox.Show("Product information is updated from central.", "Updating Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Product information could not be updated from central.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SyncwithCentralBtn_Click(object sender, EventArgs e)
        {
            var (success, fail) = await ProductManager.SyncAllLocalStocksToAPI();

            if (fail == 0)
            {
                MessageBox.Show("All Local changes to product information synced successfully.", "Updating Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (success == 0) {
                MessageBox.Show("Failed to sync with central.\n" +
                    "Check your internet connection or the API link. \n" +
                    "Ensure that product ID and stock are present and formatted as integers.", "Updating Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show($"{success} products were synced successfully. {fail} failed to sync.");
            }
        }
    }
}
