namespace Alba.CsCss.Extensions
{
    internal static class ArrayExts
    {
        public static T Item<T> (this T[] @this, int index)
        {
            return @this[index];
        }

        public static int FindChar (this char[] @this, char ch)
        {
            for (int i = 0; i < @this.Length; i++)
                if (@this[i] == ch)
                    return i;
            return -1;
        }
    }
}