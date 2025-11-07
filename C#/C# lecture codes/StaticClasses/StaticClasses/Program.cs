using StaticClassExample;
//Console.WriteLine(Person.Capitalize("heLLO"));

Person person = new Person("alI");
Console.WriteLine(person.Name);


string str = "helLo";
Console.WriteLine(str.Capitalize()); //Output: Hello

int a = 5;
Console.WriteLine(a.Square());


int b = 3;
Console.WriteLine(Helper.Pow(a,b)); // (int num, int time)
Console.WriteLine(a.Pow(b)); // (this int num, int time)