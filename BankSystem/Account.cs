namespace BankSystem
{
    internal class Account
    {
        public int accountNumber;
        public String name = "";
        public double balance;

        public void CreateAccount()
        {
            Console.WriteLine("Enter Account Number: ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Initial Balance: ");
            balance = Convert.ToDouble(Console.ReadLine());
        }

        public void Deposit()
        {
            Console.Write("Enter the Deposit Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            balance += amt;

            Console.WriteLine("Amount Deposited Successfully");

        }

        public void ShowDetails()
        {
            Console.WriteLine("\n----- ACCOUNT DETAILS -----");
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Balance: " + balance);
        }

        public virtual void Withdraw()
        {
            Console.WriteLine("Withdraw Method");
        }
    }

}
