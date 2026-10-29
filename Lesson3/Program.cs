using Lesson3;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            SavingsAccount savingsAccount = new SavingsAccount("John Doe", "123456789", 0, 5);
            CreditAccount creditAccount = new CreditAccount("Jane Smith", "987654321", 500, 1000);
            accounts.Add(savingsAccount);
            accounts.Add(creditAccount);
            foreach (var account in accounts)
            {
                Console.WriteLine(account.GetInfo());

                try
                {
                    account.Withdraw(500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine(account);
            }
            creditAccount.Withdraw(800);
            Console.WriteLine(creditAccount);   

            creditAccount.Withdraw(300);        
        }
        
    }
}
