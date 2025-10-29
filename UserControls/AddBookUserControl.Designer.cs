namespace SellUp.UserControls
{
    partial class AddBookUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BookMainPanel = new Panel();
            BookTableLayout = new TableLayoutPanel();
            LanguageTextBox = new TextBox();
            LanguageLabel = new Label();
            BFormatTextBox = new TextBox();
            GenreTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            StockTextBox = new TextBox();
            PriceTextBox = new TextBox();
            BFormatLabel = new Label();
            GenreLabel = new Label();
            AuthorLabel = new Label();
            StockLabel = new Label();
            PriceLabel = new Label();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            BookMainPanel.SuspendLayout();
            BookTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // BookMainPanel
            // 
            BookMainPanel.Controls.Add(BookTableLayout);
            BookMainPanel.Dock = DockStyle.Fill;
            BookMainPanel.Location = new Point(0, 0);
            BookMainPanel.Name = "BookMainPanel";
            BookMainPanel.Size = new Size(650, 250);
            BookMainPanel.TabIndex = 0;
            // 
            // BookTableLayout
            // 
            BookTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            BookTableLayout.ColumnCount = 2;
            BookTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            BookTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            BookTableLayout.Controls.Add(LanguageTextBox, 1, 6);
            BookTableLayout.Controls.Add(LanguageLabel, 0, 6);
            BookTableLayout.Controls.Add(BFormatTextBox, 1, 5);
            BookTableLayout.Controls.Add(GenreTextBox, 1, 4);
            BookTableLayout.Controls.Add(AuthorTextBox, 1, 3);
            BookTableLayout.Controls.Add(StockTextBox, 1, 2);
            BookTableLayout.Controls.Add(PriceTextBox, 1, 1);
            BookTableLayout.Controls.Add(BFormatLabel, 0, 5);
            BookTableLayout.Controls.Add(GenreLabel, 0, 4);
            BookTableLayout.Controls.Add(AuthorLabel, 0, 3);
            BookTableLayout.Controls.Add(StockLabel, 0, 2);
            BookTableLayout.Controls.Add(PriceLabel, 0, 1);
            BookTableLayout.Controls.Add(NameLabel, 0, 0);
            BookTableLayout.Controls.Add(NameTextBox, 1, 0);
            BookTableLayout.Dock = DockStyle.Fill;
            BookTableLayout.Location = new Point(0, 0);
            BookTableLayout.Margin = new Padding(1);
            BookTableLayout.Name = "BookTableLayout";
            BookTableLayout.RowCount = 7;
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            BookTableLayout.Size = new Size(650, 250);
            BookTableLayout.TabIndex = 2;
            // 
            // LanguageTextBox
            // 
            LanguageTextBox.BackColor = Color.White;
            LanguageTextBox.BorderStyle = BorderStyle.None;
            LanguageTextBox.Dock = DockStyle.Fill;
            LanguageTextBox.Font = new Font("Segoe UI Emoji", 9F);
            LanguageTextBox.Location = new Point(166, 214);
            LanguageTextBox.Multiline = true;
            LanguageTextBox.Name = "LanguageTextBox";
            LanguageTextBox.Size = new Size(480, 32);
            LanguageTextBox.TabIndex = 27;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.BackColor = Color.White;
            LanguageLabel.Dock = DockStyle.Fill;
            LanguageLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            LanguageLabel.ForeColor = Color.Black;
            LanguageLabel.Location = new Point(4, 214);
            LanguageLabel.Margin = new Padding(3, 3, 3, 0);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(155, 35);
            LanguageLabel.TabIndex = 26;
            LanguageLabel.Text = "Language";
            LanguageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BFormatTextBox
            // 
            BFormatTextBox.BackColor = Color.White;
            BFormatTextBox.BorderStyle = BorderStyle.None;
            BFormatTextBox.Dock = DockStyle.Fill;
            BFormatTextBox.Font = new Font("Segoe UI Emoji", 9F);
            BFormatTextBox.Location = new Point(166, 179);
            BFormatTextBox.Multiline = true;
            BFormatTextBox.Name = "BFormatTextBox";
            BFormatTextBox.Size = new Size(480, 28);
            BFormatTextBox.TabIndex = 25;
            // 
            // GenreTextBox
            // 
            GenreTextBox.BackColor = Color.White;
            GenreTextBox.BorderStyle = BorderStyle.None;
            GenreTextBox.Dock = DockStyle.Fill;
            GenreTextBox.Font = new Font("Segoe UI Emoji", 9F);
            GenreTextBox.Location = new Point(166, 144);
            GenreTextBox.Multiline = true;
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(480, 28);
            GenreTextBox.TabIndex = 24;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.BackColor = Color.White;
            AuthorTextBox.BorderStyle = BorderStyle.None;
            AuthorTextBox.Dock = DockStyle.Fill;
            AuthorTextBox.Font = new Font("Segoe UI Emoji", 9F);
            AuthorTextBox.Location = new Point(166, 109);
            AuthorTextBox.Multiline = true;
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(480, 28);
            AuthorTextBox.TabIndex = 23;
            // 
            // StockTextBox
            // 
            StockTextBox.BackColor = Color.White;
            StockTextBox.BorderStyle = BorderStyle.None;
            StockTextBox.Dock = DockStyle.Fill;
            StockTextBox.Font = new Font("Segoe UI Emoji", 9F);
            StockTextBox.Location = new Point(166, 74);
            StockTextBox.Multiline = true;
            StockTextBox.Name = "StockTextBox";
            StockTextBox.Size = new Size(480, 28);
            StockTextBox.TabIndex = 22;
            // 
            // PriceTextBox
            // 
            PriceTextBox.BackColor = Color.White;
            PriceTextBox.BorderStyle = BorderStyle.None;
            PriceTextBox.Dock = DockStyle.Fill;
            PriceTextBox.Font = new Font("Segoe UI Emoji", 9F);
            PriceTextBox.Location = new Point(166, 39);
            PriceTextBox.Multiline = true;
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(480, 28);
            PriceTextBox.TabIndex = 21;
            // 
            // BFormatLabel
            // 
            BFormatLabel.AutoSize = true;
            BFormatLabel.BackColor = Color.White;
            BFormatLabel.Dock = DockStyle.Fill;
            BFormatLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            BFormatLabel.ForeColor = Color.Black;
            BFormatLabel.Location = new Point(4, 179);
            BFormatLabel.Margin = new Padding(3);
            BFormatLabel.Name = "BFormatLabel";
            BFormatLabel.Size = new Size(155, 28);
            BFormatLabel.TabIndex = 10;
            BFormatLabel.Text = "Format";
            BFormatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.BackColor = Color.White;
            GenreLabel.Dock = DockStyle.Fill;
            GenreLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GenreLabel.ForeColor = Color.Black;
            GenreLabel.Location = new Point(4, 144);
            GenreLabel.Margin = new Padding(3);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(155, 28);
            GenreLabel.TabIndex = 8;
            GenreLabel.Text = "Genre";
            GenreLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.BackColor = Color.White;
            AuthorLabel.Dock = DockStyle.Fill;
            AuthorLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AuthorLabel.ForeColor = Color.Black;
            AuthorLabel.Location = new Point(4, 109);
            AuthorLabel.Margin = new Padding(3);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(155, 28);
            AuthorLabel.TabIndex = 6;
            AuthorLabel.Text = "Author";
            AuthorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StockLabel
            // 
            StockLabel.AutoSize = true;
            StockLabel.BackColor = Color.White;
            StockLabel.Dock = DockStyle.Fill;
            StockLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            StockLabel.ForeColor = Color.Black;
            StockLabel.Location = new Point(4, 74);
            StockLabel.Margin = new Padding(3);
            StockLabel.Name = "StockLabel";
            StockLabel.Size = new Size(155, 28);
            StockLabel.TabIndex = 4;
            StockLabel.Text = "Stock";
            StockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.BackColor = Color.White;
            PriceLabel.Dock = DockStyle.Fill;
            PriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            PriceLabel.ForeColor = Color.Black;
            PriceLabel.Location = new Point(4, 39);
            PriceLabel.Margin = new Padding(3);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(155, 28);
            PriceLabel.TabIndex = 2;
            PriceLabel.Text = "Price*";
            PriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.White;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            NameLabel.ForeColor = Color.Black;
            NameLabel.Location = new Point(4, 4);
            NameLabel.Margin = new Padding(3);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(155, 28);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name*";
            NameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameTextBox
            // 
            NameTextBox.BackColor = Color.White;
            NameTextBox.BorderStyle = BorderStyle.None;
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Font = new Font("Segoe UI Emoji", 9F);
            NameTextBox.Location = new Point(166, 4);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(480, 28);
            NameTextBox.TabIndex = 20;
            // 
            // AddBookUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BookMainPanel);
            Name = "AddBookUserControl";
            Size = new Size(650, 250);
            BookMainPanel.ResumeLayout(false);
            BookTableLayout.ResumeLayout(false);
            BookTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BookMainPanel;
        private TableLayoutPanel BookTableLayout;
        private TextBox LanguageTextBox;
        private Label LanguageLabel;
        private TextBox BFormatTextBox;
        private TextBox GenreTextBox;
        private TextBox AuthorTextBox;
        private TextBox StockTextBox;
        private TextBox PriceTextBox;
        private Label BFormatLabel;
        private Label GenreLabel;
        private Label AuthorLabel;
        private Label StockLabel;
        private Label PriceLabel;
        private Label NameLabel;
        private TextBox NameTextBox;
    }
}
