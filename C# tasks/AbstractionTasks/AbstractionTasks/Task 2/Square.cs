using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    sealed class Square:Rectangle
    {
        public Square(double side) : base(side, side)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"Square Area: {Area()}");
        }
    }
}
