using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DotNetEnv;
using System.Drawing;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class StaffRepository
    {

        //============================================== Add Staff Methood =============================================================


        public void AddStaff(Staff staff) // i set the staff class as Object so it will handle the Subclass of Staff class
        {
            try
            {
                using (SqlConnection connetcion = DatabaseConnection.GetConnection())
                {
                    connetcion.Open(); 

                    SqlTransaction transaction = connetcion.BeginTransaction();

                    string AddInsertQuery = "INSERT INTO staff (Name , Email , UserName , UserRole , PasswordHash) " +
                                    "VALUES(@name , @email , @username , @userrole , ENCRYPTBYPASSPHRASE(@Passphrase, @Password)); " +
                                    "SELECT CAST(SCOPE_IDENTITY() AS INT);"; // Get the last inserted ID

                    int staffID;

                    using (SqlCommand command = new SqlCommand(AddInsertQuery, connetcion , transaction))
                    {
                        command.Parameters.AddWithValue("@name", staff.StaffName);
                        command.Parameters.AddWithValue("@email", staff.Email);
                        command.Parameters.AddWithValue("@username", staff.UserName);
                        command.Parameters.AddWithValue("@userrole" , staff.UserRole);
                        command.Parameters.AddWithValue("@Passphrase" , ENVProcess.GetEncryptionPassphrase());
                        command.Parameters.AddWithValue("@Password", staff.Password);

                        //command.ExecuteNonQuery();
                        staffID = (int)command.ExecuteScalar();
                        
                    }

                    if(staff is Admin)
                    {
                        string insertAdminQuery = "INSERT INTO Admin (AdminID, TotalReportGenerated) VALUES (@staffID, 0)";

                        using(SqlCommand command = new SqlCommand(insertAdminQuery, connetcion , transaction))
                        {
                            command.Parameters.AddWithValue("@staffID" , staffID);

                            command.ExecuteNonQuery();
                        }
                    }
                    else if(/*staff.UserRole == "SalesClerk"*/ staff is SalesClerk)
                    {
                        string insertSalesClerkQuery = "INSERT INTO SalesClerk (SalesClerkID, TotalSalesProcessed) VALUES (@staffID, 0)";

                        using (SqlCommand cmd = new SqlCommand(insertSalesClerkQuery, connetcion, transaction))
                        {
                            cmd.Parameters.AddWithValue("@staffID", staffID);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit(); // its will commit the trasaction is everying is success
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error inserting staff: " + ex.Message);
                throw;  //Rethrow the exception so it can be handled properly
            }
        }

        //============================================== Login Staff Methood =============================================================

        public static bool LoginStaff(string username , string enteredPassword , out string userrole , out string staffName , out int staffID)
        {
            userrole = null;

            staffName = null;

            staffID = -1;

            bool userExits = false;

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string loginQuery = @"SELECT  StaffID , UserRole , Name , CONVERT(NVARCHAR(MAX), DECRYPTBYPASSPHRASE(@Passphrase, PasswordHash)) AS DecryptedPassword
                                    FROM staff
                                    WHERE UserName = @username";

                    using (SqlCommand command = new SqlCommand(loginQuery, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@Passphrase", ENVProcess.GetEncryptionPassphrase()); //Get the pass key from the .ENV file

                        using (SqlDataReader reader = command.ExecuteReader()) //execute the command as reader so its retrive the data from the database as forward only
                        {
                            if (reader.Read()) //if user exist
                            {
                                userExits = true;

                                string deceiptPassword = reader["DecryptedPassword"] as string; //i goy the passwordHash as DecriptedPassword

                                userrole = reader["UserRole"].ToString();

                                staffName = reader["Name"].ToString();

                                staffID = Convert.ToInt32(reader["StaffID"]);

                                if (enteredPassword == deceiptPassword)
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }

                if(!userExits)
                {
                    MessageBox.Show("Username does not exist", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        //============================================== Update Staff Methood =============================================================

        public void UpdateStaffDetails(int staffid , string newStaffName , string newStaffEmail , string newStaffUserRole) //Update staff details code
        {
            try
            {
                using(SqlConnection con = DatabaseConnection.GetConnection()) //get the DB connection from DatabaseConnection Class
                {
                    con.Open();

                    string updateQueryStaff = @"UPDATE staff SET Name = @newName , Email = @newEmail, UserRole = @newUserRole WHERE StaffID = @staffID";

                    using(SqlCommand cmd = new SqlCommand(updateQueryStaff , con))
                    {
                        //Parametrized for avoid SQL injection
                        cmd.Parameters.AddWithValue("@newName", newStaffName);
                        cmd.Parameters.AddWithValue("@staffID" , staffid);
                        cmd.Parameters.AddWithValue("@newEmail" , newStaffEmail);
                        cmd.Parameters.AddWithValue("@newUserRole", newStaffUserRole);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0) // If the update was successful
                        {
                            MessageBox.Show("Staff details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // If no rows were updated, it means the StaffID was not found
                        {
                            MessageBox.Show("No matching staff found. Update failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //============================================== Delete Staff Methood ===============================================================

        public static void DeleteStaff(int staffID)
        {
            try
            {
                using(SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string deleteStaffQuery = "DELETE FROM staff WHERE StaffID = @staffID";

                    using (SqlCommand cmd = new SqlCommand(deleteStaffQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@staffID" , staffID);

                        int rowDeleted = cmd.ExecuteNonQuery();

                        if (rowDeleted > 0)
                        {
                            MessageBox.Show("Staff member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No matching staff found. Deletion failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
