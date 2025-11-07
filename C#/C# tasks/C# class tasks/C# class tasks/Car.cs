using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasks
{
    class Car
    {
        public string brand;
        public string model;
        public int year;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Brand: {brand}  Model: {model}  Year: {year}");
        }
    }
}
