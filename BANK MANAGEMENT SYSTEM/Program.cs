namespace BANK_MANAGEMENT_SYSTEM
{
    internal class Program
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        public void CreateAccount()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter account holder name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter initial deposit amount: ");
            double initialDeposit = Convert.ToDouble(Console.ReadLine());



            if (accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account already exists!");
                return;
            }

            BankAccount bankAccount = new BankAccount(accountNumber, name, initialDeposit);

            accounts.Add(accountNumber, bankAccount);

            Console.WriteLine("Account Created Successfully!");




        }
        public void DepositMoney()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            if (!accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.WriteLine("Enter deposit amount: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());

            accounts[accountNumber].Deposit(depositAmount);

            Console.WriteLine("Deposit Successful.");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            if (!accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.WriteLine("Enter withdrawal amount: ");
            double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

            accounts[accountNumber].Withdraw(withdrawalAmount);

            Console.WriteLine("Withdrawal Successful.");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            if (!accounts.ContainsKey(accountNumber))
            {
                Console.WriteLine("Account not found!");
                return;
            }

            Console.WriteLine($"Balance: {accounts[accountNumber].GetBalance()}");
        }


        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome to the Bank Management System!");

            while (true)
            {
                try
                {

                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Create a new account");
                    Console.WriteLine("2. Deposit money");
                    Console.WriteLine("3. Withdraw money");
                    Console.WriteLine("4. Check balance");
                    Console.WriteLine("5. Exit");

                    Console.WriteLine("Enter your choice (1-5): ");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            p.CreateAccount();
                            break;
                        case 2:
                            p.DepositMoney();
                            break;
                        case 3:
                            p.WithdrawMoney();
                            break;
                        case 4:
                            p.CheckBalance();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter valid numeric input!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }



            }
        }

    }
}

