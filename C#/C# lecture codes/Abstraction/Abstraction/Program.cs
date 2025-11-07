using AnimalObject;
using BirdObject;
using DogObject;
using HuskyObject;

Bird bird = new Bird();
bird.Name = "Max";
bird.Age = 2;
bird.Wing = "pink";

Dog dog = new Dog();
dog.Name = "golden";
dog.Age = 3;
dog.Tail = "10sm";

//sealed keywordu hem classda hem de methodda istifade olunur
//sealed class edirsense o classdan miras ala bilmirsen
//meselen husky classi dogdan miras almaq isteyir, amma dog classinin qarsisina sealed yazilib
//ona gore miras ala bilmir

Husky husky = new Husky();
husky.Name = "husky";
husky.Age = 3;
husky.Tail = "10sm";
husky.Color = "gray";

Console.WriteLine(husky.Color);

Console.WriteLine(bird.Name);
bird.Eat();
dog.Eat();

dog.MakeSound();
bird.MakeSound();
husky.MakeSound(); // error verecek cunki sealed override yazilib


//sealed class => instance yarada bilir amma inheritance vere bilmir;
// abstract class => inheritance vere bilir amma instance yarada bilmir;

// sealed method override olanlarin qabagina yazilir
//esas meqsedi bu classdan miras alanlar artiq bu methodu override ede bilmesin

//method overloading ve operator overloading => static/compile time
//cunki methodu yazanda icindeki parametrlerin(overloading) compile edende gorursunuz
//ve neyise sehv yazanda hemin an bildirir
//meselen overload ancaq int ve string gondere bilir, amma siz bool gondermeye calisirsiniz hemin an error verir


//virtual/overriding method => dynamic/runtime
//cunki obyekt yaradildiqdan sonra baxir bu obyekte aiddir mi method yoxsa yox

