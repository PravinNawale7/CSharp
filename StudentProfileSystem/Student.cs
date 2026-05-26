namespace StudentProfileSystem
{
    internal class Student
    {
        string _name;
        int _age;
        string _course;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Student(string name, int age, string course)
        {
            _name = name;
            _age = age;
            _course = course;
        }



        public void Deconstruct(out string name,
                                out int age,
                                out string course)
        {
            name = Name;
            age = Age;
            course = Course;
        }
    }
}