using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellUp.Utils
{
    public class CustomMessageBox : Form
    {
        public CustomMessageBox(string message1, string message2, string title)
        {
            this.Text = title;
            this.BackColor = Color.White;
            this.Size = new Size(500, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            TableLayoutPanel layoutPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                ColumnCount = 1,
                RowCount = 6,
                Padding = new Padding(20),
            };

            layoutPanel.RowStyles.Clear();
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 35));

            Label messageLabel1 = new Label
            {
                Text = message1,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            Label messageLabel2 = new Label
            {
                Text = message2,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.Black,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = true
            };

            Button okButton = new Button
            {
                Text = "OK",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                DialogResult = DialogResult.OK,
                BackColor = Color.MediumSeaGreen,
                ForeColor = Color.White,
                Dock = DockStyle.Fill,
                FlatStyle = FlatStyle.Flat
            };
            okButton.FlatAppearance.BorderSize = 0;

            layoutPanel.Controls.Add(messageLabel1, 0, 0);
            layoutPanel.Controls.Add(new Panel(), 0, 1);
            layoutPanel.Controls.Add(messageLabel2, 0, 2);
            layoutPanel.Controls.Add(okButton, 0, 3);
            layoutPanel.Controls.Add(okButton, 0, 4);
            layoutPanel.Controls.Add(okButton, 0, 5);

            this.Controls.Add(layoutPanel);
            this.AcceptButton = okButton;
        }
        public static DialogResult Show(string message1, string message2, string title)
        {
            using (var customMessageBox = new CustomMessageBox(message1, message2, title))
            {
                return customMessageBox.ShowDialog();
            }
        }
    }
}

