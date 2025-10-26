using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    abstract class Employee
    {
        public string Name;
        public int Age;
        public abstract void Work();

        public virtual void ShowInfo()
        {
            Console.WriteLine("Employee info shown");
        }
    }
}
