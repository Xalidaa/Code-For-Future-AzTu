using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Models
{
    abstract class Animal
    {
        public int AveLifeTime { get; set; }

        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine("Eat Meat");
        }
    }
}
