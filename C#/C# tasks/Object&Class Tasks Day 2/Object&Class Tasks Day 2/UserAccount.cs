using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Tasks_Day_2
{
    class UserAccount
    {
        private string password;

        public string Password
        {
            get
            {
                return "Password hidden";
            }

            set
            {
                password = "****";
            }
        }
    }
}
