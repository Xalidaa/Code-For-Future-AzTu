using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_5
{
    class Computer: Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Computer is turning on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Computer is turning off.");
        }

        public override void Info()
        {
            Console.WriteLine("This is a Computer.");
        }
    }
}
