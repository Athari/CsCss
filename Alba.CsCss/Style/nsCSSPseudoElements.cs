namespace Alba.CsCss.Style
{
    internal static partial class nsCSSPseudoElements
    {
        public static CssPseudoElement GetPseudoType (string aAtom)
        {
            CssPseudoElement res;
            if (sPseudoElements.TryGetValue(aAtom, out res))
                return res;
            if (nsCSSAnonBoxes.IsAnonBox(aAtom)) {
#if MOZ_XUL
                if (nsCSSAnonBoxes.IsTreePseudoElement(aAtom))
                    return CssPseudoElement.XULTree;
#endif
                return CssPseudoElement.AnonBox;
            }
            return CssPseudoElement.NotPseudoElement;
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