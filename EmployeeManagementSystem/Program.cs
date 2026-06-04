namespace EmployeeManagementSystem
{
    internal class Program

    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee()
        {
            Console.WriteLine("Enter the ID of the employee: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of the employee: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the department of the employee: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the salary of the employee: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            var emp = employees.Find((e) => e.ID == id);
            if (emp != null)
            {
                Console.WriteLine("Employee with ID " + id + " already exists. Please try again.");
                return;
            }
            employees.Add(new Employee { ID = id, Name = name, Department = department, Salary = salary });

            Console.WriteLine("Employee added successfully!");

        }
        public void RemoveEmployee()
        {
            Console.WriteLine("Enter the ID of the Employee to Remove: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var emp = employees.Find(e => e.ID == id);
            if (emp != null)
            {
                employees.Remove(emp);
                Console.WriteLine("Employee with ID " + id + " has been removed.");
            }
            else
            {
                Console.WriteLine("Employee with ID " + id + " not found.");
            }
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Enter the ID of the Employee to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var emp = employees.Find((e) => e.ID == id);
            if (emp != null)
            {
                Console.WriteLine("Enter the new name of the employee: ");
                emp.Name = Console.ReadLine();
                Console.WriteLine("Enter the new department of the employee: ");
                emp.Department = Console.ReadLine();
                Console.WriteLine("Enter the new salary of the employee: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Employee with ID " + id + " has been updated.");
            }
            else
            {
                Console.WriteLine("Employee with ID " + id + " not found.");
            }
        }

        public void SearchEmployee()
        {
            Console.WriteLine("Enter the ID of the Employee to Search: ");
            int id = Convert.ToInt32(Console.ReadLine());
            var emp = employees.Find((e) => e.ID == id);
            if (emp != null)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
            else
            {
                Console.WriteLine("Employee with ID " + id + " not found.");
            }
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine("Employee List:");
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }
            foreach (var emp in employees)
            {
                Console.Write($"ID: {emp.ID}\nName: {emp.Name} \nDepartment: {emp.Department} \nSalary: {emp.Salary}");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome to the Employee Management System!");
            while (true)
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Remove Employee");
                Console.WriteLine("3. Update Employee");
                Console.WriteLine("4. Search Employee");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice (1-6): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        p.AddEmployee();
                        break;
                    case "2":
                        p.RemoveEmployee();
                        break;
                    case "3":
                        p.UpdateEmployee();
                        break;
                    case "4":
                        p.SearchEmployee();
                        break;
                    case "5":
                        p.DisplayAllEmployees();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}
