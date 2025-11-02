using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductObject
{
    class Product
    {
        public string Name;
        public int Price;

        public Product(string name,int price)
        {
            Name = name;
            Price = price;
        }
    }
}
