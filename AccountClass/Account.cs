using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    class Account {
        public string AccountNumber { get; set; }
        private decimal Balance { get; set; } = 0.0M; //the capital M at the end tells it to use it as a decimal not a double 
        public string Description { get; set; }

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

        public void Deposit(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true) {
                Balance += Amount; //if the statement is true we are retriving and setting the value of Balance
            }
            }

        public void Withdraw(decimal Amount) {
            var valid = CheckAmountIsPositive(Amount);
            if (valid == true) {
                if (Amount > Balance) {
                    Console.WriteLine("Insufficient finds.");
                }
                else {
                    Balance -= Amount;
                }
            }

        
        }
    }
}
