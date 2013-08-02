using Alba.CsCss.Extensions;

namespace Alba.CsCss.Style
{
    internal static partial class nsCSSKeywords
    {
        public static nsCSSKeyword LookupKeyword (string aKeyword)
        {
            return (nsCSSKeyword)gKeywordTable.GetOrDefault(aKeyword, -1);
        }

        public static string GetStringValue (nsCSSKeyword aKeyword)
        {
            return kCSSRawKeywords[(int)aKeyword];
        }
    }
}