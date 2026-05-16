
namespace PracticePrograms
{
    internal class Bank
    {
        double balance = 200;

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
            Console.WriteLine("Balance: " + balance); 


        }
        public void Withdraw(int amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdraw: " + amount);
                Console.WriteLine("Balance: " + balance);

            }
            else
            {
                Console.WriteLine("Insufficient Balance");

            }
        }
    }
}
