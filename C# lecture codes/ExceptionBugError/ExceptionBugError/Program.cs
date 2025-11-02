using System.Text;

namespace ExceptionBugError
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //error => sintaksis sehvi olanda goruruk
            // int a = 'hello'; // stringi int kimi vermisik ve single quotesda yazmisiq
            // int b = 30 // ; qoymamisiq

            //bug => kodunda proble yoxdur, amma mentiqi xeta var

            int Sum(int a,int b)
            {
                return a - b; // cem tapmaq isteyirsen amma "+" evezine "-" yazmisan
            }
            Console.WriteLine(Sum(10, 20));


            //exception => ne errordur ne de bug; bir mesaj verir ve harada sehv etdiyini line by line gosterir
            //int a = 5;
            //int b = a / 0;
            //Console.WriteLine(b);
            // Output: 
            //Unhandled exception. System.DivideByZeroException: Attempted to divide by zero.
            //at ExceptionBugError.Program.Main(String[] args) in
            //[file path]:line 22

            //biz ede bilerik ki sadece mesaj cixsin
            //bunun ucun try catch istifade ede bilerik

            int a1 = 5;
            try
            {
                int b1 = a1 / 0;
                Console.WriteLine(b1);
            }
            catch(System.Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }


            //string uzerinde coxlu deyisiklik edeceyikse string builderden istifade etmek lazimdir
            //daha cox yer tutmasin deye
            //string original uzerinde deyisiklik etmek evezine kopyalayir uzerine elave edir deyisikliyi bu da 
            //elave yer tutur
            //amma string builder originalin uzerinde isleyir, elave yer tutmur
            StringBuilder str_2 = new StringBuilder(); 
            for (int i=0;i<=100;i++)
            {
                str_2.Append("a");
            }
            Console.WriteLine(str_2);
        }
    }
}
