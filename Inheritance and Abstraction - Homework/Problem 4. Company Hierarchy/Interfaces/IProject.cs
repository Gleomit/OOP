namespace CompanyHierarchy.Interfaces
{
    using System;
    using CompanyHierarchy.Enumerations;

    interface IProject
    {
        string ProjectName{get;set;}
        DateTime ProjectStartDate { get; set; }
        State State { get; }

        void CloseProject();
    }
}
