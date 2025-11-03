namespace GenericExample
{//new() yeni obyekt yaradir; bu da demekdir ki abstract classlar yaza bilmeyeceksen
    class ZooCage <T,U> where T : Animal,new() //esas meqsed T ve U evezine yalniz bu classlar ve miraslari yazila bilsin
                        where U : Food,new()   //basqa class, tip yazilmasin
    {
        public T[] animals = new T[0];

        public U Food;

        public ZooCage(U food)
        {
            Food = food;
        }

        public void Add(T animal)
        {
            Array.Resize(ref animals, animals.Length + 1);
            animals[animals.Length - 1] = animal;
        }

        public void ShowAnimals()
        {
            foreach(T animal in animals)
            {
                Console.Write(animal);
            }
        }
    }
}

