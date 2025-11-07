using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_10
{
    sealed class Boss : Warrior
    {
        public override void Attack()
        {
            Console.WriteLine("Boss attacks with immense power!");
        }
        public void Attack(string weapon)
        {
            Console.WriteLine($"Boss attacks using the legendary weapon: {weapon}!");
        }
    }
}
