namespace First
{
    internal class Person
    {
        private int age;

        public void SetAge(int age)
        {
            Console.WriteLine("Enter the age: ");
            this.age = age; 

        }

        public void GetAge()
        {
            Console.WriteLine($"Age is: {age}");
        }
    }

}
