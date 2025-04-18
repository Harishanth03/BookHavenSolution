using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class Order
    {
        public int CustomerID { get; set; }

        public int BookID { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string DeliveryOption { get; set; }

        public DateTime? DeliveryDate { get; set; }

    }

    public class OrderRespo
    {
        public static bool PlaceOrder(Order order)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    // Insert into Orders
                    string orderQuery = @"
                        INSERT INTO Orders (CustomerID, TotalPrice, DeliveryOption, EstimatedDeliveryDate)
                        VALUES (@CustomerID, @TotalPrice, @DeliveryOption, @DeliveryDate);
                        SELECT SCOPE_IDENTITY();";

                    int orderId;
                    using (SqlCommand cmd = new SqlCommand(orderQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                        cmd.Parameters.AddWithValue("@TotalPrice", order.Price * order.Quantity);
                        cmd.Parameters.AddWithValue("@DeliveryOption", order.DeliveryOption);
                        cmd.Parameters.AddWithValue("@DeliveryDate", (object)order.DeliveryDate ?? DBNull.Value);

                        orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert into OrderDetails
                    string orderDetailQuery = @"
                        INSERT INTO OrderDetails (OrderID, BookID, Quantity, Price)
                        VALUES (@OrderID, @BookID, @Quantity, @Price);";

                    using (SqlCommand cmd = new SqlCommand(orderDetailQuery, con, transaction))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderId);
                        cmd.Parameters.AddWithValue("@BookID", order.BookID);
                        cmd.Parameters.AddWithValue("@Quantity", order.Quantity);
                        cmd.Parameters.AddWithValue("@Price", order.Price);

                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("Order placement failed: " + ex.Message);
                    return false;
                }
            }
        }
    }


}
