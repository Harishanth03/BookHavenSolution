using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class SalesTransactionDetails : TransactionBase
    {
        public int SalesTransactionID { get; set; }
        public int BookID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public SalesTransactionDetails(int salesTransactionID, int bookID, int quantity, decimal price)
        {
            SalesTransactionID = salesTransactionID;
            BookID = bookID;
            Quantity = quantity;
            Price = price;
            TotalAmount = price * quantity; // 
        }
    }
}
