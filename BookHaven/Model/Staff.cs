using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class Staff
    {
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string UserName { get; set; }

        public string Password;
        public string Email { get; set; }
        public string UserRole { get; set; }


        public Staff(int staffID ,  string staffName, string userName, string password, string email, string userRole)
        {
            StaffName = staffName;
            UserName = userName;
            Password = password;
            Email = email;
            UserRole = userRole;
            Id = staffID;
        }

        //======================================================== Add Staff Details ==========================================================

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

        //=============================================== Login Staff Details ===========================================================

        public bool login(string userName , string password , out string userRole)
        {
            userRole = null;

            string queryLogin = @"SELECT UserRole FROM staff WHERE UserName = @username AND CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE(@Passphrase, PasswordHash)) = @password";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(queryLogin , con))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@Passphrase" , ENVProcess.GetEncryptionPassphrase());

                    object result = cmd.ExecuteScalar();
                    if (result != null) 
                    { 
                        userRole = result.ToString();
                        return true;
                    }
                }

            }

             return false;
        }

        //==================================================== Update Staff Details =======================================================

        public void UpdateStaff()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string updateQuery = "UPDATE staff SET Name = @name, Email = @email, UserRole = @userrole WHERE StaffID = @staffID";

                using (SqlCommand cmd = new SqlCommand(updateQuery , connection))
                {
                    cmd.Parameters.AddWithValue("@name", StaffName);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@userrole", UserRole);
                    cmd.Parameters.AddWithValue("@staffID", Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //====================================================== Delete Staff ============================================================

        public static void DeleteStaff(int staffID)
        {
            using (SqlConnection connection =DatabaseConnection.GetConnection())
            {
                connection.Open();

                string deleteQuery = "DELETE FROM staff WHERE StaffID = @staffID";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@staffID", staffID);
                    cmd.ExecuteNonQuery();
                }

                connection.Close();
            }

            MessageBox.Show("Staff member deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
