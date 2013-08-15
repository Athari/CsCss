using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;
using int32_t = System.Int32;

namespace Alba.CsCss.Style
{
    internal partial class nsCSSProps
    {
        private static int FindIndexOfKeyword (nsCSSKeyword aKeyword, int[] aTable)
        {
            int32_t index = 0;
            while ((nsCSSKeyword)(aTable[index]) != nsCSSKeyword.UNKNOWN) {
                if ((nsCSSKeyword)(aTable[index]) == aKeyword)
                    return index;
                index += 2;
            }
            return -1;
        }

        public static bool FindKeyword (nsCSSKeyword aKeyword, int[] aTable, ref int aResult)
        {
            int32_t index = FindIndexOfKeyword(aKeyword, aTable);
            if (index >= 0) {
                aResult = aTable[index + 1];
                return true;
            }
            return false;
        }

        public static string GetStringValue (CssProperty aProperty)
        {
            return kCSSRawProperties[(int)aProperty];
        }

        public static bool IsEnabled (CssProperty aProperty)
        {
            return true; // gPropertyEnabled is an array of true, so generating it is pointless
        }

        public static bool IsShorthand (CssProperty aProperty)
        {
            return (aProperty >= CssProperty.COUNT_no_shorthands);
        }

        public static nsCSSFontDesc LookupFontDesc (string aFontDesc)
        {
            return (nsCSSFontDesc)(gFontDescTable.GetOrDefault(aFontDesc, -1));
        }

        public static CssProperty LookupProperty (string aProperty, EnabledState aEnabled)
        {
            CssProperty res = (CssProperty)gPropertyTable.GetOrDefault(aProperty, -1);
            if (res >= CssProperty.COUNT) {
                if (IsEnabled(res) || aEnabled == EnabledState.Any) {
                    res = gAliases[res - CssProperty.COUNT];
                    Debug.Assert(0 <= res && res < CssProperty.COUNT, "aliases must not point to other aliases");
                }
                else {
                    res = CssProperty.UNKNOWN;
                }
            }
            if (res != CssProperty.UNKNOWN && aEnabled == EnabledState.Enabled && !IsEnabled(res)) {
                res = CssProperty.UNKNOWN;
            }
            return res;
        }

        public static int ParserVariant (CssProperty aProperty)
        {
            return kParserVariantTable[(int)aProperty];
        }

        public static bool PropHasFlags (CssProperty aProperty, int aFlags)
        {
            return (kFlagsTable[(int)aProperty] & aFlags) == aFlags;
        }

        public static int PropertyParseType (CssProperty aProperty)
        {
            return kFlagsTable[(int)aProperty] & PARSE_PROPERTY_MASK;
        }

        public static CssProperty[] SubpropertyEntryFor (CssProperty aProperty, bool skipUnknown = false)
        {
            CssProperty[] res = kSubpropertyTable[aProperty - CssProperty.COUNT_no_shorthands];
            return skipUnknown ? res.Where(p => p != CssProperty.UNKNOWN).ToArray() : res;
        }

        public static int ValueRestrictions (CssProperty aProperty)
        {
            return kFlagsTable[(int)aProperty] & VALUE_RESTRICTION_MASK;
        }

        internal enum EnabledState
        {
            Enabled,
            Any
        };
    }
}