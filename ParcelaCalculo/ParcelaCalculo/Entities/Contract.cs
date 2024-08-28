using System;

namespace ParcelaCalculo.Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public Installment Installments { get; set; } 

        public Contract(int number, DateTime date, double totalValue, Installment installment)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = installment;
        }
    }
}
