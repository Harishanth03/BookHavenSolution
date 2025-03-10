using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Models
{
    public class Customer
    {
        public int customerID { get; set; }

        public string customerName { get; set; }

        public string customerEmail { get; set; }

        public string customerPhone { get; set; }

        public string customerAddress { get; set; }

        public string memberShipStatus { get; set; }

        public string whoAdded { get; set; }

    }


}
