using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    class Customer {
        
        private static int nextIdNbr = 0; // generate companyID
        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; private set; } = 0.0M;
        public bool Active { get; set; } = true; //set active to true

        private void Initialize() { 
            this.Id = ++nextIdNbr;
        }

        public Customer(string name, string city, string state) : this() { // create default constructor
            this.Name = name;
            this.State = state;
            this.City = city;
        }
        public Customer() { //calls on the initializer, which generates the Id number
            Initialize();
        }
        
        //method to add sales
        private bool CheckAmountPositive(decimal amount) {
            if(amount < 0) {
                Console.WriteLine("Amount cannot be Negative");
                return false;
            }
            return true;

        }
        public decimal AddSales(decimal salesAmount) {
            var valid = CheckAmountPositive(salesAmount);
            if (valid == true) {
                Sales += salesAmount;
            }
            return Sales;
        }

        //test methods in program class

    }
}
