namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CompanyHierarchy;
    using CompanyHierarchy.Enumerations;
    using CompanyHierarchy.Employees;

    public class CompanyHierarchyTest
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            Manager manager = new Manager(321, "test", "dasdsa", 203, Department.Production);
            SalesEmployee salesemployee = new SalesEmployee(321, "test", "dasdsa", 203, Department.Production, new List<Sale>() { });
            Developer developer = new Developer(321, "test", "dasdsa", 203, Department.Production, new List<Project>() {  });
            employees.Add(manager);
            employees.Add(salesemployee);
            employees.Add(developer);

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
            Console.ReadKey();
        }
    }
}
