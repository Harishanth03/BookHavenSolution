using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using System.Data.SqlClient;

namespace BookHaven.Model
{
    public class Staff
    {

        public string StaffName { get; set; }
        public string UserName { get; set; }
        public string Password;
        public string Email { get; set; }
        public string UserRole { get; set; }


        public Staff(string staffName, string userName, string password, string email, string userRole)
        {
            StaffName = staffName;
            UserName = userName;
            Password = password;
            Email = email;
            UserRole = userRole;
        }


        public void AddStaff()
        {
            using(SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string insertQuery = "INSERT INTO staff (Name , Email , UserName , UserRole , PasswordHash) VALUES(@name , @email , @username , @userrole , ENCRYPTBYPASSPHRASE(@Passphrase, @Password))";

                using(SqlCommand cmd = new SqlCommand(insertQuery , con))
                {
                    cmd.Parameters.AddWithValue("@name", StaffName);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@username", UserName);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@userrole", UserRole);
                    cmd.Parameters.AddWithValue("@Passphrase", ENVProcess.GetEncryptionPassphrase());

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
