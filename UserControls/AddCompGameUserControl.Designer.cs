namespace SellUp.UserControls
{
    partial class AddCompGameUserControl
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
            CompGameMainPanel = new Panel();
            CGameTableLayout = new TableLayoutPanel();
            CGPlatformTextBox = new TextBox();
            CGStockTextBox = new TextBox();
            CGPriceTextBox = new TextBox();
            CGPlatformLabel = new Label();
            CGStockLabel = new Label();
            CGPriceLabel = new Label();
            CGNameLabel = new Label();
            CGNameTextBox = new TextBox();
            CompGameMainPanel.SuspendLayout();
            CGameTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // CompGameMainPanel
            // 
            CompGameMainPanel.Controls.Add(CGameTableLayout);
            CompGameMainPanel.Dock = DockStyle.Fill;
            CompGameMainPanel.Location = new Point(0, 0);
            CompGameMainPanel.Name = "CompGameMainPanel";
            CompGameMainPanel.Size = new Size(650, 150);
            CompGameMainPanel.TabIndex = 0;
            // 
            // CGameTableLayout
            // 
            CGameTableLayout.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            CGameTableLayout.ColumnCount = 2;
            CGameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            CGameTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            CGameTableLayout.Controls.Add(CGPlatformTextBox, 1, 3);
            CGameTableLayout.Controls.Add(CGStockTextBox, 1, 2);
            CGameTableLayout.Controls.Add(CGPriceTextBox, 1, 1);
            CGameTableLayout.Controls.Add(CGPlatformLabel, 0, 3);
            CGameTableLayout.Controls.Add(CGStockLabel, 0, 2);
            CGameTableLayout.Controls.Add(CGPriceLabel, 0, 1);
            CGameTableLayout.Controls.Add(CGNameLabel, 0, 0);
            CGameTableLayout.Controls.Add(CGNameTextBox, 1, 0);
            CGameTableLayout.Dock = DockStyle.Fill;
            CGameTableLayout.Location = new Point(0, 0);
            CGameTableLayout.Margin = new Padding(1);
            CGameTableLayout.Name = "CGameTableLayout";
            CGameTableLayout.RowCount = 4;
            CGameTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0024929F));
            CGameTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99917F));
            CGameTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99917F));
            CGameTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 24.99917F));
            CGameTableLayout.Size = new Size(650, 150);
            CGameTableLayout.TabIndex = 29;
            // 
            // CGPlatformTextBox
            // 
            CGPlatformTextBox.BackColor = Color.White;
            CGPlatformTextBox.BorderStyle = BorderStyle.None;
            CGPlatformTextBox.Dock = DockStyle.Fill;
            CGPlatformTextBox.Font = new Font("Segoe UI Emoji", 9F);
            CGPlatformTextBox.Location = new Point(166, 115);
            CGPlatformTextBox.Multiline = true;
            CGPlatformTextBox.Name = "CGPlatformTextBox";
            CGPlatformTextBox.Size = new Size(480, 31);
            CGPlatformTextBox.TabIndex = 23;
            // 
            // CGStockTextBox
            // 
            CGStockTextBox.BackColor = Color.White;
            CGStockTextBox.BorderStyle = BorderStyle.None;
            CGStockTextBox.Dock = DockStyle.Fill;
            CGStockTextBox.Font = new Font("Segoe UI Emoji", 9F);
            CGStockTextBox.Location = new Point(166, 78);
            CGStockTextBox.Multiline = true;
            CGStockTextBox.Name = "CGStockTextBox";
            CGStockTextBox.Size = new Size(480, 30);
            CGStockTextBox.TabIndex = 22;
            // 
            // CGPriceTextBox
            // 
            CGPriceTextBox.BackColor = Color.White;
            CGPriceTextBox.BorderStyle = BorderStyle.None;
            CGPriceTextBox.Dock = DockStyle.Fill;
            CGPriceTextBox.Font = new Font("Segoe UI Emoji", 9F);
            CGPriceTextBox.Location = new Point(166, 41);
            CGPriceTextBox.Multiline = true;
            CGPriceTextBox.Name = "CGPriceTextBox";
            CGPriceTextBox.Size = new Size(480, 30);
            CGPriceTextBox.TabIndex = 21;
            // 
            // CGPlatformLabel
            // 
            CGPlatformLabel.AutoSize = true;
            CGPlatformLabel.BackColor = Color.White;
            CGPlatformLabel.Dock = DockStyle.Fill;
            CGPlatformLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CGPlatformLabel.ForeColor = Color.Black;
            CGPlatformLabel.Location = new Point(4, 115);
            CGPlatformLabel.Margin = new Padding(3);
            CGPlatformLabel.Name = "CGPlatformLabel";
            CGPlatformLabel.Size = new Size(155, 31);
            CGPlatformLabel.TabIndex = 6;
            CGPlatformLabel.Text = "Platform";
            CGPlatformLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CGStockLabel
            // 
            CGStockLabel.AutoSize = true;
            CGStockLabel.BackColor = Color.White;
            CGStockLabel.Dock = DockStyle.Fill;
            CGStockLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CGStockLabel.ForeColor = Color.Black;
            CGStockLabel.Location = new Point(4, 78);
            CGStockLabel.Margin = new Padding(3);
            CGStockLabel.Name = "CGStockLabel";
            CGStockLabel.Size = new Size(155, 30);
            CGStockLabel.TabIndex = 4;
            CGStockLabel.Text = "Stock";
            CGStockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CGPriceLabel
            // 
            CGPriceLabel.AutoSize = true;
            CGPriceLabel.BackColor = Color.White;
            CGPriceLabel.Dock = DockStyle.Fill;
            CGPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CGPriceLabel.ForeColor = Color.Black;
            CGPriceLabel.Location = new Point(4, 41);
            CGPriceLabel.Margin = new Padding(3);
            CGPriceLabel.Name = "CGPriceLabel";
            CGPriceLabel.Size = new Size(155, 30);
            CGPriceLabel.TabIndex = 2;
            CGPriceLabel.Text = "Price*";
            CGPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CGNameLabel
            // 
            CGNameLabel.AutoSize = true;
            CGNameLabel.BackColor = Color.White;
            CGNameLabel.Dock = DockStyle.Fill;
            CGNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CGNameLabel.ForeColor = Color.Black;
            CGNameLabel.Location = new Point(4, 4);
            CGNameLabel.Margin = new Padding(3);
            CGNameLabel.Name = "CGNameLabel";
            CGNameLabel.Size = new Size(155, 30);
            CGNameLabel.TabIndex = 0;
            CGNameLabel.Text = "Name*";
            CGNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CGNameTextBox
            // 
            CGNameTextBox.BackColor = Color.White;
            CGNameTextBox.BorderStyle = BorderStyle.None;
            CGNameTextBox.Dock = DockStyle.Fill;
            CGNameTextBox.Font = new Font("Segoe UI Emoji", 9F);
            CGNameTextBox.Location = new Point(166, 4);
            CGNameTextBox.Multiline = true;
            CGNameTextBox.Name = "CGNameTextBox";
            CGNameTextBox.Size = new Size(480, 30);
            CGNameTextBox.TabIndex = 20;
            // 
            // AddCompGameUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CompGameMainPanel);
            Name = "AddCompGameUserControl";
            Size = new Size(650, 150);
            CompGameMainPanel.ResumeLayout(false);
            CGameTableLayout.ResumeLayout(false);
            CGameTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CompGameMainPanel;
        private TableLayoutPanel CGameTableLayout;
        private TextBox CGPlatformTextBox;
        private TextBox CGStockTextBox;
        private TextBox CGPriceTextBox;
        private Label CGPlatformLabel;
        private Label CGStockLabel;
        private Label CGPriceLabel;
        private Label CGNameLabel;
        private TextBox CGNameTextBox;
    }
}
