using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace BookHaven.Model
{
    class SalesTransactionRepository
    {

        public int SaveTransaction(PointOfSales salesTransaction , List<SalesTransactionDetails> details)
        {
            int salesTransactionID = 0;

            using(SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                SqlTransaction sqlTransaction = con.BeginTransaction();

                try
                {
                    string insertTransactionQuery = @"INSERT INTO SalesTransaction (SalesClerkID, CustomerID, TotalAmount, PaymentMethod, Discount) 
                                                    VALUES (@SalesClerkID, @CustomerID, @TotalAmount, @PaymentMethod, @Discount); 
                                                    SELECT SCOPE_IDENTITY();";

                    using(SqlCommand cmd = new SqlCommand(insertTransactionQuery , con , sqlTransaction))
                    {
                        cmd.Parameters.AddWithValue("@SalesClerkID", salesTransaction.SalesClerkID);
                        cmd.Parameters.AddWithValue("@CustomerID", salesTransaction.CustomerID);
                        cmd.Parameters.AddWithValue("@TotalAmount", salesTransaction.CalculateNetRevenue());
                        cmd.Parameters.AddWithValue("@PaymentMethod", salesTransaction.PaymentMethod);
                        cmd.Parameters.AddWithValue("@Discount", salesTransaction.Discount);

                        salesTransactionID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    foreach(var detail in details)
                    {
                        string insertDetailQuery = @"INSERT INTO SalesTransactionDetails (SalesTransactionID, BookID, Quantity, Price) 
                                                    VALUES (@SalesTransactionID, @BookID, @Quantity, @Price);";

                        using(SqlCommand cmd = new SqlCommand(insertDetailQuery , con , sqlTransaction))
                        {
                            cmd.Parameters.AddWithValue("@SalesTransactionID", salesTransactionID);
                            cmd.Parameters.AddWithValue("@BookID", detail.BookID);
                            cmd.Parameters.AddWithValue("@Quantity", detail.Quantity);
                            cmd.Parameters.AddWithValue("@Price", detail.Price);

                            cmd.ExecuteNonQuery();
                        }
                    }

                    UpdateTotalSpent(con, sqlTransaction, salesTransaction.CustomerID, salesTransaction.CalculateNetRevenue());

                    sqlTransaction.Commit();
                }
                catch (Exception ex)
                {
                    sqlTransaction.Rollback();
                    throw new Exception("Error saving transaction: " + ex.Message);
                }
            }

            return salesTransactionID;
        }

        //============================================== Update the total spent =================================================

        public static void UpdateTotalSpent( SqlConnection con , SqlTransaction sqlTransaction , int customerID , decimal newPurchaseAmount)
        {
            decimal previousTotalSpent = 0; // get the previoud amount  from database and save it on a variable

            string getTotalSpentQuery = "SELECT TotalSpent FROM Customer WHERE CustomerID = @CustomerID";

            using(SqlCommand cmd = new SqlCommand(getTotalSpentQuery , con , sqlTransaction))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    previousTotalSpent = Convert.ToDecimal(result);
                }
            }

            decimal UpdatedTotalSpent = previousTotalSpent + newPurchaseAmount;

            string updateTotalSpentQuery = "UPDATE Customer SET TotalSpent = @UpdatedTotalSpent WHERE CustomerID = @CustomerID";

            using (SqlCommand cmd = new SqlCommand(updateTotalSpentQuery, con, sqlTransaction))
            {
                cmd.Parameters.AddWithValue("@UpdatedTotalSpent", UpdatedTotalSpent);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.ExecuteNonQuery();
            }
        }

        //=========================================== Get Total Sales =======================================================

        public static int getTotalSales()
        {
            int totalSales = 0;

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM SalesTransaction"; // Counting total transactions

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        totalSales = Convert.ToInt32(result);
                    }
                }
            }

            return totalSales;
        }
    }
}
