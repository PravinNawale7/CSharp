namespace HospitalManagementSystem
{
    internal class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        int _age;
        public string Disease { get; set; }



        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new InvalidAgeException();
                }
                else
                {
                    _age = value;
                }
            }
        }

        public Patient(int patientId, string name, int age,string disease)
        {
            PatientId = patientId;
            Name = name;
           Age = age;
            Disease = disease;
        }





    }
}
