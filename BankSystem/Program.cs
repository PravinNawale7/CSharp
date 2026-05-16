namespace BankSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("1. Saving Account");
            Console.WriteLine("2. Current Account");

            Console.Write("Select Account Type: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Account a;

            if(choice == 1)
            {
                a = new SavingAccount();
            }
            else
            {
                a = new CurrentAccount();
            }

            a.CreateAccount();

            while (true)
            {
                Console.WriteLine("\n===== BANK MENU =====");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Details");
                Console.WriteLine("4. Exit");

                Console.Write("Enter Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        a.Deposit();
                        break;
                    case 2:
                        a.Withdraw();
                        break;
                    case 3: 
                        a.ShowDetails();
                        break;

                    case 4:
                        //Environment.Exit(0);
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }

            }

        }
    }
}
