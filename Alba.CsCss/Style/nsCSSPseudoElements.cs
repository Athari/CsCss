namespace Alba.CsCss.Style
{
    internal static partial class nsCSSPseudoElements
    {
        public static nsCSSPseudoElement GetPseudoType (string aAtom)
        {
            nsCSSPseudoElement res;
            if (sPseudoElements.TryGetValue(aAtom, out res))
                return res;
            if (nsCSSAnonBoxes.IsAnonBox(aAtom)) {
#if MOZ_XUL
                if (nsCSSAnonBoxes.IsTreePseudoElement(aAtom))
                    return nsCSSPseudoElement.XULTree;
#endif
                return nsCSSPseudoElement.AnonBox;
            }
            return nsCSSPseudoElement.NotPseudoElement;
        }

        public static bool IsCSS2PseudoElement (string aAtom)
        {
            bool result = aAtom == after ||
                          aAtom == before ||
                          aAtom == firstLetter ||
                          aAtom == firstLine;
            return result;
        }
    }
}