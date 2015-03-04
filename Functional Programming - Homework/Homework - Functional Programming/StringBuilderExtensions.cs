namespace StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder stringBuilder, int startIndex, int length)
        {
            string theString = stringBuilder.ToString();
            if(startIndex < 0 || length < 0 
                || startIndex > theString.Length - 1 || startIndex + length > theString.Length)
            {
                throw new ArgumentException("Wrong length or wrong startIndex!");
            }
            else
            {
                return theString.Substring(startIndex, length);
            }
        }

        public static StringBuilder RemoveText(this StringBuilder stringBuilder, string text)
        {
            stringBuilder = new StringBuilder(stringBuilder.ToString().Replace(text, ""));
            return stringBuilder;
        }

        public static void AppendAll<T>(this StringBuilder stringBuilder, IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                stringBuilder.Append(item.ToString());   
            }
        }
    }
}
