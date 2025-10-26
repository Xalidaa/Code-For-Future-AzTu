using C__Interfaces.Models;

namespace C__Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Eaggle eaggle = new Eaggle
            {
                AveLifeTime = 10,
                HasEggs = false,
                FlySpeed = 1000,
                CrawPower = 50
            };

            Console.WriteLine(eaggle);
            eaggle.Fly();

            Penguin penguin = new Penguin
            {
                AveLifeTime = 10,
                HasEggs = false,
                SwimSpeed = 200
            };

            Console.WriteLine(penguin);
            penguin.Swim();

            Duck duck = new Duck
            {
                AveLifeTime = 8,
                HasEggs = true,
                FlySpeed = 50,
                SwimSpeed = 100
            };

            Console.WriteLine(duck);
            duck.Fly();
            duck.Swim();

            Plane plane = new Plane
            {
                FlySpeed = 900
            };
            Console.WriteLine(plane);

            plane.Fly();
        }
    }
}
