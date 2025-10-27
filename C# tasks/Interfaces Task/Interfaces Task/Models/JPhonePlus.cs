using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Interfaces_Task.Interfaces;

namespace Interfaces_Task.Models
{
    public abstract class JPhonePlus: JPhone, IPhone
    {
        public new int Memory { get; set; } = 64;

        public string ServiceTag { get; set; }

        public int accountCountPlus = 0;
        public new string[] Accounts { get; private set; }


        public JPhonePlus(string name, string serviceTag) : base(name)
        {
            if (serviceTag.Length < 5)
            {
                throw new ArgumentException("Service tag must be at least 5 characters long.");
            }

            ServiceTag = serviceTag;
            Accounts = new string[5];
        }


        public void Call(int number)
        {
            string numStr = number.ToString();
            if ((numStr.Length >= 6 && numStr.Length <= 9) && (numStr[0] == 4 || numStr[0] == 6))
            {
                Console.WriteLine("Calling ...");
            }
            else
            {
                Console.WriteLine("Invalid phone number, please check the number!");
            }
        }

        public void AddAccount(string name)
        {
            if (acc_count < 5)
            {
                Accounts[acc_count++] = name;
                Console.WriteLine($"Account '{name}' added.");
            }

            else
            {
                Console.WriteLine("You cannot add more accounts, limit is reached");
            }


        }


        public void PrintServiceTag()
        {
            Console.WriteLine("Service tag is 12345");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"JPhonePlus is called '{Name}', it has {Memory}GB of memory, {accountCountPlus} user accounts, and {SuccessfulCalls} successful calls.");
        }

    }
}