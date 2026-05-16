namespace PracticePrograms
{
    internal class Tester : Employee
    {
        public override double CalculateSalary()
        {
            return 50000 + 2000;
        }
        public override void Work()
        {
            Console.WriteLine("Working a Tester");
        }
    }
}
