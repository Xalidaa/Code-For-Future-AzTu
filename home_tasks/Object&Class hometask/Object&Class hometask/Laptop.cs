using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Class_hometask
{
    class Laptop : Device
    {
        bool isRGBKeyboard = false;

        public Laptop(string brand, string model, int screen_size, int battery_level, int price, int sale_price, int sale_count) : base(brand, model, screen_size, battery_level, price, sale_price, sale_count)
        {
            this.brand = brand;
            this.model = model;
            this.screen_size = screen_size;
            this.battery_level = battery_level;
            this.price = price;
            this.sale_price = sale_price;
            this.sale_count = sale_count;
        }
    }

    

    
}
