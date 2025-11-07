namespace Ref_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;

            //int GiveNumber(int b)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber(a)); //50
            //Console.WriteLine(a); //10

            //// ref value tiplerin adreslerini parametr kimi gondermek ucun istifade olunur
            ////ref b-ye a-nin adresini gonderir
            //int GiveNumber2(ref int b)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber2(ref a)); //50
            //Console.WriteLine(a); //50

            //// Out
            ////ref ve out eyni isi gorur, amma
            ////ref onceden deyer varsa isleyir, out deyer olmayanda istifade olunur
            //// int a = 10; --> ref/out
            //// int a1; --> out

            //int a1;
            //int GiveNumber3(out int b)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber3(out a1)); //50
            //Console.WriteLine(a1); //50

            //example 1

            //int a = 50;
            //int c = 70;
            //int GiveNumber4(int b, int x)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber4(a, c)); //50
            //Console.WriteLine(a); //50
            //Console.WriteLine(c); //70

            //example 2
            //int a = 100;
            //int c = 70;
            //int GiveNumber5(int b, ref int x)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber5(a, ref c)); //50
            //Console.WriteLine(a); //100
            //Console.WriteLine(c); //70

            //example 3
            //int a = 100;
            //int c = 70;
            //int GiveNumber6(ref int b, int x)
            //{
            //    b = 50;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber6(ref a, c)); //50
            //Console.WriteLine(a); //50
            //Console.WriteLine(c); //70

            //example 4
            //int a = 100;
            //int d = 20;
            //a++;
            //int c = a;
            //int GiveNumber7(ref int b, ref int x,int z)
            //{
            //    b = 50;
            //    x = b + z;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber7(ref a, ref c,d)); //50
            //Console.WriteLine(a); //50
            //Console.WriteLine(c); //70

            //example 5
            //int a = 100;
            //int d = 20;
            //a++;
            //int c = a;
            //--a;
            //int GiveNumber8(ref int b, int x, ref int z)
            //{
            //    b = z;
            //    x = b + z;
            //    z = 20;
            //    return b;
            //}

            //Console.WriteLine(GiveNumber8(ref a, c, ref d)); //20
            //Console.WriteLine(a); //20
            //Console.WriteLine(c); //101

            //example 6
            //int a = 100;
            //int d = 50;
            //int c;
            //a++;
            //--a;
            //int GiveNumber9(int b, int x, out int z)
            //{
            //    z = 2;
            //    b = z;
            //    x = b + z;
            //    z = 20;
            //    return z;
            //}

            //Console.WriteLine(GiveNumber9(a, d, out c)); //20
            //Console.WriteLine(a); //100
            //Console.WriteLine(d); //50
            //c = a;
            //Console.WriteLine(c);//100

            //example 7
            int a = 100;
            int c;
            a++;
            int d = a;
            --a;
            int GiveNumber10(ref int b, ref int x, out int z)
            {
                z = x;
                b = z;
                x = b + z;
                z = 20;
                return x+z;
            }

            Console.WriteLine(GiveNumber10(ref a, ref d, out c)); //222
            Console.WriteLine(a); //101
            Console.WriteLine(d); //202
            Console.WriteLine(c);//20


        }
    }
}
