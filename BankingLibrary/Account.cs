using System;

namespace BankingLibrary {
    public abstract class Account {

        public decimal Balance { get; set; } 
        public int AcctNbr { get; private set; }
        public string Description { get; set; } = "Account";
        
        private static int NextAcctNbr = 1;
        private const int AcctNbrInc = 9;
        private int AttemptsToOverdraw = 0;

        public void Deposit(decimal amount) {
            if (isAmountGTZero(amount)) {
                Balance += amount;
            }
        }

        public bool Withdraw(decimal amount) {
            if (isAmountGTZero(amount) && isSufficentFunds(amount)) {
                Balance -= amount;
                return true;
            }
            return false;
        }

        private bool isSufficentFunds (decimal amount) {
            if (Balance >= amount) {
                return true;
            }
            AttemptsToOverdraw++;
            return false;
        }

        private bool isAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;
        }

        public void Transfer(decimal amount, Account toAccount){
            if (this.Withdraw(amount)) {
                toAccount.Deposit(amount);
            }
         }

        public Account() {
            this.AcctNbr = NextAcctNbr;
            NextAcctNbr += AcctNbrInc;
        }

        public override string ToString() {
            return $"{AcctNbr}. {Description} with a balance of {Balance}.";
        }

        public void Debug() {
            Console.WriteLine(this);
        }

    }
}
