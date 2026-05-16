namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.GetData();
            //s.Show();

            SavingAccount s = new SavingAccount();
            s.Withdraw(500);

            CurrentAccount c = new CurrentAccount();
            c.Withdraw(3000);
        }
    }
}
