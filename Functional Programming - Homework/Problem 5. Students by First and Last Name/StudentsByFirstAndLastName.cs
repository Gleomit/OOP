namespace Problem_5.Students_by_First_and_Last_Name
{
    using System;
    using System.Linq;
    using ClassStudent;

    class StudentsByFirstAndLastName
    {
        static void Main()
        {
            (from student in StudentsMain.students
             where student.FirstName.CompareTo(student.LastName) < 0
             select student)
                .ToList()
                .ForEach(student => Console.WriteLine(student.ToString()));

            Console.Read();
        }
    }
}
