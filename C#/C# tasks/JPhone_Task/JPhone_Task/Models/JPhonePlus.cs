using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JPhone_Task.Interfaces;

namespace JPhone_Task.Models
{
    class JPhonePlus: JPhone, IPhone
    {
        public string ServiceTag
        {
            get
            {
                return ServiceTag;
            }

            set
            {
                if (value.Length >= 5)
                {
                    ServiceTag = value;
                }
            }
        }

        public int SuccessfulCalls { get; set; }

        public JPhonePlus(string name, string serviceTag)
        {
            ServiceTag = serviceTag;
            Name = name;
            Memory = 64;
        }

        public void Call(int number)
        {
            string numStr = number.ToString();
            if ((numStr.Length >= 6 && numStr.Length <= 9) && (numStr[0] == 4 || numStr[0] == 6))
            {
                Console.WriteLine($"Calling {number} ...");
                SuccessfulCalls++;
            }

            else
            {
                Console.WriteLine("Invalid phone number, please check the number!");
            }
        }

        public void PrintServiceTag()
        {
                       Console.WriteLine($"Service Tag: {ServiceTag}");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Phone Name: {Name}");
            Console.WriteLine($"Memory: {Memory} GB");
            Console.WriteLine($"Service Tag: {ServiceTag}");
            Console.WriteLine($"Number of Successful Calls: {SuccessfulCalls}");
            PrintAllAccounts();
        }

        public void DeleteAccount(string name)
        {
            if (accountsCount == 0)
            {
                Console.WriteLine("No accounts to delete");
                return;
            }
            int index = Array.IndexOf(accounts, name);
            if (index >= 0)
            {
                for (int i = index; i < accountsCount - 1; i++)
                {
                    accounts[i] = accounts[i + 1];
                }
                Array.Resize(ref accounts, accountsCount - 1);
                accountsCount--;
                Console.WriteLine($"Account {name} deleted successfully");
            }
            else
            {
                Console.WriteLine($"Account {name} not found");
            }
        }

        public void SetCurrentUser(string name)
        {
            int index = Array.IndexOf(accounts, name);
            if (index >= 0)
            {
                Console.WriteLine($"Current user set to {name}");
            }
            else
            {
                Console.WriteLine($"Account {name} not found");
            }
        }


    }
}
