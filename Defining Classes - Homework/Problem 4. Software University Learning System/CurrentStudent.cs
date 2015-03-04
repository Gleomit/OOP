namespace HomeworkDefiningClasses
{
    using System;

    public class CurrentStudent : Student
    {
        private string currentCourse;
        
        public CurrentStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade,
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get { return this.currentCourse; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Course cannot be null or empty string!");
                else
                    this.currentCourse = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent Status - Currently studying\nCurrent Course - " + this.CurrentCourse;
        }
    }
}
