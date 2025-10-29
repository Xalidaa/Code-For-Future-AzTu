using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStaticTasks
{
    class MathConstants
    {
        public static double PI { get; set; }
        public static double E { get; set; }


        static MathConstants()
        {
            PI = Math.PI;
            E = Math.E;
        }

        public static double Area(int r)
        {
            return PI * r * r;
        }

    }
}
