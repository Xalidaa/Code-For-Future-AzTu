using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Tasks_Day_2
{
    class Dog : Animal
    {
        public Dog(string dogName) : base(dogName)
        {
            
        }

        public void DisplayName()
        {
            Console.WriteLine("Dog's name: " + name);
        }
    }
}
