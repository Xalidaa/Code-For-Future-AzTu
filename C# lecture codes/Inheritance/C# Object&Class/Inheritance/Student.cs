// class members - classin icerisindeki hisseler
//fields - structure: access modifier, type, name
//methods
//constructor
//properties


//bir classin icinde bir nece ctor arasinda melumat alis verisi etmek ucun this istifade etdik

namespace C__Object_Class.Inheritance
{
    class Student
    {
        // fields
        public string name;
        public string surname; 
        public int birthYear;
        public bool isMarried;
        public int Average;
        public string Group;

        //constructor
        //qurucu methoddur
        //return type olmur
        //mutleq classla eyni adda olmalidir: bizim halda Student
        //methodla oxsarligi parametr qebul edir

        // Bu qeder setir yazmaq evezine her defe bu constructorlari bir birileri ile
// elaqelendire bilerem, bunun ucun this qoyacam constructorun yanina ve parametri qeyd edecem

        //public Student(string name, string surname, int birthYear, bool isMarried):this(name,surname,birthYear)
        //{
        //    //this.name = name;
        //    //this.surname = surname;
        //    //this.birthYear = birthYear;
        //    this.isMarried = isMarried;
        //}

        //// Bunlarda her defe bir arqumenti azalda bilerik, o zaman nese elave etmesek program.cs terefde
        //// hansisa arqumenti daxil etmesek error vermeyecek, 
        ////amma yazmasa idik error verecekdi ki,arqument sayi uygun deyil bir birine 
        //public Student(string name, string surname, int birthYear):this(name,surname)
        //{
        //    //this.name = name;
        //    //this.surname = surname;
        //    this.birthYear = birthYear;
        //}

        //public Student(string name, string surname):this(name)
        //{
        //    //this.name = name;
        //    this.surname = surname;
        //}

        //public Student(string name) : this()
        //{
        //    this.name = name;
        //}

        //public Student()
        //{
        //    Console.WriteLine("Constructor is working");
        //}




        // methods

        // access modifier/ return type/ name /parametr/ kod bloku

        public void GetFullName()
        {
            Console.WriteLine(name + " " + surname);
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {name} Surname: {surname} BirthYear: {birthYear}");
        }

        public int CalcAge()
        {
            int age = 2025 - birthYear;
            return age;
        }

      


    }
}