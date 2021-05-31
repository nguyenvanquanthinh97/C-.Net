using System;

namespace ConstructorInheritances
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        //public Vehicle()
        //{
        //    Console.WriteLine("Constructor of Vehicle class initiated");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Constructor of Vehicle class with params registrationNumber initiated: {0}", registrationNumber);
        }
    }

    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Constructor of Car class initiated: {0}", registrationNumber);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Subaru");
        }
    }
}
