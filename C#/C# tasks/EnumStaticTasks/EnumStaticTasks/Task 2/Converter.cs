using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStaticTasks
{
    class Converter
    {
        public static double CelciusToFarenheit(double c)
        {
            return (c * 1.8) + 32;
        }

        public static double FarenheitToCelcius(double f)
        {
            return (f - 32) / 1.8;
        }


    }
}
