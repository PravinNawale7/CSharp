namespace UserRegistrationSystem
{
    internal class User
    {
        string _name;
        string _email;
        string _password;
        int _age;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty");
                }
            }
        }
    
        public string Email
        {
            get
            {
                return _email;
            }

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

       
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                if (value.Length >= 8)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password must contain 8 characters");
                }
            }
        }

        
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value >= 18 && value <= 60)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                }
            }
        }

        
        public void ShowUser()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Email: " + _email);
            Console.WriteLine("Age: " + _age);
        }
    }
}