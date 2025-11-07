using RepetitionTask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionTask.Models
{
    class Manager:Worker
    {
        public int TeamSize { get; set; }

        public override string ToString()
        {
            return $"Manager's team size: {TeamSize} ";
        }

    }
}
