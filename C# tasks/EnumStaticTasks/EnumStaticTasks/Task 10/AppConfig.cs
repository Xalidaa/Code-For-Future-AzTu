using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStaticTasks.Task_10
{
    class AppConfig
    {
        public static Theme DefaultTheme {  get; set; }
        public static string DefaultLanguage { get; set; }

        static AppConfig()
        {
            DefaultTheme = Theme.Dark;
            DefaultLanguage = "en";
            Console.WriteLine("Static constructor işlədildi və ilkin dəyərlər təyin olundu.");
        }

        public static void ShowSettings()
        {
            Console.WriteLine($"Cari mövzu: {DefaultTheme}");
            Console.WriteLine($"Cari dil: {DefaultLanguage}");
        }

    }
}
