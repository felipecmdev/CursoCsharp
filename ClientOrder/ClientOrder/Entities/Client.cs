using System;

namespace ClientOrder.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }

        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;
        }
    }
}
