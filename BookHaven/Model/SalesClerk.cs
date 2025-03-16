using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class SalesClerk : Staff
    {
        public override void setUserRole()
        {
            UserRole = "SalesClerk"; //When Sales Clerk will called UserROle is = to Sales Clerk. i used Over ride.
        }
    }
}
