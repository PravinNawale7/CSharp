namespace PropertiesPractice
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Rahul";
            s.Age = -5;
            Console.WriteLine(s.Age);
            Console.WriteLine(s.Name);
        
            
        }
    }
}
