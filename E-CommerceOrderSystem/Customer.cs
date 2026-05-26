namespace E_CommerceOrderSystem
{
    internal class Customer
    {
        string _name;
        string _email;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }
                else
                {
                    Console.WriteLine("Invalid Email");
                }
            }
        }
        public void ShowCustomer()
        {
            Console.WriteLine("Customer Name: " + Name);
            Console.WriteLine("Customer Email: " + Email);

        }
    }
}
