namespace PracticePrograms
{

 
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.GetEmpData();
            //emp.ShowData();

            Employee e = new Developer();
            //Developer d = new Developer();
;            Console.WriteLine($"SALARY OF DEVELOPER : { e.CalculateSalary()}");
            e.Work();
            e = new Tester();
            Console.WriteLine($"SALARY OF TESTER : {e.CalculateSalary()}");
           e.Work();


            //Bank b = new Bank();
            //b.Deposit(1000);
            //b.Withdraw(1500);



        }
    }
}
