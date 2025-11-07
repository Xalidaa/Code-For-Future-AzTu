using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Developer: Employee
    {
        public override void Work()
        {
            Console.WriteLine("Developer is writing code.");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Developer: {Name}, Age: {Age}");
        }

        public void ShowInfo(string department)
        {
            Console.WriteLine($"Developer: {Name}, Department: {department}");
        }
    }
}
