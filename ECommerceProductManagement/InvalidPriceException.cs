namespace ECommerceProductManagement
{
    internal class InvalidPriceException :ApplicationException
    {
        public override string Message
        {
            get
            {
                return "Price must be greater than 0";
            }
        }
    }
}
