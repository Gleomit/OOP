namespace HumanStudentAndWorker
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The first name cannot be null or empty.");
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The last name cannot be null or empty.");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
    }
}
