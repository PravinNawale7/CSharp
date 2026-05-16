namespace InheritanceDemo
{
    internal class Student : Person

    {
        public int marks;

        public void Show()
        {
            Console.WriteLine("Enter the Marks: ");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Marks: " + marks);
        }
    }
}
