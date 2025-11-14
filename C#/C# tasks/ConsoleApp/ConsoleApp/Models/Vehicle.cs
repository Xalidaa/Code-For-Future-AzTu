using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    abstract class Vehicle
    {
        private string _brand { get; set; }
        private string _model { get; set; }
        private double _mile { get; set; }

        public string Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if(value.Length <3 || value.Length >=30)
                {
                    Console.WriteLine($"Brand's length must be between 3 and 30.");
                }
                _brand = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Length < 3 || value.Length >= 30)
                {
                    Console.WriteLine($"Brand's length must be between 3 and 30.");
                }
                _model = value;
            }
        }

        public double Mile
        {
            get
            {
                return _mile;
            }
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Mile must be positive.");
                }
                _mile = value;
            }
        }

        public Vehicle (string brand, string model,double mile)
        {
            Brand = brand;
            Model = model;
            Mile = mile;
        }

        public abstract void ShowFullInfo();
    }
}
