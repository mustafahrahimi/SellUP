using System;
using System.Linq;
using System.Windows.Forms;
using SellUp.Models;

namespace SellUp.UserControls
{
    public partial class DeleteProductUserControl : UserControl
    {
        public event EventHandler ProductDeleted;

        public DeleteProductUserControl()
        {
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool isDeleted = DeleteProductById();

                if (isDeleted)
                {
                    ProductDeleted?.Invoke(this, EventArgs.Empty);
                    CloseUserControl();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to delete the product by the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool DeleteProductById()
        {
            if (!int.TryParse(DelByIDTextBox.Text, out int id))
            {
                MessageBox.Show("Invalid Product ID. Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (id < 0)
            {
                MessageBox.Show("Negative Product ID. Please enter a valid numeric ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var product = ProductManager.Products.FirstOrDefault(p => p.Id == id) ??
                          ProductManager.LoadedProductsFromCSV.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                if (product.Stock > 0)
                {
                    var result = MessageBox.Show(
                        "The product has remaining stock. Are you sure you want to delete it?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.No)
                    {
                        return false; 
                    }
                }

                try
                {
                    ProductManager.DeleteProduct(id);
                    ProductDeleted?.Invoke(this, EventArgs.Empty);
                    CloseUserControl();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to delete the product by the given ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("No product found with the given ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private bool HasUnsavedChanges()
        {
            return !string.IsNullOrEmpty(DelByIDTextBox.Text);
        }

        private void ClearInputFields()
        {
            DelByIDTextBox.Text = string.Empty;
        }

        private void CloseUserControl()
        {
            this.Parent?.Controls.Remove(this);
            ClearInputFields();
        }
    }
}
