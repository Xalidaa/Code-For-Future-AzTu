using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    class Bird: Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Chirp! Chirp!");
        }
        public override void Sleep()
        {
            Console.WriteLine("The bird is sleeping perched on a branch.");
        }
    }
}
