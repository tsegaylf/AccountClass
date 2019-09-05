using System;
using System.Collections.Generic;
using System.Text;

namespace AccountClass {
    class NegativeNumberException : Exception{

        public string AdditionalData { get; set; }

        public NegativeNumberException() : base() {
        }
        public NegativeNumberException(string message) : base(message) {
        }
        public NegativeNumberException(string message, Exception innerException)
            : base(message, innerException) {
        }
    }
}
