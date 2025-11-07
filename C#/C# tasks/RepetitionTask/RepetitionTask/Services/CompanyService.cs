using RepetitionTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionTask.Services
{
    class CompanyService
    {
        List<Worker> workers = new List<Worker>();
        public void AddWorker(Worker worker)
        {
            workers.Add(worker);
        }
        
        public void RemoveWorker(int id)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Id == id)
                {
                    workers.Remove(workers[i]);
                }
            }
        }
        
        public void ShowAll()
        {
            Console.WriteLine("All the workers in the company: ");
            foreach(Worker worker in workers)
            {
                Console.WriteLine($"Id: {worker.Id}  Worker Name: {worker.Name}");
            }
        }
        
        public decimal ShowAverageSalary()
        {
            decimal total = 0;
            int count = 0;
            foreach(Worker worker in workers)
            {
                total = total + worker.Salary;
                count++;
            }
            decimal result = total / count;
            return result;
        }

        public override string ToString()
        {
            return $"Performing different operations on {workers} list";
        }
    }
}
