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
    public abstract class Staff
    {
        public int Id { get; set; }
        public string StaffName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } // Changed to property
        public string Email { get; set; }
        public string UserRole { get; set; }

        protected Staff(int staffID, string staffName, string email, string userName, string password, string userRole)
        {
            Id = staffID;
            StaffName = staffName;
            UserName = userName;
            Password = password;
            Email = email;
            UserRole = userRole;
        }

        // 🔹 Abstract method for inserting role-specific data
        public abstract void InsertRoleSpecificData(int staffID);

        // 🔹 Method to check if a user already exists
        public static bool UserExists(string userName, string email)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM staff WHERE UserName = @username OR Email = @email";
                using (SqlCommand cmd = new SqlCommand(checkQuery, con))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@email", email);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        //===============================================  Static Login Method ===========================================================
        public static bool Login(string userName, string password, out string userRole)
        {
            userRole = null;
            string queryLogin = @"SELECT UserRole FROM staff 
                          WHERE UserName = @username 
                          AND CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE(@Passphrase, PasswordHash)) = @password";

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(queryLogin, con))
                {
                    cmd.Parameters.AddWithValue("@username", userName);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@Passphrase", ENVProcess.GetEncryptionPassphrase());

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


        //==================================================== 🔹 Update Staff Details =======================================================
        public void UpdateStaff()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string updateQuery = "UPDATE staff SET Name = @name, Email = @email, UserRole = @userrole WHERE StaffID = @staffID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", StaffName);
                    cmd.Parameters.AddWithValue("@email", Email);
                    cmd.Parameters.AddWithValue("@userrole", UserRole);
                    cmd.Parameters.AddWithValue("@staffID", Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //====================================================== 🔹 Delete Staff ============================================================
        public static void DeleteStaff(int staffID)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
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
