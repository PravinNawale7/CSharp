    namespace EcommerceOrderSystem;

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Product p = new Product()
            {
                ProductName = "Laptop",
                Stock = 3
            };
            p.Buy(5);
            Console.WriteLine("Stock after purchase: " + p.Stock);
        }
        catch (StockException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
