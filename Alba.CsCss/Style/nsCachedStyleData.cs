namespace Alba.CsCss.Style
{
    internal class nsCachedStyleData
    {
        public static int GetBitForSID (int /*nsStyleStructID*/ aSID)
        {
            return 1 << aSID;
        }
    }
}