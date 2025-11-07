using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_5
{
    sealed class SmartPhone: Phone
    {
        public override void TurnOn()
        {
            Console.WriteLine("SmartPhone is turning on.");
        }
        public override void TurnOff()
        {
            Console.WriteLine("SmartPhone is turning off.");
        }
        public override void Info()
        {
            Console.WriteLine("This is a SmartPhone.");
        }
    }
}
