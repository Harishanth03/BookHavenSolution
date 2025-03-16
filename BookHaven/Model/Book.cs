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
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }

        public Books(string title , string author , string isbn , string genre , decimal price , int stockQuantity)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            Price = price;
            StockQuantity = stockQuantity;
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

                string bookInsertQuery = "INSERT INTO Book (Title, Author, ISBN, Genre, Price, StockQuantity) " +
                                         "VALUES (@title, @author, @isbn, @genre, @price, @stockQuantity)";

                using (SqlCommand command = new SqlCommand(bookInsertQuery, connection))
                {
                    command.Parameters.AddWithValue("@title", book.Title);
                    command.Parameters.AddWithValue("@author", book.Author);
                    command.Parameters.AddWithValue("@isbn", book.ISBN);
                    command.Parameters.AddWithValue("@genre", book.Genre);
                    command.Parameters.AddWithValue("@price", book.Price);
                    command.Parameters.AddWithValue("@stockQuantity", book.StockQuantity);

                    command.ExecuteNonQuery();
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

        public static bool deleteBook(int bookID)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string deleteStaffQuery = "DELETE FROM staff WHERE StaffID = @staffID";

                    using (SqlCommand cmd = new SqlCommand(deleteStaffQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@staffID", bookID);

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
