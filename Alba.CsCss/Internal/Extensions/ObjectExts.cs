using System.Collections.Generic;

namespace Alba.CsCss.Internal.Extensions
{
    internal static class ObjectExts
    {
        public static nsresult Equals<T> (this T @this, T other, out bool equal)
        {
            equal = EqualityComparer<T>.Default.Equals(@this, other);
            return nsresult.OK;
        }
    }
}