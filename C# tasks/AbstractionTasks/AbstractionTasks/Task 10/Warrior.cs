using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_10
{
    class Warrior: Character
    {
        public override void Attack()
        {
            Console.WriteLine("Warrior attacks with a mighty sword swing!");
        }

        public override void Defend()
        {
            Console.WriteLine("Warrior raises a shield to block.");
        }
    }
}
