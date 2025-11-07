using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_8
{
    abstract class Transport
    {
        public abstract void Move();

        public virtual void Brake()
        {
            Console.WriteLine("The transport stopped.");
        }

        public void Move(int speed)
        {
            Console.WriteLine($"The transport is moving at {speed} km/h.");
        }
    }
}
