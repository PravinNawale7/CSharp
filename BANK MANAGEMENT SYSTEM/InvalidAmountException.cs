namespace BANK_MANAGEMENT_SYSTEM
{
    internal class InvalidAmountException : ApplicationException
    {
        public override string Message =>
            "Amount must be greater than 0.";
    }
}
