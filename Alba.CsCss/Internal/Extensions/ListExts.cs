using System.Collections.Generic;

namespace Alba.CsCss.Internal.Extensions
{
    internal static class ListExts
    {
        public static T AppendElement<T> (this IList<T> @this, T item)
        {
            @this.Add(item);
            return item;
        }

        public static T AppendElement<T> (this IList<T> @this) where T : new()
        {
            var item = new T();
            @this.Add(item);
            return item;
        }

        public static T ElementAt<T> (this IList<T> @this, int index)
        {
            return @this[index];
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