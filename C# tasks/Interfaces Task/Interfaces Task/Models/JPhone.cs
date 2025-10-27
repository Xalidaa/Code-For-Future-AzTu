using Interfaces_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Task.Models
{
    public abstract class JPhone:IPhone
    {
        public string Name {  get; set; }
        public int memory { get; set; } = 32;

        public string[] Accounts { get; set; }

        public int acc_count { get; set; } = 0;


        public JPhone(string name)
        {
            Name = name;
        }

        public void Call(int number)
        {
            string numStr = number.ToString();
            if ((numStr.Length >= 6 && numStr.Length <= 8) && (numStr[0] == 4 || numStr[0] == 6))
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
            if (acc_count < 3)
            {
                Accounts[acc_count++] = name;
                Console.WriteLine($"Account '{name}' added.");
            }

            else
            {
                Console.WriteLine("You cannot add more accounts, limit is reached");
            }


        }

        public void PrintAllAccounts()
        {
            if (acc_count == 0)
            {
                Console.WriteLine("No user accounts to display.");
                return;
            }

            Console.WriteLine("User accounts:");

            foreach (string item in Accounts)
            {
                Console.WriteLine(item);
            }
           
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Phone name: {Name}  Memory: {memory} User account count: {acc_count}");
        }


    }
    
}
