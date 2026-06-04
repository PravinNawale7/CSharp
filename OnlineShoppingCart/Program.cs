namespace OnlineShoppingCart
{
    internal class Program
    {
        List<Product> cart = new List<Product>();

        public void AddToCart()
        {
            Console.WriteLine("Enter Product ID: ");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            double price = double.Parse(Console.ReadLine());

            cart.Add(new Product { ID = id, Name = name, Price = price });

            Console.WriteLine("Product added to cart successfully!");

        }
        public void RemoveFromCart()
        {
            Console.WriteLine("Enter Product ID to remove: ");
            string id = Console.ReadLine();
            var product = cart.Find((p) => p.ID == id);
            if (product != null)
            {
                cart.Remove(product);
                Console.WriteLine("Product removed from cart successfully!");
            }
            else
            {
                Console.WriteLine("Product not found in cart.");
            }
        }
        public void ShowCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
                return;
            }
            Console.WriteLine("Your Cart:");
            foreach (var item in cart)
            {
                Console.WriteLine($"ID: {item.ID}, Name: {item.Name}, Price: {item.Price}");
            }
        }
        public void CalculateBill()
        {
            double total = 0;
            foreach (var item in cart)
            {
                total += item.Price;
            }
            Console.WriteLine($"Total Bill: {total}");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome to Online Shopping Cart!");

            while (true)
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add To Cart");
                Console.WriteLine("2. Remove From Cart");
                Console.WriteLine("3. Show Cart");
                Console.WriteLine("4. Calculate Bill");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice (1-5): ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        p.AddToCart();
                        break;
                    case 2:
                        p.RemoveFromCart();
                        break;
                    case 3:
                        p.ShowCart();
                        break;
                    case 4:
                        p.CalculateBill();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            }
        }
    }
}

