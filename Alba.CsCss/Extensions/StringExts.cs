using System;

namespace Alba.CsCss.Extensions
{
    internal static class StringExts
    {
        public static bool EqualsLiteral (this string @this, string value)
        {
            return string.Equals(@this, value, StringComparison.Ordinal);
        }
    }
}