namespace PropertiesPractice
{
    class Student
    {
        string _Name;
        int _Age;

        public Student()
        {
            _Name = "Pravin";
            _Age = 22;
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
            }
        }
        public int Age
        {
            get
            {
                return _Age;

            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    _Age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age");
                }
            }
        }


    }
}
