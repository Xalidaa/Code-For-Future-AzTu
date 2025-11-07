// static members - classdan asili olan field, constructor, method ve property
// non-static members - obyektden asili olan field, constructor, method ve property

//Name, Surname, Age non-staticdir
//WorkAge static memberdir

//non-static memberler static memberlerden istifade ede bilir cunki static non-staticden qabaq yaranmisdi artiq


namespace Static_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person_1 = new Person
            {
                Name = "Ali",
                Surname = "Aliyev",
                Age = 20,

            };

            Person person_2 = new Person
            {
                Name = "Vali",
                Surname = "Valiyev",
                Age = 23,

            };

            Person person_3 = new Person
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Age = 30,

            };

            Person person_4 = new Person
            {
                Name = "Hesen",
                Surname = "Hesenov",
                Age = 30,

            };

            ////Console.WriteLine(person_1.WorkAge); this is wrong

            Console.WriteLine(Person.WorkAge);


            person_1.GetInfo();
            //Console.WriteLine(person_1.Capitalize("hello")); this is wrong
            Console.WriteLine(Person.Capitalize("hello"));

            Console.WriteLine(Person.instance_count);
        }
    }
}
