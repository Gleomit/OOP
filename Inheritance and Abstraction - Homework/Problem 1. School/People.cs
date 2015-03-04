namespace School
{
    using System;

    public class People : IDetailable
    {
        private string name;

        public People(string name)
        {
            this.Name = name;
        }

        public String Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("The name cannot be null or empty!");
                else
                    this.name = value;
            }
        }

        public string Details
        {
            get;
            set;
        }
    }
}
