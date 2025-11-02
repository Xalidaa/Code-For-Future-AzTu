namespace ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Length, IndexOf, LastIndexOf, Contains
            int[] nums = { 78,10, 20,90, 30, 40,102, 50 };
            Console.WriteLine(nums.Length);

            Console.WriteLine(Array.IndexOf(nums, 40));
            Console.WriteLine(Array.LastIndexOf(nums, 50));
            Console.WriteLine(nums.Contains(20));


            // Sort => original arraye toxunur
            // NOTE: Array.Sort() uses culture-sensitive string comparison by default,
            // which means it is generally *case-insensitive*. Therefore, names like "Ali" and "ali"
            // are treated as equal when sorting. 
            // To make sorting case-sensitive (based on Unicode values), use:
            // Array.Sort(names, StringComparer.Ordinal);
            Array.Sort(nums);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Qedir", "Zehra", "Azer", "Riad", "ali" };
            Array.Sort(names);
            foreach(string item in names)
            {
                Console.WriteLine(item);
            }


            //Reverse => original arraye toxunur
            Array.Reverse(nums);
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }

            //Array.Resize() => arrayi genisledir; stringdirse bosluq atir, reqemdirse 0larla doldurur
            //sade arraylerde bir elementin qiymetini deyismek isteyende,adice deyisirsen
            //amma eger butun arrayi deyismek isteyirsense ref-den istifade etmelisen
            Array.Resize(ref nums, 10);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

            int[] myNums(ref int[] nums)
            {
                nums = new[] { 10, 20, 30, 40, 50 };
                return nums;
            }

            int[] nums_1 = { 1, 2, 3, 4, 5 ,6};
            Console.WriteLine(myNums( ref nums_1));
            Console.WriteLine(nums_1[0]);


            //Stringlerde ref
            // bu veziyyetde output salam hello olacaq. Cunki bilirik ki stringler reference type olsa da
            //ozlerini value type kimi aparir
            string ShowString(string word)
            {
                word = "salam";
                return word;
            }
            string str = "hello";
            Console.WriteLine(ShowString(str));
            Console.WriteLine(str);

            // amma ref artiq qoysaq output salam salam olacaq; artiq reference type kimi aparacaq ozunu string
            string ShowStrings(ref string word)
            {
                word = "salam";
                return word;
            }
            string strs = "hello";
            Console.WriteLine(ShowStrings(ref strs));
            Console.WriteLine(strs);


        }

    }
}
