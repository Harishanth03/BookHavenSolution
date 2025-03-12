using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public abstract class TransactionBase
    {
        public int ID { get; protected set; } // Common ID field
        public decimal TotalAmount { get; set; }
        public decimal Discount { get; set; }

        public decimal CalculateNetRevenue()
        {
            return TotalAmount - Discount;
        }
    }
}
