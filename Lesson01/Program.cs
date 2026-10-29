namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            CreditAccount account1 = new CreditAccount("Иванов", "1234567890", 1000, 500);
            SavingsAccount account2 = new SavingsAccount("Петров", "0987654321", 2000, 5);
            accounts.Add(account1);
            accounts.Add(account2);
        }
    }
}
