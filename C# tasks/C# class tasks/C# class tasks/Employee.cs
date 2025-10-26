using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__class_tasks
{
    class Employee
    {
        public string name;
        public int salaryPerHour;
        public int hoursWorked;

        public int CalculateSalary()
        {
            return salaryPerHour * hoursWorked;
        }
    }
}
