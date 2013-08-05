using System.Text;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal static partial class nsCSSKeywords
    {
        public static nsCSSKeyword LookupKeyword (string aKeyword)
        {
            return (nsCSSKeyword)gKeywordTable.GetOrDefault(aKeyword, -1);
        }

        public static nsCSSKeyword LookupKeyword (StringBuilder aKeyword)
        {
            return LookupKeyword(aKeyword.ToString());
        }

        public static string GetStringValue (nsCSSKeyword aKeyword)
        {
            return kCSSRawKeywords[(int)aKeyword];
        }
    }
}