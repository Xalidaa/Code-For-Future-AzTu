using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Istifadeciden 5 eded daxil etmesini iste
            // Daxil edilen ededleri array-de saxla ve onlari artan sira ile duzerek ekrana cixar

            int[] numbers = [3, 67, 45, 12, 0];
            Array.Sort(numbers);
            Console.WriteLine(String.Join(" ", numbers));

            // Task 2: Bir array-i tersine cevir ve neticeni ekrana cixar. Meselen: [1,2,3,4]  -  [4,3,2,1]

            Array.Reverse(numbers);
            Console.WriteLine(String.Join(" ", numbers));

            // Task 3: Verilen array-de en kicik ve en boyuk ededi tap ve ekrana cixar

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());

            // Task 4: Verilen array-de istifadecinin daxil etdiyi ededin olub-olmadigini yoxla

            int eded = 34;
            bool containsNumber = numbers.Contains(eded);
            Console.WriteLine(containsNumber);

            // Task 5: Bir array-deki butun elementleri yeni bi array-e kocur ve her iki array-i ekrana cixar

            int[] new_numbers = new int[numbers.Length];
            Array.Copy(numbers, new_numbers, numbers.Length);
            Console.WriteLine(String.Join(" ", new_numbers));
            Console.WriteLine(String.Join(" ", numbers));

            // Task 6: Verilen array-in mueyyen hissesini sifirla ve neticeni ekrana cixar

            int[] ededler = [3, 67, 45, 12, 0, 8, 99];
            for (int i = 0; i < 3; i++)
            {
                ededler[i] = 0;

            }
            Console.WriteLine(String.Join(" ", ededler));

            // Task 7: Bir array-in olcusunu artir ve yeni elave olunan elementlerin deyerlerini goster

            Array.Resize(ref numbers, numbers.Length + 2);
            for (int i = numbers.Length -2; i < numbers.Length; i++)
            {
                numbers[i] = 4;
                Console.WriteLine(numbers[i]);
            }

            // Task 8: Asagidaki adlardan ibaret array yaradaraq adlari elifba sirasina duz: {"Omar", "Ali", "Nigar", "Zaur"}

            string[] names = ["Omar", "Ali", "Nigar", "Zaur"];
            Array.Sort(names);
            Console.WriteLine(String.Join(" ", names));

            // Task 9: Bir array-deki tek ve cut ededleri ayir ve ayri-ayriliqda ekrana cixar

            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            }
            Console.WriteLine("Even numbers: " + String.Join(" ", evenList.ToArray()));
            Console.WriteLine("Odd numbers: " + String.Join(" ", oddList.ToArray()));

            // Task 10: Iki ededler massivini birlesdir ve neticeni ekrana cixar

            int[] combined = numbers.Concat(ededler).ToArray();
            Console.WriteLine(String.Join(" ", combined));

            // Task 11: Verilen array-de 50-den boyuk ededin olub-olmadigini yoxla ve neticeni cixar

            foreach(int num in combined)
            {
                if (num > 50)
                {
                    Console.WriteLine("True");
                    break;
                }
            }

            // Task 12: Verilen array-de mueyyen bir ededin nece defe tekrarlandigini tap ve ekrana cixar

            int number = 0;
            int count = 0;
            foreach (int num in combined)
            {
                if (num == number)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            // Task 13: Bir array-deki butun ededlerin cemini tap ve orta qiymetini hesabla

            int sum = 0;
            int count1 = 0;
            foreach (int num in combined)
            {
                sum = sum + num;
                count1++;
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum/count1);

            // Task 14: Bir array-in mueyyen hissesini basqa bir array-e kocur ve neticeni goster

            int length = 4;
            int[] newArray = new int[length];
            Array.Copy(combined, 4, newArray, 0, length);
            Console.WriteLine(String.Join(" ", newArray));

            // Task 15: Istifadeci nece element daxil edeceyini evvelceden bildirir

            int len = 5;
            int[] arr = new int[len];
            for(int i = 0; i < len; i++)
            {
                arr[i] = i;
            }

            Console.WriteLine(String.Join(" ", arr));

        }
    }
}