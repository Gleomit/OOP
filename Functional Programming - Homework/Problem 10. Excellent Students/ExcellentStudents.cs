namespace ExcellentStudents
{
    using System;
    using System.Linq;
    using ClassStudent;

    class ExcellentStudents
    {
        static void Main()
        {
            (from student in StudentsMain.students
             where student.Marks.Contains(6)
             select new { FullName = string.Format("{0} - {1}", student.FirstName, student.LastName), Marks = student.Marks })
                 .ToList()
                 .ForEach(student => Console.WriteLine(
                     string.Format("\nFullName - {0}\nMarks: {1}\n", student.FullName, string.Join(", ", student.Marks))));
            
            Console.Read();
        }
    }
}
