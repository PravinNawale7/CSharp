namespace ECommerceProductManagement
{
    internal class Program
    {
        Dictionary<int, Product> products = new Dictionary<int, Product>();

        public void AddProduct()
        {
            Console.WriteLine("Enter Product ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (products.ContainsKey(id))
            {
                Console.WriteLine("Product ID already exists.");
                return;
            }

            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Category:");
            string category = Console.ReadLine();

            Console.WriteLine("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Stock:");
            int stock = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(id, name, category, price, stock);

            products.Add(id, product);

            Console.WriteLine("Product Added Successfully.");
        }

        public void UpdateStock()
        {
            Console.WriteLine("Enter Product ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!products.ContainsKey(id))
            {
                Console.WriteLine("Product Not Found.");
                return;
            }

            Console.WriteLine("Enter Quantity To Add:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            products[id].Stock += quantity;

            Console.WriteLine("Stock Updated Successfully.");

            NotificationDelegate notify = StockUpdated;
            notify();
        }

        public void PurchaseProduct()
        {
            Console.WriteLine("Enter Product ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!products.ContainsKey(id))
            {
                Console.WriteLine("Product Not Found.");
                return;
            }

            Console.WriteLine("Enter Quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            if (quantity > products[id].Stock)
            {
                throw new OutOfStockException();
            }

            products[id].Stock -= quantity;

            Console.WriteLine("Purchase Successful.");

            NotificationDelegate notify = OrderPlaced;
            notify();
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No Products Available.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("ID\tName\tCategory\tPrice\tStock");
            Console.WriteLine("---------------------------------------------------");

            foreach (var product in products.Values)
            {
                Console.WriteLine(
                    $"{product.ProductId}\t{product.Name}\t{product.Category}\t{product.Price}\t{product.Stock}"
                );
            }
        }

        public void OrderPlaced()
        {
            Console.WriteLine("Order Placed Notification Sent.");
        }

        public void StockUpdated()
        {
            Console.WriteLine("Stock Updated Notification Sent.");
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome To E-Commerce Product Management System");

            while (true)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("1. Add Product");
                    Console.WriteLine("2. Update Stock");
                    Console.WriteLine("3. Purchase Product");
                    Console.WriteLine("4. Display Products");
                    Console.WriteLine("5. Exit");

                    Console.WriteLine("Enter Your Choice (1-5):");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            p.AddProduct();
                            break;

                        case 2:
                            p.UpdateStock();
                            break;

                        case 3:
                            p.PurchaseProduct();
                            break;

                        case 4:
                            p.DisplayProducts();
                            break;

                        case 5:
                            Console.WriteLine("Exiting System...");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}