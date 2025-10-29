namespace SellUp.UserControls
{
    partial class AddProductUserControl
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
            ManageProductsPanel = new Panel();
            ProductFormsPanel = new Panel();
            SaveCancelBtnsLayout = new TableLayoutPanel();
            CancelBtn = new Button();
            SaveBtn = new Button();
            ProductComboBox = new ComboBox();
            ManageProductsPanel.SuspendLayout();
            SaveCancelBtnsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ManageProductsPanel
            // 
            ManageProductsPanel.AutoSize = true;
            ManageProductsPanel.BackColor = Color.White;
            ManageProductsPanel.Controls.Add(ProductFormsPanel);
            ManageProductsPanel.Controls.Add(SaveCancelBtnsLayout);
            ManageProductsPanel.Controls.Add(ProductComboBox);
            ManageProductsPanel.Dock = DockStyle.Fill;
            ManageProductsPanel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageProductsPanel.Location = new Point(1, 1);
            ManageProductsPanel.Name = "ManageProductsPanel";
            ManageProductsPanel.Size = new Size(858, 479);
            ManageProductsPanel.TabIndex = 3;
            // 
            // ProductFormsPanel
            // 
            ProductFormsPanel.AutoSize = true;
            ProductFormsPanel.BackColor = Color.White;
            ProductFormsPanel.BackgroundImageLayout = ImageLayout.None;
            ProductFormsPanel.Location = new Point(29, 89);
            ProductFormsPanel.Margin = new Padding(0);
            ProductFormsPanel.MinimumSize = new Size(800, 300);
            ProductFormsPanel.Name = "ProductFormsPanel";
            ProductFormsPanel.Size = new Size(800, 300);
            ProductFormsPanel.TabIndex = 31;
            // 
            // SaveCancelBtnsLayout
            // 
            SaveCancelBtnsLayout.BackColor = Color.White;
            SaveCancelBtnsLayout.ColumnCount = 2;
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Controls.Add(CancelBtn, 1, 0);
            SaveCancelBtnsLayout.Controls.Add(SaveBtn, 0, 0);
            SaveCancelBtnsLayout.Dock = DockStyle.Bottom;
            SaveCancelBtnsLayout.Location = new Point(0, 429);
            SaveCancelBtnsLayout.Margin = new Padding(0);
            SaveCancelBtnsLayout.Name = "SaveCancelBtnsLayout";
            SaveCancelBtnsLayout.RowCount = 1;
            SaveCancelBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Size = new Size(858, 50);
            SaveCancelBtnsLayout.TabIndex = 30;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.MediumSeaGreen;
            CancelBtn.Dock = DockStyle.Fill;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            CancelBtn.ForeColor = Color.White;
            CancelBtn.Location = new Point(429, 0);
            CancelBtn.Margin = new Padding(0);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(429, 50);
            CancelBtn.TabIndex = 30;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.MediumSeaGreen;
            SaveBtn.Dock = DockStyle.Fill;
            SaveBtn.FlatAppearance.BorderSize = 0;
            SaveBtn.FlatStyle = FlatStyle.Flat;
            SaveBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            SaveBtn.ForeColor = Color.White;
            SaveBtn.Location = new Point(0, 0);
            SaveBtn.Margin = new Padding(0);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(429, 50);
            SaveBtn.TabIndex = 29;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // ProductComboBox
            // 
            ProductComboBox.DropDownHeight = 105;
            ProductComboBox.DropDownWidth = 400;
            ProductComboBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductComboBox.ForeColor = Color.Black;
            ProductComboBox.FormattingEnabled = true;
            ProductComboBox.IntegralHeight = false;
            ProductComboBox.Location = new Point(279, 25);
            ProductComboBox.Margin = new Padding(0);
            ProductComboBox.Name = "ProductComboBox";
            ProductComboBox.Size = new Size(300, 33);
            ProductComboBox.TabIndex = 0;
            ProductComboBox.SelectedIndexChanged += ProductComboBox_SelectedIndexChanged;
            // 
            // AddProductUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(ManageProductsPanel);
            Name = "AddProductUserControl";
            Padding = new Padding(1, 1, 1, 0);
            Size = new Size(860, 480);
            Load += AddProductUserControl_Load;
            ManageProductsPanel.ResumeLayout(false);
            ManageProductsPanel.PerformLayout();
            SaveCancelBtnsLayout.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ManageProductsPanel;
        private ComboBox ProductComboBox;
        private Button SaveBtn;
        private TableLayoutPanel SaveCancelBtnsLayout;
        private Button CancelBtn;
        private Panel ProductFormsPanel;
    }
}
