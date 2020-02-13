using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class InterestAccount : Account {

        public decimal InterestRate { get; private set; }

        public InterestAccount() : base() {
            this.Description = "Account with Interest";
        }

        public InterestAccount(decimal interestRate) : this() { //base = parent constructor and this = call current constructor
            InterestRate = (interestRate);
        }

        public override string ToString() {
            return $"{base.ToString()} Interest Rate is {InterestRate}.";
        }

        public void CalculateInterest(int months) {
          var Interest = this.Balance * (InterestRate / 12) * months;
            Deposit(Interest);
            Console.WriteLine($"Calculated interest is {Interest}.");
        }

    }
}
