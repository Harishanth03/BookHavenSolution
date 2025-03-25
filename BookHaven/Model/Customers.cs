using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class Customers
    {
        public int customerID { get; private set; }
        public string fullName { get; set; }
        public string phoneNumber { get; set; }
        public string addres { get; set; }
        public string email { get; set; }
        public string membershipStatus { get; set; }
        public decimal totalSpent { get; set; }

        public Customers(string fullname, string phone, string address, string membershipstatus , string emailAddress)
        {
            fullName = fullname;
            phoneNumber = phone;
            addres = address;
            email = emailAddress;
            membershipStatus = membershipstatus;
        }
    }

    public class customerRespo
    {
        public static void AddCustomer(Customers customer)
        {
            using(SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();

                string insertQuery = "INSERT INTO Customer (FullName, Phone, Address, MembershipStatus , Email) VALUES (@fullName, @phone, @address, @membershipStatus , @email)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                {
                    cmd.Parameters.AddWithValue("@fullName", customer.fullName);
                    cmd.Parameters.AddWithValue("@phone", customer.phoneNumber);
                    cmd.Parameters.AddWithValue("@address", customer.addres);
                    cmd.Parameters.AddWithValue("@email", customer.email);
                    cmd.Parameters.AddWithValue("@membershipStatus", customer.membershipStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int GetTotalCustomer()
        {
            int totalCustomers = 0;

            try
            {
                using(SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();

                    string query = "SELECT COUNT(*) FROM Customer"; //Select the all Count from the Customer table

                    using(SqlCommand cmd = new SqlCommand(query , con))
                    {
                        totalCustomers = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving total customers: " + ex.Message);
                throw;
            }

            return totalCustomers;
        }

        //========================================================= Update Customer Code ===========================================================

        public static bool UpdateCustomerDetails(int customerId , Customers customer)
        {
            try
            {
                using(SqlConnection con = DatabaseConnection.GetConnection())
                {
                    con.Open();

                    string updateQuery = @"UPDATE Customer SET FullName = @fullName, Phone = @phone, Address = @address, MembershipStatus = @membershipStatus, Email = @email WHERE CustomerID = @customerID";

                    using(SqlCommand cmd = new SqlCommand (updateQuery , con))
                    {
                        cmd.Parameters.AddWithValue("@fullName", customer.fullName);
                        cmd.Parameters.AddWithValue("@phone", customer.phoneNumber);
                        cmd.Parameters.AddWithValue("@address", customer.addres);
                        cmd.Parameters.AddWithValue("@email", customer.email);
                        cmd.Parameters.AddWithValue("@membershipStatus", customer.membershipStatus);
                        cmd.Parameters.AddWithValue("@customerID", customerId);

                        int rowsffected = cmd.ExecuteNonQuery();

                        return rowsffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating customer: " + ex.Message);
                return false;
            }
        }

        //==================================================== Delete Customer =================================================================

        public static bool DeleteCustomer(int customerID)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM Customer WHERE CustomerID = @customerID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@customerID", customerID);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("Customer not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    //Handle Foreign Key Constraints
                    string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @customerID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);

                        int rowDeleted = cmd.ExecuteNonQuery();
                        return rowDeleted > 0;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                if (sqlEx.Number == 547) // Foreign key violation error
                {
                    MessageBox.Show("Cannot delete customer! There are linked transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error deleting customer: " + sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
        }

    }


}
