namespace InheritanceDemo
{
    internal class SavingAccount : Account
    {
        public void Withdraw(int amt)
        {
            if(balance - amt > 0)
            {
                balance -= amt;
                Console.WriteLine("Saving Account Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Min Balance 1000 reqquired");
            }
        }
    }
}
