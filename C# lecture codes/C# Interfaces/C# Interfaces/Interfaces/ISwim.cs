using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Interfaces
{
    interface ISwim
    {
        public int SwimSpeed { get; set; }

        public abstract void Swim();
    }
}
