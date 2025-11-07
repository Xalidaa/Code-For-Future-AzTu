
using ProductObject;
namespace BookObject
{
    class Book:Product
    {
        public string Author;

        public Book(string name,string description,int price,string author):base(name,description,price)
        {
            Author = author;
        }

        public override void SayName()
        {
            Console.WriteLine($"This is book name: {Name}");
        }
    }
}
