using C__Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Models
{
    class Duck: Bird, IFlySwim
    {
        public int FlySpeed { get; set; }
        public int SwimSpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Duck fly away " + FlySpeed);
        }

        public void Swim()
        {
            Console.WriteLine("Duck swim away " + SwimSpeed);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Duck Sound");
        }

    }
}
