using AnimalObject;
namespace BirdObject
{
    class Bird:Animal
    {
        public string Wing;

        public override void MakeSound()
        {
            Console.WriteLine("cik");
        }

    }
}
