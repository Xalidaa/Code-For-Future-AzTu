// enum da array kimi bir nece deyer saxlayir, sadece bu deyerlerin ne oldugunu bilirsiniz deqiqdir. Meselen 
//Gender adli bir field enumda saxlansa daha yaxsidir neyinki string cunki bu fielde ya male yazacaqsan ya da female
// amma string olanda ora istenilen bir soz yazila biler hansi ki duzgun deyil
using StudentEnum;
using GenderEnum;
using WeekdayExample;
namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Student student = new Student
            //    {
            //        Name = "Hasan",
            //        Surname = "Hasanov",
            //        Age = 30,
            //        GenderInfo = Gender.Male

            //    };
            //    Console.WriteLine(student.GenderInfo);


            int day = 1;

            switch(day)
            {
                case (int)WeekDay.Monday:
                    Console.WriteLine(WeekDay.Monday);
                    break;
                case (int)WeekDay.Tuesday:
                    Console.WriteLine(WeekDay.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(WeekDay.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(WeekDay.Thursday);
                    break;
                case 5:
                    Console.WriteLine(WeekDay.Friday);
                    break;
                case 6:
                    Console.WriteLine(WeekDay.Saturday);
                    break;
                case 7:
                    Console.WriteLine(WeekDay.Sunday);
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;

            }

        // index gormek ucun: Console.WriteLine((int)WeekDay.Monday);
        // elementin ozunu gormek ucun Console.WriteLine(WeekDay.Monday);

        }
    }
}
