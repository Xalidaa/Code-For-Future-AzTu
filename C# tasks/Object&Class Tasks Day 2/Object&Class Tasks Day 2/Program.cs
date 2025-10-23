using Object_Class_Tasks_Day_2;

namespace Objects_Class_Tasks_Day_2
{
    internal class Program
{
    static void Main(string[] args)
    {
            // TASK 1

            Person p1 = new Person();
            p1.Name = "Khalida";
            p1.Age = -10;
            Console.WriteLine(p1.Age);

            //TASK 2

            Student s1 = new Student(101);
            Console.WriteLine(s1.StudentId);

            // TASK 3

            UserAccount user = new UserAccount();
            user.Password = "mySecret123";
            Console.WriteLine(user.Password);

            // TASK 4

            Product product1 = new Product();
            product1.Price = 100;
            Console.WriteLine(product1.Price);

            Product product2 = new Product();
            product2.Price = -13;
            Console.WriteLine(product2.Price);

            //TASK 5

            Car car1 = new Car();
            car1.StartEngine();

            // TASK 6

            Dog dog = new Dog("Rex");
            dog.DisplayName();

            // TASK 7

            Book book = new Book("War and Peace", "L.Tolstoy");
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);

            // TASK 8

            Shape shape = new Circle();
            Shape shape2 = new Rectangle();
            shape.Draw();
            shape2.Draw();

            // TASK 9

            Shape shape1 = new Circle();
            shape1.Draw();

            // TASK 10

            MathOperations math = new MathOperations();
            Console.WriteLine(math.Add(3, 4));
            Console.WriteLine(math.Add(3.5, 4.2));
            Console.WriteLine(math.Add(3, 4,5));


        }
}
        
    
}
