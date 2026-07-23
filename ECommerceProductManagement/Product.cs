namespace ECommerceProductManagement
{
    internal class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        double _price;
        int _stock;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if(value <= 0)
                {
                    throw new InvalidPriceException();
                }
            }
        }

        public int Stock
        {
            get { return  _stock; }
            set
            {
                if (value < 0)
                    throw new Exception("Stock cannot be negative.");

                _stock = value;
            }
        }

        public Product(int productId, string name, string category, double price, int stock)
        {
            ProductId = productId;
            Name = name;
            Category = category;
            Price = price;
            Stock = stock;
        }
    }
}
