using System;

namespace First
{
    class Student
    {
        private string name;
        private int marks;

        public Student(string name, int marks)
        {
            this.name = name;
            this.marks = marks;
        }

        public void CheckResult()
        {
            if (marks >= 35)
            {
                Console.WriteLine($"{name} is Pass");
            }
            else
            {
                Console.WriteLine($"{name} is Fail");
            }
        }
    }

    class Class1
    {
        static void Main()
        {
            Student s1 = new Student("Pravin", 34);
            Student s2 = new Student("Rahul",30);
            Student s3 = new Student("Marathe",75);
            s1.CheckResult();
            s2.CheckResult();
            s3.CheckResult();

            BankAccount b1 = new BankAccount("123", 5000);
            BankAccount b2 = new BankAccount("456", 2000);
            b1.Withdraw(2000);
            b1.Deposit(1000);
            b1.ShowBalance();


            Person p = new Person();
            p.GetAge(10);
            p.SetAge();
        }
    }
}