using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    public class Account {
        private static int nextAccountNbr = 0; //we want this instance only once for the class so we added static infront of int
        public int AccountNumber { get; private set; }
        private decimal Balance { get; set; } = 0.0M; //the capital M at the end tells it to use it as a decimal not a double 
        public string Description { get; set; }
        public Customer CustomerInstance { get; set; } = null;//setting this to connect customer with the right account number, without a value its null 

        public void Transfer(Account acct, decimal amount) {
           var withdrawSuccessful = this.Withdraw(amount); // this refers to  whatever account we use to call transfer [acct1.transfer(acct2, 1000)]
            if(withdrawSuccessful) {
                acct.Deposit(amount);
            }
        }
        public Account(Customer customer) : this() { // by using this constructor customers will be assigned as soon as account is created 
            this.CustomerInstance = customer;
        }

        private Account() { // by making this private this will still exist and we will not have to create default account 
            AccountNumber = ++nextAccountNbr;
        }
        public Account(String Description, Customer customer) : this(){ // : this() is refereing back to the other constructor
            this.Description = Description;
            this.CustomerInstance = customer;
        }

        public decimal GetBalance() {
            return Balance;
        }

        private bool CheckAmountIsPositive(decimal amount) { //got rid off the duplicate code (from Deposit & Withdrawal) by creating a new method 
            if (amount < 0) {
                Console.WriteLine("Amount cannot be negative.");
                return false;
            }
            return true;
        }

        public bool Deposit(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true) {
                Balance += Amount; //if the statement is true we are retriving and setting the value of Balance
                return true;
            } return false;
            }

        public bool Withdraw(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true) {
                if (Amount > Balance) {
                    Console.WriteLine("Insufficient funds.");
                } else {
                    Balance -= Amount;
                    return true;
                }
            }
            return false;
        
        }
    }
}
