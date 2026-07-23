using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystemADO
{
    internal class Program
    {
        SqlConnection con = new SqlConnection("Data Source=PRAVIN\\SQLEXPRESS;Database=NewDB;Integrated Security=SSPI");
        SqlCommand cmd;
        
        SqlDataReader dr;

        public void AddEmployee()
        {
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Department: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the Salary Of Employee: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            cmd = new SqlCommand($"Insert into Employee Values('{name}','{department}','{salary}')",con);
            con.Open();
            if (cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Emloyee Added Successfully");
            }
            else
            {
                Console.WriteLine("Failed Add the Employee");
            }
            con.Close();
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Enter the Employee ID Which You Want to Update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name OF Employee Which is Update: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Department Of Employee Which is Update: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the Salary of Employee Which is Update: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            cmd = new SqlCommand($"Update Employee Set EmpName='{name}',Department='{department}',Salary={salary} Where EmpId={id}", con);
            con.Open();

            if(cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Record Update SuccessFully");
            }
            else
            {
                Console.WriteLine("Failed to Update the Record");
            }
            con.Close();
        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Enter the Employee ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            cmd = new SqlCommand($"Delete from Employee Where EmpId={id}",con);
            con.Open();

            if(cmd.ExecuteNonQuery() > 0)
            {
                Console.WriteLine("Record Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Failed to Deleting the Record");
            }
            con.Close();
        }

        public void SearchEmployee()
        {
            Console.WriteLine("Enter the Employee ID Which You Want to Search: ");
            int id = int.Parse(Console.ReadLine());

            cmd = new SqlCommand("Select EmpName,Department,Salary from Employee Where EmpId=" + id, con);
            con.Open();
            dr = cmd.ExecuteReader();

            Console.WriteLine("Employee Found: ");
            while (dr.Read())
            {
                Console.WriteLine(
            $"Name: {dr["EmpName"]} | " +
            $"Department: {dr["Department"]} | " +
            $"Salary: {dr["Salary"]}"
        );
            }
            dr.Close();
            con.Close();
        }

        public void DisplayAllEmployees()
        {
            cmd = new SqlCommand("Select * From Employee", con);
            con.Open();
            dr = cmd.ExecuteReader();
            Console.WriteLine("\nEmployee List");
            Console.WriteLine("------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine(
            $"ID: {dr["EmpId"]} | " +
            $"Name: {dr["EmpName"]} | " +
            $"Department: {dr["Department"]} | " +
            $"Salary: {dr["Salary"]}"
        );
            }
            dr.Close();
            con.Close();

        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Welcome to the Employee Management System!");
            while (true)
            {

                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Search Employee By ID");
                Console.WriteLine("5. Display All Employees");
                Console.WriteLine("6. Exit");

                Console.WriteLine("Enter your choice (1-6): ");

                int Choice = Convert.ToInt32(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                       p.AddEmployee();
                        break;
                    case 2:
                         p.UpdateEmployee();
                        break;
                    case 3:
                        p.DeleteEmployee();
                        break;
                    case 4:
                        p.SearchEmployee();
                        break;
                    case 5:
                        p.DisplayAllEmployees();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }

        }
    }
}