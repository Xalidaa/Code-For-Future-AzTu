namespace General_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ramiz", "Qurbanli", 19, 98.6);
            Student s2 = new Student("Ayaz", "Azimov", 19, 95.8);
            Student s3 = new Student("Zhala", "Suleymanova", 20, 97.6);
            Student s4 = new Student("Narmin", "Suleymanova", 20, 98.5);

            Group group1 = new Group();
            group1.AddStudent(s1);
            group1.AddStudent(s2);
            group1.AddStudent(s3);
            group1.AddStudent(s4);

            group1.GetAllStudents();

            group1.Sort();


            Group group2 = new Group();
            group2.GroupInfo();

            s1.ShowInfo();
            s2.ShowInfo();
            s3.ShowInfo();


            if (s1 > s2)
            {
                Console.WriteLine($"{s1.Name} got higher point than {s2.Name}");
            }
            else
            {
                Console.WriteLine($"{s2.Name} got higher point than {s1.Name}");
            }

        }
    }
}
