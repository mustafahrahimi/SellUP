namespace SellUp.Forms
{
    partial class DataGridViewControl
    {
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            MainDataGridPanel = new Panel();
            ProductsDataGridViewPanel = new DataGridView();
            MainDataGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridViewPanel).BeginInit();
            SuspendLayout();
            // 
            // MainDataGridPanel
            // 
            MainDataGridPanel.Controls.Add(ProductsDataGridViewPanel);
            MainDataGridPanel.Dock = DockStyle.Fill;
            MainDataGridPanel.Location = new Point(0, 0);
            MainDataGridPanel.Name = "MainDataGridPanel";
            MainDataGridPanel.Size = new Size(950, 510);
            MainDataGridPanel.TabIndex = 0;
            // 
            // ProductsDataGridViewPanel
            // 
            ProductsDataGridViewPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridViewPanel.BackgroundColor = Color.White;
            ProductsDataGridViewPanel.BorderStyle = BorderStyle.None;
            ProductsDataGridViewPanel.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ProductsDataGridViewPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ProductsDataGridViewPanel.DefaultCellStyle = dataGridViewCellStyle1;
            ProductsDataGridViewPanel.Dock = DockStyle.Fill;
            ProductsDataGridViewPanel.GridColor = SystemColors.ScrollBar;
            ProductsDataGridViewPanel.Location = new Point(0, 0);
            ProductsDataGridViewPanel.Name = "ProductsDataGridViewPanel";
            ProductsDataGridViewPanel.ReadOnly = true;
            ProductsDataGridViewPanel.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ProductsDataGridViewPanel.RowHeadersWidth = 62;
            ProductsDataGridViewPanel.Size = new Size(950, 510);
            ProductsDataGridViewPanel.TabIndex = 0;
            ProductsDataGridViewPanel.CellDoubleClick += ProductsDataGridViewPanel_CellDoubleClick;
            // 
            // DataGridViewControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(MainDataGridPanel);
            Name = "DataGridViewControl";
            Size = new Size(950, 510);
            MainDataGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridViewPanel).EndInit();
            ResumeLayout(false);
        }

        private Panel MainDataGridPanel;
        private DataGridView ProductsDataGridViewPanel;
    }
}
