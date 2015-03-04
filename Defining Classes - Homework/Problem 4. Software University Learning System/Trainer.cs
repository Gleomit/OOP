namespace HomeworkDefiningClasses
{
    using System;

    public class Trainer : Person
    {
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {

        }

        public void CreateCourse(string courseName)
        {
            Console.WriteLine(courseName + " course has been created!");
        }

        public override string ToString()
        {
            return base.ToString() + "\nRole - Trainer";
        }
    }
}
