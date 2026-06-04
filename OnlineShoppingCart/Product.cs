namespace OnlineShoppingCart
{
    internal class Product
    {
        string _id;
        string _name;
        double _price;

        public string ID
        {
            get
            {
                return _id;

            }
            set
            {
                _id = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

    }
}
