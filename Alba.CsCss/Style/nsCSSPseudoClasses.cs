using Alba.CsCss.Extensions;

// TODO Convert sources from nsCSSPseudoClasses.cpp instead of copypasting
namespace Alba.CsCss.Style
{
    internal static partial class nsCSSPseudoClasses
    {
        public static nsCSSPseudoClass GetPseudoType (string aAtom)
        {
            return sPseudoClasses.GetOrDefault(aAtom, nsCSSPseudoClass.NotPseudoClass);
        }

        public static bool HasSelectorListArg (nsCSSPseudoClass aType)
        {
            return aType == nsCSSPseudoClass.any;
        }

        public static bool HasStringArg (nsCSSPseudoClass aType)
        {
            return aType == nsCSSPseudoClass.lang ||
                   aType == nsCSSPseudoClass.mozEmptyExceptChildrenWithLocalname ||
                   aType == nsCSSPseudoClass.mozSystemMetric ||
                   aType == nsCSSPseudoClass.mozLocaleDir ||
                   aType == nsCSSPseudoClass.dir;
        }

        public static bool HasNthPairArg (nsCSSPseudoClass aType)
        {
            return aType == nsCSSPseudoClass.nthChild ||
                   aType == nsCSSPseudoClass.nthLastChild ||
                   aType == nsCSSPseudoClass.nthOfType ||
                   aType == nsCSSPseudoClass.nthLastOfType;
        }
    }
}