namespace Alba.CsCss.Style
{
    internal class nsCachedStyleData
    {
        public static int GetBitForSID (nsStyleStructID aSID)
        {
            return 1 << (int)aSID;
        }
    }
}