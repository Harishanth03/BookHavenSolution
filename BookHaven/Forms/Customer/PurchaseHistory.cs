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

namespace BookHaven.Forms.Customer
{
    public partial class PurchaseHistory : UserControl
    {
        private DataTable purchaseHistoryTable = new DataTable();

        public PurchaseHistory()
        {
            InitializeComponent();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            LoadPurchaseHistory();
        }

        //======================================== Load Data into DataTable ========================================
        private void LoadPurchaseHistory()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                string query = @"
                SELECT 
                    b.Title AS BookName,
                    c.FullName AS CustomerName,
                    s.TotalAmount,
                    s.Discount,
                    s.PaymentMethod,
                    s.TransactionDate AS TransactionDate
                FROM SalesTransaction s
                JOIN SalesTransactionDetails sd ON s.SalesTransactionID = sd.SalesTransactionID
                JOIN Book b ON sd.BookID = b.BookID
                JOIN Customer c ON s.CustomerID = c.CustomerID
                ORDER BY s.TransactionDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                purchaseHistoryTable.Clear();
                adapter.Fill(purchaseHistoryTable);

                purchaseHistoryDataGridView.AutoGenerateColumns = true;
                purchaseHistoryDataGridView.DataSource = purchaseHistoryTable;
            }
        }

        //========================================= Combined Filter Logic =========================================
        private void FilterByDateAndSearch()
        {
            if (purchaseHistoryTable.Rows.Count == 0) return;

            DateTime from = purchaseHistoryFrom.Value.Date;
            DateTime to = purchaseHistoryTo.Value.Date.AddDays(1).AddSeconds(-1); // inclusive of full day

            string search = purchaseHistorySearchTextbox.Text.Trim().Replace("'", "''");

            // Build base date filter
            string dateFilter = $"TransactionDate >= #{from:MM/dd/yyyy}# AND TransactionDate <= #{to:MM/dd/yyyy}#";

            // Add search filter
            if (!string.IsNullOrEmpty(search))
            {
                dateFilter += $" AND (BookName LIKE '%{search}%' OR CustomerName LIKE '%{search}%')";
            }

            try
            {
                // THIS is the correct place to apply it
                purchaseHistoryTable.DefaultView.RowFilter = dateFilter;
                purchaseHistoryDataGridView.DataSource = purchaseHistoryTable.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter error: " + ex.Message);
            }
        }




        //========================================= Event Handlers =========================================

        private void purchaseHistoryFrom_ValueChanged(object sender, EventArgs e)
        {
            FilterByDateAndSearch();
        }

        private void purchaseHistoryTo_ValueChanged(object sender, EventArgs e)
        {
            FilterByDateAndSearch();
        }

        private void purchaseHistorySearchTextbox_TextChanged(object sender, EventArgs e)
        {
            FilterByDateAndSearch();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            DashboardBookHaven dashboard = this.FindForm() as DashboardBookHaven;

            if (dashboard != null)
            {
                dashboard.LoadUserControl(new CustomerForm());
            }
            else
            {
                MessageBox.Show("Error: Could not find Dashboard.", "Navigation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
