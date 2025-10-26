using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_9
{
    abstract class MathUtility
    {
        public abstract int Calculate();

        public virtual void DisplayResult()
        {
            Console.WriteLine("The result is: " + Calculate());
        }

        public int Calculate(int a, int b)
        {
            return a + b;
        }

        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}
