using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_6
{
    sealed class CryptoPayment: Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Cryptocurrency.");
        }
        public override void Confirm()
        {
            Console.WriteLine("Cryptocurrency payment confirmed on the blockchain.");
        }
    }
}
