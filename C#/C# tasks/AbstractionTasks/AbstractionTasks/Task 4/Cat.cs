using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Cat: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!");
        }
        public override void Sleep()
        {
            Console.WriteLine("The cat is sleeping curled up.");
        }
    }
}
