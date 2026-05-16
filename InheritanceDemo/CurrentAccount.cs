namespace InheritanceDemo
{
    internal class CurrentAccount : Account
    {
        public void Withdraw(int amt)
        {
            balance -= amt;
            Console.WriteLine("Current Balance is : " + balance);
        }
    }
}
