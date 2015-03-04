namespace CompanyHierarchy.Employees
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Interfaces;

    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            
        }

        public override string ToString()
        {
            return "I am a manager!";
        }
    }
}
