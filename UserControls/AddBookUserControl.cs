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
    public partial class AddBookUserControl : UserControl
    {
        public AddBookUserControl()
        {
            InitializeComponent();
        }

        public string BookName
        {
            get { return NameTextBox.Text; } 
            set { NameTextBox.Text = value;  }
        }

        public string Author
        {
            get { return AuthorTextBox.Text; }
            set { AuthorTextBox.Text = value; }
        }

        public string Genre
        {
            get { return GenreTextBox.Text; }
            set { GenreTextBox.Text = value; }
        }

        public string Format
        {
            get { return BFormatTextBox.Text; }
            set { BFormatTextBox.Text = value; }
        }

        public string Language
        {
            get { return LanguageTextBox.Text; }
            set { LanguageTextBox.Text = value; }
        }

        public double Price
        {
            get
            {
                if (double.TryParse(PriceTextBox.Text, out double price)) return price;
                else return -1;
            }
            set 
            {
                if (value <= 0)
                {
                    PriceTextBox.Text = "";
                }
                else
                {
                    PriceTextBox.Text = value.ToString();
                }
            }
        }
        public int Stock
        {
            get
            {
                if (int.TryParse(StockTextBox.Text, out int stock)) return stock;
                else return -1;  
            }
            set 
            {
                if (value <= 0)
                {
                    StockTextBox.Text = "";
                }
                else
                {
                    StockTextBox.Text = value.ToString();
                }
            }
        }
        public bool HasInput()
        {
            return !string.IsNullOrWhiteSpace(NameTextBox.Text)    ||
                   !string.IsNullOrWhiteSpace(PriceTextBox.Text)   ||
                   !string.IsNullOrWhiteSpace(StockTextBox.Text)   ||
                   !string.IsNullOrWhiteSpace(AuthorTextBox.Text)  ||
                   !string.IsNullOrWhiteSpace(GenreTextBox.Text)   ||
                   !string.IsNullOrWhiteSpace(BFormatTextBox.Text) ||
                   !string.IsNullOrWhiteSpace(LanguageTextBox.Text);
        }
    }
}
