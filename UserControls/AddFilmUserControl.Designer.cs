namespace SellUp.UserControls
{
    partial class AddFilmUserControl
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
            FilmMainPanel = new Panel();
            FilmTableLayout = new TableLayoutPanel();
            FRuntimeTextBox = new TextBox();
            FFormatTextBox = new TextBox();
            FStockTextBox = new TextBox();
            FPriceTextBox = new TextBox();
            FRuntimeLabel = new Label();
            FFormatLabel = new Label();
            FStockLabel = new Label();
            FPriceLabel = new Label();
            FNameLabel = new Label();
            FNameTextBox = new TextBox();
            FilmMainPanel.SuspendLayout();
            FilmTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // FilmMainPanel
            // 
            FilmMainPanel.Controls.Add(FilmTableLayout);
            FilmMainPanel.Dock = DockStyle.Fill;
            FilmMainPanel.Location = new Point(0, 0);
            FilmMainPanel.Name = "FilmMainPanel";
            FilmMainPanel.Size = new Size(650, 185);
            FilmMainPanel.TabIndex = 0;
            // 
            // FilmTableLayout
            // 
            FilmTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            FilmTableLayout.ColumnCount = 2;
            FilmTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            FilmTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            FilmTableLayout.Controls.Add(FRuntimeTextBox, 1, 4);
            FilmTableLayout.Controls.Add(FFormatTextBox, 1, 3);
            FilmTableLayout.Controls.Add(FStockTextBox, 1, 2);
            FilmTableLayout.Controls.Add(FPriceTextBox, 1, 1);
            FilmTableLayout.Controls.Add(FRuntimeLabel, 0, 4);
            FilmTableLayout.Controls.Add(FFormatLabel, 0, 3);
            FilmTableLayout.Controls.Add(FStockLabel, 0, 2);
            FilmTableLayout.Controls.Add(FPriceLabel, 0, 1);
            FilmTableLayout.Controls.Add(FNameLabel, 0, 0);
            FilmTableLayout.Controls.Add(FNameTextBox, 1, 0);
            FilmTableLayout.Dock = DockStyle.Fill;
            FilmTableLayout.Location = new Point(0, 0);
            FilmTableLayout.Margin = new Padding(1);
            FilmTableLayout.Name = "FilmTableLayout";
            FilmTableLayout.RowCount = 5;
            FilmTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20.002121F));
            FilmTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9994678F));
            FilmTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9994678F));
            FilmTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9994678F));
            FilmTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9994717F));
            FilmTableLayout.Size = new Size(650, 185);
            FilmTableLayout.TabIndex = 28;
            // 
            // FRuntimeTextBox
            // 
            FRuntimeTextBox.BackColor = Color.White;
            FRuntimeTextBox.BorderStyle = BorderStyle.None;
            FRuntimeTextBox.Dock = DockStyle.Fill;
            FRuntimeTextBox.Font = new Font("Segoe UI Emoji", 9F);
            FRuntimeTextBox.Location = new Point(166, 148);
            FRuntimeTextBox.Multiline = true;
            FRuntimeTextBox.Name = "FRuntimeTextBox";
            FRuntimeTextBox.Size = new Size(480, 33);
            FRuntimeTextBox.TabIndex = 24;
            // 
            // FFormatTextBox
            // 
            FFormatTextBox.BackColor = Color.White;
            FFormatTextBox.BorderStyle = BorderStyle.None;
            FFormatTextBox.Dock = DockStyle.Fill;
            FFormatTextBox.Font = new Font("Segoe UI Emoji", 9F);
            FFormatTextBox.Location = new Point(166, 112);
            FFormatTextBox.Multiline = true;
            FFormatTextBox.Name = "FFormatTextBox";
            FFormatTextBox.Size = new Size(480, 29);
            FFormatTextBox.TabIndex = 23;
            // 
            // FStockTextBox
            // 
            FStockTextBox.BackColor = Color.White;
            FStockTextBox.BorderStyle = BorderStyle.None;
            FStockTextBox.Dock = DockStyle.Fill;
            FStockTextBox.Font = new Font("Segoe UI Emoji", 9F);
            FStockTextBox.Location = new Point(166, 76);
            FStockTextBox.Multiline = true;
            FStockTextBox.Name = "FStockTextBox";
            FStockTextBox.Size = new Size(480, 29);
            FStockTextBox.TabIndex = 22;
            // 
            // FPriceTextBox
            // 
            FPriceTextBox.BackColor = Color.White;
            FPriceTextBox.BorderStyle = BorderStyle.None;
            FPriceTextBox.Dock = DockStyle.Fill;
            FPriceTextBox.Font = new Font("Segoe UI Emoji", 9F);
            FPriceTextBox.Location = new Point(166, 40);
            FPriceTextBox.Multiline = true;
            FPriceTextBox.Name = "FPriceTextBox";
            FPriceTextBox.Size = new Size(480, 29);
            FPriceTextBox.TabIndex = 21;
            // 
            // FRuntimeLabel
            // 
            FRuntimeLabel.AutoSize = true;
            FRuntimeLabel.BackColor = Color.White;
            FRuntimeLabel.Dock = DockStyle.Fill;
            FRuntimeLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FRuntimeLabel.ForeColor = Color.Black;
            FRuntimeLabel.Location = new Point(4, 148);
            FRuntimeLabel.Margin = new Padding(3);
            FRuntimeLabel.Name = "FRuntimeLabel";
            FRuntimeLabel.Size = new Size(155, 33);
            FRuntimeLabel.TabIndex = 8;
            FRuntimeLabel.Text = "Runtime";
            FRuntimeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FFormatLabel
            // 
            FFormatLabel.AutoSize = true;
            FFormatLabel.BackColor = Color.White;
            FFormatLabel.Dock = DockStyle.Fill;
            FFormatLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FFormatLabel.ForeColor = Color.Black;
            FFormatLabel.Location = new Point(4, 112);
            FFormatLabel.Margin = new Padding(3);
            FFormatLabel.Name = "FFormatLabel";
            FFormatLabel.Size = new Size(155, 29);
            FFormatLabel.TabIndex = 6;
            FFormatLabel.Text = "Format";
            FFormatLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FStockLabel
            // 
            FStockLabel.AutoSize = true;
            FStockLabel.BackColor = Color.White;
            FStockLabel.Dock = DockStyle.Fill;
            FStockLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FStockLabel.ForeColor = Color.Black;
            FStockLabel.Location = new Point(4, 76);
            FStockLabel.Margin = new Padding(3);
            FStockLabel.Name = "FStockLabel";
            FStockLabel.Size = new Size(155, 29);
            FStockLabel.TabIndex = 4;
            FStockLabel.Text = "Stock";
            FStockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FPriceLabel
            // 
            FPriceLabel.AutoSize = true;
            FPriceLabel.BackColor = Color.White;
            FPriceLabel.Dock = DockStyle.Fill;
            FPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FPriceLabel.ForeColor = Color.Black;
            FPriceLabel.Location = new Point(4, 40);
            FPriceLabel.Margin = new Padding(3);
            FPriceLabel.Name = "FPriceLabel";
            FPriceLabel.Size = new Size(155, 29);
            FPriceLabel.TabIndex = 2;
            FPriceLabel.Text = "Price*";
            FPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FNameLabel
            // 
            FNameLabel.AutoSize = true;
            FNameLabel.BackColor = Color.White;
            FNameLabel.Dock = DockStyle.Fill;
            FNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            FNameLabel.ForeColor = Color.Black;
            FNameLabel.Location = new Point(4, 4);
            FNameLabel.Margin = new Padding(3);
            FNameLabel.Name = "FNameLabel";
            FNameLabel.Size = new Size(155, 29);
            FNameLabel.TabIndex = 0;
            FNameLabel.Text = "Name*";
            FNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FNameTextBox
            // 
            FNameTextBox.BackColor = Color.White;
            FNameTextBox.BorderStyle = BorderStyle.None;
            FNameTextBox.Dock = DockStyle.Fill;
            FNameTextBox.Font = new Font("Segoe UI Emoji", 9F);
            FNameTextBox.Location = new Point(166, 4);
            FNameTextBox.Multiline = true;
            FNameTextBox.Name = "FNameTextBox";
            FNameTextBox.Size = new Size(480, 29);
            FNameTextBox.TabIndex = 20;
            // 
            // AddFilmUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmMainPanel);
            Name = "AddFilmUserControl";
            Size = new Size(650, 185);
            FilmMainPanel.ResumeLayout(false);
            FilmTableLayout.ResumeLayout(false);
            FilmTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel FilmMainPanel;
        private TableLayoutPanel FilmTableLayout;
        private TextBox FRuntimeTextBox;
        private TextBox FFormatTextBox;
        private TextBox FStockTextBox;
        private TextBox FPriceTextBox;
        private Label FRuntimeLabel;
        private Label FFormatLabel;
        private Label FStockLabel;
        private Label FPriceLabel;
        private Label FNameLabel;
        private TextBox FNameTextBox;
    }
}
