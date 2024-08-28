using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelaCalculo.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }

        public double Interest(double amount, int months)
        {
            double result = 0.0;

            for (double i = 0.0; i < months; i += 0.1)
            {
                result += amount * i; 
            }

            return result;
        }

    }
}
