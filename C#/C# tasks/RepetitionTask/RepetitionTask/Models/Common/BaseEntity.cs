using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionTask.Models.Common
{
    abstract class BaseEntity
    {
        public int Id { get; }
        public static int counter {  get; set; }

        static BaseEntity()
        {
            counter = 0;
        }

        public BaseEntity()
        {
            counter++;
            Id = counter;

        }

        public override string ToString()
        {
            return $"Id: {Id}";
        }
    }
}
