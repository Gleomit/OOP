namespace CompanyHierarchy
{
    using System;
    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    class Employee : Person, IEmployee
    {
        private double salary;
        private Department department;

        public Employee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("The salary cannot be negative number.");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public override string ToString()
        {
            return "I am a employee!";
        }
    }
}
