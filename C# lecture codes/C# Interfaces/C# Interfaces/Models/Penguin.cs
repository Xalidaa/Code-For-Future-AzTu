using C__Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Models
{
    class Penguin:Bird, ISwim
    {
        public int SwimSpeed { get; set; }

        public void Swim()
        {
            Console.WriteLine("Penguin swim away " + SwimSpeed);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Penguin Sound");
        }
    }
}
