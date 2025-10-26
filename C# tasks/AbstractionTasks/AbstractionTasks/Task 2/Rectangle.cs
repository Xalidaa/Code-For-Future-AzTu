using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public Rectangle(double w, double h)
        {
            width = w;
            height = h;
        }

        public override double Area()
        {
            return width * height;
        }

        public override void Display()
        {
            Console.WriteLine($"Rectangle Area: {Area()}");
        }
    }
}
