namespace StudentsJoinedToSpecialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ClassStudent;

    public class StudentsJoinedTest
    {
        public static void Main()
        {
            List<StudentSpecialty> studentSpecialties = new List<StudentSpecialty>()
            {
                new StudentSpecialty("Testovo", 123456),
                new StudentSpecialty("Advanced", 678910)
            };

            (from specialty in studentSpecialties 
             join student in StudentsMain.students on specialty.FacultyNumber equals student.FacultyNumber
                 orderby student.FirstName
                 select new
                 {
                     StudentName = student.FirstName,
                     FacultyNumber = student.FacultyNumber,
                     SpecialtyName = specialty.SpecialtyName
                 })
                 .ToList()
                 .ForEach(student => Console.WriteLine(
                     string.Format("{0} {1} {2}", student.StudentName, 
                     student.FacultyNumber, student.SpecialtyName)));

            Console.Read();
        }
    }
}
