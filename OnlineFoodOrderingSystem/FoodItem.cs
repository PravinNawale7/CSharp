namespace OnlineFoodOrderingSystem
{
    internal class FoodItem
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        double _price;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidPriceException();
                }
                _price = value;
            }
        }      

        public FoodItem(int foodId,string foodName,double price)
        {
            FoodId = foodId;
            FoodName = foodName;
            Price = price;
        }
    }
}
