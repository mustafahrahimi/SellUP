using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SellUp.UserControls
{
    public partial class AddProductToCartUserControl : UserControl
    {
        
        public event EventHandler ProductSavedToCart;
        public event EventHandler ProductCancel;

        public AddProductToCartUserControl()
        {
            InitializeComponent();
        }
        public string ProductIDText
        {
            get => AddProdToCartIDTextBox.Text;
            set => AddProdToCartIDTextBox.Text = value;
        }
        public string QuantityText
        {
            get => AddProdToCartDesiredUnitsTextBox.Text;
            set => AddProdToCartDesiredUnitsTextBox.Text = value;
        }

        private void AddProdToCartSaveBtn_Click(object sender, EventArgs e)
        {
            string inputProductIDText = AddProdToCartIDTextBox.Text;
            string inputQuantityText = AddProdToCartDesiredUnitsTextBox.Text;

            if (int.TryParse(inputProductIDText, out int productID) && productID > 0 &&
                int.TryParse(inputQuantityText, out int quantity) && quantity > 0)
            {
                ProductSavedToCart?.Invoke(this, new ProductSaveEventArgs(productID, quantity));

                if (this.Parent != null)
                {
                    this.Parent.Controls.Remove(this);
                }
            }
            else
            {
                MessageBox.Show("Invalid Product ID or Quantity entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddProdToCartCancelBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddProdToCartIDTextBox.Text) ||
                !string.IsNullOrWhiteSpace(AddProdToCartDesiredUnitsTextBox.Text))
            {
                var result = MessageBox.Show("You have unsaved changes. Are you sure you want to cancel?",
                                             "Unsaved Changes",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            ProductCancel?.Invoke(this, EventArgs.Empty);

            if (this.Parent != null)
            {
                this.Parent.Controls.Remove(this);
            }
        }

        public class ProductSaveEventArgs : EventArgs
        {
            public int ProductID { get; }
            public int Quantity { get; }

            public ProductSaveEventArgs(int productID, int quantity)
            {
                ProductID = productID;
                Quantity = quantity;
            }
        }
    }
}

