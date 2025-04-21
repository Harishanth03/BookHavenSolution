using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookHaven.Model;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookHaven.Forms.Dashboard
{
    public partial class GraphView: UserControl
    {
        public GraphView()
        {
            InitializeComponent();
            int totalCustomers = customerRespo.GetTotalCustomer();

            totalCustomersLable.Text = totalCustomers.ToString();

            totalCustomersLable.Text = DashboardRealTimeUpdates.LoadTotalCustomers();
            totalSalesLable.Text = DashboardRealTimeUpdates.LoadTotalSales();
            totalOrderLable.Text = DashboardRealTimeUpdates.TotalOrders();
            totalBookLable.Text = DashboardRealTimeUpdates.LoadTotalBooks();
        }

        private void LoadChartOrders()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        CAST(TransactionDate AS DATE) AS DateOnly,
                        COUNT(*) AS TotalOrders
                    FROM SalesTransaction
                    WHERE TransactionDate >= DATEADD(DAY, -30, GETDATE())
                    GROUP BY CAST(TransactionDate AS DATE)
                    ORDER BY DateOnly";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable orderTable = new DataTable();
                adapter.Fill(orderTable);

                chartOrders.Series.Clear();
                chartOrders.Series.Add("TotalOrders");
                chartOrders.Series["TotalOrders"].ChartType = SeriesChartType.Column;

                chartOrders.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartOrders.ChartAreas[0].AxisX.Interval = 1;

                foreach (DataRow row in orderTable.Rows)
                {
                    string date = Convert.ToDateTime(row["DateOnly"]).ToString("MM/dd");
                    int totalOrders = Convert.ToInt32(row["TotalOrders"]);
                    chartOrders.Series["TotalOrders"].Points.AddXY(date, totalOrders);
                }
            }
        }

        private void LoadChartSales()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = @"
                    SELECT 
                        CAST(st.TransactionDate AS DATE) AS DateOnly,
                        SUM(std.Quantity) AS BooksSold
                    FROM SalesTransactionDetails std
                    JOIN SalesTransaction st ON std.SalesTransactionID = st.SalesTransactionID
                    WHERE st.TransactionDate >= DATEADD(DAY, -30, GETDATE())
                    GROUP BY CAST(st.TransactionDate AS DATE)
                    ORDER BY DateOnly";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable salesTable = new DataTable();
                adapter.Fill(salesTable);

                chartSales.Series.Clear();
                chartSales.Series.Add("BooksSold");
                chartSales.Series["BooksSold"].ChartType = SeriesChartType.Column;

                chartSales.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                chartSales.ChartAreas[0].AxisX.Interval = 1;

                foreach (DataRow row in salesTable.Rows)
                {
                    string date = Convert.ToDateTime(row["DateOnly"]).ToString("MM/dd");
                    int booksSold = Convert.ToInt32(row["BooksSold"]);
                    chartSales.Series["BooksSold"].Points.AddXY(date, booksSold);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GraphView_Load(object sender, EventArgs e)
        {
            LoadChartOrders();
            LoadChartSales();
        }
    }
}
