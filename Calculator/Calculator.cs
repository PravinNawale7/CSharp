namespace Calculator
{
    internal class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition: {a + b}");
        }
        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Subtraction: {a - b}");
        }

        public static string SayHello(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
