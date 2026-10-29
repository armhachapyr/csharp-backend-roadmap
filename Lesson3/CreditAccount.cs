using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    internal class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; }
        public CreditAccount(string owner, string accountNumber, decimal balance, decimal creditLimit)
            : base(owner, accountNumber, balance)
        {
            CreditLimit = creditLimit;
        }

        public override void Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("Сумма для снятия должна быть положительной");
            }
            if(Balance - amount < -CreditLimit)
            {
                throw new InvalidOperationException("Снятие средств превысит кредитный лимит");
            }
            Balance -= amount;
        }

    }
}
