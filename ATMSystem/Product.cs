namespace EcommerceOrderSystem;

internal class Product
{
    string _productName;
    int _stock;

    public string ProductName
    {
        get { return _productName; }
        set { _productName = value; }
    }
    public int Stock
    {
        get { return _stock; }
        set { _stock = value; }
    }

    public void Buy(int quantity)
    {
        if (quantity > _stock)
        {
            throw new StockException();
        }

        _stock -= quantity;
        Console.WriteLine("Order placed successfully");
    }




}
