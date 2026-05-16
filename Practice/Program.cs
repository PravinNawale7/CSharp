using System;

namespace Practice
{
    class Student
    {
        public string name;
        public int age;

        public void Show()
        {
            Console.WriteLine("Name is " + name + " Age is " + age);
        }
    }

    class Rectangle
    {
        public int length, width;

        public float Area()
        {
            return length * width;
        }
    }

    class Calculator
    {
        public float a, b;

        public float Add(int a, int b)
        {
            return a + b;
        }
        public float Substract(int a, int b) => (
            a - b);
        
        
    }

    class Employee
    {
        public double salary;
        public string name;

        public void Display()
        {
            Console.WriteLine("Name " + name +  "\n" + "Salary " + salary);
        }
    }

    class Bank
    {
        public int balance = 500;

        public void Deposit(int amount)
        {
           balance += amount;
        }

       public void Display()
        {
            Console.WriteLine("Balance is " + balance);
        }
    }
    
    class EmployeeClass
    {
        public int salary = 15000;
    }
    class Manager : EmployeeClass
    {
        public void AddBonus(int percent)
        {
            salary = salary + (salary * percent / 100);
            Console.WriteLine("Final Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.name = "Pravin";
            //s.age = 21;
            //s.Show();

            //Rectangle r = new Rectangle();
            //r.length = 100;
            //r.width = 50;
            //Console.WriteLine(r.Area());

            //Calculator c = new Calculator();
            //Console.WriteLine("Addition " + c.Add(10, 30));
            //Console.WriteLine("Substraction " + c.Substract(90, 30));

            //Employee e = new Employee();
            //e.salary = 52000;
            //e.name = "Pravin";
            //e.Display();

            //Bank b  = new Bank();
            //b.Deposit(1500);
            //b.Display();


            Manager m = new Manager();
            m.AddBonus(20);
                    
        }
    }
}