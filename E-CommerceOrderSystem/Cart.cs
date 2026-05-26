namespace E_CommerceOrderSystem
{
    internal class Cart
    {
        Product[] products = new Product[5];

        public Product this[int index]
        {
            get
            { 
                return products[index];
            }
            set 
            {
                products[index] = value;
            }
        }
    }
}
