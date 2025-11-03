using System.Security.Cryptography;

namespace AlgorithmTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //string str = "hello";
            //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            //string st = "";
            //foreach (char c in str)
            //{
            //    foreach (char v in vowels)
            //    {
            //        bool isVowel = false;
            //        if (v == c)
            //        {
            //            isVowel == true;
            //            break;
            //        }
            //    }

            //}


            // Task 2

            int[] nums = [2, 5, 1, 9];
            int max = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (Math.Abs(nums[i] - nums[j]) > max)
                    {
                        max = Math.Abs(nums[i] - nums[j]);
                    }
                    break;
                }
            }
            Console.WriteLine(max);

            //Task 3
            string sentence = "level madam test";

            string[] words = sentence.Split(" ");

            string palindrome = "";
            foreach (string word in words)
            {
                string reverse = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reverse = reverse + word[i];
                }

                if (reverse == word)
                {
                    palindrome = palindrome + word + " ";
                }
            }
            Console.WriteLine(palindrome);

            //Task 4


            //Task 5
            string sen = "I love coding";
            string[] lis = sen.Split(" ");
            string rev = "";

            foreach (string word in lis)
            {
                rev = word + " " + rev;
            }

            Console.WriteLine(rev);


            // Task 6
            int[] arr = [2, 3, 4, 7, 8];
            int odd_count = 0;
            int even_count = 0;

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    odd_count++;
                }
                else
                {
                    even_count++;
                }
            }
            int result = Math.Abs(odd_count - even_count);
            Console.WriteLine(result);

            //Task 7

            string a = "programming";

            int max1 = 0;
            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int count = 1;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
                if (count >= max1)
                {
                    max1 = count;
                    index = i;

                }

            }
            Console.WriteLine($"{a[index]}: {max1}");

            // Task 8
            int num = 1234;
            int b = 0;
            while (num > 0)
            {
                b = b + num % 10;
                num = num / 10;
            }

            if (b == 10)
            {
                Console.WriteLine("Bingo");
            }
            else
            {
                Console.WriteLine(b);
            }


            // Task 9

            int n = 15;
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.Write("Fizz ");
                }
                else if (i % 3 != 0 && i % 5 == 0)
                {
                    Console.Write("Buzz ");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("FizzBuzz ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }

            //Task 10

            IsEvenOrOdd(7);

            

            //Task 11
            int a = 8;
            IsEvenOdd(a);

            //Task 12
            int result = Sum(1, 2, 3, 4);
            Console.WriteLine(result);

            //Task 14
            Console.WriteLine(Root(27,3));

            //Task 15
            string s1 = "listen";
            string s2 = "silent";
            int count = 0;
            if(s1.Length ==s2.Length)
            {
                foreach(char i in s1)
                {
                    foreach(char j in s2)
                    {
                        if(i==j)
                        {
                            count++;
                        }
                    }
                }
                if(count==s1.Length)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not anagram");
                }
            }





        }


        //Task 10
        static void IsEvenOrOdd(int a)
        {
            string[] string1 = { "Even", "Odd" };
            Console.WriteLine(string1[a % 2]);
        }

        //Task 11
        public static void IsEvenOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                {
                    Console.WriteLine("Odd");
                }
            }
        }

        //Task 12

        public static int Sum(params int[] ints)
        {
            int sum = 0;
            foreach(int i in ints)
            {
                sum = sum + i;
            }
            return sum;

        }

        // Task 13
        //public static int Sum2(params int[] ints)
        //{

        //    return

        //}



        //Task 14

        public static int Root(int n, int k)
        {
            int count = 0;
            while (n > 1)
            {
                n = n / k;
                count++;
            }
            return count;
        }

    }
}
