using System;

class Employee
{
    public string name;
    public int age;

    public void Display()
    {
        Console.WriteLine($"Name {name},Age: {age}");
    }
}
class Car
{
    public string Brand;
    public string Model;
    public string Price;

    public void Display()
    {
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Price: {Price}");

    }
}
class Test
{
   static void Main()
    {
        Employee emp = new Employee();
        emp.name = "Test";
        emp.age = 25;
        emp.Display();

        Car car = new Car();
        car.Brand = "TATA";
        car.Model = "Punch";
        car.Price = "1200000";
        car.Display();

        Account account = new Account();
        account.AccountNumber = "123456";
        account.Balance = 5000;

        account.Deposit(2000);
        account.Withdraw(3000);
        account.DisplayBalance();
    }

} 