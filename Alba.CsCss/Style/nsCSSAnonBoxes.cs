namespace Alba.CsCss.Style
{
    // internal mozilla stuff no one cares about
    internal static class nsCSSAnonBoxes
    {
        public static bool IsAnonBox (string aAtom)
        {
            return false;
        }

        public static bool IsTreePseudoElement (string aAtom)
        {
            return false;
        }
    }
}