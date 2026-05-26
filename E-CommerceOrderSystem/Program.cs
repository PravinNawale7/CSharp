using E_CommerceOrderSystem;

namespace E_CommerceOrderSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                Name = "John Doe",
                Email = "johndoe@gmail.com"
            };

            Product p1 = new Product()
            {
                ProductName = "Laptop",
                Price = 50000
            };

            Product p2 = new Product()
            {
                ProductName = "Mouse",
                Price = 1000
            };

            Cart cart = new Cart();

            cart[0] = p1;
            cart[1] = p2;

            c1.ShowCustomer();

            Console.WriteLine();

            cart[0].ShowProduct();

            Console.WriteLine();

            cart[1].ShowProduct();

            Order order = new Order();

            double bill = order.CalculateBill(cart);

            Console.WriteLine();
            Console.WriteLine("TOTAL BILL = " + bill);

            order = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.ReadLine();
        }
    }
}