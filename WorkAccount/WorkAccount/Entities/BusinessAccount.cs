using System.Security.Cryptography.X509Certificates;

namespace WorkAccount.Entities
{
    internal class BusinessAccount : Account
    {
        public double LocalLimit { get; set; }


        public BusinessAccount(int number, string holder, double balance, double localLimit) : base (number, holder, balance)
        {
            LocalLimit = localLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LocalLimit)
            {
                Balance += amount;
            }
        }
    }
}
