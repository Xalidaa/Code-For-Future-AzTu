using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Bicycle : Vehicle
    {
        private int _wheelNum { get; set; }

        public int WheelNum
        {
            get
            {
                return _wheelNum;
            }
            set
            {
                if (value <= 0 || value >= 5)
                {
                    Console.WriteLine("Number of doors must be between 0 and 5(both are not included)");
                }
                _wheelNum = value;
            }
        }

        public Bicycle(string brand, string model, double mile, int wheelNum) : base(brand, model,mile)
        {
            WheelNum = wheelNum;
        }


        public override void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand} Model: {Model} Mile: {Mile} Number of Wheels: {WheelNum}");
        }
    }
}
