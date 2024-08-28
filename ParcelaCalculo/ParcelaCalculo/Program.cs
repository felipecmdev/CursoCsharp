using System;
using System.Globalization;
using ParcelaCalculo.Entities;
using ParcelaCalculo.Services.Entities;

namespace ParcelaCalculo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            string instal = Console.ReadLine();

            Installment installment;

            

    

            Contract contract = new Contract(number, date, contractValue);
        }
    }
}