using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasks
{
    class BankAccount
    {
        public string owner;
        public double balance;

        public void Deposit()
        {
            double amount = 200;
            Console.WriteLine($"Current balance: {balance + amount}") ;
        }

        public void Withdraw()
        {
            double amount = 200;
            Console.WriteLine($"Initial balance: {balance}");
            Console.WriteLine($"Balance left: {balance - amount}");
        }

    }
}
