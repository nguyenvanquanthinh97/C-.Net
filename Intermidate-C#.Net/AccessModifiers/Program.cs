using Amazons;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer {Id = 1, Name = "Thinh"};
            customer.Promote();
        }
    }
}
