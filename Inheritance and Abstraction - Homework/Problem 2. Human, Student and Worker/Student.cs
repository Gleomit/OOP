namespace HumanStudentAndWorker
{
    using System;

    public class Student : Human
    {
        private string faultyNumber;

        public Student(string firstName, string lastName, string faultyNumber)
            : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }

        public string FaultyNumber
        {
            get { return this.faultyNumber; }
            set
            {
                if(string.IsNullOrWhiteSpace(value) || (value.Trim().Length < 5 && value.Trim().Length > 10))
                {
                    throw new Exception("The faulty number must be in the range 5 - 10 and cannot be null or empty.");
                }
                else
                {
                    this.faultyNumber = value;
                }
            }
        }
    }
}
