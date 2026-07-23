namespace ECommerceProductManagement
{
    internal class OutOfStockException : ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Insufficient stock available.";
            }
        }
    }
}