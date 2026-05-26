namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount
            {
                AccountHolderName = "Rahul Marathe",
                Balance = 1500
            };
            Console.WriteLine(account.AccountNumber);
            account.Deposit(500);
            account.Withdraw(2000);
            account.ShowBalance();
            
            



        }
    }
}
