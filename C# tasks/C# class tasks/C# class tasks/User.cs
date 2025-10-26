using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasks
{
    class User
    {
        public string username;
        public string password;

        public void Login()
        {
            string pass = "1234";

            string user = "Khalidaa";

            if ((username == user) && (password == pass))
            {
                Console.WriteLine("Giris ugurlu!");
            }
            else
            {
                Console.WriteLine("Sehv melumat");
            }
        }
    }
}
