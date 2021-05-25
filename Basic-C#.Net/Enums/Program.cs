using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            // By default, Console.WriteLine will call the method .toString()
            // Console.WriteLine(method);
            Console.WriteLine(method.ToString());

            // Convert enum ShippingMethod to int
            Console.WriteLine((int)method);

            // Parsing string to enum ShippingMethod
            // convert string to object type ShippingMethod
            // Then we convert object type ShippingMethod to enum ShippingMethod
            var strMethod = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), strMethod);
            Console.WriteLine(shippingMethod);
        }
    }

    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3,
    }
}
