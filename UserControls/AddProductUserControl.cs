using System;
using System.Windows.Forms;
using SellUp.Forms;
using SellUp.Models;

namespace SellUp.UserControls
{
    public partial class AddProductUserControl : UserControl
    {
        private AddBookUserControl bookUserControl;
        private AddFilmUserControl filmUserControl;
        private AddCompGameUserControl compGameUserControl;

        public event EventHandler ProductSaved;

        public AddProductUserControl()
        {
            InitializeComponent();

            bookUserControl = new AddBookUserControl();
            filmUserControl = new AddFilmUserControl();
            compGameUserControl = new AddCompGameUserControl();

            ProductFormsPanel.Controls.Add(bookUserControl);
            ProductFormsPanel.Controls.Add(filmUserControl);
            ProductFormsPanel.Controls.Add(compGameUserControl);

            ShowView(bookUserControl);
        }

        private void AddProductUserControl_Load(object sender, EventArgs e)
        {
            PopulateProductComboBox();
        }

        private void PopulateProductComboBox()
        {
            ProductComboBox.Items.Add("Book");
            ProductComboBox.Items.Add("Film");
            ProductComboBox.Items.Add("Computer Game");
            ProductComboBox.SelectedItem = "Book";
        }

        private void ProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string? selectedType = ProductComboBox.SelectedItem?.ToString();

            switch (selectedType)
            {
                case "Book":
                    ShowView(bookUserControl);
                    break;
                case "Film":
                    ShowView(filmUserControl);
                    break;
                case "Computer Game":
                    ShowView(compGameUserControl);
                    break;
            }
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

        private void ShowView(UserControl view)
        {
            if (view == null) return;

            ProductFormsPanel.Controls.Clear();
            ProductFormsPanel.Controls.Add(view);

            view.Dock = DockStyle.None;
            view.Location = new Point(
                (ProductFormsPanel.Width - view.Width) / 2,
                (ProductFormsPanel.Height - view.Height) / 2
            );

            view.BringToFront();
            view.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ProductComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a product type.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? selectedType = ProductComboBox.SelectedItem?.ToString();
            Product? newProduct = null;

            switch (selectedType)
            {
                case "Book":
                    if (string.IsNullOrWhiteSpace(bookUserControl.BookName) || bookUserControl.Price <= 0)
                    {
                        MessageBox.Show("Please fill in all required fields for the book.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (bookUserControl.Price < 0 || bookUserControl.Stock < 0)
                    {
                        MessageBox.Show("Please fill in positive values for price or stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    newProduct = new Book
                    {
                        Id = ProductManager.GenerateNewProductId(),
                        Name = bookUserControl.BookName,
                        Price = bookUserControl.Price,
                        Stock = bookUserControl.Stock,
                        Author = bookUserControl.Author,
                        Genre = bookUserControl.Genre,
                        Format = bookUserControl.Format,
                        Language = bookUserControl.Language
                    };
                    break;

                case "Film":
                    if (string.IsNullOrWhiteSpace(filmUserControl.FilmName) || filmUserControl.Price <= 0)
                    {
                        MessageBox.Show("Please fill in all required fields for the film.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (filmUserControl.Price < 0 || filmUserControl.Stock < 0 || filmUserControl.Runtime < 0)
                    {
                        MessageBox.Show("Please fill in positive values for price, stock or runtime.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    newProduct = new Film
                    {
                        Id = ProductManager.GenerateNewProductId(),
                        Name = filmUserControl.FilmName,
                        Price = filmUserControl.Price,
                        Stock = filmUserControl.Stock,
                        Format = filmUserControl.Format,
                        RunningTime = filmUserControl.Runtime
                    };
                    break;

                case "Computer Game":
                    if (string.IsNullOrWhiteSpace(compGameUserControl.CGName) || compGameUserControl.Price <= 0)
                    {
                        MessageBox.Show("Please fill in all required fields for the computer game.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (compGameUserControl.Price < 0 || compGameUserControl.Stock < 0)
                    {
                        MessageBox.Show("Please fill in positive values for price or stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    newProduct = new ComputerGame
                    {
                        Id = ProductManager.GenerateNewProductId(),
                        Name = compGameUserControl.CGName,
                        Price = compGameUserControl.Price,
                        Stock = compGameUserControl.Stock,
                        platform = compGameUserControl.Platform
                    };
                    break;

                default:
                    MessageBox.Show("Invalid product type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (newProduct != null)
            {
                ProductManager.AddProduct(newProduct);
                MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
            }

            ProductSaved?.Invoke(this, EventArgs.Empty);
            CloseUserControl();
        }

        private void ClearInputFields()
        {
            bookUserControl.BookName = "";
            bookUserControl.Author = "";
            bookUserControl.Genre = "";
            bookUserControl.Format = "";
            bookUserControl.Language = "";
            bookUserControl.Price = 0;
            bookUserControl.Stock = 0;

            filmUserControl.FilmName = "";
            filmUserControl.Price = 0;
            filmUserControl.Stock = 0;
            filmUserControl.Format = "";
            filmUserControl.Runtime = 0;

            compGameUserControl.CGName = "";
            compGameUserControl.Price = 0;
            compGameUserControl.Stock = 0;
            compGameUserControl.Platform = "";
        }

        private bool HasUnsavedChanges()
        {
            var selectedType = ProductComboBox.SelectedItem?.ToString();
            return selectedType switch
            {
                "Book" => bookUserControl.HasInput(),
                "Film" => filmUserControl.HasInput(),
                "Computer Game" => compGameUserControl.HasInput(),
                _ => false
            };
        }

        private void CloseUserControl()
        {
            this.Parent?.Controls.Remove(this);
            ClearInputFields();
        }
    }
}
