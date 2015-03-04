namespace HomeworkDefiningClasses
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be null or empty string!");
                else
                    this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name be null or empty string!");
                else
                    this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 10)
                    throw new ArgumentException("Age cannot be less than 10!");
                else
                    this.age = value;
            }
        }

        public override string ToString()
        {
            return "First name - " + this.FirstName + "\nLast name - " + this.LastName + "\nAge - " + this.Age.ToString();
        }
    }
}
