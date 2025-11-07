using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

namespace C__ref_out_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Task 1: ref ilə iki ədədin yerini dəyişmək ref parametri imkan verir.
             * Dəyişiklik birbaşa əsas dəyişənə tətbiq olunur.*/

            int x = 5;
            int y = 10;
            Console.WriteLine($"Evvel: x = {x}, y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Sonra: x = {x}, y = {y}");

            /* Task 2: out ilə ədədi analiz etmək out parametrləri üçündür.
             * Burada return əvəzinə iki out istifadə olunub.*/
            int num = -4;
            bool positive, even;
            AnalyzeNumber(num, out positive, out even);
            Console.WriteLine($"Eded: {num}, Musbet: {positive}, Cut: {even}");

            /* Task 3: ref ilə massivdəki ədədləri 2 dəfə artırmaq  
             *  ref ilə ötürülən massivdə edilən dəyişiklik .
             *  Hər element 2 dəfə artırılır. */

            int[] myArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Evvel:");
            foreach (int num in myArray)
            {
                Console.Write(num + " ");
            }

            DoubleArray(ref myArray);
            Console.WriteLine("\nSonra:");
            foreach (int num in myArray)
            {
                Console.Write(num + " ");
            }

            /* Task 4: out ilə String analiz (simvol və sait sayı)
            İki out parametri: biri ümumi uzunluq, biri saitlərin sayı üçün.
            vowels.Contains(ch) ilə sait yoxlanılır.*/

            string sentence = "Hello World";
            int totalLength, vowels;
            AnalyzeString(sentence, out totalLength, out vowels);

            Console.WriteLine($"Metn: {sentence}");
            Console.WriteLine($"Umumi uzunluq: {totalLength}");
            Console.WriteLine($"Saitlerin sayı: {vowels}");

            /* Task 5: Method Overloading ilə sahə hesablamaları
             * Eyni adda 3 metod, amma(int, double, 2 int).
             * C# avtomatik olaraq uyğun metodu seçir. */

            Console.WriteLine("Kvadratın sahəsi: " + Area(5));
            Console.WriteLine("Dairənin sahəsi: " + Area(2.5));
            Console.WriteLine("Düzbucaqlının sahəsi: " + Area(4, 7));


        }

        // Task 1
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

        }

        // Task 2
        static void AnalyzeNumber(int number, out bool isPositive, out bool isEven)
        {
            isPositive = number > 0;
            isEven = number % 2 == 0;
        }

        // Task 3

        static void DoubleArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= 2;
            }
        }

        // Task 4
        static void AnalyzeString(string str, out int length, out int vowelCount)
        {
            length = str.Length;
            vowelCount = 0;
            string vowels = "aeiouAEIOU";
            foreach (char ch in str)
            {
                if (vowels.Contains(ch))
                {
                    vowelCount++;
                }
            }
        }


        // Task 5

        static double Area(int side)
        {
            return side * side;
        }

        static double Area(double radius)
        {
            return 3.14 * radius * radius;
        }

        static double Area(int width, int height)
        {
            return width * height;
        }



    }
}
