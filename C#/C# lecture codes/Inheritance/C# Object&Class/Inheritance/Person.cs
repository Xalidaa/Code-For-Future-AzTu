namespace C__Object_Class.Inheritance
{
    class Person
    {
        public string name;

        public string surname;

        public int birthYear;

        public bool isMarried;

        public Person(string name, string surname,int birthYear,bool isMarried)
        {
            this.name = name;
            this.surname = surname;
            this.birthYear = birthYear;
            this.isMarried = isMarried;
        }
    }
}