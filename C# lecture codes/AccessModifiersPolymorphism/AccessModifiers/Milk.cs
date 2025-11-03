
using ProductObject;
namespace MilkObject
{
    class Milk:Product
    {
        public int FatPercent;

        public Milk(string name, string description,int price,int fatPercent) : base(name, description, price)
        {
            FatPercent = fatPercent;
        }

        public override void SayName()
        {
            Console.WriteLine($"This is milk name: {Name}");
        }
    }
}
