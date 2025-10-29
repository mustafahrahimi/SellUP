namespace SellUp.UserControls
{
    partial class ProcessDeliveryUserControl
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
            DeleteProductTableLayout = new TableLayoutPanel();
            RecievedUnitsTableLayoutPanel = new TableLayoutPanel();
            ProcessDeliveryStockLabel = new Label();
            ProcessDeliveryStockTextBox = new TextBox();
            SaveCancelBtnsLayout = new TableLayoutPanel();
            ProcessDeliveryCancelBtn = new Button();
            ProcessDeliverySaveBtn = new Button();
            DeleteInputFieldsLayout = new TableLayoutPanel();
            ProcessDeliveryProdId = new Label();
            ProcessDeliveryIDTextBox = new TextBox();
            DelMsgLabel = new Label();
            DeleteProductTableLayout.SuspendLayout();
            RecievedUnitsTableLayoutPanel.SuspendLayout();
            SaveCancelBtnsLayout.SuspendLayout();
            DeleteInputFieldsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteProductTableLayout
            // 
            DeleteProductTableLayout.BackColor = Color.MediumSeaGreen;
            DeleteProductTableLayout.ColumnCount = 1;
            DeleteProductTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DeleteProductTableLayout.Controls.Add(RecievedUnitsTableLayoutPanel, 0, 2);
            DeleteProductTableLayout.Controls.Add(SaveCancelBtnsLayout, 0, 3);
            DeleteProductTableLayout.Controls.Add(DeleteInputFieldsLayout, 0, 1);
            DeleteProductTableLayout.Controls.Add(DelMsgLabel, 0, 0);
            DeleteProductTableLayout.Dock = DockStyle.Fill;
            DeleteProductTableLayout.Location = new Point(0, 0);
            DeleteProductTableLayout.Name = "DeleteProductTableLayout";
            DeleteProductTableLayout.RowCount = 4;
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            DeleteProductTableLayout.Size = new Size(780, 220);
            DeleteProductTableLayout.TabIndex = 1;
            // 
            // RecievedUnitsTableLayoutPanel
            // 
            RecievedUnitsTableLayoutPanel.ColumnCount = 2;
            RecievedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            RecievedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            RecievedUnitsTableLayoutPanel.Controls.Add(ProcessDeliveryStockLabel, 0, 0);
            RecievedUnitsTableLayoutPanel.Controls.Add(ProcessDeliveryStockTextBox, 1, 0);
            RecievedUnitsTableLayoutPanel.Dock = DockStyle.Fill;
            RecievedUnitsTableLayoutPanel.Location = new Point(0, 110);
            RecievedUnitsTableLayoutPanel.Margin = new Padding(0);
            RecievedUnitsTableLayoutPanel.Name = "RecievedUnitsTableLayoutPanel";
            RecievedUnitsTableLayoutPanel.RowCount = 1;
            RecievedUnitsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RecievedUnitsTableLayoutPanel.Size = new Size(780, 55);
            RecievedUnitsTableLayoutPanel.TabIndex = 32;
            // 
            // ProcessDeliveryStockLabel
            // 
            ProcessDeliveryStockLabel.AutoSize = true;
            ProcessDeliveryStockLabel.Dock = DockStyle.Fill;
            ProcessDeliveryStockLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ProcessDeliveryStockLabel.ForeColor = Color.White;
            ProcessDeliveryStockLabel.Location = new Point(3, 3);
            ProcessDeliveryStockLabel.Margin = new Padding(3);
            ProcessDeliveryStockLabel.Name = "ProcessDeliveryStockLabel";
            ProcessDeliveryStockLabel.Size = new Size(189, 49);
            ProcessDeliveryStockLabel.TabIndex = 1;
            ProcessDeliveryStockLabel.Text = "Received Units";
            ProcessDeliveryStockLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProcessDeliveryStockTextBox
            // 
            ProcessDeliveryStockTextBox.BorderStyle = BorderStyle.None;
            ProcessDeliveryStockTextBox.Dock = DockStyle.Fill;
            ProcessDeliveryStockTextBox.Font = new Font("Segoe UI Emoji", 10F);
            ProcessDeliveryStockTextBox.Location = new Point(198, 3);
            ProcessDeliveryStockTextBox.Multiline = true;
            ProcessDeliveryStockTextBox.Name = "ProcessDeliveryStockTextBox";
            ProcessDeliveryStockTextBox.Size = new Size(579, 49);
            ProcessDeliveryStockTextBox.TabIndex = 4;
            // 
            // SaveCancelBtnsLayout
            // 
            SaveCancelBtnsLayout.ColumnCount = 2;
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Controls.Add(ProcessDeliveryCancelBtn, 1, 0);
            SaveCancelBtnsLayout.Controls.Add(ProcessDeliverySaveBtn, 0, 0);
            SaveCancelBtnsLayout.Dock = DockStyle.Fill;
            SaveCancelBtnsLayout.Location = new Point(0, 165);
            SaveCancelBtnsLayout.Margin = new Padding(0);
            SaveCancelBtnsLayout.Name = "SaveCancelBtnsLayout";
            SaveCancelBtnsLayout.RowCount = 1;
            SaveCancelBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Size = new Size(780, 55);
            SaveCancelBtnsLayout.TabIndex = 31;
            // 
            // ProcessDeliveryCancelBtn
            // 
            ProcessDeliveryCancelBtn.BackColor = Color.White;
            ProcessDeliveryCancelBtn.Dock = DockStyle.Bottom;
            ProcessDeliveryCancelBtn.FlatAppearance.BorderSize = 0;
            ProcessDeliveryCancelBtn.FlatAppearance.MouseDownBackColor = Color.White;
            ProcessDeliveryCancelBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ProcessDeliveryCancelBtn.FlatStyle = FlatStyle.Flat;
            ProcessDeliveryCancelBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            ProcessDeliveryCancelBtn.ForeColor = Color.MediumSeaGreen;
            ProcessDeliveryCancelBtn.Location = new Point(393, 7);
            ProcessDeliveryCancelBtn.Name = "ProcessDeliveryCancelBtn";
            ProcessDeliveryCancelBtn.Size = new Size(384, 45);
            ProcessDeliveryCancelBtn.TabIndex = 30;
            ProcessDeliveryCancelBtn.Text = "Cancel";
            ProcessDeliveryCancelBtn.UseVisualStyleBackColor = false;
            ProcessDeliveryCancelBtn.Click += ProcessDeliveryCancelBtn_Click;
            // 
            // ProcessDeliverySaveBtn
            // 
            ProcessDeliverySaveBtn.BackColor = Color.White;
            ProcessDeliverySaveBtn.Dock = DockStyle.Bottom;
            ProcessDeliverySaveBtn.FlatAppearance.BorderSize = 0;
            ProcessDeliverySaveBtn.FlatAppearance.MouseDownBackColor = Color.White;
            ProcessDeliverySaveBtn.FlatAppearance.MouseOverBackColor = Color.White;
            ProcessDeliverySaveBtn.FlatStyle = FlatStyle.Flat;
            ProcessDeliverySaveBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            ProcessDeliverySaveBtn.ForeColor = Color.MediumSeaGreen;
            ProcessDeliverySaveBtn.Location = new Point(3, 7);
            ProcessDeliverySaveBtn.Name = "ProcessDeliverySaveBtn";
            ProcessDeliverySaveBtn.Size = new Size(384, 45);
            ProcessDeliverySaveBtn.TabIndex = 29;
            ProcessDeliverySaveBtn.Text = "Save";
            ProcessDeliverySaveBtn.UseVisualStyleBackColor = false;
            ProcessDeliverySaveBtn.Click += ProcessDeliverySaveBtn_Click;
            // 
            // DeleteInputFieldsLayout
            // 
            DeleteInputFieldsLayout.ColumnCount = 2;
            DeleteInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DeleteInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            DeleteInputFieldsLayout.Controls.Add(ProcessDeliveryProdId, 0, 0);
            DeleteInputFieldsLayout.Controls.Add(ProcessDeliveryIDTextBox, 1, 0);
            DeleteInputFieldsLayout.Dock = DockStyle.Fill;
            DeleteInputFieldsLayout.Location = new Point(0, 55);
            DeleteInputFieldsLayout.Margin = new Padding(0);
            DeleteInputFieldsLayout.Name = "DeleteInputFieldsLayout";
            DeleteInputFieldsLayout.RowCount = 1;
            DeleteInputFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DeleteInputFieldsLayout.Size = new Size(780, 55);
            DeleteInputFieldsLayout.TabIndex = 0;
            // 
            // ProcessDeliveryProdId
            // 
            ProcessDeliveryProdId.AutoSize = true;
            ProcessDeliveryProdId.Dock = DockStyle.Fill;
            ProcessDeliveryProdId.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            ProcessDeliveryProdId.ForeColor = Color.White;
            ProcessDeliveryProdId.Location = new Point(3, 3);
            ProcessDeliveryProdId.Margin = new Padding(3);
            ProcessDeliveryProdId.Name = "ProcessDeliveryProdId";
            ProcessDeliveryProdId.Size = new Size(189, 49);
            ProcessDeliveryProdId.TabIndex = 1;
            ProcessDeliveryProdId.Text = "Product ID";
            ProcessDeliveryProdId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProcessDeliveryIDTextBox
            // 
            ProcessDeliveryIDTextBox.BorderStyle = BorderStyle.None;
            ProcessDeliveryIDTextBox.Dock = DockStyle.Fill;
            ProcessDeliveryIDTextBox.Font = new Font("Segoe UI Emoji", 10F);
            ProcessDeliveryIDTextBox.Location = new Point(198, 3);
            ProcessDeliveryIDTextBox.Multiline = true;
            ProcessDeliveryIDTextBox.Name = "ProcessDeliveryIDTextBox";
            ProcessDeliveryIDTextBox.Size = new Size(579, 49);
            ProcessDeliveryIDTextBox.TabIndex = 4;
            // 
            // DelMsgLabel
            // 
            DelMsgLabel.AutoSize = true;
            DelMsgLabel.BackColor = Color.MediumSeaGreen;
            DelMsgLabel.Dock = DockStyle.Fill;
            DelMsgLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            DelMsgLabel.ForeColor = Color.White;
            DelMsgLabel.Location = new Point(3, 0);
            DelMsgLabel.Name = "DelMsgLabel";
            DelMsgLabel.Size = new Size(774, 55);
            DelMsgLabel.TabIndex = 2;
            DelMsgLabel.Text = "Please enter Product ID and units received to update the stock.";
            DelMsgLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ProcessDeliveryUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(DeleteProductTableLayout);
            Name = "ProcessDeliveryUserControl";
            Size = new Size(780, 220);
            DeleteProductTableLayout.ResumeLayout(false);
            DeleteProductTableLayout.PerformLayout();
            RecievedUnitsTableLayoutPanel.ResumeLayout(false);
            RecievedUnitsTableLayoutPanel.PerformLayout();
            SaveCancelBtnsLayout.ResumeLayout(false);
            DeleteInputFieldsLayout.ResumeLayout(false);
            DeleteInputFieldsLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel DeleteProductTableLayout;
        private TableLayoutPanel SaveCancelBtnsLayout;
        private Button ProcessDeliveryCancelBtn;
        private Button ProcessDeliverySaveBtn;
        private TableLayoutPanel DeleteInputFieldsLayout;
        private Label ProcessDeliveryProdId;
        private TextBox ProcessDeliveryIDTextBox;
        private Label DelMsgLabel;
        private TableLayoutPanel RecievedUnitsTableLayoutPanel;
        private Label ProcessDeliveryStockLabel;
        private TextBox ProcessDeliveryStockTextBox;
    }
}
