namespace StringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Ali";
            //Length method
            Console.WriteLine(str.Length); //Output: 3;  prints length of string

            // Trim, TrimStart, TrimEnd;  tip string
            string str1 = "     Ali    ";
            Console.WriteLine(str1.Length);
            str1 = str1.Trim(); // her terefden bosluq silir
            //str1 = str1.TrimStart(); // stringin basindaki bosluqlari silir
            //str1 = str1.TrimEnd(); //stringin sonundaki bosluqlari silir
            Console.WriteLine(str1.Length);


            // ToUpper, ToLower methodlari; tip string

            Console.WriteLine(str1.ToUpper()); // butun herfler boyuk
            Console.WriteLine(str1.ToLower()); //butun herfler kicik

            //Contains --> stringin icinde char ve ya basqa string axtarir; tipi bool

            string country = "Azerbaycan";
            Console.WriteLine(country.Contains('A')); //char qebul edir
            Console.WriteLine(country.Contains('a')); // char qebul edir
            Console.WriteLine(country.Contains("A")); // string kimi herfi qebul edir
            Console.WriteLine(country.Contains("can")); //string axtara bilir
            Console.WriteLine(country.Contains("Can", StringComparison.OrdinalIgnoreCase)); // ignore case

            //IndexOf --> stringin ve ya charin hansi indeksde yerlesdiyini gosterir, soldan sayir
            //birinci tapdigini goturur; tipi int

            Console.WriteLine(country.IndexOf('a')); //5
            Console.WriteLine(country.IndexOf('A')); //0
            Console.WriteLine(country.IndexOf("caN",StringComparison.OrdinalIgnoreCase)); //7
            Console.WriteLine(country.IndexOf("a",StringComparison.OrdinalIgnoreCase)); //0

            //LastIndexOf --> stringin ve ya charin hansi indeksde yerlesdiyini gosterir, sagdan sayir
            //birinci tapdigini goturur;  tipi int

            Console.WriteLine(country.LastIndexOf('a')); // 8
            Console.WriteLine(country.LastIndexOf('A')); // 0
            Console.WriteLine(country.LastIndexOf("A",StringComparison.OrdinalIgnoreCase)); // 8

            // Substring - stringden bir hisse kesib goturur, capa verir; tip string; iki overloadu var

            Console.WriteLine(country.Substring(4)); // bir index verirsen, o indexden sona kimi print edir
            // Output: baycan  country[4] = b
            Console.WriteLine(country.Substring(4,3)); // bu indexden baslayib, uzunlugu ne qederdirse o qeder kesir
            // Output: bay   country[4] = b, 3 dene goturur 


            // StartsWith, EndWith; tip bool; stringin bir stringle ve ya charla basladigini ya da bitdiyini yoxlayir

            Console.WriteLine(country.StartsWith('A')); // True
            Console.WriteLine(country.StartsWith('a')); // False
            Console.WriteLine(country.StartsWith("a",StringComparison.OrdinalIgnoreCase)); // True

            Console.WriteLine(country.EndsWith("cAn", StringComparison.OrdinalIgnoreCase)); //True

            // Split (String => Arraye)   Join(Array => Stringe)
            // Split birbasa original uzerinde deyisiklik edir, kopyasinda, ona gore menimsetmeye ehtiyac yoxdur

            string country1 = "A z e r b a y c a n";

            country1.Split(" ");
            Console.WriteLine(country1);

            // JOIN; tipi string
            char[] letters = { 'a', 'b', 'c' };
            Console.WriteLine(String.Join("", letters)); // birinci parametr aralarina ne qoysun onu teyin edir
            Console.WriteLine(String.Join("-", letters));

            // Replace => bir stringi/chari digeri ile evez edir; kopyada isleyir; string tipi

            string country2 = "A z e r b a y c a n";
            country2 = country2.Replace(" ", "");
            Console.WriteLine(country2); // Azerbaycan

            string phone = "055 555 55 55";
            phone = phone.Replace(" ", "-");
            Console.WriteLine(phone); // 055-555-55-55



            // Equals; charlarda yoxdur; tipi bool; iki dene stringi ve ya obyekti muqayise edir

            string str_1 = "Salam";
            string str_2 = "salam";
            Console.WriteLine(String.Equals(str_1,str_2,StringComparison.OrdinalIgnoreCase)); //True

            // Compare;  tipi int;  
            // -1(eger ikinci parametr geride olarsa); 0(eyni olarsa); 1(2-ci parametr onde olarsa)

            string str_3 = "Salam";
            string str_4 = "Salam";
            Console.WriteLine(String.Compare(str_3, str_4)); // 0

            string str_5 = "Salam";
            string str_6 = "Aalam";
            Console.WriteLine(String.Compare(str_5, str_6)); // 1

            string str_7 = "Aalam";
            string str_8 = "Salam";
            Console.WriteLine(String.Compare(str_7, str_8)); // -1

            string str_9 = "Salam";
            string str_0 = "salam";
            Console.WriteLine(String.Compare(str_9, str_0)); // 1

            string str_s = "Salam";
            string str_t = "salam";
            Console.WriteLine(String.Compare(str_s, str_t, StringComparison.OrdinalIgnoreCase)); // 0


            // IsNullOrEmpty()
            string test_str = "";
            Console.WriteLine(String.IsNullOrEmpty(test_str));
            // Output: True;  because it is empty

            //IsNullOrWhiteSpace()
            Console.WriteLine(String.IsNullOrWhiteSpace(test_str));
            // Output: False;  because it is neither null nor white space


            // PadLeft PadRight; mueyyen bir simvol sayina cattirmaq ucunu soldan ve ya sagdan doldurur simvollarla

            string test = "h";
            // Default olaraq bir parametr verende(8) bosluqlarla doldurur, amma biz meselen indi * vermisik, ona gore
            // 7 * qoyur, sayi 8-e catdirir sol terefden doldurur
            test = test.PadLeft(8, '*');
            test = test.PadRight(16, '*');

            Console.WriteLine(test);






        }
    }
}
