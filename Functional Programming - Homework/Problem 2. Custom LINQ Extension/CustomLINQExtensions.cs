namespace CustomLINQExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class CustomLINQExtensions
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return collection.Where(item => predicate(item) == false);
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int count) 
        {
            IEnumerable<T> result = collection;
            for (int i = 0; i < count; i++)
            {
                result = result.Concat(collection);
            }
            return result;
        }

        public static IEnumerable<string> WhereEndsWith<T>(this IEnumerable<string> collection, IEnumerable<string> suffixes)
        {
            return (from item in collection
                    from suffix in suffixes
                where item.ToString().EndsWith(suffix)
                select item);
        }
    }
}
