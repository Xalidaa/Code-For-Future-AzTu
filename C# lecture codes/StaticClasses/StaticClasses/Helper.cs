namespace StaticClassExample
{
    static class Helper
    {
        public static string Capitalize(this string word)
        {
            return word[0].ToString().ToUpper() + word.Substring(1).ToLower();
        }

        public static int Square(this int num)
        {
            return num * num;
        }

        public static int Pow(this int num, int time)
        {
            int pow = 1;
            for (int i = 0; i<time; i++)
            {
                 pow = num * pow;
            }
            return pow;
        }
    }
}

// static classlar sadece komekci methodlari saxladigimiz classlardir
// static classlar object yarada bilmir(instance yoxdur)
//miras verme ve alma yoxdur
//static class memberleri static olmalidir(static classlarda)

//Capitalize methodunun parametrinin qarsisina "this" keywordu qoyanda
//eger adi halda bir obyekt yaradib, obyekt uzerinden cagirirdiqsa
//indi her hansi bir deyisen yaradib hemin deyisenin adi uzerinden cagira bilerik
//adi string methodlari kimi
//str.Capitalize() => str.ToUpper()

// this olan bele methodlara extension methodlar deyilir ve static classda olur yalniz
// direct olaraq deyisen uzerinden istifade edirik methodu; yazmasa idik static classin uzerinden methodu
//cagirib birde deyeri verecekdik: Helper.Square(a) -    a.Square() +

// method extension olanda => Helper.Square(a) ve a.Square() her ikisi isleyir
// adi method olanda => yalniz Helper.Square(a) isleyir