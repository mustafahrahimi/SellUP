namespace SellUp.UserControls
{
    partial class AddProductToCartUserControl
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
            AddProductToCartTableLayout = new TableLayoutPanel();
            RecievedUnitsTableLayoutPanel = new TableLayoutPanel();
            AddProdToCartDesiredUnitsLabel = new Label();
            AddProdToCartDesiredUnitsTextBox = new TextBox();
            SaveCancelBtnsLayout = new TableLayoutPanel();
            AddProdToCartCancelBtn = new Button();
            AddProdToCartSaveBtn = new Button();
            AddProdToCartInputFieldsLayout = new TableLayoutPanel();
            AddProdToCartId = new Label();
            AddProdToCartIDTextBox = new TextBox();
            AddProdToCartMsgLabel = new Label();
            AddProductToCartTableLayout.SuspendLayout();
            RecievedUnitsTableLayoutPanel.SuspendLayout();
            SaveCancelBtnsLayout.SuspendLayout();
            AddProdToCartInputFieldsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // AddProductToCartTableLayout
            // 
            AddProductToCartTableLayout.BackColor = Color.MediumSeaGreen;
            AddProductToCartTableLayout.ColumnCount = 1;
            AddProductToCartTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            AddProductToCartTableLayout.Controls.Add(RecievedUnitsTableLayoutPanel, 0, 2);
            AddProductToCartTableLayout.Controls.Add(SaveCancelBtnsLayout, 0, 3);
            AddProductToCartTableLayout.Controls.Add(AddProdToCartInputFieldsLayout, 0, 1);
            AddProductToCartTableLayout.Controls.Add(AddProdToCartMsgLabel, 0, 0);
            AddProductToCartTableLayout.Dock = DockStyle.Fill;
            AddProductToCartTableLayout.Location = new Point(1, 1);
            AddProductToCartTableLayout.Name = "AddProductToCartTableLayout";
            AddProductToCartTableLayout.RowCount = 4;
            AddProductToCartTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            AddProductToCartTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AddProductToCartTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            AddProductToCartTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            AddProductToCartTableLayout.Size = new Size(856, 219);
            AddProductToCartTableLayout.TabIndex = 2;
            // 
            // RecievedUnitsTableLayoutPanel
            // 
            RecievedUnitsTableLayoutPanel.ColumnCount = 2;
            RecievedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            RecievedUnitsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            RecievedUnitsTableLayoutPanel.Controls.Add(AddProdToCartDesiredUnitsLabel, 0, 0);
            RecievedUnitsTableLayoutPanel.Controls.Add(AddProdToCartDesiredUnitsTextBox, 1, 0);
            RecievedUnitsTableLayoutPanel.Dock = DockStyle.Fill;
            RecievedUnitsTableLayoutPanel.Location = new Point(0, 97);
            RecievedUnitsTableLayoutPanel.Margin = new Padding(0);
            RecievedUnitsTableLayoutPanel.Name = "RecievedUnitsTableLayoutPanel";
            RecievedUnitsTableLayoutPanel.RowCount = 1;
            RecievedUnitsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            RecievedUnitsTableLayoutPanel.Size = new Size(856, 54);
            RecievedUnitsTableLayoutPanel.TabIndex = 32;
            // 
            // AddProdToCartDesiredUnitsLabel
            // 
            AddProdToCartDesiredUnitsLabel.AutoSize = true;
            AddProdToCartDesiredUnitsLabel.Dock = DockStyle.Fill;
            AddProdToCartDesiredUnitsLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            AddProdToCartDesiredUnitsLabel.ForeColor = Color.White;
            AddProdToCartDesiredUnitsLabel.Location = new Point(3, 3);
            AddProdToCartDesiredUnitsLabel.Margin = new Padding(3);
            AddProdToCartDesiredUnitsLabel.Name = "AddProdToCartDesiredUnitsLabel";
            AddProdToCartDesiredUnitsLabel.Size = new Size(208, 48);
            AddProdToCartDesiredUnitsLabel.TabIndex = 1;
            AddProdToCartDesiredUnitsLabel.Text = "Desired Units";
            AddProdToCartDesiredUnitsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddProdToCartDesiredUnitsTextBox
            // 
            AddProdToCartDesiredUnitsTextBox.BackColor = Color.White;
            AddProdToCartDesiredUnitsTextBox.BorderStyle = BorderStyle.None;
            AddProdToCartDesiredUnitsTextBox.Dock = DockStyle.Fill;
            AddProdToCartDesiredUnitsTextBox.Font = new Font("Segoe UI Emoji", 10F);
            AddProdToCartDesiredUnitsTextBox.Location = new Point(217, 3);
            AddProdToCartDesiredUnitsTextBox.Multiline = true;
            AddProdToCartDesiredUnitsTextBox.Name = "AddProdToCartDesiredUnitsTextBox";
            AddProdToCartDesiredUnitsTextBox.Size = new Size(636, 48);
            AddProdToCartDesiredUnitsTextBox.TabIndex = 4;
            // 
            // SaveCancelBtnsLayout
            // 
            SaveCancelBtnsLayout.ColumnCount = 2;
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Controls.Add(AddProdToCartCancelBtn, 1, 0);
            SaveCancelBtnsLayout.Controls.Add(AddProdToCartSaveBtn, 0, 0);
            SaveCancelBtnsLayout.Dock = DockStyle.Bottom;
            SaveCancelBtnsLayout.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            SaveCancelBtnsLayout.Location = new Point(0, 166);
            SaveCancelBtnsLayout.Margin = new Padding(0);
            SaveCancelBtnsLayout.Name = "SaveCancelBtnsLayout";
            SaveCancelBtnsLayout.RowCount = 1;
            SaveCancelBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Size = new Size(856, 53);
            SaveCancelBtnsLayout.TabIndex = 31;
            // 
            // AddProdToCartCancelBtn
            // 
            AddProdToCartCancelBtn.BackColor = Color.White;
            AddProdToCartCancelBtn.Dock = DockStyle.Bottom;
            AddProdToCartCancelBtn.FlatAppearance.BorderSize = 0;
            AddProdToCartCancelBtn.FlatAppearance.MouseDownBackColor = Color.White;
            AddProdToCartCancelBtn.FlatAppearance.MouseOverBackColor = Color.White;
            AddProdToCartCancelBtn.FlatStyle = FlatStyle.Flat;
            AddProdToCartCancelBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            AddProdToCartCancelBtn.ForeColor = Color.MediumSeaGreen;
            AddProdToCartCancelBtn.Location = new Point(431, 3);
            AddProdToCartCancelBtn.Name = "AddProdToCartCancelBtn";
            AddProdToCartCancelBtn.Size = new Size(422, 47);
            AddProdToCartCancelBtn.TabIndex = 30;
            AddProdToCartCancelBtn.Text = "Cancel";
            AddProdToCartCancelBtn.UseVisualStyleBackColor = false;
            AddProdToCartCancelBtn.Click += AddProdToCartCancelBtn_Click;
            // 
            // AddProdToCartSaveBtn
            // 
            AddProdToCartSaveBtn.BackColor = Color.White;
            AddProdToCartSaveBtn.Dock = DockStyle.Bottom;
            AddProdToCartSaveBtn.FlatAppearance.BorderSize = 0;
            AddProdToCartSaveBtn.FlatAppearance.MouseDownBackColor = Color.White;
            AddProdToCartSaveBtn.FlatAppearance.MouseOverBackColor = Color.White;
            AddProdToCartSaveBtn.FlatStyle = FlatStyle.Flat;
            AddProdToCartSaveBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            AddProdToCartSaveBtn.ForeColor = Color.MediumSeaGreen;
            AddProdToCartSaveBtn.Location = new Point(3, 3);
            AddProdToCartSaveBtn.Name = "AddProdToCartSaveBtn";
            AddProdToCartSaveBtn.Size = new Size(422, 47);
            AddProdToCartSaveBtn.TabIndex = 29;
            AddProdToCartSaveBtn.Text = "Save";
            AddProdToCartSaveBtn.UseVisualStyleBackColor = false;
            AddProdToCartSaveBtn.Click += AddProdToCartSaveBtn_Click;
            // 
            // AddProdToCartInputFieldsLayout
            // 
            AddProdToCartInputFieldsLayout.ColumnCount = 2;
            AddProdToCartInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            AddProdToCartInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            AddProdToCartInputFieldsLayout.Controls.Add(AddProdToCartId, 0, 0);
            AddProdToCartInputFieldsLayout.Controls.Add(AddProdToCartIDTextBox, 1, 0);
            AddProdToCartInputFieldsLayout.Dock = DockStyle.Fill;
            AddProdToCartInputFieldsLayout.Location = new Point(0, 43);
            AddProdToCartInputFieldsLayout.Margin = new Padding(0);
            AddProdToCartInputFieldsLayout.Name = "AddProdToCartInputFieldsLayout";
            AddProdToCartInputFieldsLayout.RowCount = 1;
            AddProdToCartInputFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            AddProdToCartInputFieldsLayout.Size = new Size(856, 54);
            AddProdToCartInputFieldsLayout.TabIndex = 0;
            // 
            // AddProdToCartId
            // 
            AddProdToCartId.AutoSize = true;
            AddProdToCartId.Dock = DockStyle.Fill;
            AddProdToCartId.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            AddProdToCartId.ForeColor = Color.White;
            AddProdToCartId.Location = new Point(3, 3);
            AddProdToCartId.Margin = new Padding(3);
            AddProdToCartId.Name = "AddProdToCartId";
            AddProdToCartId.Size = new Size(208, 48);
            AddProdToCartId.TabIndex = 1;
            AddProdToCartId.Text = "Product ID";
            AddProdToCartId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddProdToCartIDTextBox
            // 
            AddProdToCartIDTextBox.BackColor = Color.White;
            AddProdToCartIDTextBox.BorderStyle = BorderStyle.None;
            AddProdToCartIDTextBox.Dock = DockStyle.Fill;
            AddProdToCartIDTextBox.Font = new Font("Segoe UI Emoji", 10F);
            AddProdToCartIDTextBox.Location = new Point(217, 3);
            AddProdToCartIDTextBox.Multiline = true;
            AddProdToCartIDTextBox.Name = "AddProdToCartIDTextBox";
            AddProdToCartIDTextBox.Size = new Size(636, 48);
            AddProdToCartIDTextBox.TabIndex = 4;
            // 
            // AddProdToCartMsgLabel
            // 
            AddProdToCartMsgLabel.AutoSize = true;
            AddProdToCartMsgLabel.Dock = DockStyle.Fill;
            AddProdToCartMsgLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            AddProdToCartMsgLabel.ForeColor = Color.White;
            AddProdToCartMsgLabel.Location = new Point(3, 0);
            AddProdToCartMsgLabel.Name = "AddProdToCartMsgLabel";
            AddProdToCartMsgLabel.Size = new Size(850, 43);
            AddProdToCartMsgLabel.TabIndex = 2;
            AddProdToCartMsgLabel.Text = "Please enter the desired amount of the selected product to add to cart.";
            AddProdToCartMsgLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddProductToCartUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(AddProductToCartTableLayout);
            Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            Margin = new Padding(1);
            Name = "AddProductToCartUserControl";
            Padding = new Padding(1);
            Size = new Size(858, 221);
            AddProductToCartTableLayout.ResumeLayout(false);
            AddProductToCartTableLayout.PerformLayout();
            RecievedUnitsTableLayoutPanel.ResumeLayout(false);
            RecievedUnitsTableLayoutPanel.PerformLayout();
            SaveCancelBtnsLayout.ResumeLayout(false);
            AddProdToCartInputFieldsLayout.ResumeLayout(false);
            AddProdToCartInputFieldsLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel AddProductToCartTableLayout;
        private TableLayoutPanel RecievedUnitsTableLayoutPanel;
        private Label AddProdToCartDesiredUnitsLabel;
        private TextBox AddProdToCartDesiredUnitsTextBox;
        private TableLayoutPanel SaveCancelBtnsLayout;
        private Button AddProdToCartCancelBtn;
        private Button AddProdToCartSaveBtn;
        private TableLayoutPanel AddProdToCartInputFieldsLayout;
        private Label AddProdToCartId;
        private TextBox AddProdToCartIDTextBox;
        private Label AddProdToCartMsgLabel;
    }
}
