using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Circle : Shape
    {
        protected double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Circle Area: {Area()}");
        }
    }
}
