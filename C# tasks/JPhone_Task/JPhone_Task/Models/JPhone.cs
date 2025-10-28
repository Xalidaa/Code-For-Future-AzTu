using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPhone_Task.Interfaces;

namespace JPhone_Task.Models
{
    class JPhone: IPhone
    {
        public string Name { get; set; }
        public int Memory { get; set; }
        public int accountsCount { get; set; }
        public string[] accounts;

        public JPhone(string name)
        {
            Name = name;
            Memory = 32;
            accountsCount = 0;
        }

        public void Call(int number)
        {
            string numStr = number.ToString();
            if ((numStr.Length >= 6 && numStr.Length <= 8) && (numStr[0] == 4 || numStr[0] == 6))
            {
                Console.WriteLine($"Calling {number} ...");
            }

            else
            {
                Console.WriteLine("Invalid phone number, please check the number!");
            }
        }  

        public void AddAccount(string name)
        {
            if (accountsCount > 3)
            {
                Console.WriteLine("You cannot add more accounts, limit is reached");
            }
            else
            {
                
                Array.Resize(ref accounts, accountsCount+1);
                accounts[accountsCount] = name;
                Console.WriteLine($"Account {name} added successfully");
                accountsCount++;
            }
        }

        public void PrintAllAccounts()
        {
            if (accountsCount == 0)
            {
                Console.WriteLine("No user accounts to display");
            }
            else
            {
                foreach (string account in accounts)
                {
                    Console.WriteLine("User accounts: ");
                    Console.WriteLine(account);
                }
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Phone Name: {Name}  Memory: {Memory}GB The number of users: {accountsCount}");
        }
    }
}
