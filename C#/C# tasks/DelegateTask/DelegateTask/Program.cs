namespace DelegateTask
{
    class Tasks
    {
        static void Main(string[] args)
        {
            CustomList<int> list = new CustomList<int>( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
            Predicate<int> isEven = x => x % 2 == 0;
            //int result = list.Find(isEven);
            //Console.WriteLine( result );

            CustomList<int> result1 = list.FindAll(isEven);//2 4 6 8 10
            for(int i=0; i<result1.Count; i++)
            {
                Console.WriteLine( result1[i] );
            }
            Console.WriteLine(result1.Count);

            Console.WriteLine(list.FindIndex(x => x==5));
        }
    }
}
