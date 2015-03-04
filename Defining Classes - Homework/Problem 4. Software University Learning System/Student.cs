namespace HomeworkDefiningClasses
{
    using System;

    public class Student : Person
    {
        private long studentNumber;
        private double averageGrade;

        public Student(string firstName, string lastName, int age, long studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public long StudentNumber
        {
            get { return this.studentNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Student number cannot be negative!");
                else
                    this.studentNumber = value;
            }
        }

        public double AverageGrade
        {
            get { return this.averageGrade; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Average grade cannot be negative!");
                else
                    this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nRole - Student\nStudent Number - "
                + this.StudentNumber.ToString() + "\nAverage Grade - " + this.AverageGrade.ToString();
        }
    }
}
