using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    //the Compasition Method: we don't inherite anything 

    public class Checking {

        private Account _account = null; //instant variable of a class... normal practice to initializ it to null

        public bool Deposit(decimal amount) {
            return _account.Deposit(amount);
        }

        public bool Withdraw(decimal amount) {
            return _account.Withdraw(amount);
        }

        public bool WriteCheck(int checkNbr, decimal amount) {
            return false;
        }

        public string Print() {
            return _account.Print();
        }

        public decimal GetBalance() {
            return _account.GetBalance();
        }

        //public Checking(string description, Customer customer) {
        //    _account = new Account(description, customer); //instead of using base, we have to call the acount constructor with the parameter
        //}

    }
}
