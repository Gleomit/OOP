namespace CompanyHierarchy.Employees
{
    using System;
    using System.Collections.Generic;
    using CompanyHierarchy.Enumerations;

    class SalesEmployee : RegularEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(int id, string firstName, string lastName, 
            double salary, Department department, List<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            this.sales = sales;
        }

        public override string ToString()
        {
            return "I am a salesemployee!";
        }
    }
}
