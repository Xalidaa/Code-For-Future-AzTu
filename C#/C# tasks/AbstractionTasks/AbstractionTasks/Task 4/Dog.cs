using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Dog: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }

        public override void Sleep()
        {
            Console.WriteLine("The dog is sleeping peacefully.");
        }
    }
}
