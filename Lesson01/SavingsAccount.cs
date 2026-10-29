using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class SavingsAccount : BankAccount 
    {
        public int Rate { get; set; }
        public SavingsAccount(string owner, string accountNumber, decimal balance, int rate)
            : base(owner, accountNumber, balance)
        {
            Rate = rate;
        }
        public void AddInterest()
        {
            Balance += Balance * Rate / 100;
        }
    }
}
