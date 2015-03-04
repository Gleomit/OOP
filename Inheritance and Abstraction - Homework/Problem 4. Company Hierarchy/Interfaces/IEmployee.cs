namespace CompanyHierarchy.Interfaces
{
    using CompanyHierarchy.Enumerations;

    interface IEmployee
    {
        double Salary { get; set; }
        Department Department { get; set; }
    }
}
