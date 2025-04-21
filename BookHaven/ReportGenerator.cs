using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BookHaven.Model;
using System.Data;

namespace BookHaven
{
    public static class ReportGenerator
    {
        private static SqlConnection GetConnection()
        {
            return DatabaseConnection.GetConnection();
        }

        //=========================================== Sales Report =======================================

        public static DataTable GetSalesReport()
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = @"
                    SELECT 
                        s.SalesTransactionID,
                        c.FullName AS CustomerName,
                        s.TotalAmount,
                        s.Discount,
                        s.NetRevenue,
                        s.PaymentMethod,
                        s.TransactionDate
                    FROM SalesTransaction s
                    LEFT JOIN Customer c ON s.CustomerID = c.CustomerID
                    ORDER BY s.TransactionDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;

            }
        }

        //=========================================== Total Books Sold ===============================================

        public static DataTable GetBookSalesSummary()
        {
            using(SqlConnection con = GetConnection())
            {
                con.Open();
                string query = @"
                    SELECT 
                        b.Title AS BookTitle,
                        SUM(sd.Quantity) AS TotalSold,
                        SUM(sd.Quantity * sd.Price) AS RevenueGenerated
                    FROM SalesTransactionDetails sd
                    JOIN Book b ON sd.BookID = b.BookID
                    GROUP BY b.Title
                    ORDER BY TotalSold DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        //=========================================== Customer Purchase Histor ==================================

        public static DataTable GetCustomerPurchaseHistory()
        {
            using (SqlConnection con = GetConnection())
            {
                con.Open();
                string query = @"
                    SELECT 
                        c.FullName AS CustomerName,
                        b.Title AS BookTitle,
                        sd.Quantity,
                        sd.Price,
                        (sd.Quantity * sd.Price) AS Subtotal,
                        s.TransactionDate
                    FROM SalesTransactionDetails sd
                    JOIN SalesTransaction s ON sd.SalesTransactionID = s.SalesTransactionID
                    JOIN Customer c ON s.CustomerID = c.CustomerID
                    JOIN Book b ON sd.BookID = b.BookID
                    ORDER BY s.TransactionDate DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }
    }
}
