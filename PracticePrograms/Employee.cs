namespace PracticePrograms
{
    internal abstract class Employee
    {
        int id;
        String name;
        double Salary;

        public abstract void Work();

        public void GetEmpData()
        {
            Console.WriteLine("Enter Your Id: " + id);
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name: " + name);
            name = Console.ReadLine();
            Console.WriteLine("Enter the Salary: " + Salary);
            Salary = Convert.ToDouble(Console.ReadLine());
        }
        public void ShowData()
        {
            Console.WriteLine("EMP ID IS: " + id);
            Console.WriteLine("EMP NAME IS : " + name);
            Console.WriteLine("EMP SALARY IS : " + Salary);
        }
        public virtual double CalculateSalary()
        {
            return 50000;
        }

    }
}
