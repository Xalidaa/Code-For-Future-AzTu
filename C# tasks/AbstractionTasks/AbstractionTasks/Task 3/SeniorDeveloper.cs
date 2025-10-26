using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks
{
    sealed class SeniorDeveloper: Developer
    {
        public override void Work()
        {
            Console.WriteLine("Senior Developer is designing system architecture.");
        }
    }
}
