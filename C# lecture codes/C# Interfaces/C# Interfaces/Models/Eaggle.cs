using C__Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Models
{
    class Eaggle: Bird, IFly
    {
        public int CrawPower { get; set; }
        public int FlySpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Eaggle fly away " + FlySpeed);
        }

        public override void MakeSound()
        {
            Console.WriteLine("Eaggle Sound");
        }
    }
}
