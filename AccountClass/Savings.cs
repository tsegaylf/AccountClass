using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {

    public class Savings : Account {

        private decimal IntRate = 0.01M;

        public void SetInterestRate(decimal intRate) { //method to change intererst rate or you can add parameter into constructor
            this.IntRate = intRate;
        }

        public Savings(decimal intRate, string description, Customer customer)// you can add as many parameter as you like even when refering to a base constructor
            : base(description, customer) {
            this.IntRate = intRate; // put the parameter for intRate in this constructor so it is created when a savings is created 

        }

    }
}
