namespace SellUp.UserControls
{
    partial class DeleteProductUserControl
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
            SaveCancelBtnsLayout = new TableLayoutPanel();
            CancelBtn = new Button();
            DeleteBtn = new Button();
            DeleteInputFieldsLayout = new TableLayoutPanel();
            DelByIdLabel = new Label();
            DelByIDTextBox = new TextBox();
            DelMsgLabel = new Label();
            DeleteProductTableLayout.SuspendLayout();
            SaveCancelBtnsLayout.SuspendLayout();
            DeleteInputFieldsLayout.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteProductTableLayout
            // 
            DeleteProductTableLayout.ColumnCount = 1;
            DeleteProductTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            DeleteProductTableLayout.Controls.Add(SaveCancelBtnsLayout, 0, 2);
            DeleteProductTableLayout.Controls.Add(DeleteInputFieldsLayout, 0, 1);
            DeleteProductTableLayout.Controls.Add(DelMsgLabel, 0, 0);
            DeleteProductTableLayout.Dock = DockStyle.Fill;
            DeleteProductTableLayout.Location = new Point(0, 0);
            DeleteProductTableLayout.Margin = new Padding(0);
            DeleteProductTableLayout.Name = "DeleteProductTableLayout";
            DeleteProductTableLayout.RowCount = 3;
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            DeleteProductTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            DeleteProductTableLayout.Size = new Size(750, 160);
            DeleteProductTableLayout.TabIndex = 0;
            // 
            // SaveCancelBtnsLayout
            // 
            SaveCancelBtnsLayout.ColumnCount = 2;
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Controls.Add(CancelBtn, 1, 0);
            SaveCancelBtnsLayout.Controls.Add(DeleteBtn, 0, 0);
            SaveCancelBtnsLayout.Dock = DockStyle.Fill;
            SaveCancelBtnsLayout.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            SaveCancelBtnsLayout.Location = new Point(0, 104);
            SaveCancelBtnsLayout.Margin = new Padding(0);
            SaveCancelBtnsLayout.Name = "SaveCancelBtnsLayout";
            SaveCancelBtnsLayout.RowCount = 1;
            SaveCancelBtnsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            SaveCancelBtnsLayout.Size = new Size(750, 56);
            SaveCancelBtnsLayout.TabIndex = 31;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = Color.White;
            CancelBtn.Dock = DockStyle.Bottom;
            CancelBtn.FlatAppearance.BorderSize = 0;
            CancelBtn.FlatAppearance.MouseDownBackColor = Color.White;
            CancelBtn.FlatAppearance.MouseOverBackColor = Color.White;
            CancelBtn.FlatStyle = FlatStyle.Flat;
            CancelBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            CancelBtn.ForeColor = Color.MediumSeaGreen;
            CancelBtn.Location = new Point(378, 8);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(369, 45);
            CancelBtn.TabIndex = 30;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.White;
            DeleteBtn.Dock = DockStyle.Bottom;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatAppearance.MouseDownBackColor = Color.White;
            DeleteBtn.FlatAppearance.MouseOverBackColor = Color.White;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI Emoji", 10F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.MediumSeaGreen;
            DeleteBtn.Location = new Point(3, 8);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(369, 45);
            DeleteBtn.TabIndex = 29;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // DeleteInputFieldsLayout
            // 
            DeleteInputFieldsLayout.ColumnCount = 2;
            DeleteInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            DeleteInputFieldsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            DeleteInputFieldsLayout.Controls.Add(DelByIdLabel, 0, 0);
            DeleteInputFieldsLayout.Controls.Add(DelByIDTextBox, 1, 0);
            DeleteInputFieldsLayout.Dock = DockStyle.Fill;
            DeleteInputFieldsLayout.Location = new Point(0, 48);
            DeleteInputFieldsLayout.Margin = new Padding(0);
            DeleteInputFieldsLayout.Name = "DeleteInputFieldsLayout";
            DeleteInputFieldsLayout.RowCount = 1;
            DeleteInputFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            DeleteInputFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DeleteInputFieldsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            DeleteInputFieldsLayout.Size = new Size(750, 56);
            DeleteInputFieldsLayout.TabIndex = 0;
            // 
            // DelByIdLabel
            // 
            DelByIdLabel.AutoSize = true;
            DelByIdLabel.Dock = DockStyle.Fill;
            DelByIdLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            DelByIdLabel.ForeColor = Color.White;
            DelByIdLabel.Location = new Point(3, 3);
            DelByIdLabel.Margin = new Padding(3);
            DelByIdLabel.Name = "DelByIdLabel";
            DelByIdLabel.Size = new Size(181, 50);
            DelByIdLabel.TabIndex = 1;
            DelByIdLabel.Text = "Product ID";
            DelByIdLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DelByIDTextBox
            // 
            DelByIDTextBox.BorderStyle = BorderStyle.None;
            DelByIDTextBox.Dock = DockStyle.Fill;
            DelByIDTextBox.Font = new Font("Segoe UI Emoji", 10F);
            DelByIDTextBox.Location = new Point(190, 3);
            DelByIDTextBox.Multiline = true;
            DelByIDTextBox.Name = "DelByIDTextBox";
            DelByIDTextBox.Size = new Size(557, 50);
            DelByIDTextBox.TabIndex = 4;
            // 
            // DelMsgLabel
            // 
            DelMsgLabel.AutoSize = true;
            DelMsgLabel.Dock = DockStyle.Fill;
            DelMsgLabel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold);
            DelMsgLabel.ForeColor = Color.White;
            DelMsgLabel.Location = new Point(3, 0);
            DelMsgLabel.Name = "DelMsgLabel";
            DelMsgLabel.Size = new Size(744, 48);
            DelMsgLabel.TabIndex = 2;
            DelMsgLabel.Text = "Please enter the Product ID to remove it from inventory.";
            DelMsgLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DeleteProductUserControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            Controls.Add(DeleteProductTableLayout);
            Name = "DeleteProductUserControl";
            Size = new Size(750, 160);
            DeleteProductTableLayout.ResumeLayout(false);
            DeleteProductTableLayout.PerformLayout();
            SaveCancelBtnsLayout.ResumeLayout(false);
            DeleteInputFieldsLayout.ResumeLayout(false);
            DeleteInputFieldsLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel DeleteProductTableLayout;
        private TableLayoutPanel DeleteInputFieldsLayout;
        private Label DelByIdLabel;
        private Label DelMsgLabel;
        private TextBox DelByIDTextBox;
        private TableLayoutPanel SaveCancelBtnsLayout;
        private Button CancelBtn;
        private Button DeleteBtn;
    }
}
