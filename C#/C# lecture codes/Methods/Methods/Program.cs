namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //methods
            // void method that does not need any return
            //void SayHello()
            //{
            //    Console.WriteLine("Hello World!");
            //}
            //SayHello();

            // return method; it returns a string value

            string SayHello()
            {
                return "Hello World!";
            }
            Console.WriteLine(SayHello());

            //parameters

            //int Sum(int a, int b)
            //{
            //    return a + b;
            //}
            //int result = Sum(20, 30);

            //Console.WriteLine(result);

            // default parameters; when you don't get parameters you assign it beforehand

            int Sum(int a = 10, int b = 20)
            {
                return a + b;
            }
            int result = Sum();

            Console.WriteLine(result);

            //if there are given parameters then you use them and do not touch default ones

            int Sum2(int a = 10, int b = 20)
            {
                return a + b;
            }
            int result2 = Sum2(20, 30);

            Console.WriteLine(result);

            //if the first doesn't have default parametr and the second has, and in method you give one parameter
            //it is assigned to first parameter: b = 20(by default) a = 60(Sum3(60))

            int Sum3(int a, int b = 20)
            {
                return a + b;
            }
            int result3 = Sum3(60);

            Console.WriteLine(result);

            //but if the second one doesn't have default parameter it will be an error

            //int Sum4(int a = 10, int b)
            //{
            //    return a + b;
            //}
            //int result4 = Sum4(60);

            //Console.WriteLine(result);

            //that's why you have to change parameters' places if you need to

            int Sum5(int b, int a = 10)
            {
                return a + b;
            }
            int result5 = Sum5(60);

            Console.WriteLine(result);


            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            void ShowNumbers(int[] nums)
            {
                foreach (int item in nums)
                {
                    Console.WriteLine(item);
                }
            }

            ShowNumbers(nums);


            string name = "John";
            void SpellName(string name)
            {
                foreach (char item in name)
                {
                    Console.WriteLine(item);
                }
            }

            SpellName(name);


            //params keyword - verguller qoyaraq gonderdiyimiz arqumentleri
            //array-e cevirmek ucun istifade olunan keyworddur

            void ShowNums(params int[] nums)
            {
                foreach (int item in nums)
                {
                    Console.WriteLine(item);
                }
            }

            ShowNums(1, 2, 3, 4);



            void ShowLetters(char elem, params char[] letters)
            {
                foreach (char item in letters)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("********");
                Console.WriteLine(elem);
            }
           

            ShowLetters('e', 'a', 'b', 'c', 'd');
            /*Output:
             * a
             * b
             * c
             * d
             * ********
             * e
             */

            //SIRA: (NORMAL PARAMETR, DEFAULT PARAMETR, PARAMS)

            void ShowLetters2(char elem = 'x', params char[] letters)
            {
                foreach (char item in letters)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("********");
                Console.WriteLine(elem);
            }

            ShowLetters2('e', 'a', 'b', 'c', 'd');
            /*Output:
             * a
             * b
             * c
             * d
             * ********
             * e cunki default x olsa da e deyeri verilib ona gore x istifade olunmur
             */

            void ShowLetters3(string y, char elem='x', params char[] letters)
            {
                foreach (char item in letters)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("********");
                Console.WriteLine(elem);
                Console.WriteLine("********");
                Console.WriteLine(y);
            }
            


            ShowLetters3("hello",'e', 'a', 'b', 'c', 'd');

            /*Output:
             * a
             * b
             * c
             * d
             * ********
             * e
             * ********
             * hello
             */



            //bir metod yaz soz ve herf qebul etsin o sozun icinde o herf nece denedirse bize sayini ver

            int LetterCount(string word, char letter)
            {
                int count = 0;
                foreach(char l in word)
                {
                    if(letter == l)
                    {
                        count++;
                    }
                }
                return count;
            }

            Console.WriteLine(LetterCount("hello", 'l'));
        }
    }
}
