using Alba.CsCss.Internal.Extensions;

// TODO Convert sources from nsCSSPseudoClasses.cpp instead of copypasting
namespace Alba.CsCss.Style
{
    internal static partial class nsCSSPseudoClasses
    {
        public static CssPseudoClass GetPseudoType (string aAtom)
        {
            return sPseudoClasses.GetOrDefault(aAtom, CssPseudoClass.NotPseudoClass);
        }

        public static bool HasSelectorListArg (CssPseudoClass aType)
        {
            return aType == CssPseudoClass.Any;
        }

        public static bool HasStringArg (CssPseudoClass aType)
        {
            return aType == CssPseudoClass.Lang ||
                   aType == CssPseudoClass.MozEmptyExceptChildrenWithLocalname ||
                   aType == CssPseudoClass.MozSystemMetric ||
                   aType == CssPseudoClass.MozLocaleDir ||
                   aType == CssPseudoClass.Dir;
        }

        public static bool HasNthPairArg (CssPseudoClass aType)
        {
            return aType == CssPseudoClass.NthChild ||
                   aType == CssPseudoClass.NthLastChild ||
                   aType == CssPseudoClass.NthOfType ||
                   aType == CssPseudoClass.NthLastOfType;
        }
    }
}