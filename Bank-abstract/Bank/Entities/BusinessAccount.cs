

namespace Bank.Entities
{
    internal class BusinessAccount : Account
    {

        public double LoanLimit {  get; private set; }





        public BusinessAccount() { }

   

        public BusinessAccount(int number, string holder, double balance, double loanLimit): base (number, holder, balance) {  
            
            LoanLimit = loanLimit; 

        }

        public void Loan(double amount)
        {
            if (LoanLimit > 0.0 && LoanLimit - amount >0 && amount <= LoanLimit)
            {
                LoanLimit -= amount;
                Balance += amount;
            }


        }




    }
}
