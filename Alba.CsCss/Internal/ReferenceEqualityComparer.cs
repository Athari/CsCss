using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Alba.CsCss.Internal
{
    internal class ReferenceEqualityComparer<T> : IEqualityComparer<T>
    {
        private static ReferenceEqualityComparer<T> _default;

        public static IEqualityComparer<T> Default
        {
            get { return _default ?? (_default = new ReferenceEqualityComparer<T>()); }
        }

        public bool Equals (T x, T y)
        {
            return ReferenceEquals(x, y);
        }

        public int GetHashCode (T obj)
        {
            return RuntimeHelpers.GetHashCode(obj);
        }
    }
}