using ClientOrder.Entities;
using System;
using System.ComponentModel;
using System.Globalization;

namespace ClientOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());
            
            Client client = new Client(name, email, birth);

            Console.WriteLine("Enter order data:");
            string status = Console.ReadLine();
            OrderStatus os;
            Enum.TryParse(status, out os);

            Order order = new Order(os, client);

            Console.Write("How many items to this order? ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");

                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product (prodName, price);

                OrderItem oi = new OrderItem(quantity, price, product);

                order.AddItem(oi);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine("Order moment: " + order.Moment.ToShortTimeString());

            Console.WriteLine("Order Status: " + os);

            Console.WriteLine(client.Name + "(" + client.Date + ") - " + client.Email);

            Console.WriteLine("Order items:");

            Console.WriteLine(order.Items);
        }
    }
}
