namespace C__Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Example of value type: 
             * changing 'a' doesn't affect 'b' 
             * because each has its own copy*/
            int a = 10;
            int b = a;
            a = 20;
            Console.WriteLine(b);


            // Strings in C# are reference types, but they are immutable (cannot be changed once created).
            // When s2 = s1, both refer to the same "hello" string.
            // Reassigning s1 = "world" makes s1 point to a new string object, while s2 still points to "hello".

            string s1 = "hello";
            string s2 = s1;
            s1 = "world";
            Console.WriteLine(s2);


            // Arrays are reference types,
            // so '==' compares their memory addresses, not their contents.
            // Even if two arrays have the same elements,
            // 'arr1 == arr2' will be false because they are different objects.

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };
            Console.WriteLine(arr1 == arr2);


            // Arrays are reference types,
            // so ar1 and ar2 point to the same array.
            // Changing an element through ar1 also affects ar2
            // because they reference the same object.

            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = ar1;
            ar1[0] = 10;
            Console.WriteLine(ar2[0]);


            // If Else Cases

            if (arr1 == arr2)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }

            // Switch Case

            switch (a)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 20:
                    Console.WriteLine("Twenty");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            // loops
            // for

            int[] arr3 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
            }

            // while
            while (a > 0)
            {
                Console.WriteLine(a);
                a--;
            }

            // do while
            do
            {
                Console.WriteLine(a);
                a--;
            }
            while (a > 0);

            // foreach
            // 'foreach' is a loop that iterates over each element in a collection (like an array, list, or string).
            // For each iteration, the current element is stored in a variable (like 'item' or 'c').
            // It’s useful for reading or processing elements without using an index.
            // Note: The loop variable is read-only; changing it doesn’t modify the original collection.

            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }


        }
    }
}
