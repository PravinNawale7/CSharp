using System;

namespace First
{
    internal class BankAccount
    {
        private string accountNumber;
        private int balance;

        public BankAccount(string accountNumber, int balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }

        public void Withdraw(int amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}");
            }
        }

        public void ShowBalance()
        {
            Console.WriteLine($"Balance: {balance}");
        }
    }
}