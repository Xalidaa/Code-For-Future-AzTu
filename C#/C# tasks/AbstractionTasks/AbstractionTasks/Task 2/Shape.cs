using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    abstract class Shape
    {
        public abstract double Area();
        public virtual void Display()
        {
            Console.WriteLine($"Area: {Area()}");
        }

        public double Area(double width, double height)
        {
            return width * height;
        }

        public double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
