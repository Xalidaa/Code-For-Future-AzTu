using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Test
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayHello(int a)
        {
            Console.WriteLine("Hello " + a);
        }

        public void SayHello(int a, string b)
        {
            Console.WriteLine("Hello " + a);
        }

        public void SayHello(string b, int a)
        {
            Console.WriteLine("Hello " + a);
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}

//Method Overloading eyni adlarda olan methodlarda muxtelif variantlar cixartmaq
//(yeni parametr tipi ve sayi ferqli olmaq)
//methodlarinizin tipi ferqli olsa bele eger method adlari ve paramterler eynidirse method overloading ede bilmirisniz

//parametrlerin her ikisi eyni tipde olarsa ve iki methodda yerleri ferqli yerlesdirilerse, error verir
//lakin tipler ferqli olarsa error vermir
//(int a, int b) --> (int b, int a) error
//(int a, string b) --> (string b, int a) error vermir