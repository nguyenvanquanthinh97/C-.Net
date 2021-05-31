using System;

namespace Amazons
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rateCalculate = new RateCalculating();
            rateCalculate.Calculate();

            Console.WriteLine("Promote has changed logic");
        }
    }
}