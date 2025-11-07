using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(String[] args)
        {
            // Task 1: Iki ededin cemini ve hasilini qaytaran method yaz
            int a = 4;
            int b = 12;
            int result1 = Sum(a, b);
            int result2 = Product(a, b);
            Console.WriteLine(result1);
            Console.WriteLine(result2);

            // Task 2: Setirde nece herf, reqem, ve bosluq oldugunu tap

            string message = " Hello World 123";
            int result1 = Letter_count(message);
            Console.WriteLine(result1);
            int result2 = num_count(message);
            Console.WriteLine(result2);

            int space_count = 0;

            foreach (char c in message)
            {
                if (c == ' ')
                {
                    space_count++;
                }
            }
            Console.WriteLine(space_count);


            // Task 3: Verilmis ededin musbet, menfi ve ya sifir oldugunu mueyyen et

            int eded = 54;
            if (eded > 0)
            {
                Console.WriteLine("Musbet");
            }
            else if (eded < 0)
            {
                Console.WriteLine("Menfi");
            }
            else
            {
                Console.WriteLine("Sifir");
            }

            //Task 4: Cumlede nece soz oldugunu tap

            string sentence = "My name is Kate";
            char delimiter = ' ';
            string[] words = sentence.Split(delimiter);
            int count = 0;
            foreach (string c in words)
            {
                count++;
            }
            Console.WriteLine(count);

            // Task 5: Cumlede en uzun sozu tap

            string sentence = "My name is Katherine";
            char delimiter = ' ';
            string[] words = sentence.Split(delimiter);
            int max = words[0].Length;
            int index = 0;
            foreach (string word in words)
            {
                if (word.Length > max)
                {
                    max = word.Length;
                    Console.WriteLine(word);
                    index++;
                }
                else if (word.Length == max && word != words[0])
                {
                    Console.WriteLine(word);
                    Console.WriteLine(words[index]);
                }
            }

            // Task 6: Setirdeki butun a herflerini "@" ile evez et

            string text = "I am a Sales Accountant";
            string result = text.Replace("a", "@", StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(result);

            // Task 7: Setirde 'C#' sozunun olub olmadigini yoxla

            string message = " I like coding in C#";
            bool string_exists = message.Contains("C#");
            Console.WriteLine(string_exists);

            // Task 8: Verilmis setirden bir hisse cixart

            string message = "Azerbaycan";
            string substring = message.Substring(4);
            Console.WriteLine(substring);

            // Task 9: Cumledeki butun sozleri yeni setre yazdir

            string sentence = "Hello World, How are you?";
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // Task 10: Arraydeki sozleri tek bir setre birlesdir

            string[] words = ["Say", "Hi", "to", "the", "world"];
            Console.WriteLine(string.Join(" ", words));

            //Task 11: Setirdeki bosluqlari sil
            string country = "U z b e k i s t a n";
            string result = country.Replace(" ", "");
            Console.WriteLine(result);

            // Task 12: Setirde nece boyuk ve kicik herf oldugunu tap
            string sentence = "Hello World, How are you?";
            int upperCount = 0;
            int lowerCount = 0;
            foreach (char c in sentence)
            {
                if (Char.IsUpper(c))
                {
                    upperCount++;
                }
                else if (Char.IsLower(c))
                {
                    lowerCount++;
                }
            }
            Console.WriteLine(upperCount + " " + lowerCount);

            // Task 13: Setirdeki sait ve samit herflerin sayini tap
            string sentence = "Merhaba Dünya, Nasılsınız?";
            int vowelCount = 0;
            int consonantCount = 0;
            string vowels = "aeıioöuüAEIIOÖUÜ";
            foreach (char c in sentence)
            {
                if (Char.IsLetter(c))
                {
                    if (vowels.Contains(c))
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }

            }
            Console.WriteLine(vowelCount + " " + consonantCount);

            // Task 14: Verilmis setrin tersini tap
            string sentence = "Hello World!";
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            string reversedSentence = new string(charArray);
            Console.WriteLine(reversedSentence);

            // Task 15: TryParse ile istifadeci daxil etdiyi string-i edede cevir
            string input = "123";
            int number;
            bool success = int.TryParse(input, out number);

            if (success)
            {
                Console.WriteLine("Converted number: " + number);
            }
            else
            {
                Console.WriteLine("Convertion unsuccessful");
            }
        }

        // Task 1: Iki ededin cemini ve hasilini qaytaran method yaz(method hissesi)
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Product(int a, int b)
        {
            return a * b;
        }

        // Task 2: Setirde nece herf, reqem, ve bosluq oldugunu tap

        static int Letter_count(string message)
        {
            int letter_count = 0;
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char c in message.ToUpper())
            {
                foreach (char x in letters)
                {
                    if (c == x)
                    {
                        letter_count++;
                    }
                }
            }
            return letter_count;
        }

        static int num_count(string message)
        {
            int num_count = 0;
            string numbers = "1234567890";
            foreach (char c in message)
            {
                foreach (char n in numbers)
                {
                    if (c == n)
                    {
                        num_count++;
                    }
                }
            }
            return num_count;
        }


    }
}

