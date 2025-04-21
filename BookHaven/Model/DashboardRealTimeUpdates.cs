using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class DashboardRealTimeUpdates
    {
        public static string LoadTotalCustomers()
        {
            using(SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customer", con);
                return cmd.ExecuteScalar().ToString();
            }
        }

        //==================================== load total orders ===============================

        public static string TotalOrders()
        {
            using(SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders", con);
                return cmd.ExecuteScalar().ToString();
            }
        }

        public static string LoadTotalSales()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SalesTransaction", con);
                return cmd.ExecuteScalar().ToString();
            }
        }

        public static string LoadTotalBooks()
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT SUM(StockQuantity) FROM Book", con);
                object result = cmd.ExecuteScalar();
                return result != DBNull.Value ? result.ToString() : "0";
            }
        }

    }
}
