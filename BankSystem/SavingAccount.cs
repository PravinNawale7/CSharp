namespace BankSystem
{
    internal class SavingAccount : Account
    {
        public override void Withdraw()
        {
            Console.WriteLine("Enter Withdraw Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            if(balance - amt >= 1000)
            {
                balance =- amt;
                Console.WriteLine("Withdraw Successfull");

            }
            else
            {
                Console.WriteLine("Minimum balance 1000 required");
            }
        }
    }
}
