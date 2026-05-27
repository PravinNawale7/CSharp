namespace BankManagementSystem
{
    internal class BankAccount
    {
        string _accountHolderName;
        int _accountNumber;
        double _balance;

        public string AccountHolderName
        {
            get { return _accountHolderName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _accountHolderName = value;
                }
                else
                {
                    Console.WriteLine("Account Holder Name Cannot be empty");
                }
            }
        }
        public int AccountNumber
        {
            get { return _accountNumber; }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    throw new InvalidAmountException();
                }
            }
        }

        public BankAccount(string accountHolderName, int accountNumber, double initialBalance)
        {
            AccountHolderName = accountHolderName;
            _accountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"Deposited {amount}. New Balance: {_balance}");
            }
            else
            {
                throw new InvalidAmountException();
            }
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidAmountException();
            }

            if (amount > Balance)
            {
                throw new InsufficientBalanceException();
            }

            Balance -= amount;

            Console.WriteLine(
                $"Withdrew {amount}. New Balance: {_balance}"
            );
        }
    }
    }
