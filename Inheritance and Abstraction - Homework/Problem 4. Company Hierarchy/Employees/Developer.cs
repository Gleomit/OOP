namespace CompanyHierarchy.Employees
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Enumerations;

    class Developer : RegularEmployee
    {
        private List<Project> projects;

        public Developer(int id, string firstName, string lastName, 
            double salary, Department department, List<Project> projects)
            : base(id, firstName, lastName, salary, department)
        {
            this.projects = projects;
        }

        public override string ToString()
        {
            return "I am a developer!";
        }
    }
}
