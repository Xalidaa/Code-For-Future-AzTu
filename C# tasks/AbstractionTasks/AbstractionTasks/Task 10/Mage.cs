using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_10
{
    class Mage: Character
    {
        public override void Attack()
        {
            Console.WriteLine("Mage casts a destructive fire spell!");
        }
        public override void Defend()
        {
            Console.WriteLine("Mage teleports a short distance to evade.");
        }
    }
}
