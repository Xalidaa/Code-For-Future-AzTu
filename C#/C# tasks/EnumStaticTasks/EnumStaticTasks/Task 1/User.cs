using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStaticTasks
{
    class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public static int count { get; set; }


        static User()
        {
            count = 0;
        }

        public User(string name, string email)
        {
            Name = name;
            Email = email;
            count++;
        }

        
    }
}
