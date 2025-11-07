using SerializeTasks.Models;
using SerializeTasks.Services;

namespace SerializeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\ca r221.14\\source\\repos\\SerializeTasks\\SerializeTasks\\Data\\JSons\\index.json";
            List<Student> students = new()
            {
                new Student {Name = "Narmin", Age =20 , Group = new Group {Name = "6523e" } },
                new Student {Name = "Ulviyye", Age =21 , Group = new Group {Name = "652id" } }
            };

            StudentService.WriteStudentsToFile(path, students);
            Console.WriteLine("Ilkin telebeler fayla yazildi.");

            Student newStudent = new Student{Name = "Khalida", Age = 19, Group = new Group { Name = "APA201" } };
            StudentService.AddStudentToFile(path, newStudent);
            Console.WriteLine("Yeni telebe elave edildi");

            StudentService.RemoveStudentFromFile(path, "Narmin");
            Console.WriteLine($"Telebe silindi");
        }
    }
}
