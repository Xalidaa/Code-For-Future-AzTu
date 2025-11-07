using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_6
{
    class PayPal: Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using PayPal.");
        }

        public override void Confirm()
        {
            Console.WriteLine("PayPal payment confirmed with email verification.");
        }
    }
}
