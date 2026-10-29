using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    internal class SavingsAccount : BankAccount
    {
        public decimal Rate{ get; }
        
        public SavingsAccount(string owner, string accountNumber, decimal balance, int rate)
            : base(owner, accountNumber, balance)
        {
            Rate = rate;
        }
        public void AddInterest()
        {
            decimal interest = Balance * Rate / 100;
            Deposit(interest);
        }


    }
}
