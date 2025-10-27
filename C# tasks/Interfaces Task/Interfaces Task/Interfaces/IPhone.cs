using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Task.Interfaces
{
    interface IPhone
    {
        public abstract void Call(int number);

        public abstract void AddAccount(string name);
        public abstract void PrintAllAccounts();
        public abstract void PrintInfo();


    }
}
