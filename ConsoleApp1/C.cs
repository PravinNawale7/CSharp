namespace ConsoleApp1
{
    internal class C : A
    {
        public void Show()
        {
            //Console.WriteLine(privateVar);
            Console.WriteLine(internalVar);
            Console.WriteLine(protectedVar);
            Console.WriteLine(privateProtectedVar);
            Console.WriteLine(protectedInternalVar);
            Console.WriteLine(publicVar);
            
        }
    }
}
