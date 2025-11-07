using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepetitionTask.Models.Common;

namespace RepetitionTask.Models
{
    class Worker: BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }

        public override string ToString()
        {
            return $"Worker name: {Name}  Age: {Age}  Salary: {Salary} Department: {Department}";
        }


    }
}
