namespace HomeworkDefiningClasses
{
    using System;

    public class GraduateStudent : Student
    {
        public GraduateStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent Status - Graduate";
        }
    }
}
