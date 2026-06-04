namespace StudentResultPortal
{
    internal class Program
    {
        Dictionary<String, Student> students = new Dictionary<String, Student>();

        public void AddStudent()
        {
            Console.WriteLine("\nEnter Student Details:");
            Console.Write("Roll No: ");
            string rollNo = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Marks must be between 0 and 100");
                return;
            }

            if (students.ContainsKey(rollNo))
            {
                Console.WriteLine("Student already exists");
                return;
            }

            students.Add(rollNo, new Student { RollNo = rollNo, Name = name, Marks = marks });

            Console.WriteLine("\nStudent added successfully!");
        }




        public void DisplayResult()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("\nNo students found.");
                return;
            }
            Console.WriteLine("\nStudent Results:");
            Console.WriteLine("Roll No\tName\tMarks");
            Console.WriteLine("---------------------------------");
            foreach (var student in students.Values)
            {
                Console.WriteLine($"{student.RollNo}\t{student.Name}\t{student.Marks}");
            }
        }

        public void FindStudentByRollNo()
        {
            Console.Write("\nEnter Roll No to Find: ");
            string rollNo = Console.ReadLine();
            if (!students.ContainsKey(rollNo))
            {
                Console.WriteLine("Student not found");
                return;
            }
            var student = students[rollNo];
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Roll No: {student.RollNo}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"Marks: {student.Marks}");
        }

        public void RemoveStudent()
        {
            Console.Write("\nEnter Roll No to Remove: ");
            string rollNo = Console.ReadLine();
            if (!students.ContainsKey(rollNo))
            {
                Console.WriteLine("Student not found");
                return;
            }
            students.Remove(rollNo);
            Console.WriteLine("\nStudent removed successfully!");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to Student Result Portal!");

            while (true)
            {

                Console.WriteLine("=================================");
                Console.WriteLine("    STUDENT RESULT SYSTEM");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Find Student By RollNo");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Display Result");
                Console.WriteLine("5. Exit");
                Console.WriteLine("---------------------------------");
                Console.Write("Enter Your Choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        p.AddStudent();
                        break;

                    case 2:
                        p.FindStudentByRollNo();
                        break;

                    case 3:
                        p.RemoveStudent();
                        break;

                    case 4:
                        p.DisplayResult();
                        break;

                    case 5:
                        Console.WriteLine("\nExiting the program...");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice. Please enter a number between 1 and 5.");
                        break;
                }

                Console.WriteLine("\nPress Any Key To Continue...");
                Console.ReadKey();
            }

        }
    }
}

