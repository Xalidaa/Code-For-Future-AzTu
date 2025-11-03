using DogObject;

namespace HuskyObject
{
    class Husky : Dog
    {
        public string Color;


        public override void Eat()
        {
            Console.WriteLine("Eat meat");
        }

        public override void MakeSound()
        {
            Console.WriteLine("husky woof");
        }
    }
}

