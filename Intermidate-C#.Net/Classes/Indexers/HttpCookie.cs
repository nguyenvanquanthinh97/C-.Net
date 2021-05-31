using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        private List<Order> Orders { get; }
        public DateTime Expire { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
            Orders = new List<Order>();
        }

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        public Order this[int index]
        {
            get => Orders[index];
/*            set
            {
                if (index < Orders.Count - 1)
                {
                    Orders[index] = value;
                    return;
                }
                Orders.Add(value);
            }*/
            set => Orders[index] = value;
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public int GetTotalOrders()
        {
            return Orders.Count;
        }
    }
}