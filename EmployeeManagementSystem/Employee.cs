namespace EmployeeManagementSystem
{
    internal class Employee
    {
        int _id;
        string _name;
        string _department;
        double _salary;

        public int ID
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine("ID must be greater than 0.");
                }
            }
        }
        public String Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be empty.");
                }
            }
        }
        public String Department
        {
            get { return _department; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _department = value;
                }
                else
                {
                    Console.WriteLine("Department cannot be empty.");
                }
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");

                }
            }
        }


    }
}
