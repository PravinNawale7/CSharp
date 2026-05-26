namespace E_CommerceOrderSystem
{
    internal class Product
    {
        string _productName;
        double _price;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _productName = value;
                }
                else
                {
                    Console.WriteLine("Invalid Product Name");
                }
            }
        }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Invalid Price");
                }
            }
        }

        public void ShowProduct()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
        }
    }
}
