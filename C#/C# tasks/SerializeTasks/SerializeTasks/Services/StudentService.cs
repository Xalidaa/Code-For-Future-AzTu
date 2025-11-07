using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SerializeTasks.Models;
using Newtonsoft.Json;

namespace SerializeTasks.Services
{
    class StudentService
    {
        public static void WriteStudentsToFile(string path,List<Student> students )
        {
            string jsonString = JsonConvert.SerializeObject(students, Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path,false))
            {
                sw.WriteLine(jsonString);
            }
        }

        public static void AddStudentToFile(string path, Student student)
        {
                List<Student> students;
            using (StreamReader sr = new StreamReader(path))
            {
                string fileContent = sr.ReadToEnd();

                if (string.IsNullOrEmpty(fileContent)) 
                {
                    students = new List<Student>();
                }
                else
                {
                    students = JsonConvert.DeserializeObject<List<Student>>(fileContent);
                    
                }


            }
                students.Add(student);

                WriteStudentsToFile(path, students);
            
        }
        public static void RemoveStudentFromFile(string path, string studentName)
        {
            List<Student> students;

            using (StreamReader sr = new StreamReader(path))
            {
                string fileContent = sr.ReadToEnd();
                students = JsonConvert.DeserializeObject<List<Student>>(fileContent);

                if (students.Contains(studentName))
                {
                    students.Remove(students.IndexOf(studentName));
                }
                else
                {
                    Console.WriteLine($"The student with name {studentName} is not found");
                }
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                string jsonString = JsonConvert.SerializeObject(students, Formatting.Indented);
                sw.WriteLine(jsonString);
            }
        }
    }
}
