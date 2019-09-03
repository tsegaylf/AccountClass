using System;

namespace AccountClass {
    class Program {

        static void Main(string[] args) {
            var cust1 = new Customer();
            cust1.Name = "New Customer";

            var sav1 = new Savings(0.02m, "My Primary Savings", cust1);
            sav1.Deposit(100);
            sav1.Withdraw(20);
            Console.WriteLine($"Savv1 Balance is {sav1.GetBalance()}");

            var acct1 = new Account("Primary Checking", cust1); // creating an account looks like this 
            acct1.Deposit(2);
            //Console.WriteLine($"{acct1.AccountNumber} {acct1.Description} "
            //    + $" {acct1.GetBalance()} {acct1.CustomerInstance.Name}");


            var acct2 = new Account("Secondary Checking", cust1);
            acct2.Deposit(1000);
            //Console.WriteLine($"{acct2.AccountNumber} {acct2.Description} "
            //    + $" {acct2.GetBalance()} {acct2.CustomerInstance.Name}");

            cust1.Name = "1st Customer";

            var acct3 = new Account("Primary Savings", cust1);
            acct3.Deposit(50000);
            //Console.WriteLine($"{acct3.AccountNumber} {acct3.Description} "
            //    + $" {acct3.GetBalance()} {acct3.CustomerInstance.Name}");

            var accounts = new Account[] { acct1, acct2, acct3 };
            var accountTotal = 0M;
            foreach(var account in accounts) {
                accountTotal += account.GetBalance();
            Console.WriteLine($"{account.AccountNumber} {account.Description} "
                + $" {account.GetBalance()} {account.CustomerInstance.Name}");
            }
            Console.WriteLine($"Total of all account is {accountTotal}");
        }

    }
}
