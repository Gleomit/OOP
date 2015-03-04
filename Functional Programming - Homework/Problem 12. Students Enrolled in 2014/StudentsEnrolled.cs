namespace StudentsEnrolledIn2014
{
    using System;
    using System.Linq;
    using ClassStudent;

    public class StudentsEnrolled
    {
        public static void Main()
        {
            StudentsMain.students.Where(student => student.FacultyNumber.ToString()[4] == '1'
                && student.FacultyNumber.ToString()[5] == '4')
                .Select(student => 
                    new 
                    { 
                    FullName = string.Format("{0} - {1}", student.FirstName, student.LastName),
                    Marks = student.Marks,
                    FacultyNumber = student.FacultyNumber
                })
                .ToList()
                .ForEach(student => 
                    Console.WriteLine(
                    string.Format("Full name - {0}\nFaculty number - {1}\nMarks{2}", student.FullName,
                    student.FacultyNumber, string.Join(", ", student.Marks))));        

            Console.Read();
        }
    }
}
