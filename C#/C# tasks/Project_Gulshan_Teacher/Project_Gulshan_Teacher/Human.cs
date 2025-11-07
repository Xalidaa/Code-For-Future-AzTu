using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Gulshan_Teacher
{
    public class Human
    {
        public string Name;
        public string Surname;
        public int Age = 0;
        public string Gender;
        public string Nationality;

        public Human( string name, string surname, string gender, string nationality, int age=0)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
            Nationality = nationality;
        }

        public void getFullName()
        {
             Console.WriteLine($"{Name} {Surname}");
        }

        public int getBirthYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - Age;
        }


    }
}
