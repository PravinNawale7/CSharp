namespace ConsoleApp1
{
    public class B
    {
        //public void Show()
        public static void Main()
        {
            A a = new A();
            C c = new C();
            c.Show();

            a.SameClass();
            //Console.WriteLine(a.privateVar);
            Console.WriteLine(a.internalVar);
            //Console.WriteLine(a.protectedVar);
            //Console.WriteLine(a.privateProtectedVar);
            Console.WriteLine(a.protectedInternalVar);
            Console.WriteLine(a.publicVar);


        }
    }
}
