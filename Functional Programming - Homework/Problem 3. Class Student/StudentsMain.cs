namespace ClassStudent
{
    using System.Collections.Generic;

    public class StudentsMain
    {
        public static List<Student> students = LoadStudents();

        private static List<Student> LoadStudents()
        {
            return new List<Student>()
            {
                new Student("Sara","Mills", 10, 4324147, "", "smills0@marketwatch.com	", new List<int>(){}, 2, "FirstGroup"),
                new Student("Daniel	", "Carter", 18, 123456, "", "", new List<int>(){}, 1, "FirstGroup"),
                new Student("Aaron	", "Gibson", 19, 432423, "", "", new List<int>(){}, 2, "FirstGroup"),
                new Student("William", "Alexander", 20, 678910, "", "", new List<int>(){}, 1, "SecondGroup"),
                new Student("Mildred", "Hansen", 21, 432423, "", "", new List<int>(){6}, 2, "FirstGroup"),
                new Student("Antonio", "Gonzalez", 10, 432423, "", "", new List<int>(){6}, 3, "SecondGroup"),
                new Student("Cheryl", "Gray", 10, 432423, "", "", new List<int>(){2, 2}, 2, "FirstGroup")
            };
        }

        static void Main()
        {

        }
    }
}
