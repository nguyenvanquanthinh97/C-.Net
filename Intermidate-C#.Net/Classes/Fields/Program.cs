using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.AddOrder(new Order());
            customer.AddOrder(new Order());

            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
