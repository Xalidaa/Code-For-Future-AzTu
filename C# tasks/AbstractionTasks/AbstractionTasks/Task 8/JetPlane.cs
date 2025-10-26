using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_8
{
    sealed class JetPlane:Plane
    {
        public override void Move()
        {
            Console.WriteLine("The jet plane is flying at high speed.");
        }
        public override void Brake()
        {
            Console.WriteLine("The jet plane is slowing down for landing.");
        }
    }
}
