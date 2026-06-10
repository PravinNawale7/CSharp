namespace OnlineFoodOrderingSystem
{
    internal class Order
    {
        List<FoodItem> cart = new List<FoodItem> ();

        public void AddFoodItem()
        {
            Console.WriteLine("Enter the Food Item ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Name of FoodItem: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Price of FoodItem: ");
            double price = Convert.ToDouble(Console.ReadLine());
            var foodItem = cart.Find(c=>c.FoodId == id);

            if (foodItem != null)
            {
                Console.WriteLine("Food Item Already Exists.Please Add Another Food Item");
                return;
            }

            FoodItem item = new FoodItem(id,name,price);
            cart.Add(item);

            Console.WriteLine("Food Item Added Successfully");
            Console.WriteLine($"Food ID   : {id}");
            Console.WriteLine($"Food Name : {name}");
            Console.WriteLine($"Price     :Rs.{price}");

        }

        public void RemoveFoodItem()
        {
            Console.WriteLine("Enter Food Item ID To Remove:");
            int id = Convert.ToInt32(Console.ReadLine());
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
                return;
            }

            var foodItem = cart.Find(c => c.FoodId == id);

            if (foodItem == null)
            {
                Console.WriteLine("Food Item Not Found");
                return;
            }
            cart.Remove(foodItem);

            Console.WriteLine("Food Item Removed Successfully");
        }
        public void DisplayCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
                return;
            }

            Console.WriteLine("ID\tName\tPrice");
            Console.WriteLine("------------------------------------------");

            foreach (var item in cart)
            {
                Console.WriteLine($"{item.FoodId}\t{item.FoodName}\t{item.Price}");
            }
            Console.WriteLine();
        }

        public void GenerateBill()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
                return;
            }
            Console.WriteLine("==================================");
            Console.WriteLine("         FOOD ORDER BILL");
            Console.WriteLine("==================================");

            Console.WriteLine("ID\tItem Name\tPrice");
            Console.WriteLine("----------------------------------");

            double total = 0;

            foreach (var item in cart)
            {
                Console.WriteLine(
                    $"{item.FoodId}\t{item.FoodName}\t\t{item.Price}"
                );

                total += item.Price;
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Total Bill:\t\tRs.{total}");
            Console.WriteLine("==================================");

            
        }

        public void ConfirmOrder()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is Empty");
                return;
            }
            OrderPlaced();
            Console.WriteLine();


            cart.Clear();

            Console.WriteLine("Cart Cleared Successfully");
        }
       

        public void SendEmail()
        {
            Console.WriteLine("Email Sent");
        }

        public void SendSMS()
        {
            Console.WriteLine("SMS Sent");
        }

        public void SendWhatsApp()
        {
            Console.WriteLine("WhatsApp Notification Sent");
        }

        public void OrderPlaced()
        {
            Console.WriteLine("Order Placed Successfully");

            NotificationDelegate notify = SendEmail;

            notify += SendSMS;
            notify += SendWhatsApp;

            notify();

        }
    }
}
