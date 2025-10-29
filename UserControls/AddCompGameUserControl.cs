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
    public partial class AddCompGameUserControl : UserControl
    {
        public AddCompGameUserControl()
        {
            InitializeComponent();
        }
        public string CGName
        {
            get { return CGNameTextBox.Text; }
            set { CGNameTextBox.Text = value; }
        }
        public double Price
        {
            get
            {
                if (double.TryParse(CGPriceTextBox.Text, out double price)) return price;
                else return 0;
            }
            set
            {
                if (value <= 0)
                {
                    CGPriceTextBox.Text = "";
                }
                else
                {
                    CGPriceTextBox.Text = value.ToString();
                }
            }
        }
        public int Stock
        {
            get
            {
                if (int.TryParse(CGStockTextBox.Text, out int stock)) return stock;
                else return 0;
            }
            set
            {
                if (value <= 0)
                {
                    CGStockTextBox.Text = "";
                }
                else
                {
                    CGStockTextBox.Text = value.ToString();
                }
            }
        }
        public string Platform
        {
            get { return CGPlatformTextBox.Text; }
            set { CGPlatformTextBox.Text = value; }
        }
        public bool HasInput()
        {
            return !string.IsNullOrWhiteSpace(CGNameTextBox.Text) ||
                   !string.IsNullOrWhiteSpace(CGPriceTextBox.Text) ||
                   !string.IsNullOrWhiteSpace(CGStockTextBox.Text) ||
                   !string.IsNullOrWhiteSpace(CGPlatformTextBox.Text);
        }

    }
}
