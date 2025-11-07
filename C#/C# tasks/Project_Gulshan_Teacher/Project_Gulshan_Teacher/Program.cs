namespace Project_Gulshan_Teacher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            User user1 = new User("Narmin", "Suleymanova", "Female", "Azerbaijani", "naraiissm", "narminsuleyman@gmail.com", "narmin");
            User user2 = new User("Ayaz", "Azimov", "Male", "Azerbaijani", "iazimov", "ayazazimov@gmail.com", "aiaz2006");
            User user3 = new User("Farid", "Mustafayev","Male","Azerbaijani", "faridmsta","faridmustafayev@gmail.com","farid12345");
            User user4 = new User("Furkan", "Yildirim", "Male", "Turkish", "p3rto", "furkan2004@gmail.com", "fur_kan04");
            User user5 = new User("Kamilla", "Rahimova", "Female", "Azerbaijani", "camileen", "kamillarahimova@gmail.com", "kamochek2006");
            User user6 = new User("Selcan", "Karimli", "Female", "Azerbaijani", "selkarimli", "seljankarimli@gmail.com", "sel_karim06");


            UserFunctions.CreateUser(users, user1);
            UserFunctions.CreateUser(users, user2);
            UserFunctions.CreateUser(users, user3);
            UserFunctions.CreateUser(users, user4);
            UserFunctions.CreateUser(users, user5);
            UserFunctions.CreateUser(users, user6);

            Console.WriteLine(UserFunctions.Login(users, "faridmsta", "farid12345"));
            Console.WriteLine(UserFunctions.Login(users, "leyla", "12345"));

            UserFunctions.SortUsersByUsername(users);
            var filtered = UserFunctions.FilterByBirthYear(users, 2000);

            User newUser = new User(
                name: "Ali",
                surname: "Mammadov",
                gender: "Male",
                nationality: "Azerbaijani",
                username: "ali123",
                email: "ali@mail.com",
                password: "12345",
                age: 25,
                isAdmin: false,
                bio: "Hello, I am Ali"
            );

            UserFunctions.CreateUser(users, newUser);

            UserFunctions.SortUsersByUsername(users);

            Console.WriteLine($"Total users: {users.Count}");
            Console.Write("First user: ");
            users[0].getFullName();
            Console.WriteLine();
        Console.WriteLine($"Username: {users[0].Username}");

        }
    }
}
