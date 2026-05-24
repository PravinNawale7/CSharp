namespace ConsoleApp1
{
    public class A

    {
        private int privateVar = 1;
        internal int internalVar = 2;
        protected int protectedVar = 3;
        private protected int privateProtectedVar = 4;
        protected internal int protectedInternalVar = 5;
        public int publicVar = 6;

        public void SameClass()
        {
            Console.WriteLine("FROM Class A privateVar " + privateVar);
            Console.WriteLine("FROM Class A internalVar " + internalVar);
            Console.WriteLine("FROM Class A protectedVar " + protectedVar);
            Console.WriteLine("FROM Class A privateProtectedVar " + privateProtectedVar);
            Console.WriteLine("FROM Class A protectedInternalVar " + protectedInternalVar);
            Console.WriteLine("FROM Class A publicVar " + publicVar);
        }
    }
}


