namespace C__Methods_Tasks
{
    internal class Program
    {
        // Task 1: Iki ededin ferqini tapan method
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 5;
            int difference = CalculateDifference(num1, num2);
            Console.WriteLine($"Difference between {num1} and {num2} is: {difference}");
        }

        static int CalculateDifference(int a, int b)
        {
            return Math.Abs(a - b);
        }

        //// Task 2: Verilmis ededin kvadratini tapan method
        static void Main(string[] args)
        {
            int eded = 5;
            int result = Kvadrat(eded);
            Console.WriteLine($"{eded} ededinin kvadrati: {result}");
        }

        static int Kvadrat(int eded)
        {
            return eded * eded;
        }


        //// Task 3: Istifadeciden ad alib ekrana "Salam, [ad]" yazan method

        static void Main(string[] args)
        {
            string name = "Xalida";
            string result = SayHello(name);
            Console.WriteLine(result);
        }

        static string SayHello(string message)
        {
            return $"Salam, {message}";
        }

        //// Task 4: Verilmis ededi tek ve ya cutdur kimi yoxlayan method

        static void Main(string[] args)
        {
            int eded = 45;
            String result = Tek_Cut(eded);
            Console.WriteLine(result);
        }

        static String Tek_Cut(int x)
        {
            if (x % 2 == 0)
            {
                return "Cut";
            }
            else
            {
                return "Tek";
            }
        }

        //// Task 5: 1-den n-e qeder ededlerin cemini qaytaran method

        static void Main(string[] args)
        {
            int n = 10;
            int result = Sum(n);
            Console.WriteLine(result);
        }

        static int Sum(int n)
        {
            int sum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        // Task 6: Iki ededin en boyuyunu tapan method

        static void Main(string[] args)
        {
            int eded1 = 34;
            int eded2 = 45;
            int result = Maximum(eded1, eded2);
            Console.WriteLine(result);
        }

        static int Maximum(int eded1, int eded2)
        {
            if (eded1 < eded2)
            {
                return eded2;
            }
            else
            {
                return eded1;
            }
        }

        // Task 7: Verilmis ededin faktorialini hesablayan method

        static void Main(string[] args)
        {
            int eded = 5;
            int result = Faktorial(eded);
            Console.WriteLine(result);
        }

        static int Faktorial(int eded)
        {
            int p = 1;
            for (int i = 1; i < eded + 1; i++)
            {
                p = p * i;
            }
            return p;
        }

        // Task 8: Setirdeki saitlerin sayini tapan method

        static void main(string[] args)
        {
            string row = "hello";
            int result = sait_count(row);
            Console.Writeline(result);
        }

        static int sait_count(string row)
        {
            int count = 0;
            string vowels = "aeiouy";
            foreach (char c in row.tolower())
            {
                foreach (char v in vowels)
                {
                    if (c == v)
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        // Task 9: Ededler massivinde cut ededlerin cemini tapan method

        static void Main(string[] args)
        {
            int[] ededler = { 2, 5, 7, 8, 4 };
            int result = Cut_cem(ededler);
            Console.WriteLine(result);
        }

        static int Cut_cem(int[] ededler)
        {
            int sum = 0;
            foreach (int i in ededler)
            {
                if (i % 2 ==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }

        //Task 10: Her hansi bir sozu reverse etmek ucun method

        static void Main(string[] args) 
        {
            string message = "Hello";
            string result = Reverse(message);
            Console.WriteLine(result);
        }

        static string Reverse(string message)
        {
            string text = " ";
            foreach (char c in message)
            {
                text = c + text;
            }
            return text;
        }
    }
        
}
