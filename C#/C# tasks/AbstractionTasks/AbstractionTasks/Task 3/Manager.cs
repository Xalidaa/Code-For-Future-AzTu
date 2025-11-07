using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing the team.");
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Manager name: {Name}  Age: {Age}");
        }
    }
}
