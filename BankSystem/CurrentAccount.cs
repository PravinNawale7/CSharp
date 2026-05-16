namespace BankSystem
{
    internal class CurrentAccount : Account
    {
        public override void Withdraw()
        {
            Console.Write("Enter Withdraw Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            if(amt <= balance)
            {
                balance -= amt;
                Console.WriteLine("Withdraw Successful");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }
    }
}
