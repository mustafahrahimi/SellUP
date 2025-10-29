namespace SellUp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTableLayout = new TableLayoutPanel();
            NavigationPanel = new TableLayoutPanel();
            CashRegisterBtn = new Button();
            InventoryBtn = new Button();
            MainPanel = new Panel();
            WelcomeTableLayout = new TableLayoutPanel();
            WelcomeLabel = new Label();
            NameLabel = new Label();
            WelcomeLabel2 = new Label();
            MainTableLayout.SuspendLayout();
            NavigationPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            WelcomeTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // MainTableLayout
            // 
            MainTableLayout.BackColor = Color.White;
            MainTableLayout.ColumnCount = 1;
            MainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayout.Controls.Add(NavigationPanel, 0, 1);
            MainTableLayout.Controls.Add(MainPanel, 0, 0);
            MainTableLayout.Dock = DockStyle.Fill;
            MainTableLayout.Location = new Point(0, 0);
            MainTableLayout.Name = "MainTableLayout";
            MainTableLayout.RowCount = 2;
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            MainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            MainTableLayout.Size = new Size(1478, 654);
            MainTableLayout.TabIndex = 0;
            // 
            // NavigationPanel
            // 
            NavigationPanel.BackColor = Color.White;
            NavigationPanel.ColumnCount = 2;
            NavigationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NavigationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            NavigationPanel.Controls.Add(CashRegisterBtn, 1, 0);
            NavigationPanel.Controls.Add(InventoryBtn, 0, 0);
            NavigationPanel.Dock = DockStyle.Fill;
            NavigationPanel.Location = new Point(5, 593);
            NavigationPanel.Margin = new Padding(5);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.RowCount = 1;
            NavigationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            NavigationPanel.Size = new Size(1468, 56);
            NavigationPanel.TabIndex = 0;
            // 
            // CashRegisterBtn
            // 
            CashRegisterBtn.BackColor = Color.MediumSeaGreen;
            CashRegisterBtn.Dock = DockStyle.Fill;
            CashRegisterBtn.FlatAppearance.BorderSize = 0;
            CashRegisterBtn.FlatStyle = FlatStyle.Flat;
            CashRegisterBtn.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            CashRegisterBtn.ForeColor = Color.White;
            CashRegisterBtn.Location = new Point(737, 3);
            CashRegisterBtn.Name = "CashRegisterBtn";
            CashRegisterBtn.Size = new Size(728, 50);
            CashRegisterBtn.TabIndex = 3;
            CashRegisterBtn.Text = "Process sales";
            CashRegisterBtn.UseVisualStyleBackColor = false;
            CashRegisterBtn.Click += CashRegisterBtn_Click;
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.MediumSeaGreen;
            InventoryBtn.Dock = DockStyle.Fill;
            InventoryBtn.FlatAppearance.BorderSize = 0;
            InventoryBtn.FlatStyle = FlatStyle.Flat;
            InventoryBtn.Font = new Font("Segoe UI Emoji", 11F, FontStyle.Bold);
            InventoryBtn.ForeColor = Color.White;
            InventoryBtn.Location = new Point(3, 3);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(728, 50);
            InventoryBtn.TabIndex = 2;
            InventoryBtn.Text = "Manage stock";
            InventoryBtn.UseVisualStyleBackColor = false;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.White;
            MainPanel.Controls.Add(WelcomeTableLayout);
            MainPanel.Controls.Add(WelcomeLabel2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.ForeColor = Color.Black;
            MainPanel.Location = new Point(3, 3);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1472, 582);
            MainPanel.TabIndex = 1;
            // 
            // WelcomeTableLayout
            // 
            WelcomeTableLayout.ColumnCount = 2;
            WelcomeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            WelcomeTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            WelcomeTableLayout.Controls.Add(WelcomeLabel, 0, 0);
            WelcomeTableLayout.Controls.Add(NameLabel, 1, 0);
            WelcomeTableLayout.Location = new Point(544, 243);
            WelcomeTableLayout.Name = "WelcomeTableLayout";
            WelcomeTableLayout.RowCount = 1;
            WelcomeTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            WelcomeTableLayout.Size = new Size(304, 52);
            WelcomeTableLayout.TabIndex = 2;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Dock = DockStyle.Fill;
            WelcomeLabel.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel.Location = new Point(3, 0);
            WelcomeLabel.Margin = new Padding(3, 0, 0, 0);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(179, 52);
            WelcomeLabel.TabIndex = 0;
            WelcomeLabel.Text = "Welcome to";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.BackColor = Color.MediumSeaGreen;
            NameLabel.Dock = DockStyle.Fill;
            NameLabel.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(182, 0);
            NameLabel.Margin = new Padding(0, 0, 3, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(119, 52);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "SellUP";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WelcomeLabel2
            // 
            WelcomeLabel2.AutoSize = true;
            WelcomeLabel2.Font = new Font("Segoe UI Emoji", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeLabel2.Location = new Point(258, 338);
            WelcomeLabel2.Name = "WelcomeLabel2";
            WelcomeLabel2.Size = new Size(877, 37);
            WelcomeLabel2.TabIndex = 1;
            WelcomeLabel2.Text = "Use the buttons below to navigate to Inventory or Cash Register.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 654);
            Controls.Add(MainTableLayout);
            MaximumSize = new Size(1500, 710);
            MinimumSize = new Size(1500, 710);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SellUP";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            MainTableLayout.ResumeLayout(false);
            NavigationPanel.ResumeLayout(false);
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            WelcomeTableLayout.ResumeLayout(false);
            WelcomeTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayout;
        private TableLayoutPanel NavigationPanel;
        private Button CashRegisterBtn;
        private Button InventoryBtn;
        private Panel MainPanel;
        private Label WelcomeLabel2;
        private TableLayoutPanel WelcomeTableLayout;
        private Label WelcomeLabel;
        private Label NameLabel;
    }
}
