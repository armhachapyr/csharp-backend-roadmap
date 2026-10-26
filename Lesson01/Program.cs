namespace Lesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAcc = new BankAccount("Alex", "123456789", 1000);
            BankAccount secondAcc = new BankAccount("John", "987654321");
            firstAcc.Deposit(500);
            secondAcc.Deposit(1000);
            firstAcc.Withdraw(200);
            Console.WriteLine(firstAcc.GetInfo());
            Console.WriteLine(secondAcc.GetInfo());
            try
            {
                firstAcc.Deposit(-50);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            try
            {
                secondAcc.Withdraw(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
