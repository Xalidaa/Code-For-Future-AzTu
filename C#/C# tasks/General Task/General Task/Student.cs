using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Task
{
    class Student
    {
        private static int nextId = 1;

        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Point { get; set; }

        public Student(string name, string surname, int age, double point)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                Console.WriteLine("Name and Surname cannot be empty.");
                return;
            }

            if (point < 0)
            {
                Console.WriteLine("Point cannot be negative");
                return;
            }

            Id = nextId++;
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Surname: {Surname}, Age: {Age}, Point: {Point}");
        }

        public static bool operator >(Student s1, Student s2)
        {
            return s1.Point > s2.Point;
        }

        public static bool operator <(Student s1, Student s2)
        {
            return s1.Point < s2.Point;
        }

        

    }
}
