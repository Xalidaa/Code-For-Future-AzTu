using RepetitionTask.Models;
using RepetitionTask.Services;
using RepetitionTask.Models.Common;

namespace Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyService companyService = new CompanyService();

            Worker w1 = new Worker { Name = "Narmin", Age = 20, Salary = 1500, Department = "Engineering" };
            Worker w2 = new Worker { Name = "Murad", Age = 24, Salary = 1250, Department = "Sales" };
            Manager m1 = new Manager { Name = "Akifa", Age = 28, Salary = 2000, Department = "IT", TeamSize = 10 };

            companyService.AddWorker(w1);
            companyService.AddWorker(w2);
            companyService.AddWorker(m1);

            companyService.RemoveWorker(2);
            
            companyService.ShowAll();
            

            



        }
    }
}