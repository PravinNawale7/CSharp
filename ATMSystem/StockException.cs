namespace EcommerceOrderSystem;

internal class StockException : ApplicationException
{
    public override string Message
    {
        get
        {
            return "Stock Not Available";
        }
    }
}
