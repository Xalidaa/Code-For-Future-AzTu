using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_hometask
{
    //TASK 1
    class Human
    {
        public string name;
        public string surname;
        public int age;
        public string gender;
        public string nationality;

        public Human(string name, string surname, int age, string gender, string nationality)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.gender = gender;
            this.nationality = nationality;
        }

        public void GetFullName()
        {
            Console.WriteLine($" Full name: {name} {surname}");
        }

        public int GetBirthYear()
        {
            int birth = 2025 - age;
            return birth;
        }


    }
}
