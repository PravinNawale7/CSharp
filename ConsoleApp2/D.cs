using ConsoleApp1;
namespace ConsoleApp2
{
    internal class D : A
    {
        static void Main(string[] args)
        {
            D d = new D();

            //Console.WriteLine(d.privateVar);
            //Console.WriteLine(d.internalVar);
            Console.WriteLine(d.protectedVar);
            //Console.WriteLine(d.privateProtectedVar);
            Console.WriteLine(d.protectedInternalVar);
            Console.WriteLine(d.publicVar);
        }
    }
}
