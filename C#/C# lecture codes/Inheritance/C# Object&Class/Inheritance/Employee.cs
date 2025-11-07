using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// iki ferqli class arasinda ctorlarin melumat alisverisini teyin etmek ucun base istifade edirik
namespace C__Object_Class.Inheritance
{
    class Employee: Person
    {

        public int salary;

        public string jobName;

        public Employee(string name, string surname, int birthYear, bool isMarried,int salary,string jobName):base(name,surname,birthYear,isMarried)
        {
            //this.name = name;
            //this.surname = surname;
            //this.birthYear = birthYear;
            //this.isMarried = isMarried;
            this.salary = salary;
            this.jobName = jobName;
        }
    }
}
