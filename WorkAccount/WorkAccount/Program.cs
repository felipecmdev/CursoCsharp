using WorkAccount.Entities;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING EXEMPLOS

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING *OPERAÇÃO INSEGURA*

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0); *NÃO FUNCIONA*

            //BusinessAccount acc5 = (BusinessAccount)acc3; *CAUSA ERRO POR IMPEDIR QUE BusinessAccount SEJA CONVERTIDO PARA SavingsAccount*

            if (acc3 is BusinessAccount) //O IF NÃO PASSARÁ POIS acc3 NÃO É UMA INSTÂNCIA DE BusinessAccount PORÉM O CÓDIGO FUNCIONARÁ 
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }


        }
    }
}