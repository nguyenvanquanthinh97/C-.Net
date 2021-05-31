using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }

        public void AddOrder(Order order)
        {
            if (order == null)
            {
                throw new NullReferenceException("order is null");
            }
            this.Orders.Add(order);
        }

        public void Promote()
        {
            // .....
        }
    }
}