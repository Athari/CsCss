using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;
using int32_t = System.Int32;

namespace Alba.CsCss.Style
{
    internal partial class nsCSSProps
    {
        public static int[] kBackgroundAttachmentKTable;
        public static int[] kBackgroundPositionKTable;
        public static int[] kBackgroundOriginKTable;
        public static int[] kBackgroundRepeatKTable;
        public static int[] kBackgroundRepeatPartKTable;
        public static int[] kBackgroundSizeKTable;
        public static int[] kBorderColorKTable;
        public static int[] kBorderImageSliceKTable;
        public static int[] kBorderImageRepeatKTable;
        public static int[] kBoxShadowTypeKTable;
        public static int[] kContentKTable;
        public static int[] kCursorKTable;
        public static int[] kColorKTable;
        public static int[] kFontKTable;
        public static int[] kFontSizeKTable;
        public static int[] kFontStretchKTable;
        public static int[] kFontStyleKTable;
        public static int[] kFontWeightKTable;
        public static int[] kListStyleKTable;
        public static int[] kObjectPatternKTable;
        public static int[] kOrientationKeywords;
        public static int[] kOverflowKTable;
        public static int[] kPageMarksKTable;
        public static int[] kPageSizeKTable;
        public static int[] kParserVariantTable;
        public static int[] kRadialGradientLegacySizeKTable;
        public static int[] kRadialGradientShapeKTable;
        public static int[] kRadialGradientSizeKTable;
        public static int[] kScanKeywords;
        public static int[] kStrokeObjectValueKTable;
        public static int[] kTextDecorationLineKTable;
        public static int[] kTextOverflowKTable;
        public static int[] kWidthKTable;

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

        public static string GetStringValue (nsCSSProperty aProperty)
        {
            return kCSSRawProperties[(int)aProperty];
        }

        public static bool IsEnabled (nsCSSProperty aProperty)
        {
            return true; // gPropertyEnabled is an array of true, so generating it is pointless
        }

        public static bool IsShorthand (nsCSSProperty aProperty)
        {
            return (aProperty >= nsCSSProperty.COUNT_no_shorthands);
        }

        public static nsCSSFontDesc LookupFontDesc (string aFontDesc)
        {
            return (nsCSSFontDesc)(gFontDescTable.GetOrDefault(aFontDesc, -1));
        }

        public static nsCSSProperty LookupProperty (string aProperty, EnabledState aEnabled)
        {
            nsCSSProperty res = (nsCSSProperty)gPropertyTable.GetOrDefault(aProperty, -1);
            if (res >= nsCSSProperty.COUNT) {
                if (IsEnabled(res) || aEnabled == EnabledState.Any) {
                    res = gAliases[res - nsCSSProperty.COUNT];
                    Debug.Assert(0 <= res && res < nsCSSProperty.COUNT, "aliases must not point to other aliases");
                }
                else {
                    res = nsCSSProperty.UNKNOWN;
                }
            }
            if (res != nsCSSProperty.UNKNOWN && aEnabled == EnabledState.Enabled && !IsEnabled(res)) {
                res = nsCSSProperty.UNKNOWN;
            }
            return res;
        }

        public static int ParserVariant (nsCSSProperty aProperty)
        {
            return kParserVariantTable[(int)aProperty];
        }

        public static bool PropHasFlags (nsCSSProperty aProperty, int aFlags)
        {
            return (kFlagsTable[(int)aProperty] & aFlags) == aFlags;
        }

        public static int PropertyParseType (nsCSSProperty aProperty)
        {
            return kFlagsTable[(int)aProperty] & PARSE_PROPERTY_MASK;
        }

        public static nsCSSProperty[] SubpropertyEntryFor (nsCSSProperty aProperty, bool skipUnknown = false)
        {
            // skipUnknown === Where(p => p != Unknown)
            nsCSSProperty[] res = kSubpropertyTable[aProperty - nsCSSProperty.COUNT_no_shorthands];
            return skipUnknown ? res.Where(p => p != nsCSSProperty.UNKNOWN).ToArray() : res;
        }

        public static int ValueRestrictions (nsCSSProperty aProperty)
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