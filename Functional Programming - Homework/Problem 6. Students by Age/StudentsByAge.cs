namespace StudentsbyAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using ClassStudent;

    class StudentsByAge
    {
        static void Main()
        {
            (from student in StudentsMain.students
                where student.Age >= 18 && student.Age <= 24
                select new List<string>() { student.FirstName, student.LastName, student.Age.ToString() })
                .ToList()
                .ForEach(student => Console.WriteLine(string.Join(", ", student)));

            Console.Read();
        }
    }
}
