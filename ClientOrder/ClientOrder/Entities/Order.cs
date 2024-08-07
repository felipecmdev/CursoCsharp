using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace ClientOrder.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(OrderStatus os, Client client)
        {
            Status = os;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total(double Price)
        {
            double total = 0.0;

            foreach (OrderItem item in Items)
            {
                total = item.SubTotal();
            }

            return total;
        }
    }
}
