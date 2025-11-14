using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    internal class Car:Vehicle
    {
        private int _doorsNum { get; set; }
        public int DoorsNum
        {
            get
            {
                return _doorsNum;
            }
            set
            {
                if(value <= 0 || value >= 5)
                {
                    Console.WriteLine("Number of doors must be between 0 and 5(both are not included)");
                }
                _doorsNum = value;
            }
        }
        public Car(string brand, string model, double mile, int doorsNum) : base(brand, model, mile)
        {
            DoorsNum = doorsNum;
        }


        public override void ShowFullInfo()
        {
            Console.WriteLine($"Brand: {Brand} --- Model: {Model}  --- Mile: {Mile}  --- Number of doors: {DoorsNum}");
        }
    }
}
