using Generic_Type;
using GenericExample;
//program.csde class hissesini nece yazmisiq ele qeyd edirik yeni <> isare ile
//ve o isarenin icinde gonderdiyimiz deyerin tipini qeyd edirik
//tutaq ki en birinci numunede deyer 50-dir, ona gore <int> yaziriq

//Product<int> product = new Product<int>(50);
//Product<char> product_2 = new Product<char>('A');
//Product<string> product_3 = new Product<string>("High");

//Console.WriteLine(product_3.Quality);
//Console.WriteLine(product_2.Quality);


Lion lion = new Lion { Name = "lion_1", AveLifeTime=20, IsPrime=true };
Elephant elephant = new Elephant { Name = "elephant_1", AveLifeTime=20, TeethWeight=50};

Meat meat = new Meat { Name = "beef",IsHalal=true};
Grass grass = new Grass { Name = "yonca", Size = 50 };

ZooCage<Lion,Meat> zoocage = new ZooCage<Lion,Meat>(meat);
zoocage.Add(lion);
zoocage.ShowAnimals();

ZooCage<Elephant,Grass> zoocage1 = new ZooCage<Elephant,Grass>(grass);
zoocage1.Add(elephant);

Console.WriteLine(zoocage.animals);
Console.WriteLine(zoocage1.animals);

