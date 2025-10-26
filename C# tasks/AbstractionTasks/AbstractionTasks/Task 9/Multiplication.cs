using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_9
{
    class Multiplication: MathUtility
    {
        public override int Calculate()
        {
            int a = 5;
            int b = 10;
            return a * b;
        }
        public override void DisplayResult()
        {
            Console.WriteLine("Multiplication Result: " + Calculate());
        }
    }
}
