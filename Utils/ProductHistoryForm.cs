using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SellUp.Models;

namespace SellUp.Utils
{
    public partial class ProductHistoryForm : Form
    {
        private Product _product;

        public ProductHistoryForm(Product product)
        {
            InitializeComponent();
            LoadHistory(product);    
        }
        private void LoadHistory(Product product)
        {
            var historyEntries = ProductManager.ProductHistoryLog.Where(
                h => h.ProductId == product.Id && h.ProductType == product.GetType().Name
            ).OrderBy(h => h.Timestamp).ToList();

            ProductHistoryChart.Series.Clear();

            ProductHistoryChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            ProductHistoryChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            ProductHistoryChart.ChartAreas[0].AxisY2.MajorGrid.Enabled = false;

            ProductHistoryChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 6);
            ProductHistoryChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Arial", 8);
            ProductHistoryChart.ChartAreas[0].AxisY2.LabelStyle.Font = new Font("Arial", 8);

            ProductHistoryChart.ChartAreas[0].AxisY.Title = "Stock";
            ProductHistoryChart.ChartAreas[0].AxisX.Title = "Time Log (60 sec)";
            ProductHistoryChart.ChartAreas[0].AxisY2.Title = "Price";

            ProductHistoryChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            ProductHistoryChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            ProductHistoryChart.ChartAreas[0].AxisX.Interval = 60;
            ProductHistoryChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            var stockSeries = new Series("Stock")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Blue,
                XValueType = ChartValueType.DateTime
            };

            var priceSeries = new Series("Price")
            {
                ChartType = SeriesChartType.Line,
                Color = System.Drawing.Color.Green,
                YAxisType = AxisType.Secondary,
                XValueType = ChartValueType.DateTime
            };

            if (historyEntries.Count >= 3)
            {
                foreach (var entry in historyEntries)
                {
                    stockSeries.Points.AddXY(entry.Timestamp, entry.Stock);
                    priceSeries.Points.AddXY(entry.Timestamp, entry.Price);
                }
            }

            ProductHistoryChart.Series.Add(stockSeries);
            ProductHistoryChart.Series.Add(priceSeries);
        }
        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ProductHistoryChart = new Chart();
            ((System.ComponentModel.ISupportInitialize)ProductHistoryChart).BeginInit();
            SuspendLayout();
            // 
            // ProductHistoryChart
            // 
            chartArea1.Name = "ChartArea1";
            ProductHistoryChart.ChartAreas.Add(chartArea1);
            ProductHistoryChart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            ProductHistoryChart.Legends.Add(legend1);
            ProductHistoryChart.Location = new Point(0, 0);
            ProductHistoryChart.Name = "ProductHistoryChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            ProductHistoryChart.Series.Add(series1);
            ProductHistoryChart.Size = new Size(1028, 444);
            ProductHistoryChart.TabIndex = 0;
            ProductHistoryChart.Text = "Product History";
            // 
            // ProductHistoryForm
            // 
            ClientSize = new Size(1028, 444);
            Controls.Add(ProductHistoryChart);
            Name = "ProductHistoryForm";
            ((System.ComponentModel.ISupportInitialize)ProductHistoryChart).EndInit();
            ResumeLayout(false);
        }
        private Chart ProductHistoryChart;
    }
}
