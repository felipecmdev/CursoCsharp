namespace WorkAccount.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; } 

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            interestRate = interestRate;
        }
 
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            //CASO QUEIRA UTILIZAR A FUNÇÃO DA SUPERCLASSE E ADICIONAR ALGO APENAS USE base
            //base.Withdraw(amount)
            //Balance -= 2.0
            Balance -= amount;
        }
    }
}
