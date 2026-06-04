namespace BANK_MANAGEMENT_SYSTEM
{
    internal class BankAccount
    {
        public int AccountNumber { get; }
        public string AccountHolderName { get; }

        private double _balance;

        public BankAccount(int accountNumber, string accountHolderName, double initialDeposit)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            
            if(initialDeposit < 0)
                throw new InvalidAmountException();

            _balance = initialDeposit;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException();

            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException();

            if (amount > _balance)
                throw new InsufficientBalanceException();

            _balance -= amount;
        }
    }

}

