namespace BankManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Bank Management System");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Enter the Account Holder Name: ");
                string accountHolderName = Console.ReadLine();

                Console.WriteLine("Enter Account Number: ");
                int accountNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                BankAccount account = new BankAccount(accountHolderName,accountNumber,initialBalance);
                Console.WriteLine("Account Created Successfully");
                Console.WriteLine();


                Console.WriteLine("Enter Deposit Amount: ");
                double depositAmount = double.Parse(Console.ReadLine());
                account.Deposit(depositAmount);
                Console.WriteLine();


                Console.WriteLine("Enter Withdraw Amount: ");
                double withdrawAmount = double.Parse(Console.ReadLine());
                account.Withdraw(withdrawAmount);
                Console.WriteLine();

                Console.WriteLine($"Current Balance: {account.Balance}");

            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");

            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric input.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for using the Bank Management System.");
            }
            Console.ReadLine();
        }
    }
}
