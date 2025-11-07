using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__Interfaces.Interfaces;

namespace C__Interfaces.Models
{
    class Plane: IFly
    {
        public int FlySpeed { get; set; }

        public void Fly()
        {
            Console.WriteLine("Plane fly away " + FlySpeed);
        }
    }
}
