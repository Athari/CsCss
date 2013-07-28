using System.Collections.Generic;
using Alba.CsCss.Extensions;

namespace Alba.CsCss
{
    internal partial class nsCSSKeywords
    {
        private readonly Dictionary<string, int> gKeywordTable = kCSSRawKeywords.ToCaseInsensitiveNameTable();

        public nsCSSKeyword LookupKeyword (string aKeyword)
        {
            return (nsCSSKeyword)gKeywordTable.GetOrDefault(aKeyword, -1);
        }

        public string GetStringValue (nsCSSKeyword aKeyword)
        {
            return kCSSRawKeywords[(int)aKeyword];
        }
    }
}