namespace StudentClass
{
    using System;

    public class StudentClassTest
    {
        public static void Main()
        {
            Student student = new Student("Example", 21);
            student.PropertyChanged += (sender, eventArgs) =>
            {
                Console.WriteLine("Property changed: {0} (from {1} to {2})",
                    eventArgs.PropertyName, eventArgs.OldValue, eventArgs.NewValue);
            };
            student.Name = "Mickey";
            student.Name = "Hellboy";
            student.Age = 20;

            Console.Read();
        }
    }
}
