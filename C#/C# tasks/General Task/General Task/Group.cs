using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General_Task
{
    class Group
    {
        private static int nextnum = 101;
        public string No { get; }
        private Student[] students;

        public Group()
        {
            No = "AP" + nextnum;
            nextnum++;
            students = new Student[0];
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("Student cannot be null.");
                return;
            }

            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            Console.WriteLine($"{student.Name} added to group {No}");

        }

        public void GetAllStudents()
        {
            Console.WriteLine("All students: ");
            foreach(Student student in students)
            {
                Console.Write($"{student.Name} ");
                Console.WriteLine(student.Surname);
            }
        }

        public Student[] Sort()
        {
            Student[] copy = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                copy[i] = students[i];
            }

            for (int i = 0; i < copy.Length - 1; i++)
            {
                for (int j = 0; j < copy.Length - i - 1; j++)
                {
                    if (copy[j].Point > copy[j + 1].Point)
                    {
                        Student temp = copy[j];
                        copy[j] = copy[j + 1];
                        copy[j + 1] = temp;
                    }
                }
            }
            return copy;
        }


        public void GroupInfo()
        {
            Console.WriteLine($"Group number: {No}");
        }

    }
}
