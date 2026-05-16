class Account
{
    public string AccountNumber;
    public double Balance;

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}");

    }
    public void Withdraw(double amount)
    {
        if(amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn:{amount}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"Current Balance: {Balance}");
    }
}