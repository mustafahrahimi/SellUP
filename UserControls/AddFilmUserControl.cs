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
    public partial class AddFilmUserControl : UserControl
    {
        public AddFilmUserControl()
        {
            InitializeComponent();
        }
        public string FilmName
        {
            get { return FNameTextBox.Text; }
            set { FNameTextBox.Text = value; }
        }
        public double Price
        {
            get 
            {
                if (double.TryParse(FPriceTextBox.Text, out double price)) return price; 
                else return 0;
            }
            set 
            {
                if (value <= 0)
                {
                    FPriceTextBox.Text = "";
                }
                else
                {
                    FPriceTextBox.Text = value.ToString();
                }
            }
        }

        public int Stock
        {
            get
            {
                if (int.TryParse(FStockTextBox.Text, out int stock)) return stock;  
                else return 0;
            }
            set
            {
                if (value <= 0)
                {
                    FStockTextBox.Text = "";
                }
                else
                {
                    FStockTextBox.Text = value.ToString();
                }
            }
        }
        public double Runtime
        {
            get
            {
                if (double.TryParse(FRuntimeTextBox.Text, out double price)) return price;
                else return 0;
            }
            set
            {
                if (value <= 0)
                {
                    FRuntimeTextBox.Text = "";
                }
                else
                {
                    FRuntimeTextBox.Text = value.ToString();
                }
            }
        }
        public string Format
        {
            get { return FFormatTextBox.Text; }
            set { FFormatTextBox.Text = value; }
        }
        public bool HasInput()
        {
            return !string.IsNullOrWhiteSpace(FNameTextBox.Text)   ||
                   !string.IsNullOrWhiteSpace(FPriceTextBox.Text)  ||
                   !string.IsNullOrWhiteSpace(FStockTextBox.Text)  ||
                   !string.IsNullOrWhiteSpace(FFormatTextBox.Text) ||
                   !string.IsNullOrWhiteSpace(FRuntimeTextBox.Text);
        }

    }
}
