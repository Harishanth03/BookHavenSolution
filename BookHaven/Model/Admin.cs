using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public class Admin : Staff
    {
        public override void setUserRole()
        {
            UserRole = "Admin";
        }
    }
}
