using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Thinh";
            cookie["Header"] = "Get";
            cookie.AddOrder(new Order(1));
            cookie.AddOrder(new Order(2));
            
            cookie.Expire = DateTime.Now.AddDays(30);

            Console.WriteLine(cookie["name"]);
            Console.WriteLine(cookie["Header"]);
            Console.WriteLine(cookie.GetTotalOrders());
            Console.WriteLine(cookie[0].Id);
            Console.WriteLine(cookie[1].Id);
            Console.WriteLine(cookie.Expire);
        }
    }
}
