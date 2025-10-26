using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_5
{
    class Phone: Device
    {
        public override void TurnOn()
        {
            Console.WriteLine("Phone is turning on.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Phone is turning off.");
        }

        public override void Info()
        {
            Console.WriteLine("This is a Phone.");
        }
    }
}
