using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumStaticTasks
{
    class IdGenerator
    {
        private static int lastId { get; set; }

        static IdGenerator()
        {
            lastId = 12;
        }
        
        public static int GetNextId()
        {
            lastId++;
            return lastId;
        }
    }
}
