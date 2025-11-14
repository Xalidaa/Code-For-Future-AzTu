using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Gallery gallery = new Gallery();
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Vehicle Management System");
                Console.ResetColor();
                Console.WriteLine("1. Add a new car");
                Console.WriteLine("2. Show all cars");
                Console.WriteLine("3. Find a specific car");
                Console.WriteLine("4. Exit the program");
                Console.Write("type your option: ");
                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.Write("Enter the car brand: ");
                    string brand = Console.ReadLine();
                    Console.Write("Enter the car model: ");
                    string model = Console.ReadLine();
                    Console.Write("Enter the car mile: ");
                    double mile = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter the number of doors: ");
                    int doorsNum = Convert.ToInt32(Console.ReadLine());

                    try
                    {
                        Car car = new Car(brand, model, mile, doorsNum);
                        gallery.AddCar(car);
                        Console.WriteLine("The car is added");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
                else if (choice == "2")
                {
                    Console.WriteLine("All cars: ");
                    gallery.ShowAllCars();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Options to search: ");
                    Console.WriteLine("1. Search according to brand");
                    Console.WriteLine("2. Search according to mile");
                    Console.Write("Choose your option: ");
                    string searchChoice = Console.ReadLine();

                    if (searchChoice == "1")
                    {
                        Console.Write("Enter the brand name: ");
                        string brandSearch = Console.ReadLine();
                        var foundCars = gallery.FilterCar(brandSearch);
                        Console.WriteLine("Search result:");
                        foreach (var car in foundCars)
                        {
                            car.ShowFullInfo();
                        }
                    }
                    else if (searchChoice == "2")
                    {
                        Console.Write("Enter the mile: ");
                        double mileSearch = Convert.ToDouble(Console.ReadLine());
                        var foundCars = gallery.FilterCar(mileSearch);
                        Console.WriteLine("Search result:");
                        foreach (var car in foundCars)
                        {
                            car.ShowFullInfo();
                        }
                    }


                }
                else if (choice == "4")
                {
                    Console.WriteLine("Exiting the program...");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                }
            }
        }
    }
}