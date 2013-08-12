using System;
using System.Collections.Generic;

namespace Alba.CsCss.Internal.Extensions
{
    /// <summary>Copied from Alba.Framework to avoid referencing.</summary>
    internal static class DictionaryExts
    {
        public static TValue GetOrDefault<TKey, TValue> (this IDictionary<TKey, TValue> @this, TKey key, TValue defaultValue = default(TValue))
        {
            TValue value;
            return @this.TryGetValue(key, out value) ? value : defaultValue;
        }

        public static TValue GetOrDefault<TKey, TValue> (this IDictionary<TKey, TValue> @this, TKey key, Func<TValue> getDefaultValue)
        {
            TValue value;
            return @this.TryGetValue(key, out value) ? value : getDefaultValue();
        }

        public static TValue? GetNullableOrDefault<TKey, TValue> (this IDictionary<TKey, TValue> @this, TKey key, TValue? defaultValue = null)
            where TValue : struct
        {
            TValue value;
            return @this.TryGetValue(key, out value) ? value : defaultValue;
        }
    }
}