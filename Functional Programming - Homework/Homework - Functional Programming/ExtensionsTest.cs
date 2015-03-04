namespace HomeworkFunctionalProgramming
{
    using System;
    using System.Text;
    using StringBuilderExtensions;

    public class ExtensionsTest
    {
        static void Main()
        {
            StringBuilder builder = new StringBuilder("blqblq");
          
            Console.WriteLine(builder.Substring(1, 5));
            Console.Read();
        }
    }
}
