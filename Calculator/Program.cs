namespace Calculator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            CalculatorDelegate cd = calculator.Add;
             cd += calculator.Subtract;
            cd(20, 10);

            Console.WriteLine();

            MessageDelegate md = Calculator.SayHello;
            Console.WriteLine(md("Rahul"));
            
            Console.WriteLine();
        }
    }
}
