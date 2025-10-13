namespace Code_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///* Task 1*/
            //int number = 37;
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            ///* Task 2*/

            //for (int i = 1; i <= 100; i++)
            //{

            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            /* Task 3*/
            int count = 0;

            for (int i = 80; i>=0;i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);

            /* Task 4*/

            int sum = 0;
            for (int i = 0; i <= 50; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
                else if (i % 5 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);

            /* Task 5*/

            int eded = 2859;
            say = 0
            while (eded > 0)
            {
                int b = eded % 10;
                eded = eded / 10;
                say++;
            }
            Console.WriteLine(say);


            /* Task 6*/


        }
    }
}
