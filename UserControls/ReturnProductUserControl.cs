using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SellUp.Forms;
using SellUp.Models;

namespace SellUp.UserControls
{
    public partial class ReturnProductUserControl : UserControl
    {

        public List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)> soldProductsReadFromCSV = new List<(int ProductID, int uniqueSaleID, int Quantity, double Price, DateTime DateOfSale)>();
        public event EventHandler productReturned;       
        public ReturnProductUserControl()
        {
            InitializeComponent();
        }
        private void ReturnProdSaveBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ReturnProdIDTextBox.Text, out int uniqueSaleID) &&
                int.TryParse(ReturnedUnitsTextBox.Text, out int returnedUnits) &&
                returnedUnits > 0)
            {
                soldProductsReadFromCSV = ProductManager.ReadSalesFromCsv();

                if (soldProductsReadFromCSV == null || !soldProductsReadFromCSV.Any())
                {
                    MessageBox.Show("The sales list is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int index = soldProductsReadFromCSV.FindIndex(p => p.uniqueSaleID == uniqueSaleID);

                if (index == -1)
                {
                    MessageBox.Show("The requested product was not found in the sales list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var returnedProduct = soldProductsReadFromCSV[index];

                if (returnedUnits > returnedProduct.Quantity)
                {
                    MessageBox.Show("The requested returned units exceeds the sold units.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ProductManager.UpdateStockAfterDelivery(returnedProduct.ProductID, returnedUnits);
                productReturned?.Invoke(this, EventArgs.Empty);

                returnedProduct.Quantity -= returnedUnits;

                if (returnedProduct.Quantity == 0)
                {
                    soldProductsReadFromCSV.RemoveAt(index);
                }
                else
                {
                    soldProductsReadFromCSV[index] = returnedProduct;
                }

                ProductManager.SaveSalesToCsv(soldProductsReadFromCSV);
                MessageBox.Show($"{returnedUnits} units of product {returnedProduct.uniqueSaleID} returned successfully!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter valid Product ID and Returned Units.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReturnProdCancelBtn_Click(object sender, EventArgs e)
        {
            if (HasUnsavedChanges())
            {
                var result = MessageBox.Show("You have unsaved changes. Are you sure you want to cancel?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No)
                    return;
            }
            CloseUserControl();
        }

        private bool HasUnsavedChanges()
        {
            return !string.IsNullOrEmpty(ReturnProdIDTextBox.Text) || !string.IsNullOrEmpty(ReturnedUnitsTextBox.Text);
        }

        private void ClearInputFields()
        {
            ReturnProdIDTextBox.Text = string.Empty;
            ReturnedUnitsTextBox.Text = string.Empty;
        }

        private void CloseUserControl()
        {
            this.Parent?.Controls.Remove(this);
            ClearInputFields();
        }
    }
}
