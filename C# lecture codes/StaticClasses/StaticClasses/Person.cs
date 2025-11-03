namespace StaticClassExample
{
    class Person
    {
        public string Name { get; set; }
        
        public Person(string name)
        {
            //Name = Helper.Capitalize(name);
            Name = name.Capitalize();
        }
    }
}
