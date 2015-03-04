namespace Studentsby_Groups
{
    using System;
    using System.Linq;
    using ClassStudent;

    public class StudentsByGroup
    {
        public static void Main()
        {
            (from student in StudentsMain.students
                group student by student.GroupName into groups
                    select groups)
                    .ToList()
                    .ForEach(group => Console.WriteLine(
                        string.Format("\n\nGroup name - {0}:\n{1}", group.Key,
                        string.Join("\n", group.Select(student => student.ToString())))));

            Console.Read();
        }
    }
}
