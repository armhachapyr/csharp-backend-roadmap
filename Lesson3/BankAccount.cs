using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Lesson3
{
    internal class BankAccount
    {
        public string Owner { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }


        public BankAccount(string owner, string accountNumber, decimal balance)
        {
            if (string.IsNullOrWhiteSpace(owner) || string.IsNullOrWhiteSpace(accountNumber))
            {
                throw new ArgumentException("Пустая строка");
            }
            this.Owner = owner;
            this.AccountNumber = accountNumber;
            if (balance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(balance), "Баланс должен быть положительным");
            }
            this.Balance = balance;
        }
        public BankAccount(string owner, string accountNumber)
          : this(owner, accountNumber, 0)
        {

        }



        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть неотрицательной");
            }
            Balance += amount;
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Сумма должна быть положительной");
            }
            else if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Недостаточно средств");

            }
            Balance -= amount;
        }
        public string GetInfo()
        {
            return $"Owner: {Owner} | Account Number: {AccountNumber} | Balance: {Balance}";
        }
        public override string ToString()
        {
            return $"{Owner}: {Balance}";
        }

    }
}