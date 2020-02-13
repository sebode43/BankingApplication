using BankingLibrary;
using System;
using System.Collections.Generic;

namespace BankingApplication {
    class Program {
        static void Main(string[] args) {

            var sav1 = new Savings(0.01m);

            var int1 = new Savings(0.12m);
            int1.Deposit(100);
            int1.CalculateInterest(3);


            var chk1 = new Checking();
            chk1.Deposit(100);
            chk1.Withdraw(75);

            var chk2 = new Checking();
            chk2.Deposit(500);

            //chk1.Debug();
            //chk2.Debug();
            chk2.Transfer(100, chk1);
            //chk1.Debug();
            //chk2.Debug();

            var accounts = new List<Account>();
            accounts.Add(sav1);
            accounts.Add(int1);
            //accounts.Add(chk1);
            //accounts.Add(chk2);
            Console.WriteLine();
            foreach (var account in accounts) {
                Console.WriteLine(account);
            }
        }
    }
}
