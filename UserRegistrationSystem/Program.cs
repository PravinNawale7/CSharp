namespace UserRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "John Doe";
            u.Email = "johndoe1@gmail.com";
            u.Password = "12345678";
            u.Age = 18;

            u.ShowUser();
        }
    }
}
