using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    abstract class Media
    {
        private string _title { get; set; }
        private int _year { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Title cannot be empty.");
                }
                _title = value;
                
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Year cannot be negative.");
                }
                _year = value;
            }
        }

        public abstract void DisplayInfo();

    }
}
