namespace HospitalManagementSystem
{
    internal class InvalidAgeException : ApplicationException
    {
        public override string Message
        {
            get { return "Age must be greater than 0."; } 
        }

    }
}
