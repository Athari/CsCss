namespace Alba.CsCss
{
    internal static class nsresultExts
    {
        public static bool Succeeded (this nsresult @this)
        {
            return ((uint)@this & 0x80000000) == 0;
        }

        public static bool Failed (this nsresult @this)
        {
            return ((uint)@this & 0x80000000) != 0;
        }
    }
}