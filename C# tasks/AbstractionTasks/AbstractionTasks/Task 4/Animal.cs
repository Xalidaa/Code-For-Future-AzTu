using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    abstract class Animal
    {
        public abstract void MakeSound();

        public virtual void Sleep()
        {
            Console.WriteLine("The animal is sleeping.");
        }

        public void MakeSound(int times)
        {
            for (int i = 1; i <=times; i++)
            {
                MakeSound();
            }
        }
    }
}
