
namespace Bank.Entities
{
    internal class Account
    {


        public int Number { get; private set; }
        public string Holder { get; private set; }

        public double Balance { get; protected set; }



        public Account() { }


        public Account(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }



        public Account(int number, string holder, double balance) : this(number, holder)
        {

            Balance = balance;

        }


        public virtual void WithDraw(double amount)
        {


            Balance -= amount+5.0;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


        public override string ToString()
        {
            return "Conta: "
                + Number
                + ", Holder: "
                + Holder
                + " - Saldo em Conta: $ "
                + Balance;
        }







    }
}
