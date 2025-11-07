using AbstractionTasks.Task_10;
using AbstractionTasks.Task_5;
using AbstractionTasks.Task_6;
using AbstractionTasks.Task_7;
using AbstractionTasks.Task_8;
using AbstractionTasks.Task_9;

namespace AbstractionTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TASK 1
            Vehicle car = new Car();
            car.StartEngine();
            car.StopEngine();

            car.StartEngine("Eco");

            Car tesla = new ElectricCar();
            tesla.StartEngine();
            tesla.StopEngine();

            //TASK 2

            Shape s1 = new Rectangle(4, 5);
            s1.Display();

            Shape s2 = new Circle(3);
            s2.Display();

            Shape s3 = new Rectangle(7, 2);
            s3.Display();

            Console.WriteLine("Overloaded Area Methods:");
            Console.WriteLine("Rectangle Area (overload): " + s1.Area(3, 6));
            Console.WriteLine("Circle Area (overload): " + s2.Area(5));

            //TASK 3

            Manager mgr = new Manager() { Name = "Zhala", Age = 19 };
            mgr.ShowInfo();
            mgr.Work();

            Developer dev = new Developer() { Name = "Aqil", Age = 19 };
            dev.ShowInfo();
            dev.ShowInfo("Backend");

            SeniorDeveloper sdev = new SeniorDeveloper() { Name = "Murad", Age = 30 };
            sdev.Work();
            sdev.ShowInfo();

            // TASK 4

            Dog dog = new Dog();
            dog.MakeSound();
            dog.Sleep();

            Cat cat = new Cat();
            cat.MakeSound(2);

            //TASK 5

            Phone phone1 = new Phone();
            phone1.TurnOff();

            Computer comp = new Computer();
            comp.Info();

            SmartPhone sp = new SmartPhone();
            sp.TurnOn("Khalida");

            //TASK 6

            CreditCard card = new CreditCard();
            card.Pay(150.00);
            card.Confirm();

            PayPal pal = new PayPal();
            pal.Pay(200.00, "AZN");
            pal.Confirm();

            // TASK 7
            AudioPlayer ap = new AudioPlayer();
            ap.Play("High");

            // TASK 8

            JetPlane jp = new JetPlane();
            jp.Move(600);

            //TASK 9


            // TASK 10

            Warrior warrior = new Warrior();
            Mage mage = new Mage();
            Boss boss = new Boss();

            // 1. Warrior Actions
            Console.WriteLine("\n**Warrior Actions:**");
            warrior.Attack(); 
            warrior.Defend();

            // 2. Mage Actions
            Console.WriteLine("\n**Mage Actions:**");
            mage.Attack();
            mage.Defend();

            // 3. Boss Actions
            Console.WriteLine("\n**Boss Actions:**");

            boss.Attack();

            boss.Attack("Sword of Annihilation");

            boss.Defend();



        }

    }
}
