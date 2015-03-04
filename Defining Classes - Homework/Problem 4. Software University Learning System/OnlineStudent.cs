namespace HomeworkDefiningClasses
{
    using System;

    public class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade,
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent Type - Online";
        }
    }
}
