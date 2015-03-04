namespace FilterStudentsbyPhone
{
    using System;
    using System.Linq;
    using ClassStudent;

    class FilterStudentsByPhone
    {
        static void Main()
        {
            (from student in StudentsMain.students
                 where student.Phone.StartsWith("02") 
                 || student.Phone.StartsWith("3592")
                 || student.Phone.StartsWith("+359 2")
                 select student)
                 .ToList()
                 .ForEach(student => Console.WriteLine(student.ToString()));

            Console.Read();
        }
    }
}
