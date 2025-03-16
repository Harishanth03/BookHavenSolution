using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven.Model
{
    public abstract class Staff
    {
        public string StaffName {  get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; protected set; } //Read Only From the Outside.
        public string Password { get; set; }

        public abstract void setUserRole();

        public Staff()
        {
            setUserRole(); //for call when constractor was calls.
        }


    }
}
