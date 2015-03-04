namespace School
{
    using System;
    
    public class Student : People
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber)
            : base(name)
        {
            this.UniqueClassNumber = uniqueClassNumber;
        }

        public int UniqueClassNumber
        {
            get { return this.uniqueClassNumber; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("The class number cannot be negative.");
                }
                else
                {
                    this.uniqueClassNumber = value;
                }
            }
        }
    }
}
