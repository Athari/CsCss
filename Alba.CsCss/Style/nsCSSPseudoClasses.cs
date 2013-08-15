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
            return aType == CssPseudoClass.any;
        }

        public static bool HasStringArg (CssPseudoClass aType)
        {
            return aType == CssPseudoClass.lang ||
                   aType == CssPseudoClass.mozEmptyExceptChildrenWithLocalname ||
                   aType == CssPseudoClass.mozSystemMetric ||
                   aType == CssPseudoClass.mozLocaleDir ||
                   aType == CssPseudoClass.dir;
        }

        public static bool HasNthPairArg (CssPseudoClass aType)
        {
            return aType == CssPseudoClass.nthChild ||
                   aType == CssPseudoClass.nthLastChild ||
                   aType == CssPseudoClass.nthOfType ||
                   aType == CssPseudoClass.nthLastOfType;
        }
    }
}