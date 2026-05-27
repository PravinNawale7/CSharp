namespace BankManagementSystem
{
    internal class InsufficientBalanceException : ApplicationException
    {
        public override string Message
        {
            get
            {
                 return "Insufficient balance for the withdrawal.";
            }
        }
    }
}
