using System;

namespace PracticeProject
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter First number:");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Operator (+, -, *, /):");
                char op = Convert.ToChar(Console.ReadLine());

                switch (op)
                {
                    case '+':
                        Console.WriteLine("Result: " + (num1 + num2));
                        break;

                    case '-':
                        Console.WriteLine("Result: " + (num1 - num2));
                        break;

                    case '*':
                        Console.WriteLine("Result: " + (num1 * num2));
                        break;

                    case '/':
                        if (num2 != 0)
                            Console.WriteLine("Result: " + (num1 / num2));
                        else
                            Console.WriteLine("Cannot divide by zero");
                        break;

                    default:
                        Console.WriteLine("Invalid Operator");
                        break;
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                char choice = Convert.ToChar(Console.ReadLine());

                if (choice == 'n' || choice == 'N')
                {
                    Console.WriteLine("Calculator Ended");
                    break;
                }
            }
        }
    }
}