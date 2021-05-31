
using System;

namespace InterfaceTestability
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order {DatePlace = DateTime.Now, TotalPrice = 100f};

            orderProcessor.Process(order);
        }
    }
}
