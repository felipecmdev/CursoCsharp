namespace EmployeeProfile.Entities
{
    internal class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsorcedEmployee()
        {
        }
        public OutsorcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = addtionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
         }
    }
}
