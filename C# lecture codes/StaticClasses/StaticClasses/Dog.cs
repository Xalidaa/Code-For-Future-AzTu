namespace StaticClassExample
{
    class Dog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            //Name = Helper.Capitalize(name);
            Name = name.Capitalize();
        }
    }
}
