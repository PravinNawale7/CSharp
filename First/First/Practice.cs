namespace First
{
    internal class Practice
    {
        static void Main()
        {
            //123
            //321

            //int number = 123;
            //int reverse = 0;

            //while (number > 0)
            //{
            //   int digit = number % 10;
            //   reverse = reverse * 10 + digit;
            //   number = number / 10;


            //}
            //Console.WriteLine("REVERSE " + reverse);

            //int number = 12345;
            //int count = 0;

            //while (number > 0)
            //{
            //    number = number / 10;
            //    count++;
            //}
            //Console.WriteLine(count);



            //    int number = 1331;

            //    if (number < 0)
            //    {
            //        Console.WriteLine("Not Palindrome");
            //        return;
            //    }

            //    int original = number;
            //    int result = 0;

            //    while (number > 0)
            //    {
            //        int digit = number % 10;
            //        result = result * 10 + digit;
            //        number /= 10;
            //    }

            //if (original == result)
            //    Console.WriteLine("Palindrome");
            //else
            //    Console.WriteLine("Not Palindrome");

            //int fact = 1;
            //for (int i = 1; i <= 5; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine("FACT ==> " + fact);

            int a = 0;
            int b = 1;

            Console.Write(a + " " + b + " ");
            for(int i = 2; i < 10; i++)
            {
                int result = a + b;
                Console.Write(result + " ");

                a = b; 
                b= result;
            }

    }
    }
}
