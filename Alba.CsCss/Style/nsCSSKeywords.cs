using System.Text;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal static partial class nsCSSKeywords
    {
        public static CssKeyword LookupKeyword (string aKeyword)
        {
            return (CssKeyword)gKeywordTable.GetOrDefault(aKeyword, -1);
        }

        public static CssKeyword LookupKeyword (StringBuilder aKeyword)
        {
            return LookupKeyword(aKeyword.ToString());
        }

        public static string GetStringValue (CssKeyword aKeyword)
        {
            return kCSSRawKeywords[(int)aKeyword];
        }
    }
}