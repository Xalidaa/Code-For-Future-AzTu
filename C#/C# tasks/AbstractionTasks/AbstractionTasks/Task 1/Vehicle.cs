using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    abstract class Vehicle
    {
        public abstract void StartEngine();

        public virtual void StopEngine()
        {
            Console.WriteLine("Vehicle stopped.");
        }

        public void StartEngine(string mode)
        {
            Console.WriteLine($"Vehicle engine started in {mode} mode.");
        }
    }
}
