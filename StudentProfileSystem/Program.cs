namespace StudentProfileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(
                "John Doe",
                20,
                "Computer Science"
            );

            var (name, age, course) = s;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Course: {course}");
        }
    }
}