using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SellUp.Models;
using SellUp.Utils;

namespace SellUp.Forms
{
    public partial class DataGridViewControl : UserControl
    {
        public DataGridView ProductsDataGridView { get; private set; }

        public DataGridViewControl()
        {
            InitializeComponent();
            ProductsDataGridView = new DataGridView();
            ProductsDataGridViewPanel.CellFormatting += ProductsDataGridView_CellFormatting;
        }
        public void LoadProductsIntoGrid(List<Product> products)
        {
            var table = new DataTable();

            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Type", typeof(string));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(double));
            table.Columns.Add("Stock", typeof(int));
            table.Columns.Add("Author", typeof(string));
            table.Columns.Add("Genre", typeof(string));
            table.Columns.Add("Format", typeof(string));
            table.Columns.Add("Language", typeof(string));
            table.Columns.Add("RunningTime", typeof(string));
            table.Columns.Add("Platform", typeof(string));

            foreach (var product in products)
            {
                if (product is Book book)
                {
                    table.Rows.Add(book.Id, "Book", book.Name, book.Price, book.Stock,
                                   book.Author, book.Genre, book.Format, book.Language, "", "");
                }
                else if (product is Film film)
                {
                    table.Rows.Add(film.Id, "Film", film.Name, film.Price, film.Stock,
                                   "", "", film.Format, "", film.RunningTime.ToString(), "");
                }
                else if (product is ComputerGame game)
                {
                    table.Rows.Add(game.Id, "ComputerGame", game.Name, game.Price, game.Stock,
                                   "", "", "", "", "", game.platform);
                }
            }

            ProductsDataGridViewPanel.DataSource = table;
            ProductsDataGridView = ProductsDataGridViewPanel;
        }
        private void ProductsDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ProductsDataGridViewPanel.Columns[e.ColumnIndex].Name is string columnName &&
                ProductsDataGridViewPanel.Rows[e.RowIndex].DataBoundItem is DataRowView rowView)
            {
                var type = rowView["Type"]?.ToString();

                if ((type == "Book" && (columnName == "RunningTime" || columnName == "Platform")) ||
                    (type == "Film" && (columnName == "Author" || columnName == "Genre" || columnName == "Platform")) ||
                    (type == "ComputerGame" && (columnName == "Author" || columnName == "Genre" || columnName == "RunningTime" || columnName == "Language")))
                {
                    e.CellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void ProductsDataGridViewPanel_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
               try
                {
                    int id = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells["Id"].Value);

                    var selectedProduct = ProductManager.Products.FirstOrDefault(p => p.Id == id) 
                                         ?? ProductManager.LoadedProductsFromCSV.FirstOrDefault(p => p.Id == id);

                    if (selectedProduct != null)
                    {
                        var historyForm = new ProductHistoryForm(selectedProduct);
                        historyForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Product with the selected ID not found.", "Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Error retrieving history for the selected product.", "Not Found Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
