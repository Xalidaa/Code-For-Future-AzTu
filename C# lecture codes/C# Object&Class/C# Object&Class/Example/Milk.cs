using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductObject;
namespace MilkObject
{
    class Milk:Product
    {
        public int FatPercent;

        public Milk(string name, int price,int fatPercent): base(name,price)
        {
            FatPercent = fatPercent;
        }
    }
}
