using JPhone_Task.Models;
namespace JPhone_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JPhone phone1 = new JPhone("Tina's overpriced phone");
            phone1.AddAccount("Tina");
            phone1.PrintInfo();

            JPhonePlus phone2 = new JPhonePlus("Bob's even more overpriced phone", "SERV12345");

            phone2.AddAccount("Bob");
            phone2.PrintServiceTag();
            phone2.Call(612345);
            phone2.PrintInfo();
            phone2.DeleteAccount("Bob");
        }
    }
}
