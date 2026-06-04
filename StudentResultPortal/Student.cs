namespace StudentResultPortal
{
    internal class Student
    {
        string _rollNo;
        string _name;
        double _marks;

        public string RollNo
        {
            get { return _rollNo; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _rollNo = value;
                }
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) { _name = value; }
            }
        }
        public double Marks
        {
            get { return _marks; }
            set
            {

                _marks = value;
            }

        }
    }
}
