namespace AnimalObject
{ // Animal classi base-dir, miras vermelidir amma instance almamalidir(abstract olur)
    //miras verdiyi classlar instance alir, ozu amma almir

    // abstract classlar, abstract methodlar

    //3 nov method olur: virtual, abstract, sealed
    abstract class Animal
    {
        public string Name;
        public int Age;


        //virtual method => bezi miras classlarda mueyyen methodu deyismek isteyirikse
        //virtual ve override keywordleri istifade olunur
        public virtual void Eat()
        {
            Console.WriteLine("Eat grass");
        }

        //abstract methodlarin kod bloku hissesi olmur base classda;
        //gedib miras verdiyimiz butun classlarda mutleq icini doldururuq;
        //virtual kimi o da override keywordunu istifade edir
        public abstract void MakeSound();
    }
}
