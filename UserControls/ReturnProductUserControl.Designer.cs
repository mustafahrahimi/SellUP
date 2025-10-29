namespace SellUp.UserControls
{
    partial class ReturnProductUserControl
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
            ReturnProductTableLayout = new TableLayoutPanel();
            ReturnedUnitsTableLayoutPanel = new TableLayoutPanel();
            ProcessDeliveryStockLabel = new Label();
            ReturnedUnitsTextBox = new TextBox();
            SaveCancelBtnsLayout = new TableLayoutPanel();
            ReturnProdCancelBtn = new Button();
            ReturnProdSaveBtn = new Button();
            ReturnProdIDTableLayout = new TableLayoutPanel();
            ReturnProdID = new Label();
            ReturnProdIDTextBox = new TextBox();
            ReturnProdLabel = new Label();
            ReturnProductTableLayout.SuspendLayout();
            ReturnedUnitsTableLayoutPanel.SuspendLayout();
            SaveCancelBtnsLayout.SuspendLayout();
            ReturnProdIDTableLayout.SuspendLayout();
            SuspendLayout();
            // 
            // ReturnProductTableLayout
            // 
            ReturnProductTableLayout.BackColor = Color.MediumSeaGreen;
            ReturnProductTableLayout.ColumnCount = 1;
            ReturnProductTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ReturnProductTableLayout.Controls.Add(ReturnedUnitsTableLayoutPanel, 0, 2);
            ReturnProductTableLayout.Controls.Add(SaveCancelBtnsLayout, 0, 3);
            ReturnProductTableLayout.Controls.Add(ReturnProdIDTableLayout, 0, 1);
            ReturnProductTableLayout.Controls.Add(ReturnProdLabel, 0, 0);
            ReturnProductTableLayout.Dock = DockStyle.Fill;
            ReturnProductTableLayout.Location = new Point(0, 0);
            ReturnProductTableLayout.Margin = new Padding(1);
            ReturnProductTableLayout.Name = "ReturnProductTableLayout";
            ReturnProductTableLayout.RowCount = 4;
            ReturnProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ReturnProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ReturnProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ReturnProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            ReturnProductTableLayout.Size = new Size(750, 200);
            ReturnProductTableLayout.TabIndex = 2;
            // 
            // ReturnedUnitsTableLayoutPanel
            // 
            ReturnedUnitsTableLayoutPanel.ColumnCount = 2;
            ReturnedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ReturnedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            ReturnedUnitsTableLayoutPanel.Controls.Add(ProcessDeliveryStockLabel, 0, 0);
            ReturnedUnitsTableLayoutPanel.Controls.Add(ReturnedUnitsTextBox, 1, 0);
            ReturnedUnitsTableLayoutPanel.Dock = DockStyle.Fill;
            ReturnedUnitsTableLayoutPanel.Location = new Point(0, 100);
            ReturnedUnitsTableLayoutPanel.Margin = new Padding(0);
            ReturnedUnitsTableLayoutPanel.Name = "ReturnedUnitsTableLayoutPanel";
            ReturnedUnitsTableLayoutPanel.RowCount = 1;
            ReturnedUnitsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ReturnedUnitsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            ReturnedUnitsTableLayoutPanel.Size = new Size(750, 50);
            ReturnedUnitsTableLayoutPanel.TabIndex = 32;
            // 
            // ProcessDeliveryStockLabel
            // 
            ProcessDeliveryStockLabel.AutoSize = true;
            ProcessDeliveryStockLabel.Dock = DockStyle.Fill;
            ProcessDeliveryStockLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ProcessDeliveryStockLabel.ForeColor = Color.White;
            ProcessDeliveryStockLabel.Location = new Point(4, 3);
            ProcessDeliveryStockLabel.Margin = new Padding(4, 3, 4, 3);
            ProcessDeliveryStockLabel.Name = "ProcessDeliveryStockLabel";
            ProcessDeliveryStockLabel.Size = new Size(179, 44);
            ProcessDeliveryStockLabel.TabIndex = 1;
            ProcessDeliveryStockLabel.Text = "Received Units";
            ProcessDeliveryStockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReturnedUnitsTextBox
            // 
            ReturnedUnitsTextBox.BorderStyle = BorderStyle.None;
            ReturnedUnitsTextBox.Dock = DockStyle.Fill;
            ReturnedUnitsTextBox.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnedUnitsTextBox.Location = new Point(191, 3);
            ReturnedUnitsTextBox.Margin = new Padding(4, 3, 4, 3);
            ReturnedUnitsTextBox.Multiline = true;
            ReturnedUnitsTextBox.Name = "ReturnedUnitsTextBox";
            ReturnedUnitsTextBox.Size = new Size(555, 44);
            ReturnedUnitsTextBox.TabIndex = 4;
            // 
            // SaveCancelBtnsLayout
            // 
            SaveCancelBtnsLayout.ColumnCount = 2;
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Controls.Add(ReturnProdCancelBtn, 1, 0);
            SaveCancelBtnsLayout.Controls.Add(ReturnProdSaveBtn, 0, 0);
            SaveCancelBtnsLayout.Dock = DockStyle.Fill;
            SaveCancelBtnsLayout.Location = new Point(0, 150);
            SaveCancelBtnsLayout.Margin = new Padding(0);
            SaveCancelBtnsLayout.Name = "SaveCancelBtnsLayout";
            SaveCancelBtnsLayout.RowCount = 1;
            SaveCancelBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Size = new Size(750, 50);
            SaveCancelBtnsLayout.TabIndex = 31;
            // 
            // ReturnProdCancelBtn
            // 
            ReturnProdCancelBtn.BackColor = Color.White;
            ReturnProdCancelBtn.Dock = DockStyle.Bottom;
            ReturnProdCancelBtn.FlatAppearance.BorderSize = 0;
            ReturnProdCancelBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ReturnProdCancelBtn.FlatStyle = FlatStyle.Flat;
            ReturnProdCancelBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            ReturnProdCancelBtn.ForeColor = Color.MediumSeaGreen;
            ReturnProdCancelBtn.Location = new Point(378, 7);
            ReturnProdCancelBtn.Name = "ReturnProdCancelBtn";
            ReturnProdCancelBtn.Size = new Size(369, 40);
            ReturnProdCancelBtn.TabIndex = 30;
            ReturnProdCancelBtn.Text = "Cancel";
            ReturnProdCancelBtn.UseVisualStyleBackColor = false;
            ReturnProdCancelBtn.Click += ReturnProdCancelBtn_Click;
            // 
            // ReturnProdSaveBtn
            // 
            ReturnProdSaveBtn.BackColor = Color.White;
            ReturnProdSaveBtn.Dock = DockStyle.Bottom;
            ReturnProdSaveBtn.FlatAppearance.BorderSize = 0;
            ReturnProdSaveBtn.FlatAppearance.MouseDownBackColor = Color.White;
            ReturnProdSaveBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ReturnProdSaveBtn.FlatStyle = FlatStyle.Flat;
            ReturnProdSaveBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            ReturnProdSaveBtn.ForeColor = Color.MediumSeaGreen;
            ReturnProdSaveBtn.Location = new Point(3, 7);
            ReturnProdSaveBtn.Name = "ReturnProdSaveBtn";
            ReturnProdSaveBtn.Size = new Size(369, 40);
            ReturnProdSaveBtn.TabIndex = 29;
            ReturnProdSaveBtn.Text = "Save";
            ReturnProdSaveBtn.UseVisualStyleBackColor = false;
            ReturnProdSaveBtn.Click += ReturnProdSaveBtn_Click;
            // 
            // ReturnProdIDTableLayout
            // 
            ReturnProdIDTableLayout.ColumnCount = 2;
            ReturnProdIDTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            ReturnProdIDTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            ReturnProdIDTableLayout.Controls.Add(ReturnProdID, 0, 0);
            ReturnProdIDTableLayout.Controls.Add(ReturnProdIDTextBox, 1, 0);
            ReturnProdIDTableLayout.Dock = DockStyle.Fill;
            ReturnProdIDTableLayout.Location = new Point(0, 50);
            ReturnProdIDTableLayout.Margin = new Padding(0);
            ReturnProdIDTableLayout.Name = "ReturnProdIDTableLayout";
            ReturnProdIDTableLayout.RowCount = 1;
            ReturnProdIDTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ReturnProdIDTableLayout.Size = new Size(750, 50);
            ReturnProdIDTableLayout.TabIndex = 0;
            // 
            // ReturnProdID
            // 
            ReturnProdID.AutoSize = true;
            ReturnProdID.Dock = DockStyle.Fill;
            ReturnProdID.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ReturnProdID.ForeColor = Color.White;
            ReturnProdID.Location = new Point(4, 3);
            ReturnProdID.Margin = new Padding(4, 3, 4, 3);
            ReturnProdID.Name = "ReturnProdID";
            ReturnProdID.Size = new Size(179, 44);
            ReturnProdID.TabIndex = 1;
            ReturnProdID.Text = "Product Sale ID";
            ReturnProdID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReturnProdIDTextBox
            // 
            ReturnProdIDTextBox.BorderStyle = BorderStyle.None;
            ReturnProdIDTextBox.Dock = DockStyle.Fill;
            ReturnProdIDTextBox.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReturnProdIDTextBox.Location = new Point(191, 3);
            ReturnProdIDTextBox.Margin = new Padding(4, 3, 4, 3);
            ReturnProdIDTextBox.Multiline = true;
            ReturnProdIDTextBox.Name = "ReturnProdIDTextBox";
            ReturnProdIDTextBox.Size = new Size(555, 44);
            ReturnProdIDTextBox.TabIndex = 4;
            // 
            // ReturnProdLabel
            // 
            ReturnProdLabel.AutoSize = true;
            ReturnProdLabel.Dock = DockStyle.Fill;
            ReturnProdLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ReturnProdLabel.ForeColor = Color.White;
            ReturnProdLabel.Location = new Point(4, 0);
            ReturnProdLabel.Margin = new Padding(4, 0, 4, 0);
            ReturnProdLabel.Name = "ReturnProdLabel";
            ReturnProdLabel.Size = new Size(742, 50);
            ReturnProdLabel.TabIndex = 2;
            ReturnProdLabel.Text = "Please enter Product ID and the returned amount to register the return. ";
            ReturnProdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ReturnProductUserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            Controls.Add(ReturnProductTableLayout);
            Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ReturnProductUserControl";
            Size = new Size(750, 200);
            ReturnProductTableLayout.ResumeLayout(false);
            ReturnProductTableLayout.PerformLayout();
            ReturnedUnitsTableLayoutPanel.ResumeLayout(false);
            ReturnedUnitsTableLayoutPanel.PerformLayout();
            SaveCancelBtnsLayout.ResumeLayout(false);
            ReturnProdIDTableLayout.ResumeLayout(false);
            ReturnProdIDTableLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ReturnProductTableLayout;
        private TableLayoutPanel ReturnedUnitsTableLayoutPanel;
        private Label ProcessDeliveryStockLabel;
        private TextBox ReturnedUnitsTextBox;
        private TableLayoutPanel SaveCancelBtnsLayout;
        private Button ReturnProdCancelBtn;
        private Button ReturnProdSaveBtn;
        private TableLayoutPanel ReturnProdIDTableLayout;
        private Label ReturnProdID;
        private TextBox ReturnProdIDTextBox;
        private Label ReturnProdLabel;
    }
}
