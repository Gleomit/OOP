namespace FilterStudentsbyEmailDomain
{
    using System;
    using System.Linq;
    using ClassStudent;

    class FilterStudentsByEmailDomain
    {
        static void Main()
        {
            (from student in StudentsMain.students
             where student.Email.Contains("@abv.bg")
             select student)
             .ToList()
             .ForEach(student => Console.WriteLine(student.ToString()));

            Console.Read();
        }
    }
}
