using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Tasks_Day_2
{
    class Product
    {
        private int price;

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The price can't be negative");

                }
                else
                {
                    price = value;

                }
            }
        }
    }
}
