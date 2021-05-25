using System;
using Classes.Math;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person thinh = new Person() { name = "Thinh" };
            thinh.Introduce();

            Console.WriteLine(Calc.Add(3,5));
        }
    }
}
