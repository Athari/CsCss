using System;
using System.Collections.Generic;

namespace Alba.CsCss.Extensions
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
    }
}