namespace BankingSystem
{
    internal class BankAccount
    {
        string _accountHolderName;
        double _balance;
        int _accountNumber;

        public string AccountHolderName
        {
            get
            {
                return _accountHolderName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _accountHolderName = value;
                }
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if(value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance Cannot Be Negative");
                }
            }
        }

        public int AccountNumber
        {
            get;                        //Auto Property Initializer
        } = 1001;

        public void Deposit(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }
            else
            {
                Balance += amount;
                Console.WriteLine($"Deposited {amount} . New Balance = {Balance} ");
            }
        }
        public void Withdraw(int amount)
        {
            if(amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw {amount} SuccessFully. Balance is {Balance}");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("Account Balance is " + Balance);
        }

    }
}
