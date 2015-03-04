namespace WeakStudents
{
    using System;
    using System.Linq;
    using ClassStudent;

    public class WeakStudents
    {
        public static void Main()
        {
            StudentsMain.students.Where(student => student.Marks.Count(mark => mark == 2) == 2)
                .Select(student => new { FullName = string.Format("{0} - {1}", student.FirstName, student.LastName), Marks = student.Marks })
                .ToList()
                .ForEach(student => Console.WriteLine(
                    string.Format("\nFullName - {0}\nMarks: {1}\n", student.FullName, string.Join(", ", student.Marks))));

            Console.Read();
        }
    }
}
