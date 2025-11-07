using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_4
{
    sealed class Parrot: Bird
    {
        public override void MakeSound()
        {
            Console.WriteLine("Squawk! Squawk!");
        }

        public override void Sleep()
        {
            Console.WriteLine("The parrot is sleeping while hanging upside down.");
        }
    }
}
