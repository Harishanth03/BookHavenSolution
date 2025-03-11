using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

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
    }


}
