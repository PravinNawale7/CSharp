namespace HospitalManagementSystem
{
    internal class Program
    {
        Dictionary<int, Patient> patients = new Dictionary<int, Patient>();

        public void AddPatient()
        {
            Console.WriteLine("Enter the Patient ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Patient Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Patient Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Disease Name: ");
            string disease = Console.ReadLine();

            Patient p = new Patient(id,name,age,disease);

            if (patients.ContainsKey(id))
            {
                Console.WriteLine("Patient ID already exists.");
                return;
            }

            patients.Add(id, p);
            Console.WriteLine("Patient Added Successfully");
        }

        public void RemovePatient()
        {
            Console.WriteLine("Enter Patient ID to Remove: ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!patients.ContainsKey(id)){
                Console.WriteLine("Patient Not Found");
                return;
            }
            patients.Remove(id);


            Console.WriteLine("SuccessFully Remove");

        }
        public void SearchPatient()
        {
            Console.WriteLine("Enter Patient ID to Search:  ");
            int id = Convert.ToInt32(Console.ReadLine());

            if (!patients.ContainsKey(id))
            {
                Console.WriteLine("Patients Not Found");
                return;
            }
            var patient = patients[id];
            Console.WriteLine("Result Found: ");
            Console.WriteLine("ID\tName\tAge\tDisease");
            Console.WriteLine($"{patient.PatientId}\t{patient.Name}\t{patient.Age}\t{patient.Disease}");



        }


        public void DisplayPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No Patients Found.");
                return;
            }

            Console.WriteLine("ID\tName\tAge\tDisease");

            foreach (var patient in patients.Values)
            {
                Console.WriteLine($"{patient.PatientId}\t{patient.Name}\t{patient.Age}\t{patient.Disease}");
            }
        }

        public void AgeGreater()
        {
            var patient = from p in patients.Values where p.Age > 60 select p;
            Console.WriteLine("ID\tName\tAge\tDisease");

            foreach (var p in patient)
            {
                Console.WriteLine($"{p.PatientId}\t{p.Name}\t{p.Age}\t{p.Disease}");
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Welcome to the Hospital Management System !!!");

            try
            {
                while (true)
                {
                    Console.WriteLine("Please select an option:");
                    Console.WriteLine("1. Add Patient");
                    Console.WriteLine("2. Remove Patient");
                    Console.WriteLine("3. Search Patient");
                    Console.WriteLine("4. Display All Patients");
                    Console.WriteLine("5. Display Senior Citizen");
                    Console.WriteLine("6. Exit");

                    Console.WriteLine("Enter Your Choice (1-6) ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            p.AddPatient();
                            break;
                        case 2:
                            p.RemovePatient();
                            break;
                        case 3:
                            p.SearchPatient();
                            break;
                        case 4:
                            p.DisplayPatients();
                            break;
                        case 5:
                            p.AgeGreater();
                            break;
                        case 6:
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
