using System;
using System.Globalization;

namespace InterfaceTest.Entities
{
    internal class Invoice
    {
        public double BasicPayemnt { get; set; }
        public double Tax { get; set; }


        public Invoice(double basicPayment, double tax)
        {
            BasicPayemnt = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayemnt + Tax; }
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayemnt.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
