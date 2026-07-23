using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDataAdapter
{
    internal class Program
    {
        SqlConnection con = new SqlConnection("Data Source=PRAVIN\\SQLEXPRESS;Database=NewDB;Integrated Security=SSPI"); 
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;

        public Program()
        {
            da = new SqlDataAdapter("SELECT * FROM Employee", con);
            cb = new SqlCommandBuilder(da); 
            ds = new DataSet();
            da.Fill(ds, "Employee");
            ds.Tables["Employee"].PrimaryKey = new DataColumn[]
             {
                ds.Tables["Employee"].Columns["EmpId"]
             };

        }

        public void AddEmployee()
        {
            Console.WriteLine("Enter the Employee Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Department: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter the Salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());

            DataRow row = ds.Tables["Employee"].NewRow();
            row["EmpName"] = name;
            row["Department"] = department;
            row["Salary"] = salary;

            ds.Tables["Employee"].Rows.Add(row);
            da.Update(ds, "Employee");

            ds.Tables["Employee"].Clear();
            da.Fill(ds, "Employee");

            Console.WriteLine("Employee Added Successfully!");
        }

        public void UpdateEmployee()
        {
            Console.WriteLine("Enter the Employee ID Which You Want to Update: ");
            int id = int.Parse(Console.ReadLine());

            DataRow row = ds.Tables["Employee"].Rows.Find(id);

            if(row != null)
            {
                Console.WriteLine("Enter new Name: ");
                row["EmpName"] = Console.ReadLine();
                Console.WriteLine("Enter new Department: ");
                row["Department"] = Console.ReadLine();
                Console.WriteLine("Enter new Salary: ");
                row["Salary"] = decimal.Parse(Console.ReadLine());

                da.Update(ds, "Employee");
                Console.WriteLine("Record Updated Successfully!");
            }
            else
            {
                Console.WriteLine("Employee Not Found!");

            }

        }

        public void DeleteEmployee()
        {
            Console.WriteLine("Enter the Employee ID to Delete: ");
            int id = int.Parse(Console.ReadLine());

            DataRow row = ds.Tables["Employee"].Rows.Find(id);

            if (row != null) {
                row.Delete();
                da.Update(ds, "Employee");
                Console.WriteLine("Record Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Employee Not Found!");
            }
        }

        public void SearchEmployee()
        {
            Console.WriteLine("Enter the Employee ID to Search: ");
            int id = int.Parse(Console.ReadLine());

            DataRow row = ds.Tables["Employee"].Rows.Find(id);
            if (row != null)
            {
                Console.WriteLine($"Name: {row["EmpName"]} | Department: {row["Department"]} | Salary: {row["Salary"]}");
            }
            else
            {
                Console.WriteLine("Employee not found!");
            }
        }

        public void DisplayAllEmployees()
        {
            Console.WriteLine("\nEmployee List: ");
            Console.WriteLine("------------------------------------------");

            foreach (DataRow row in ds.Tables["Employee"].Rows)
            {
                Console.WriteLine($"ID: {row["EmpId"]} | Name: {row["EmpName"]} | Department: {row["Department"]} | Salary: {row["Salary"]}");

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