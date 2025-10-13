namespace Task_in_C_
{
    internal class Program
    {
        static void Main(String[] args)
        {
            // Task 1: Massivin elementlərini ekrana çap et

            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Task 2: Massivdəki elementlərin cəmini tap

            int sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);

            // Task 3: Massivdəki ən böyük elementi tap

            int[] numbers = { 1, 2, 3, 4, 5 };
            int largest = numbers[0];
            foreach (int i in numbers)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            Console.WriteLine(largest);

            // Task 5: Massivdə cüt və tək ədədlərin sayını tap

            int[] numbers = { 1, 2, 3, 4, 5 };
            int cut = 0;
            int tek = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    cut = cut + 1;
                }
                else
                {
                    tek = tek + 1;
                }

            }
            Console.WriteLine(cut);
            Console.WriteLine(tek);

            // Task 6:  Massivi tərsinə çap et
            int[] numbers = { 1, 2, 3, 4, 5 };
            int[] reversed = new int[numbers.Length];
            for (int i = numbers.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversed[j] = numbers[i];
            }
            Console.WriteLine(string.Join(", ", reversed));

            // Task 7: Massivdə konkret ədədin olub-olmadığını yoxla (Linear Search)

            int[] numbers = { 1, 2, 3, 4, 5 };
            int Axtarilan_eded = 6;
            bool varmi = false;
            foreach (int i in numbers)
            {
                if (i == Axtarilan_eded)
                {
                    varmi = true;
                    break;
                }
            }
            Console.WriteLine(varmi);

            // Task 8: Massivdəki elementlərin orta qiymətini tap

            int[] numbers = { 1, 2, 3, 4, 5 };
            int sum = 0;
            int count = 0;
            foreach (int i in numbers)
            {
                sum = sum + i;
                count++;
            }
            Console.WriteLine(sum / count);

            // Task 9: İki massiv arasında ümumi elementləri tap

            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };
            List<int> commonElements = new List<int>();
            foreach (int i in array1)
            {
                foreach (int j in array2)
                {
                    if (i == j && !commonElements.Contains(i))
                    {
                        commonElements.Add(i);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", commonElements));
        }
    }
}
