using StudentObject;
using PersonObject;
using EmployeeObject;
using ProductObject;
using MilkObject;

// Object Class

//instance = variable teyin etmek

// Student student = new Student();  //type(object), name,  value

// Console.WriteLine(student);

// Console.WriteLine(student.name); //bize bos cavab qaytaracaq, cunku obyektin icini doldurmamisiq heleki
//birazdan dolduranda bu isleyecek

// student.name = "Ali";
// student.surname = "Aliyev";
// student.birthYear = 2010;
// student.isMarried = false;
// Console.WriteLine(student.name);

// bir dene de obyekt yaradiram; bu hec elverisli yol deyil cunki her defe copy paste edirsen
//tutaq ki 100 dene telebe daxil etmelisense 500 setir kod yazmali olacaqsan. Bunu etmeyin
//basqa bir yolu var

// Student student_2 = new Student();
// student_2.name = "Ali";
// student_2.surname = "Aliyev";
// student_2.birthYear = 2005;
// student_2.isMarried = false;
// Console.WriteLine(student_2.name);

//Console.WriteLine(student.GetFullName()); yazmaq duzgun deyil cunki console-un icinde console var
//ve return type void-dur. Console.WriteLine ise void type goturmur.
//Ona gore biz sadece bele yazacagiq:

// student.GetFullName(); // Output: Ali Aliyev
// student_2.GetFullName(); // Output: Vali Valiyev

// Bu her iki obyektde isleyir cunki method ozu ayrica bir qelibdir, hec birine aid deyil

// student.GetFullInfo(); //Output: Name: Ali Surname: ALiyev BirthYear: 2010
// student_2.GetFullInfo(); //Output: Name: Vali Surname: Valiyev BirthYear: 2005

//Burada artiq return type var ona gore console istifade edirik
// Console.WriteLine(student.CalcAge()); //Output: 15
// Console.WriteLine(student_2.CalcAge()); //Output: 20



//Artiq yuxarida elave etdiyimiz melumatlarin qisa versiyasini gosterirem
//hansindaki constructor istifade etmisik diger faylda

//Student student = new Student("Azad", "Azadov", 2000, false);
//Student student_2 = new Student("Lale", "Abbasova", 2005, false);

//Console.WriteLine(student.name); //Output: Azad
//Console.WriteLine(student.birthYear); //Output: 2000
//student_2.GetFullInfo(); //Output: Name: Lale Surname: Abbasova BirthYear: 2005 isMarried: false


//Employee employee = new Employee("Azad", "Azadov", 2000, false,20000,"Developer");
//Console.WriteLine(employee.name);

Milk milk_1 = new Milk("Palsud",10, 2);
Milk milk_2 = new Milk("Milla",5, 4);
Milk milk_3 = new Milk("Atena",7, 9);

Milk[] milks = { milk_1, milk_2, milk_3 };

// Find average fatPercent of all milk products

int sum = 0;
int count = 0;
foreach(Milk milk in milks)
{
    sum = sum + milk.FatPercent;
    count++;
}

Console.WriteLine(sum/count);

// Find the milk products whose price is greater than 5

foreach(Milk milk in milks)
{
    if(milk.Price > 5)
    {
        Console.WriteLine(milk.Name);
    }
}








