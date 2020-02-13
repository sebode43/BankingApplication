using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Savings : InterestAccount {

        private void setDescription(string description) {
            Description = description;
        }
        public Savings() : base() {
            setDescription("Savings");
        }

        public Savings(decimal interestRate) : base(interestRate) {
            setDescription("Savings");

        }
    }
}
