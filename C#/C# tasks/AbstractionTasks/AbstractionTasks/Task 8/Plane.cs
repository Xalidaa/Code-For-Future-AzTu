using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_8
{
    class Plane: Transport
    {
        public override void Move()
        {
            Console.WriteLine("The plane is flying.");
        }
        public override void Brake()
        {
            Console.WriteLine("The plane has landed.");
        }
    
    }
}
