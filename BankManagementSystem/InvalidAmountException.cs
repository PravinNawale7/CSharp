namespace BankManagementSystem
{
    internal class InvalidAmountException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Amount must be greater than zero.";
            }
        }
    }
}
