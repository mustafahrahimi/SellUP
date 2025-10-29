namespace SellUp.Forms
{
    partial class CashRegisterUserControl
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
            MainLayoutPanel = new TableLayoutPanel();
            CardAndOpsBtnsLayout = new TableLayoutPanel();
            TimerLabel = new Label();
            CashRegisterOpsBtns = new TableLayoutPanel();
            ReturnSaleBtn = new Button();
            ProcessSaleBtn = new Button();
            RmvFromCartBtn = new Button();
            AddToCartBtn = new Button();
            CartLayoutPanel = new TableLayoutPanel();
            CartListBox = new ListBox();
            TotalPriceLayout = new TableLayoutPanel();
            PriceLabel = new Label();
            CheckoutPriceLabel = new Label();
            CartLabel = new Label();
            DataTableLayoutCR = new TableLayoutPanel();
            SearchLayout = new TableLayoutPanel();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            DataGridPanelCR = new Panel();
            MainLayoutPanel.SuspendLayout();
            CardAndOpsBtnsLayout.SuspendLayout();
            CashRegisterOpsBtns.SuspendLayout();
            CartLayoutPanel.SuspendLayout();
            TotalPriceLayout.SuspendLayout();
            DataTableLayoutCR.SuspendLayout();
            SearchLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            MainLayoutPanel.BackColor = Color.White;
            MainLayoutPanel.ColumnCount = 2;
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            MainLayoutPanel.Controls.Add(CardAndOpsBtnsLayout, 0, 0);
            MainLayoutPanel.Controls.Add(DataTableLayoutCR, 1, 0);
            MainLayoutPanel.Dock = DockStyle.Fill;
            MainLayoutPanel.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            MainLayoutPanel.Location = new Point(0, 0);
            MainLayoutPanel.Margin = new Padding(5);
            MainLayoutPanel.Name = "MainLayoutPanel";
            MainLayoutPanel.RowCount = 1;
            MainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainLayoutPanel.Size = new Size(1470, 582);
            MainLayoutPanel.TabIndex = 0;
            // 
            // CardAndOpsBtnsLayout
            // 
            CardAndOpsBtnsLayout.ColumnCount = 1;
            CardAndOpsBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CardAndOpsBtnsLayout.Controls.Add(TimerLabel, 0, 0);
            CardAndOpsBtnsLayout.Controls.Add(CashRegisterOpsBtns, 0, 3);
            CardAndOpsBtnsLayout.Controls.Add(CartLayoutPanel, 0, 2);
            CardAndOpsBtnsLayout.Controls.Add(CartLabel, 0, 1);
            CardAndOpsBtnsLayout.Dock = DockStyle.Fill;
            CardAndOpsBtnsLayout.Location = new Point(3, 3);
            CardAndOpsBtnsLayout.Name = "CardAndOpsBtnsLayout";
            CardAndOpsBtnsLayout.RowCount = 4;
            CardAndOpsBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            CardAndOpsBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            CardAndOpsBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 54F));
            CardAndOpsBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            CardAndOpsBtnsLayout.Size = new Size(361, 576);
            CardAndOpsBtnsLayout.TabIndex = 0;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.BackColor = Color.White;
            TimerLabel.Dock = DockStyle.Fill;
            TimerLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLabel.ForeColor = SystemColors.ControlText;
            TimerLabel.Location = new Point(3, 0);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(355, 46);
            TimerLabel.TabIndex = 6;
            TimerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CashRegisterOpsBtns
            // 
            CashRegisterOpsBtns.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CashRegisterOpsBtns.ColumnCount = 1;
            CashRegisterOpsBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CashRegisterOpsBtns.Controls.Add(ReturnSaleBtn, 0, 3);
            CashRegisterOpsBtns.Controls.Add(ProcessSaleBtn, 0, 2);
            CashRegisterOpsBtns.Controls.Add(RmvFromCartBtn, 0, 1);
            CashRegisterOpsBtns.Controls.Add(AddToCartBtn, 0, 0);
            CashRegisterOpsBtns.Location = new Point(3, 406);
            CashRegisterOpsBtns.Name = "CashRegisterOpsBtns";
            CashRegisterOpsBtns.RowCount = 4;
            CashRegisterOpsBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            CashRegisterOpsBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            CashRegisterOpsBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            CashRegisterOpsBtns.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            CashRegisterOpsBtns.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            CashRegisterOpsBtns.Size = new Size(355, 167);
            CashRegisterOpsBtns.TabIndex = 1;
            // 
            // ReturnSaleBtn
            // 
            ReturnSaleBtn.BackColor = Color.MediumSeaGreen;
            ReturnSaleBtn.Dock = DockStyle.Fill;
            ReturnSaleBtn.FlatAppearance.BorderSize = 0;
            ReturnSaleBtn.FlatStyle = FlatStyle.Flat;
            ReturnSaleBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ReturnSaleBtn.ForeColor = Color.White;
            ReturnSaleBtn.Location = new Point(5, 126);
            ReturnSaleBtn.Margin = new Padding(5, 3, 5, 3);
            ReturnSaleBtn.Name = "ReturnSaleBtn";
            ReturnSaleBtn.Size = new Size(345, 38);
            ReturnSaleBtn.TabIndex = 8;
            ReturnSaleBtn.Text = "Process a Return";
            ReturnSaleBtn.UseVisualStyleBackColor = false;
            ReturnSaleBtn.Click += ReturnSaleBtn_Click;
            // 
            // ProcessSaleBtn
            // 
            ProcessSaleBtn.BackColor = Color.MediumSeaGreen;
            ProcessSaleBtn.Dock = DockStyle.Fill;
            ProcessSaleBtn.FlatAppearance.BorderSize = 0;
            ProcessSaleBtn.FlatStyle = FlatStyle.Flat;
            ProcessSaleBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ProcessSaleBtn.ForeColor = Color.White;
            ProcessSaleBtn.Location = new Point(5, 85);
            ProcessSaleBtn.Margin = new Padding(5, 3, 5, 3);
            ProcessSaleBtn.Name = "ProcessSaleBtn";
            ProcessSaleBtn.Size = new Size(345, 35);
            ProcessSaleBtn.TabIndex = 7;
            ProcessSaleBtn.Text = "Process Purchase";
            ProcessSaleBtn.UseVisualStyleBackColor = false;
            ProcessSaleBtn.Click += ProcessSaleBtn_Click;
            // 
            // RmvFromCartBtn
            // 
            RmvFromCartBtn.BackColor = Color.MediumSeaGreen;
            RmvFromCartBtn.Dock = DockStyle.Fill;
            RmvFromCartBtn.FlatAppearance.BorderSize = 0;
            RmvFromCartBtn.FlatStyle = FlatStyle.Flat;
            RmvFromCartBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            RmvFromCartBtn.ForeColor = Color.White;
            RmvFromCartBtn.Location = new Point(5, 44);
            RmvFromCartBtn.Margin = new Padding(5, 3, 5, 3);
            RmvFromCartBtn.Name = "RmvFromCartBtn";
            RmvFromCartBtn.Size = new Size(345, 35);
            RmvFromCartBtn.TabIndex = 6;
            RmvFromCartBtn.Text = "Delete from Cart";
            RmvFromCartBtn.UseVisualStyleBackColor = false;
            RmvFromCartBtn.Click += RmvFromCartBtn_Click;
            // 
            // AddToCartBtn
            // 
            AddToCartBtn.BackColor = Color.MediumSeaGreen;
            AddToCartBtn.Dock = DockStyle.Fill;
            AddToCartBtn.FlatAppearance.BorderSize = 0;
            AddToCartBtn.FlatStyle = FlatStyle.Flat;
            AddToCartBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            AddToCartBtn.ForeColor = Color.White;
            AddToCartBtn.Location = new Point(5, 3);
            AddToCartBtn.Margin = new Padding(5, 3, 5, 3);
            AddToCartBtn.Name = "AddToCartBtn";
            AddToCartBtn.Size = new Size(345, 35);
            AddToCartBtn.TabIndex = 5;
            AddToCartBtn.Text = " Include into Cart";
            AddToCartBtn.UseVisualStyleBackColor = false;
            AddToCartBtn.Click += AddToCartBtn_Click;
            // 
            // CartLayoutPanel
            // 
            CartLayoutPanel.ColumnCount = 1;
            CartLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CartLayoutPanel.Controls.Add(CartListBox, 0, 0);
            CartLayoutPanel.Controls.Add(TotalPriceLayout, 0, 1);
            CartLayoutPanel.Dock = DockStyle.Fill;
            CartLayoutPanel.Location = new Point(3, 95);
            CartLayoutPanel.Name = "CartLayoutPanel";
            CartLayoutPanel.RowCount = 2;
            CartLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            CartLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            CartLayoutPanel.Size = new Size(355, 305);
            CartLayoutPanel.TabIndex = 2;
            // 
            // CartListBox
            // 
            CartListBox.Dock = DockStyle.Fill;
            CartListBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 25;
            CartListBox.Location = new Point(3, 0);
            CartListBox.Margin = new Padding(3, 0, 3, 3);
            CartListBox.Name = "CartListBox";
            CartListBox.ScrollAlwaysVisible = true;
            CartListBox.Size = new Size(349, 256);
            CartListBox.TabIndex = 3;
            // 
            // TotalPriceLayout
            // 
            TotalPriceLayout.ColumnCount = 2;
            TotalPriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TotalPriceLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TotalPriceLayout.Controls.Add(PriceLabel, 0, 0);
            TotalPriceLayout.Controls.Add(CheckoutPriceLabel, 1, 0);
            TotalPriceLayout.Dock = DockStyle.Fill;
            TotalPriceLayout.Location = new Point(5, 264);
            TotalPriceLayout.Margin = new Padding(5);
            TotalPriceLayout.Name = "TotalPriceLayout";
            TotalPriceLayout.RowCount = 1;
            TotalPriceLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TotalPriceLayout.Size = new Size(345, 36);
            TotalPriceLayout.TabIndex = 4;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.BackColor = Color.White;
            PriceLabel.Dock = DockStyle.Fill;
            PriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(3, 3);
            PriceLabel.Margin = new Padding(3);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(166, 30);
            PriceLabel.TabIndex = 0;
            PriceLabel.Text = "TOTAL CHECKOUT: ";
            PriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CheckoutPriceLabel
            // 
            CheckoutPriceLabel.AutoSize = true;
            CheckoutPriceLabel.Dock = DockStyle.Fill;
            CheckoutPriceLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckoutPriceLabel.Location = new Point(175, 0);
            CheckoutPriceLabel.Name = "CheckoutPriceLabel";
            CheckoutPriceLabel.Size = new Size(167, 36);
            CheckoutPriceLabel.TabIndex = 1;
            CheckoutPriceLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.BackColor = Color.MediumSeaGreen;
            CartLabel.Dock = DockStyle.Fill;
            CartLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CartLabel.ForeColor = Color.White;
            CartLabel.Location = new Point(6, 49);
            CartLabel.Margin = new Padding(6, 3, 6, 3);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(349, 40);
            CartLabel.TabIndex = 3;
            CartLabel.Text = "Shopping Cart";
            CartLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DataTableLayoutCR
            // 
            DataTableLayoutCR.BackColor = Color.Transparent;
            DataTableLayoutCR.ColumnCount = 1;
            DataTableLayoutCR.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DataTableLayoutCR.Controls.Add(SearchLayout, 0, 0);
            DataTableLayoutCR.Controls.Add(DataGridPanelCR, 0, 1);
            DataTableLayoutCR.Dock = DockStyle.Fill;
            DataTableLayoutCR.Location = new Point(370, 3);
            DataTableLayoutCR.Name = "DataTableLayoutCR";
            DataTableLayoutCR.RowCount = 2;
            DataTableLayoutCR.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            DataTableLayoutCR.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            DataTableLayoutCR.Size = new Size(1097, 576);
            DataTableLayoutCR.TabIndex = 1;
            // 
            // SearchLayout
            // 
            SearchLayout.ColumnCount = 2;
            SearchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            SearchLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            SearchLayout.Controls.Add(SearchBtn, 1, 0);
            SearchLayout.Controls.Add(SearchTextBox, 0, 0);
            SearchLayout.Dock = DockStyle.Fill;
            SearchLayout.Location = new Point(3, 3);
            SearchLayout.Name = "SearchLayout";
            SearchLayout.RowCount = 1;
            SearchLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            SearchLayout.Size = new Size(1091, 51);
            SearchLayout.TabIndex = 1;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.MediumSeaGreen;
            SearchBtn.Dock = DockStyle.Fill;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(766, 3);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(322, 45);
            SearchBtn.TabIndex = 3;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Dock = DockStyle.Fill;
            SearchTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(3, 3);
            SearchTextBox.Multiline = true;
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = " Search by product id, name or product type here ...";
            SearchTextBox.Size = new Size(757, 45);
            SearchTextBox.TabIndex = 0;
            // 
            // DataGridPanelCR
            // 
            DataGridPanelCR.BackColor = Color.White;
            DataGridPanelCR.Dock = DockStyle.Fill;
            DataGridPanelCR.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold);
            DataGridPanelCR.Location = new Point(5, 62);
            DataGridPanelCR.Margin = new Padding(5);
            DataGridPanelCR.Name = "DataGridPanelCR";
            DataGridPanelCR.Size = new Size(1087, 509);
            DataGridPanelCR.TabIndex = 0;
            // 
            // CashRegisterUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(MainLayoutPanel);
            Name = "CashRegisterUserControl";
            Size = new Size(1470, 582);
            Load += CashRegisterUserControl_Load;
            MainLayoutPanel.ResumeLayout(false);
            CardAndOpsBtnsLayout.ResumeLayout(false);
            CardAndOpsBtnsLayout.PerformLayout();
            CashRegisterOpsBtns.ResumeLayout(false);
            CartLayoutPanel.ResumeLayout(false);
            TotalPriceLayout.ResumeLayout(false);
            TotalPriceLayout.PerformLayout();
            DataTableLayoutCR.ResumeLayout(false);
            SearchLayout.ResumeLayout(false);
            SearchLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainLayoutPanel;
        private TableLayoutPanel CardAndOpsBtnsLayout;
        private TableLayoutPanel CashRegisterOpsBtns;
        private Button ReturnSaleBtn;
        private Button ProcessSaleBtn;
        private Button RmvFromCartBtn;
        private Button AddToCartBtn;
        private TableLayoutPanel CartLayoutPanel;
        private ListBox CartListBox;
        private TableLayoutPanel TotalPriceLayout;
        private Label PriceLabel;
        private Label CheckoutPriceLabel;
        private Label CartLabel;
        private TableLayoutPanel DataTableLayoutCR;
        private Panel DataGridPanelCR;
        private TableLayoutPanel SearchLayout;
        private Button SearchBtn;
        private TextBox SearchTextBox;
        private Label TimerLabel;
    }
}
