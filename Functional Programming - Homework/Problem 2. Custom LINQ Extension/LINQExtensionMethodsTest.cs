using System.Collections.Generic;
using System.Linq;

namespace CustomLINQExtension
{
    using System;

    public class LINQExtensionMethodsTest
    {
        static void Main()
        {
            List<string> temp = new List<string>()
            {
                "test",
                "example",
                "apple"
            };

            Console.WriteLine(string.Join(", ", temp.WhereEndsWith<string>(new List<string>(){"e"})));
            Console.Read();
        }
    }
}
