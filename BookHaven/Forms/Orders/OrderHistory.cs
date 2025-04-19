using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookHaven.Model;

namespace BookHaven.Forms.Orders
{
    public partial class OrderHistory : UserControl
    {
        private DataTable orderHistoryTable = new DataTable();

        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistoryData();
            BindDataGridColumns(); // Important: match DataPropertyName to DB columns
        }

        //======================================== Load Data into DataTable ========================================
        private void LoadOrderHistoryData()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = @"
                SELECT 
                    o.OrderID,
                    c.FullName AS CustomerName,
                    b.Title AS BookTitle,
                    od.Quantity,
                    od.Price,
                    (od.Quantity * od.Price) AS TotalPrice,
                    o.OrderDate,
                    o.DeliveryOption,
                    o.EstimatedDeliveryDate
                FROM Orders o
                JOIN OrderDetails od ON o.OrderID = od.OrderID
                JOIN Customer c ON o.CustomerID = c.CustomerID
                JOIN Book b ON od.BookID = b.BookID
                ORDER BY o.OrderDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                orderHistoryTable.Clear();
                adapter.Fill(orderHistoryTable);

                OrderHistoryDataGridView.AutoGenerateColumns = false;
                OrderHistoryDataGridView.DataSource = orderHistoryTable.DefaultView;
            }
        }

        //========================================= Set DataPropertyName Mapping =========================================
        private void BindDataGridColumns()
        {
            OrderHistoryDataGridView.Columns["OrderID"].DataPropertyName = "OrderID";
            OrderHistoryDataGridView.Columns["CustomerName"].DataPropertyName = "CustomerName";
            OrderHistoryDataGridView.Columns["BookTitle"].DataPropertyName = "BookTitle";
            OrderHistoryDataGridView.Columns["Quantity"].DataPropertyName = "Quantity";
            OrderHistoryDataGridView.Columns["Price"].DataPropertyName = "Price";
            OrderHistoryDataGridView.Columns["TotalPrice"].DataPropertyName = "TotalPrice";
            OrderHistoryDataGridView.Columns["OrderDate"].DataPropertyName = "OrderDate";
            OrderHistoryDataGridView.Columns["DeliveryOption"].DataPropertyName = "DeliveryOption";
            OrderHistoryDataGridView.Columns["EstimatedDeliveryDate"].DataPropertyName = "EstimatedDeliveryDate";
        }

        //========================================= Filter by Date =====================================================
        private void FilterOrdersByDate()
        {
            if (orderHistoryTable.Rows.Count == 0) return;

            DateTime fromDate = OrderHistoryFrom.Value.Date;
            DateTime toDate = OrderHistoryTo.Value.Date;

            if (fromDate <= toDate)
            {
                // Use single quotes and ISO 8601 format (yyyy-MM-dd)
                string filter = $"OrderDate >= '{fromDate:yyyy-MM-dd}' AND OrderDate <= '{toDate:yyyy-MM-dd}'";
                orderHistoryTable.DefaultView.RowFilter = filter;
            }
            else
            {
                // If invalid date range, clear filter
                orderHistoryTable.DefaultView.RowFilter = string.Empty;
            }
        }


        //========================================= Event Handlers =====================================================
        private void OrderHistoryFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterOrdersByDate();
        }

        private void OrderHistoryTo_ValueChanged(object sender, EventArgs e)
        {
            FilterOrdersByDate();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            DashboardBookHaven dashboard = this.FindForm() as DashboardBookHaven;
            if (dashboard != null)
                dashboard.LoadUserControl(new Order());
            else
                MessageBox.Show("Error loading Order form", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
