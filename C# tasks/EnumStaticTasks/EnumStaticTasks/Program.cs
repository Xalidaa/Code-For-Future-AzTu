using EnumStaticTasks.Task_10;

namespace EnumStaticTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1

            User user1 = new User("naraissm", "narminsuleymanova@gmail.com");
            User user2 = new User("iazimov", "ayazazimov@gmail.com");
            User user3 = new User("faridmsta", "faridmustafayev@gmail.com");


            Console.WriteLine($"Total number of users: {User.count}");

            //TASK 2

            Console.WriteLine(Converter.CelciusToFarenheit(100));
            Console.WriteLine(Converter.FarenheitToCelcius(212));

            //TASK 3

            Console.WriteLine(MathConstants.Area(5));

            //TASK 4

            IdGenerator.GetNextId();
            IdGenerator.GetNextId();
            IdGenerator.GetNextId();
            Console.WriteLine(IdGenerator.GetNextId());

            //TASK 5

            int day = 3;

            switch(day)
            {
                case (int)Days.Monday:
                    Console.WriteLine(Days.Monday);
                    break;
                case (int)Days.Tuesday:
                    Console.WriteLine(Days.Tuesday);
                    break;
                case (int)Days.Wednesday:
                    Console.WriteLine(Days.Wednesday);
                    break;
                case (int)Days.Thursday:
                    Console.WriteLine(Days.Thursday);
                    break;
                case (int)Days.Friday:
                    Console.WriteLine(Days.Friday);
                    break;
                case (int)Days.Saturday:
                    Console.WriteLine(Days.Saturday);
                    break;
                case (int)Days.Sunday:
                    Console.WriteLine(Days.Sunday);
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }


            //TASK 6


            static void ShowPermissions(UserRole role)
            {
                switch (role)
                {
                    case UserRole.Admin:
                        Console.WriteLine($"{UserRole.Admin} has full access");
                        break;
                    case UserRole.Moderator:
                        Console.WriteLine($"{UserRole.Moderator} has less access than {UserRole.Admin}");
                        break;
                    case UserRole.Member:
                        Console.WriteLine($"{UserRole.Member} has access to member info");
                        break;
                    case UserRole.Guest:
                        Console.WriteLine($"{UserRole.Guest} has no access");
                        break;
                    default:
                        Console.WriteLine("Invalid role");
                        break;

                }
            }

            ShowPermissions(UserRole.Admin);
            ShowPermissions(UserRole.Moderator);
            ShowPermissions(UserRole.Member);
            ShowPermissions(UserRole.Guest);

            //TASK 7

            static void OrdersStatus(OrderStatus status)
            {
                switch (status)
                {
                    case OrderStatus.Pending:
                        Console.WriteLine("Order is pending");
                        break;
                    case OrderStatus.Processing:
                        Console.WriteLine("Order is processing");
                        break;
                    case OrderStatus.Completed:
                        Console.WriteLine("Order is ready");
                        break;
                    case OrderStatus.Cancelled:
                        Console.WriteLine("Order has been cancelled");
                        break;
                    default:
                        Console.WriteLine("Invalid error");
                        break;

                }


            }

            OrdersStatus(OrderStatus.Completed);

            // TASK 8

            FileAccess userAccess = FileAccess.Read | FileAccess.Write;

            Console.WriteLine($"İstifadəçi səlahiyyətləri: {userAccess}");
            if ((userAccess & FileAccess.Read) == FileAccess.Read)
            {
                Console.WriteLine("Oxuma icazəsi var.");
            }
            else if ((userAccess & FileAccess.Write) == FileAccess.Write)
            {
                Console.WriteLine("Yazma icazəsi var.");
            }
            else if ((userAccess & FileAccess.Execute) == FileAccess.Execute) 
            {
                Console.WriteLine("İcra icazəsi var.");
            }
            else
            {
                Console.WriteLine("İcra icazəsi yoxdur.");
            }

            //TASK 10

            AppConfig.ShowSettings();


        }
    }
}
