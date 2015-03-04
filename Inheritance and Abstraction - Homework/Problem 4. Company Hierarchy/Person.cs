namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Interfaces;

    public class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID 
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID cannot be negative number.");
                }
                else
                {
                    this.id = value;
                }
            }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First name cannot be null or empty.");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last name cannot be null or empty.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public override string ToString()
        {
            return "I am a person!";
        }
    }
}
