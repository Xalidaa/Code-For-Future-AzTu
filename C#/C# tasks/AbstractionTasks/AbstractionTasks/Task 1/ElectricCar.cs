using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    sealed class ElectricCar : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Electric car powered on.");
        }
        public override void StopEngine()
        {
            Console.WriteLine("Electric car powered off.");
        }
    }
}
