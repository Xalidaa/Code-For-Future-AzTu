using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    class Person
    {
        //public int instance_count = 0;
        public static int instance_count = 0;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static int WorkAge { get; set; }

        // class yarandigi anda static ctor ise dusur
        // adi ctor ise obyekt yarananda ise dusur

        //static ctoru static bir deyisene deyer menimsetmek isteyende istifade edirik
        static Person()
        {
            WorkAge = 19;
            Console.WriteLine("static ctor ise dusdu");
        }

        public Person ()
        {
            instance_count++; 
            Console.WriteLine(instance_count);
            // her obyekt ucun yeniden basdaki qiymete qayidir ele artirir eger non-staticdirse field; output olur: 1 1 1
            //amma static olanda en son ne idise deyer ona elave edir output olur bu halda: 1 2 3
            Console.WriteLine("non-static ctor ise dusdu");
        }


        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}  Age: {Age} Surname: {Surname}");
        }

        //metodun obyektden hec bir asililigi yoxdur, bunu staticle etsek daha yaxsi olar
        public static string Capitalize (string word)
        {
            return word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
        }
    }
}
