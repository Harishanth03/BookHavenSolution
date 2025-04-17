using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace BookHaven.Model
{
    public class Books
    {
        public int BookID { get; private set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; } //retail price
        public int StockQuantity { get; set; }
        public int SupplierID { get; set; }


        public Books(string title , string author , string isbn , string genre , decimal price , int stockQuantity , int supplierId)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Price = price;
            StockQuantity = stockQuantity;
            SupplierID = supplierId;
        }
    }

    //======================================================== Add Book Details ==========================================================

    public class BookRespo
    {
        public void addBook(Books book)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    int bookID;

                    // Check if the book already exists
                    string checkQuery = "SELECT BookID FROM Book WHERE ISBN = @isbn";

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection, transaction))
                    {
                        checkCmd.Parameters.AddWithValue("@isbn", book.ISBN);
                        object result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Book already exists
                            bookID = Convert.ToInt32(result);
                        }
                        else
                        {
                            // Insert new book
                            string insertBook = @"INSERT INTO Book (Title, Author, ISBN, Genre, Price, StockQuantity)
                                          VALUES (@title, @author, @isbn, @genre, @price, @stock);
                                          SELECT CAST(SCOPE_IDENTITY() AS INT)";

                            using (SqlCommand insertCmd = new SqlCommand(insertBook, connection, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@title", book.Title);
                                insertCmd.Parameters.AddWithValue("@author", book.Author);
                                insertCmd.Parameters.AddWithValue("@isbn", book.ISBN);
                                insertCmd.Parameters.AddWithValue("@genre", book.Genre);
                                insertCmd.Parameters.AddWithValue("@price", book.Price);
                                insertCmd.Parameters.AddWithValue("@stock", book.StockQuantity);

                                bookID = (int)insertCmd.ExecuteScalar();
                            }
                        }
                    }

                    // Always insert into Purchase table
                    string insertPurchase = @"INSERT INTO Purchase (SupplierID, BookID, Quantity, PurchasePrice)
                                      VALUES (@supplierID, @bookID, @quantity, @purchasePrice)";

                    using (SqlCommand purchaseCmd = new SqlCommand(insertPurchase, connection, transaction))
                    {
                        purchaseCmd.Parameters.AddWithValue("@supplierID", book.SupplierID);
                        purchaseCmd.Parameters.AddWithValue("@bookID", bookID);
                        purchaseCmd.Parameters.AddWithValue("@quantity", book.StockQuantity);
                        purchaseCmd.Parameters.AddWithValue("@purchasePrice", book.Price);

                        purchaseCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Failed to add book and purchase: " + ex.Message);
                }
            }
        }


        public static bool updateBook(int bookID ,  Books book)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string updateQuery = "UPDATE Book SET Title = @title, Author = @author, ISBN = @isbn, " +
                                "Genre = @genre, Price = @price " +
                                "WHERE BookID = @bookID";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@title" , book.Title);
                        cmd.Parameters.AddWithValue("@author" , book.Author);
                        cmd.Parameters.AddWithValue("@isbn", book.ISBN);
                        cmd.Parameters.AddWithValue("@genre", book.Genre);
                        cmd.Parameters.AddWithValue("@price", book.Price);
                        cmd.Parameters.AddWithValue("@bookID" , bookID);

                        int rowAffected = cmd.ExecuteNonQuery();

                        if (rowAffected > 0)
                        {
                            MessageBox.Show("Book updated successfully!", "Book Update" , MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Book Not Found!", "Book Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error inserting staff: " + ex.Message);
                throw;
            }
        }

        public static bool deleteBook(int bookID) //get the BookID as parameter from Object Creation in Butt0n clck event
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection()) 
                {
                    connection.Open();

                    string deleteStaffQuery = "DELETE FROM Book WHERE BookID = @bookID";

                    using (SqlCommand cmd = new SqlCommand(deleteStaffQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@bookID", bookID);

                        int rowDeleted = cmd.ExecuteNonQuery();

                        if (rowDeleted > 0)
                        {
                            MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("No matching  book found. Deletion failed.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting staff: " + ex.Message);
                throw;
            }
        }
    }
}
