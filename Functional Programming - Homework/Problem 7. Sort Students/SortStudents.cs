namespace SortStudents
{
    using System;
    using System.Linq;
    using ClassStudent;

    class SortStudents
    {
        static void Main()
        {
            // Sorting throught lambda expressions
            StudentsMain.students.OrderByDescending(student => student.FirstName).
                ThenByDescending(student => student.LastName)
                .ToList()
                .ForEach(student => Console.WriteLine(student.ToString()));

            // Sorting throught linq query
            (from student in StudentsMain.students
             orderby student.FirstName descending, student.LastName descending
             select student)
                 .ToList()
                 .ForEach(student => Console.WriteLine(student.ToString()));

            Console.Read();
        }
    }
}
