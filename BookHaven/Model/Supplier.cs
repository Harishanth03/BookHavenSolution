using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }        
        public string Address { get; set; }    
        public string SupplierType { get; set; }

        public Supplier(string name, string contactPerson, string phone , string email , string address , string supplierType) //for add
        {
            Name = name;
            ContactPerson = contactPerson;
            Phone = phone;
            Email = email;
            Address = address;
            SupplierType = supplierType;
        }

        public Supplier(int id, string name, string contactPerson, string phone , string email, string address, string supplierType) //for update and delete
        {
            SupplierID = id;
            Name = name;
            ContactPerson = contactPerson;
            Phone = phone;
            Email = email;
            Address = address;
            SupplierType = supplierType;
        }
    }

    public class SupplierRespo
    {
        // ======================== Add Supplier ========================
        public void AddSupplier(Supplier supplier)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO Supplier (Name, ContactPerson, Phone, Email, Address, SupplierType) VALUES (@name, @contact, @phone, @email, @address, @type)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", supplier.Name);
                    cmd.Parameters.AddWithValue("@contact", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("@address", supplier.Address);
                    cmd.Parameters.AddWithValue("@type", supplier.SupplierType);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        // ======================== Update Supplier ========================
        public bool UpdateSupplier(Supplier supplier)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "UPDATE Supplier SET Name = @name, ContactPerson = @contact, Phone = @phone, Email = @email, Address = @address, SupplierType = @type WHERE SupplierID = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", supplier.Name);
                    cmd.Parameters.AddWithValue("@contact", supplier.ContactPerson);
                    cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                    cmd.Parameters.AddWithValue("@id", supplier.SupplierID);
                    cmd.Parameters.AddWithValue("@email", supplier.Email);
                    cmd.Parameters.AddWithValue("@address", supplier.Address);
                    cmd.Parameters.AddWithValue("@type", supplier.SupplierType);

                    int affected = cmd.ExecuteNonQuery();
                    return affected > 0;
                }
            }
        }

        // ======================== Delete Supplier ========================
        public bool DeleteSupplier(int supplierId)
        {
            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM Supplier WHERE SupplierID = @id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", supplierId);
                    int deleted = cmd.ExecuteNonQuery();
                    return deleted > 0;
                }
            }
        }

        // ======================== Search Suppliers ========================
        public List<Supplier> SearchSuppliers(string keyword)
        {
            List<Supplier> results = new List<Supplier>();

            using (SqlConnection con = DatabaseConnection.GetConnection())
            {
                con.Open();
                string query = @"SELECT SupplierID, Name, ContactPerson, Phone 
                                 FROM Supplier 
                                 WHERE Name LIKE @keyword OR ContactPerson LIKE @keyword";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            results.Add(new Supplier(
                                Convert.ToInt32(reader["SupplierID"]),
                                reader["Name"].ToString(),
                                reader["ContactPerson"].ToString(),
                                reader["Phone"].ToString(),
                                reader["Email"]?.ToString(),
                                reader["Address"]?.ToString(),
                                reader["SupplierType"]?.ToString()
                            ));

                        }
                    }
                }
            }

            return results;
        }
    }


}
