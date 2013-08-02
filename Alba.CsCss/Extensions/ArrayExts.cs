namespace Alba.CsCss.Extensions
{
    internal static class ArrayExts
    {
        public static T Item<T> (this T[] @this, int index)
        {
            return @this[index];
        }
    }
}