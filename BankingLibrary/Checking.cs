using System;
using System.Collections.Generic;
using System.Text;

namespace BankingLibrary {
    public class Checking {
        
        public InterestAccount iacct { get; private set; }
        public int CheckNbr { get; private set; }

        public void Deposit(decimal amount) {
            iacct.Deposit(amount);
        }

        public bool Withdraw(decimal amount) {
            CheckNbr++;
            return iacct.Withdraw(amount);
        }

        public void Transfer(decimal amount, Account toAccount) {
            iacct.Transfer(amount, toAccount);
        }

        public void Transfer(decimal amount, Checking toAccount) {
            iacct.Transfer(amount, toAccount.iacct);
        }

        public Checking(decimal IntRate) {
            iacct = new InterestAccount(IntRate);
            iacct.Description = "Checking";
        }

        public Checking() : this(0.02m){

        }

    }
}
