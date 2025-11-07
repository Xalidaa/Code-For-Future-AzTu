using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_5
{
    abstract class Device
    {
        public abstract void TurnOn();

        public abstract void TurnOff();

        public virtual void Info()
        {
            Console.WriteLine("Generic Device");
        }

        public void TurnOn(string user)
        {
            Console.WriteLine($"Device is turning on for user: {user}");
        }
    }
}
