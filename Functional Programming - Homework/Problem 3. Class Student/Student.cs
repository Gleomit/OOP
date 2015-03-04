namespace ClassStudent
{
    using System.Collections.Generic;

    public class Student
    {
        public Student()
        {

        }

        public Student(string firstName, string lastName, int age, long facultyNumber, string phone,
            string email, IList<int> marks, int groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string GroupName { get; private set; }

        public int Age { get; set; }
        public long FacultyNumber { get; set; }
        public int GroupNumber { get; set; }

        public IList<int> Marks { get; set; }

        public override string ToString()
        {
            return string.Format("Student name - {0}", this.FirstName);
        }
    }
}
