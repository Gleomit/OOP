namespace CompanyHierarchy.Interfaces
{
    using System;

    interface ISale
    {
        string ProductName { get; set; }
        double Price { get; set; }
        DateTime Date { get; set; }
    }
}
