namespace PracticePrograms
{
    internal class Developer : Employee
    {
        public override double CalculateSalary()
        {
            return 50000 + 5000;
        }

        public override void Work()
        {
            Console.WriteLine("Working a Developer");
        }
    }
}
