namespace HomeworkDefiningClasses
{
    using System;

    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, long studentNumber, double averageGrade,
            string dropoutReason)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get { return this.dropoutReason; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Dropout reason cannot be null or empty string!");
                else
                    this.dropoutReason = value;
            }
        }

        public void Reapply()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return base.ToString() + "\nStudent Status - Dropout\nDropout reason - " + this.DropoutReason;
        }
    }
}
