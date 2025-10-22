namespace Object_Class_hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            //Human person1 = new Human("Khalida","Hajizada",19,"Female","Azerbaijani");
            //person1.GetFullName();
            //Console.WriteLine(person1.GetBirthYear());


            //TASK 2

            Phone p1 = new Phone("Apple", "iPhone 14", 6, 90, 900, 1200, 5);
            Phone p2 = new Phone("Samsung", "Galaxy S23", 7, 80, 800, 1100, 3);

            Laptop l1 = new Laptop("Asus", "ROG Strix", 15, 70, 1500, 2000, 2);
            Laptop l2 = new Laptop("HP", "Pavilion", 14, 60, 900, 1000, 4);

            Device[] products = { p1, p2, l1, l2 };

            FilterByPrice(products, 1000);
            FilterByName(products, "Apple");
        }

        static void FilterByPrice(Device[] arr, double minPrice)
        {
            Console.WriteLine("\n Price >" + minPrice + "olan mehsullar: ");

            foreach (var item in arr)
            {
                if (item.sale_price > minPrice)
                {
                    Console.WriteLine(item.brand + " " + item.model);
                }
            }
        }

        static void FilterByName(Device[] arr, string name)
        {
            int count = 0;
            foreach (var item in arr)
            {
                if(item.brand.ToLower() == name.ToLower())
                {
                    count++;
                }
            }
            Console.WriteLine("\n" + name + " adlı məhsulların sayı: " + count);
        }
    }
}
