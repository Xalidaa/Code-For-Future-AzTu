using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Models
{
    abstract class Bird : Animal
    {
        public bool HasEggs { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Make Bird Sound");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat Meat");
        }
    }
}
