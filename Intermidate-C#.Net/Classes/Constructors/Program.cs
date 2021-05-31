using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);
        }
    }
}
