namespace CompanyHierarchy.Interfaces
{
    using CompanyHierarchy.Enumerations;

    interface IManager
    {
        double Salary { get; set; }
        Department Department { get; set; }
    }
}
