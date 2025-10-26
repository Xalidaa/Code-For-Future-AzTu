using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_10
{
    abstract class Character
    {
        public abstract void Attack();
        public virtual void Defend()
        {
            Console.WriteLine("Character defends.");
        }
    }
}
