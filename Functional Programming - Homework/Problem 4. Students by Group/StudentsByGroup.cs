namespace StudentsbyGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using ClassStudent;

    class StudentsByGroup
    {
        static void Main()
        {
            (from student in StudentsMain.students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student).
                ToList().
                ForEach(student => Console.WriteLine(student.ToString()));
            
            Console.Read();
        }
    }
}
