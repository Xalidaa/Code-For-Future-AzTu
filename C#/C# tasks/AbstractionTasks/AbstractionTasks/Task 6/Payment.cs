using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionTasks.Task_6
{
    abstract class Payment
    {
        public abstract void Pay(double amount);

        public virtual void Confirm()
        {
            Console.WriteLine("Payment confirmed.");
        }

        public void Pay(double amount, string currency)
        {
            Console.WriteLine($"Paid {amount} {currency}.");
        }
    }
}
