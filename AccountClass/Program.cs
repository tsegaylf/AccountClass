using System;

namespace AccountClass {
    class Program {
        static void Main(string[] args) {

            //Build systrem for Bank with multiple types of accounts

            var acct1 = new Account(); // acct1 is the variable name
            acct1.AccountNumber = "12345";

            acct1.Description = "Primary Checking";
            acct1.Deposit(50000);
            Console.WriteLine($"{acct1.AccountNumber} {acct1.Description} {acct1.GetBalance()}");
            acct1.Withdraw(52000);
            Console.WriteLine($"{acct1.AccountNumber} {acct1.Description} {acct1.GetBalance()}");
            acct1.Deposit(5);
            Console.WriteLine($"{acct1.AccountNumber} {acct1.Description} {acct1.GetBalance()}");
            var balance = acct1.GetBalance();
            Console.WriteLine($"{balance}");
            acct1.Withdraw(-1000000);
            Console.WriteLine($"{acct1.AccountNumber} {acct1.Description} {acct1.GetBalance()}");
        }

    }
}
