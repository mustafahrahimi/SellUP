using System;
using System.Linq;
using System.Windows.Forms;
using SellUp.Models;

namespace SellUp.UserControls
{
    public partial class ProcessDeliveryUserControl : UserControl
    {
        public event EventHandler? StockUpdated;

        public ProcessDeliveryUserControl()
        {
            InitializeComponent();
        }
        private void ProcessDeliverySaveBtn_Click(object sender, EventArgs e)
        {
            if (!TryParseInputs(out int productID, out int stockToAdd))
                return;

            if (stockToAdd <= 0)
            {
                MessageBox.Show("Stock cannot be zero or negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (UpdateStock(productID, stockToAdd))
                {
                    MessageBox.Show("Stock updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("An error occurred while updating stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UpdateStock(int productId, int stockToAdd)
        {
            Product? product = FindProductById(productId);
            if (product == null)
                return false;

            ProductManager.UpdateStockAfterDelivery(productId, stockToAdd);
            StockUpdated?.Invoke(this, EventArgs.Empty);
            CloseUserControl();
            return true;
        }

        private void ProcessDeliveryCancelBtn_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                var result = MessageBox.Show(
                    "You have unsaved changes. Are you sure you want to cancel?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;
            }

            CloseUserControl();
        }

        private bool TryParseInputs(out int productID, out int stockToAdd)
        {
            productID = 0;
            stockToAdd = 0;

            if (string.IsNullOrEmpty(ProcessDeliveryIDTextBox.Text) || string.IsNullOrEmpty(ProcessDeliveryStockTextBox.Text))
            {
                MessageBox.Show("Please fill in both the ID and Stock fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(ProcessDeliveryIDTextBox.Text, out productID))
            {
                MessageBox.Show("Product ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(ProcessDeliveryStockTextBox.Text, out stockToAdd))
            {
                MessageBox.Show("Stock must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private Product? FindProductById(int productID)
        {
            return ProductManager.Products?.FirstOrDefault(p => p.Id == productID)
                ?? ProductManager.LoadedProductsFromCSV?.FirstOrDefault(p => p.Id == productID);
        }

        private bool HasUnsavedChanges()
        {
            return !string.IsNullOrEmpty(ProcessDeliveryIDTextBox.Text)
                || !string.IsNullOrEmpty(ProcessDeliveryStockTextBox.Text);
        }

        private void ClearInputFields()
        {
            ProcessDeliveryIDTextBox.Text = string.Empty;
            ProcessDeliveryStockTextBox.Text = string.Empty;
        }

        private void CloseUserControl()
        {
            this.Parent?.Controls.Remove(this);
            ClearInputFields();
        }
    }
}
