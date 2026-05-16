namespace InheritanceDemo
{
    internal class Person

    {
        public String name;
        public int age;

        public void GetData()
        {
            Console.WriteLine("Enter Your Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Age: ");
            age = Convert.ToInt32(Console.ReadLine());

        }
    }
}
