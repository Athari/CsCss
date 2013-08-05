using System;
using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Internal.Extensions
{
    internal static class EnumerableExts
    {
        public static Dictionary<string, int> ToCaseInsensitiveNameTable (this IEnumerable<string> @this)
        {
            var dic = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            int i = 0;
            foreach (string str in @this)
                dic.Add(str, i++);
            return dic;
        }

        public static bool IsEmpty<T> (this IEnumerable<T> @this)
        {
            return !@this.Any();
        }
    }
}