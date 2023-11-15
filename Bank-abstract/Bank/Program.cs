using Bank.Entities;
using System;
using System.Globalization;





namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Account> accounts = new List <Account> ();
            accounts.Add (new  SavingsAccount(1001, "Alex", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1002,"Maria", 500.0, 400.0));
            accounts.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            accounts.Add(new BusinessAccount(1004, "Ana", 500.00, 500.00));

            double sumBalance = 0.0;

            foreach (Account account in accounts)
            {
                sumBalance += account.Balance;
            }

            Console.WriteLine("Total Balance = " + sumBalance.ToString("F2", CultureInfo.InvariantCulture));


            foreach (Account account in accounts)
            {
                account.WithDraw(10.0);
            }

            foreach (Account account in accounts)
            {
                Console.WriteLine("Updated balance for account "
                    + account.Number
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }


        }




    }



}