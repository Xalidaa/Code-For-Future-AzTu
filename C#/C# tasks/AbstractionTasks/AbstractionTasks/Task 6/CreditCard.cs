using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_6
{
    class CreditCard: Payment
    {
        public override void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Credit Card.");
        }
        public override void Confirm()
        {
            Console.WriteLine("Credit Card payment confirmed with OTP verification.");
        }
    }
}
