using System;

namespace BankingLibrary {
    public class Account {

        public decimal Balance { get; set; } //cannot deposit or withdraw anything < 1 or withdraw any more than what is in the balance
        public int AcctNbr { get; set; } //acctnbr needs a unique value
        public string Description { get; set; }
        private int NextNbr = 0;

        public void Deposit(decimal amount) {
            if (amount > 0) {
                Balance += amount;
            } else{
                Console.WriteLine("Cannot Deposit");
            }
        }

        public void Withdraw(decimal amount) {
            if (amount > 0 && amount <= Balance) {
                Balance -= amount;
            } else {
                Console.WriteLine("Cannot Withdraw");
            }
        }

        public void Transfer(decimal amount, Account toAccount, Account fromAccount){
            fromAccount.Withdraw(amount);
            toAccount.Deposit(amount);
         }

        public Account() {
            AcctNbr = NextNbr += 1;
            }   

    }
}
