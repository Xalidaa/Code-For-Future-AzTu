using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_9
{
    sealed class Power:Multiplication
    {
        public override int Calculate()
        {
            int a = 2;
            int b = 3;
            return (int)Math.Pow(a, b);
        }
        public override void DisplayResult()
        {
            Console.WriteLine("Power Result: " + Calculate());
        }
    }
}
