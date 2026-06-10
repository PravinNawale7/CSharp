namespace OnlineFoodOrderingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            Console.WriteLine("Welcome to the Online Food Ordering System !!!");

            while (true)
            {
                try
                {


                    Console.WriteLine("Please Select an Option");
                    Console.WriteLine("1. Add FoodItem");
                    Console.WriteLine("2. Remove FoodItem");
                    Console.WriteLine("3. Display Cart");
                    Console.WriteLine("4. Generate Bill");
                    Console.WriteLine("5. Confirm Order");
                    Console.WriteLine("6 .Exit");

                    Console.WriteLine("Enter Your choice (1-6");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            order.AddFoodItem();
                            break;
                        case 2:
                            order.RemoveFoodItem();
                            break;
                        case 3:
                            order.DisplayCart();
                            break;
                        case 4:
                            order.GenerateBill();
                            break;
                        case 5:
                            order.ConfirmOrder();
                            break;
                        case 6:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                }

        }
    }
}
