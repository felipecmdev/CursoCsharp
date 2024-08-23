using AccountTryCatch.Entities.Exceptions;
using AccountTryCatch.Entities.Exceptions;
using System;
using System.Globalization;

namespace AccountTryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Holder: ");
            string holder = Console.ReadLine();

            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Withdraw limit: ");
            double wdLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, wdLimit);

            Console.WriteLine();

            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.WithDraw(amount);
                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }


            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
