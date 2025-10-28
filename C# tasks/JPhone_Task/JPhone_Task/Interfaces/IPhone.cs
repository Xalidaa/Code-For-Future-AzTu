using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPhone_Task.Interfaces
{
    interface IPhone
    {
        void Call(int number);
        void AddAccount(string name);
        void PrintAllAccounts();
        void PrintInfo();
    }
}
