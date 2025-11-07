using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car stopped.");
        }
    }
}
