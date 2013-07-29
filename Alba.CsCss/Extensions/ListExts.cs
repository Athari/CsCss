using System.Collections.Generic;

namespace Alba.CsCss.Extensions
{
    internal static class ListExts
    {
        public static void AppendElement<T> (this IList<T> @this, T item)
        {
            @this.Add(item);
        }

        public static void RemoveElementAt<T> (this IList<T> @this, int index)
        {
            @this.RemoveAt(index);
        }

        public static int Length<T> (this IList<T> @this)
        {
            return @this.Count;
        }
    }
}