namespace LibraryManagementSystem
{
    internal class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        double _price;

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
                _price = value;
            }
        }

        public Book(int id,string name,string author,double price)
        {
            BookId = id;
            Title = name;
            Author = author;
            Price = price;
        }
    }
}
