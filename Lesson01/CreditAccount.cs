using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    internal class CreditAccount : BankAccount
    {
        public int CreditLimit { get; set; }
        public CreditAccount(string owner, string accountNumber, decimal balance, int creditLimit)
            : base(owner, accountNumber, balance)
        {
            CreditLimit = creditLimit;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной");
            }
            if (Balance - amount > -CreditLimit)
            {
                base.Withdraw(amount);
            } else
            {
                throw new InvalidOperationException("Превышен кредитный лимит");
            }
            
        }
    }
}
