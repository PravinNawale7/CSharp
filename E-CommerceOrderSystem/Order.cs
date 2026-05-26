namespace E_CommerceOrderSystem
{
    internal class Order
    {
        public double CalculateBill(Cart cart)
        {
            double total = 0;

            for (int i = 0; i < 5; i++)
            {
                if (cart[i] != null)
                {
                    total += cart[i].Price;

                }
            }
            return total;

        }
        ~Order()
        {
            Console.WriteLine("Order destroyed");
        }
    }
}
