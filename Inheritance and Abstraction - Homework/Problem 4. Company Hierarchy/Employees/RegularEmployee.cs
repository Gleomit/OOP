namespace CompanyHierarchy.Employees
{
    using CompanyHierarchy.Enumerations;

    class RegularEmployee : Employee
    {
        public RegularEmployee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            
        }

        public override string ToString()
        {
            return "I am a regular employee!";
        }
    }
}
