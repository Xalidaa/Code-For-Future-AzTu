using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Interfaces.Interfaces
{
    interface IFly
    {
        public int FlySpeed { get; set; }

        public abstract void Fly();
    }
}



// interface hansisa data, ozellik, davranisi classlara tetbiq edir 


// class ve interface eynilikler
// 1. her ikisinin default accessi internal-dir
// 2. class classdan miras alir, interface interface-den implementasiya ede bilir



// class ve interface ferqlilikler
// 1. classlarda membersler default olaraq private-dir, interface-lerde defaul olaraq public-dir
// 2. interface-lerde membersler default olaraq public-dir
// 3. class inheritance edir, interface implementation edir(constructor yoxdur)
// 4. interface-de methodlar default olaraq abstract-dir
// 5. interface-de constructor yoxdur, fields yoxdur, destructor yoxdur
// 6. bir classa sadece bir class miras vere biler, amma birden cox interface implement ede biler
// 7. bir class sadece bir class-dan miras ala biler, amma interface istediyi qeder interface-den implementasiya ede biler




