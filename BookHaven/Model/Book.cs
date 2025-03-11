using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

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

                string bookInsertQuery = "INSERT INTO Book (Title, Author, ISBN, Genre, Price, StockQuantity) VALUES (@title, @author, @isbn, @genre, @price, @stockQuantity)";

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
    }
}
