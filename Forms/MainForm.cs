using System.Windows.Forms;
using SellUp.Forms;
using SellUp.Models;
using SellUp.UserControls;
using System.Timers;
using SellUp.Utils;

namespace SellUp
{
    public partial class MainForm : Form
    {
        private InventoryUserControl inventoryUserView;
        private CashRegisterUserControl cashRegisterView;
        private AddBookUserControl addBookView;
        private DataGridViewControl dataGridView;
        private System.Windows.Forms.Timer apiSyncTimer;
        private ElapsedTimer sharedTimer;


        public MainForm()
        {
            InitializeComponent();
            inventoryUserView = new InventoryUserControl();
            cashRegisterView = new CashRegisterUserControl();
        }
        private async void MainForm_Load(object sender, EventArgs e)
        {
            apiSyncTimer = new System.Windows.Forms.Timer();
            apiSyncTimer.Interval = 60_000; // 60000 ms
            apiSyncTimer.Tick += ApiSyncTimer_Tick;
            apiSyncTimer.Start();

            ProductManager.LoadFromCSV();
            await ProductManager.LoadProductsFromAPI();

            sharedTimer = new ElapsedTimer();
            inventoryUserView.BindTimer(sharedTimer);
            cashRegisterView.BindTimer(sharedTimer);
            sharedTimer.Start();
        }
        private async void ApiSyncTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                await ProductManager.UpdateProductsFromAPI();
            }
            catch
            {
                MessageBox.Show("Failed to periodically sync local with central.", "Sync Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void InventoryBtn_Click(object sender, EventArgs e)
        {
            RemoveFocusBorder(InventoryBtn);
            ResetButtonStyles();
            SetButtonStyles(InventoryBtn);

            if (inventoryUserView == null)
            {
                inventoryUserView = new InventoryUserControl();
            }

            ShowView(inventoryUserView);
        }
        private void CashRegisterBtn_Click(object sender, EventArgs e)
        {
            RemoveFocusBorder(CashRegisterBtn);
            ResetButtonStyles();
            SetButtonStyles(CashRegisterBtn);

            if (cashRegisterView == null)
            {
                cashRegisterView = new CashRegisterUserControl();
            }

            ShowView(cashRegisterView);
        }
        private void ShowView(UserControl view)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;
        }

        private void SetButtonStyles(Button btn)
        {
            btn.BackColor = Color.MediumSeaGreen;
            btn.ForeColor = Color.White;
        }
        private void ResetButtonStyles()
        {
            InventoryBtn.BackColor = Color.WhiteSmoke;
            InventoryBtn.ForeColor = Color.Black;

            CashRegisterBtn.BackColor = Color.WhiteSmoke;
            CashRegisterBtn.ForeColor = Color.Black;
        }
        private void RemoveFocusBorder(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductManager.SaveToCSV();
        }
    }
}
