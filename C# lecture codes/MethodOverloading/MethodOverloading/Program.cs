namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.SayHello();
        }
    }
}


//method signature: method name, parameter type, number of parameters
//method signature does not include method type
// method overloading is related to method signature; the method names must be the same but
//parameter types and number of parameters must differ 
