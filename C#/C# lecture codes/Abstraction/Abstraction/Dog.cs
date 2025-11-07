using AnimalObject;

namespace DogObject
{
    /*sealed*/ class Dog:Animal
    {
        public string Tail;


        public override void Eat()
        {
            Console.WriteLine("Eat meat");
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine("woof");
        }
    }
}
