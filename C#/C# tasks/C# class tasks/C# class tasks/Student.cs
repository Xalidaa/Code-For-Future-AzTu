using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasksentObject
{
    class Student
    {
        public string name;
        public int age;
        public int grade;


        public void ShowInfo()
        {
            Console.WriteLine($"Name: {name} Age: {age} Grade: {grade}");
        }
    }
}
