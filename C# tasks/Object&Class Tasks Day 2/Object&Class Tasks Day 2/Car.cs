using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_Tasks_Day_2
{
    class Car
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");

            CheckEngine();
        }

        private void CheckEngine()
        {
            Console.WriteLine("Checking the engine");
        }
    }
}
