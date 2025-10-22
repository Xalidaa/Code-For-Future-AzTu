using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_hometask
{
    class Device
    {
        public string brand;
        public string model;
        public int screen_size;
        public int battery_level;
        public int price;
        public int sale_price;
        public int sale_count;

        public Device (string brand, string model, int screen_size, int battery_level, int price, int sale_price, int sale_count)
        {
            this.brand = brand;
            this.model = model;
            this.screen_size = screen_size;
            this.battery_level = battery_level;
            this.price = price;
            this.sale_price = sale_price;
            this.sale_count = sale_count;
        }

        public void Calculate_profit()
        {
            double totalCost = price * sale_count;
            double totalIncome = sale_price * sale_count;
            double profit = totalIncome - totalCost;

            if (profit > 0)
            {
                Console.WriteLine($"income: {profit} AZN");
            }
            else if (profit < 0)
            {
                Console.WriteLine($"loss: {Math.Abs(profit)} AZN");
            }
            else
            {
                Console.WriteLine($"no income or loss");
            }
        }

        public void DisplayBatteryLevel()
        {
            Console.WriteLine($"{battery_level}%");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Screen Size: {screen_size}  Model: {model}  Brand: {brand}");
        }
    }
}
