using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class PointOfSales : TransactionBase
    {
        public int SalesClerkID { get; set; }
        public int CustomerID { get; set; }
        public DateTime TransactionDate { get; private set; } = DateTime.Now;
        public string PaymentMethod { get; set; }

        public PointOfSales(int salesClerkID , int customerID , decimal totalAmount , string paymentMethod , decimal discount)
        {
            SalesClerkID = salesClerkID;

            CustomerID = customerID;

            TotalAmount = totalAmount;

            PaymentMethod = paymentMethod;

            Discount = discount;
        }

    }
}
