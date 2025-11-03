using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//fieldlerde access modifierler default olaraq private-dir

namespace ProductObject
{
    class Product
    {
        public string Name;
        public string Description;
        public int Price;


        public Product(string name,string description,int price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public virtual void SayName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
