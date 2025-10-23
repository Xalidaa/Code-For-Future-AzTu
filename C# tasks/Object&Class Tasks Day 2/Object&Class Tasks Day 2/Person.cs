using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Tasks_Day_2
{
    class Person
    {
        private string name;
        private int age;
        public int Age
        {
            get
            {
                return age;

            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid age");
                }

            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {

            }
        }
    }   
}
