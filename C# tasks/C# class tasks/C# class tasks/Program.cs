namespace C__class_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Student student = new Student();
            //student.name = "Khalida";
            //student.age = 19;
            //student.grade = 100;

            //Student student_2 = new Student();
            //student_2.name = "Narmin";
            //student_2.age = 20;
            //student_2.grade = 98;

            //student.ShowInfo();
            //student_2.ShowInfo();

            //Task 2
            //Car car = new Car("Toyota", "Camry",2009);
            //car.Display();

            //Task 3

            //Rectangle area = new Rectangle();
            //area.width = 8;
            //area.height = 4;

            //Console.WriteLine(area.Area());

            // Task 4

            //BankAccount account = new BankAccount();
            //account.owner = "Khalida";
            //account.balance = 1200.50;

            //account.Withdraw();

            // Task 5

            //Book book1 = new Book("Master i Marqarita", "Mixail Bulqakov", 500);
            //Book book2 = new Book("Tri Musketera", "Alexandr Duma", 600);
            //book1.GetInfo();
            //book2.GetInfo();

            // Task 6

            User user1 = new User();
            user1.username = "Khalida123";
            user1.password = "1234";
            user1.Login();


            // Task 7
            Employee emp1 = new Employee();
            emp1.name = "Ali";
            emp1.salaryPerHour = 45;
            emp1.hoursWorked = 20;
            Console.WriteLine(emp1.CalculateSalary());

        }
    }
}
