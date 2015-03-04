namespace School
{
    using System;
    using System.Collections.Generic;

    public class Discipline : IDetailable
    {
        private string name;
        private int numberOfLectures;
        private List<Student> students;

        public Discipline(string name, int numberOfLectures, List<Student> students)
        {
            this.NumberOfLectures = numberOfLectures;
            this.Name = name;
            this.students = students;
        }

        public int NumberOfLectures
        {
            get { return this.numberOfLectures; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Number of lectures cannot be negative number!");
                }
                else
                {
                    this.numberOfLectures = value;
                }
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("The name cannot be empty or null.");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string Details
        {
            get;
            set;
        }
    }
}
