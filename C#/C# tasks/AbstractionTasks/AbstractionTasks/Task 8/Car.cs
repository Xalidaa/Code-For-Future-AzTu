using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_8
{
    class Car: Transport
    {
        public override void Move()
        {
            Console.WriteLine("The car is moving.");
        }
        public override void Brake()
        {
            Console.WriteLine("The car stopped.");
        }
    }
}
