namespace SellUp
{
    partial class InventoryUserControl
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
            MainTableLayout = new TableLayoutPanel();
            InventoryManagementLayout = new TableLayoutPanel();
            T0p10ProductsLabel = new Label();
            OpsBtnLayout = new TableLayoutPanel();
            SyncwithCentralBtn = new Button();
            FetchfromCentralBtn = new Button();
            SalesOverViewBtn = new Button();
            ProcessDeliveryBtn = new Button();
            RemoveProdBtn = new Button();
            AddProdBtn = new Button();
            TopTenListBox = new ListBox();
            TimerLabel = new Label();
            SearchAndDataLayout = new TableLayoutPanel();
            SearchLayout = new TableLayoutPanel();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            DataGridPanel = new Panel();
            MainTableLayout.SuspendLayout();
            InventoryManagementLayout.SuspendLayout();
            OpsBtnLayout.SuspendLayout();
            SearchAndDataLayout.SuspendLayout();
            SearchLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayout
            // 
            MainTableLayout.BackColor = Color.White;
            MainTableLayout.ColumnCount = 2;
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            MainTableLayout.Controls.Add(InventoryManagementLayout, 0, 0);
            MainTableLayout.Controls.Add(SearchAndDataLayout, 1, 0);
            MainTableLayout.Dock = DockStyle.Fill;
            MainTableLayout.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            MainTableLayout.Location = new Point(0, 0);
            MainTableLayout.Margin = new Padding(5, 4, 5, 4);
            MainTableLayout.Name = "MainTableLayout";
            MainTableLayout.RowCount = 1;
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayout.Size = new Size(1500, 710);
            MainTableLayout.TabIndex = 0;
            // 
            // InventoryManagementLayout
            // 
            InventoryManagementLayout.ColumnCount = 1;
            InventoryManagementLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            InventoryManagementLayout.Controls.Add(T0p10ProductsLabel, 0, 1);
            InventoryManagementLayout.Controls.Add(OpsBtnLayout, 0, 3);
            InventoryManagementLayout.Controls.Add(TopTenListBox, 0, 2);
            InventoryManagementLayout.Controls.Add(TimerLabel, 0, 0);
            InventoryManagementLayout.Dock = DockStyle.Fill;
            InventoryManagementLayout.Location = new Point(4, 3);
            InventoryManagementLayout.Margin = new Padding(4, 3, 4, 3);
            InventoryManagementLayout.Name = "InventoryManagementLayout";
            InventoryManagementLayout.RowCount = 4;
            InventoryManagementLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            InventoryManagementLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            InventoryManagementLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 39F));
            InventoryManagementLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            InventoryManagementLayout.Size = new Size(367, 704);
            InventoryManagementLayout.TabIndex = 1;
            // 
            // T0p10ProductsLabel
            // 
            T0p10ProductsLabel.AutoSize = true;
            T0p10ProductsLabel.BackColor = Color.MediumSeaGreen;
            T0p10ProductsLabel.Dock = DockStyle.Fill;
            T0p10ProductsLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            T0p10ProductsLabel.ForeColor = Color.White;
            T0p10ProductsLabel.Location = new Point(4, 59);
            T0p10ProductsLabel.Margin = new Padding(4, 3, 4, 3);
            T0p10ProductsLabel.Name = "T0p10ProductsLabel";
            T0p10ProductsLabel.Size = new Size(359, 50);
            T0p10ProductsLabel.TabIndex = 4;
            T0p10ProductsLabel.Text = "Customer Favorites";
            T0p10ProductsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OpsBtnLayout
            // 
            OpsBtnLayout.ColumnCount = 1;
            OpsBtnLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            OpsBtnLayout.Controls.Add(SyncwithCentralBtn, 0, 5);
            OpsBtnLayout.Controls.Add(FetchfromCentralBtn, 0, 4);
            OpsBtnLayout.Controls.Add(SalesOverViewBtn, 0, 3);
            OpsBtnLayout.Controls.Add(ProcessDeliveryBtn, 0, 2);
            OpsBtnLayout.Controls.Add(RemoveProdBtn, 0, 1);
            OpsBtnLayout.Controls.Add(AddProdBtn, 0, 0);
            OpsBtnLayout.Dock = DockStyle.Fill;
            OpsBtnLayout.Location = new Point(3, 389);
            OpsBtnLayout.Name = "OpsBtnLayout";
            OpsBtnLayout.RowCount = 6;
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            OpsBtnLayout.Size = new Size(361, 312);
            OpsBtnLayout.TabIndex = 2;
            // 
            // SyncwithCentralBtn
            // 
            SyncwithCentralBtn.BackColor = Color.MediumSeaGreen;
            SyncwithCentralBtn.Dock = DockStyle.Fill;
            SyncwithCentralBtn.FlatAppearance.BorderSize = 0;
            SyncwithCentralBtn.FlatStyle = FlatStyle.Flat;
            SyncwithCentralBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            SyncwithCentralBtn.ForeColor = Color.White;
            SyncwithCentralBtn.Location = new Point(4, 263);
            SyncwithCentralBtn.Margin = new Padding(4, 3, 4, 3);
            SyncwithCentralBtn.Name = "SyncwithCentralBtn";
            SyncwithCentralBtn.Size = new Size(353, 46);
            SyncwithCentralBtn.TabIndex = 9;
            SyncwithCentralBtn.Text = "Sync with Central";
            SyncwithCentralBtn.UseVisualStyleBackColor = false;
            SyncwithCentralBtn.Click += SyncwithCentralBtn_Click;
            // 
            // FetchfromCentralBtn
            // 
            FetchfromCentralBtn.BackColor = Color.MediumSeaGreen;
            FetchfromCentralBtn.Dock = DockStyle.Fill;
            FetchfromCentralBtn.FlatAppearance.BorderSize = 0;
            FetchfromCentralBtn.FlatStyle = FlatStyle.Flat;
            FetchfromCentralBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            FetchfromCentralBtn.ForeColor = Color.White;
            FetchfromCentralBtn.Location = new Point(4, 211);
            FetchfromCentralBtn.Margin = new Padding(4, 3, 4, 3);
            FetchfromCentralBtn.Name = "FetchfromCentralBtn";
            FetchfromCentralBtn.Size = new Size(353, 46);
            FetchfromCentralBtn.TabIndex = 8;
            FetchfromCentralBtn.Text = "Get Central Data";
            FetchfromCentralBtn.UseVisualStyleBackColor = false;
            FetchfromCentralBtn.Click += FetchfromCentralBtn_Click;
            // 
            // SalesOverViewBtn
            // 
            SalesOverViewBtn.BackColor = Color.MediumSeaGreen;
            SalesOverViewBtn.Dock = DockStyle.Fill;
            SalesOverViewBtn.FlatAppearance.BorderSize = 0;
            SalesOverViewBtn.FlatStyle = FlatStyle.Flat;
            SalesOverViewBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            SalesOverViewBtn.ForeColor = Color.White;
            SalesOverViewBtn.Location = new Point(4, 159);
            SalesOverViewBtn.Margin = new Padding(4, 3, 4, 3);
            SalesOverViewBtn.Name = "SalesOverViewBtn";
            SalesOverViewBtn.Size = new Size(353, 46);
            SalesOverViewBtn.TabIndex = 7;
            SalesOverViewBtn.Text = "Breakdown Sales";
            SalesOverViewBtn.UseVisualStyleBackColor = false;
            SalesOverViewBtn.Click += SalesOverViewBtn_Click;
            // 
            // ProcessDeliveryBtn
            // 
            ProcessDeliveryBtn.BackColor = Color.MediumSeaGreen;
            ProcessDeliveryBtn.Dock = DockStyle.Fill;
            ProcessDeliveryBtn.FlatAppearance.BorderSize = 0;
            ProcessDeliveryBtn.FlatStyle = FlatStyle.Flat;
            ProcessDeliveryBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ProcessDeliveryBtn.ForeColor = Color.White;
            ProcessDeliveryBtn.Location = new Point(4, 107);
            ProcessDeliveryBtn.Margin = new Padding(4, 3, 4, 3);
            ProcessDeliveryBtn.Name = "ProcessDeliveryBtn";
            ProcessDeliveryBtn.Size = new Size(353, 46);
            ProcessDeliveryBtn.TabIndex = 6;
            ProcessDeliveryBtn.Text = "Process Delivery";
            ProcessDeliveryBtn.UseVisualStyleBackColor = false;
            ProcessDeliveryBtn.Click += ProcessDeliveryBtn_Click;
            // 
            // RemoveProdBtn
            // 
            RemoveProdBtn.BackColor = Color.MediumSeaGreen;
            RemoveProdBtn.Dock = DockStyle.Fill;
            RemoveProdBtn.FlatAppearance.BorderSize = 0;
            RemoveProdBtn.FlatStyle = FlatStyle.Flat;
            RemoveProdBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            RemoveProdBtn.ForeColor = Color.White;
            RemoveProdBtn.Location = new Point(4, 55);
            RemoveProdBtn.Margin = new Padding(4, 3, 4, 3);
            RemoveProdBtn.Name = "RemoveProdBtn";
            RemoveProdBtn.Size = new Size(353, 46);
            RemoveProdBtn.TabIndex = 5;
            RemoveProdBtn.Text = "Delete Product";
            RemoveProdBtn.UseVisualStyleBackColor = false;
            RemoveProdBtn.Click += RemoveProdBtn_Click;
            // 
            // AddProdBtn
            // 
            AddProdBtn.BackColor = Color.MediumSeaGreen;
            AddProdBtn.Dock = DockStyle.Fill;
            AddProdBtn.FlatAppearance.BorderSize = 0;
            AddProdBtn.FlatStyle = FlatStyle.Flat;
            AddProdBtn.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            AddProdBtn.ForeColor = Color.White;
            AddProdBtn.Location = new Point(4, 3);
            AddProdBtn.Margin = new Padding(4, 3, 4, 3);
            AddProdBtn.Name = "AddProdBtn";
            AddProdBtn.Size = new Size(353, 46);
            AddProdBtn.TabIndex = 4;
            AddProdBtn.Text = "Insert Product";
            AddProdBtn.UseVisualStyleBackColor = false;
            AddProdBtn.Click += AddProdBtn_Click;
            // 
            // TopTenListBox
            // 
            TopTenListBox.Dock = DockStyle.Fill;
            TopTenListBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            TopTenListBox.FormattingEnabled = true;
            TopTenListBox.ItemHeight = 21;
            TopTenListBox.Location = new Point(4, 115);
            TopTenListBox.Margin = new Padding(4, 3, 4, 3);
            TopTenListBox.Name = "TopTenListBox";
            TopTenListBox.ScrollAlwaysVisible = true;
            TopTenListBox.Size = new Size(359, 268);
            TopTenListBox.TabIndex = 3;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Dock = DockStyle.Fill;
            TimerLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLabel.Location = new Point(3, 0);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(361, 56);
            TimerLabel.TabIndex = 5;
            TimerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SearchAndDataLayout
            // 
            SearchAndDataLayout.ColumnCount = 1;
            SearchAndDataLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            SearchAndDataLayout.Controls.Add(SearchLayout, 0, 0);
            SearchAndDataLayout.Controls.Add(DataGridPanel, 0, 1);
            SearchAndDataLayout.Dock = DockStyle.Fill;
            SearchAndDataLayout.Location = new Point(379, 3);
            SearchAndDataLayout.Margin = new Padding(4, 3, 4, 3);
            SearchAndDataLayout.Name = "SearchAndDataLayout";
            SearchAndDataLayout.RowCount = 2;
            SearchAndDataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            SearchAndDataLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            SearchAndDataLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            SearchAndDataLayout.Size = new Size(1117, 704);
            SearchAndDataLayout.TabIndex = 0;
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
            SearchLayout.Size = new Size(1111, 64);
            SearchLayout.TabIndex = 0;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.MediumSeaGreen;
            SearchBtn.Dock = DockStyle.Fill;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(780, 3);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(328, 58);
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
            SearchTextBox.Size = new Size(771, 58);
            SearchTextBox.TabIndex = 0;
            // 
            // DataGridPanel
            // 
            DataGridPanel.Dock = DockStyle.Fill;
            DataGridPanel.Font = new Font("Segoe UI Emoji", 8F, FontStyle.Bold);
            DataGridPanel.Location = new Point(5, 74);
            DataGridPanel.Margin = new Padding(5, 4, 5, 4);
            DataGridPanel.Name = "DataGridPanel";
            DataGridPanel.Size = new Size(1107, 626);
            DataGridPanel.TabIndex = 1;
            // 
            // InventoryUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainTableLayout);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "InventoryUserControl";
            Size = new Size(1500, 710);
            Load += InventoryUserControl_Load;
            MainTableLayout.ResumeLayout(false);
            InventoryManagementLayout.ResumeLayout(false);
            InventoryManagementLayout.PerformLayout();
            OpsBtnLayout.ResumeLayout(false);
            SearchAndDataLayout.ResumeLayout(false);
            SearchLayout.ResumeLayout(false);
            SearchLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayout;
        private TableLayoutPanel SearchAndDataLayout;
        private TableLayoutPanel SearchLayout;
        private TextBox SearchTextBox;
        private Button SearchBtn;
        private TableLayoutPanel InventoryManagementLayout;
        private TableLayoutPanel OpsBtnLayout;
        private Button ProcessDeliveryBtn;
        private Button RemoveProdBtn;
        private Button AddProdBtn;
        private ListBox TopTenListBox;
        private Panel DataGridPanel;
        private Label T0p10ProductsLabel;
        private Button SalesOverViewBtn;
        private Button FetchfromCentralBtn;
        private Button SyncwithCentralBtn;
        private Label TimerLabel;
    }
}
