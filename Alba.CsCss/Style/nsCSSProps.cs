using System;

namespace Alba.CsCss.Style
{
    internal partial class nsCSSProps
    {
        public static object eEnabled;
        public static int[] kColorKTable;
        public static int[] kListStyleKTable;
        public static int[] kWidthKTable;
        public static int[] kRadialGradientShapeKTable;
        public static int[] kRadialGradientLegacySizeKTable;
        public static int[] kRadialGradientSizeKTable;
        public static int[] kBackgroundPositionKTable;
        public static int[] kKeywordTableTable;
        public static int[] kFontStyleKTable;
        public static int[] kFontStretchKTable;
        public static int[] kBackgroundAttachmentKTable;
        public static int[] kBackgroundRepeatKTable;
        public static int[] kBackgroundOriginKTable;
        public static int[] kBackgroundRepeatPartKTable;
        public static int[] kBackgroundSizeKTable;
        public static int[] kBorderImageSliceKTable;
        public static int[] kBorderImageRepeatKTable;
        public static int[] kBorderColorKTable;
        public static int[] kContentKTable;
        public static int[] kCursorKTable;
        public static int[] kFontKTable;
        public static int[] kFontSizeKTable;
        public static int[] kFontWeightKTable;
        public static int[] kPageMarksKTable;
        public static int[] kOverflowKTable;
        public static int[] kPageSizeKTable;
        public static int[] kTextDecorationLineKTable;
        public static int[] kTextOverflowKTable;
        public static int[] kBoxShadowTypeKTable;
        public static int[] kObjectPatternKTable;
        public static int[] kStrokeObjectValueKTable;

        public static bool FindKeyword (nsCSSKeyword keyword, object kListStyleKTable, int type)
        {
            throw new NotImplementedException();
        }

        public static nsCSSFontDesc LookupFontDesc (string descName)
        {
            throw new NotImplementedException();
        }

        public static bool IsEnabled (nsCSSProperty aPropId)
        {
            throw new NotImplementedException();
        }

        public static string GetStringValue (nsCSSProperty aPropId)
        {
            throw new NotImplementedException();
        }

        public static nsCSSProperty LookupProperty (string aProperty, object eEnabled)
        {
            throw new NotImplementedException();
        }

        public static bool PropHasFlags (nsCSSProperty propId, int appliesToPageRule)
        {
            throw new NotImplementedException();
        }

        public static int ParserVariant (nsCSSProperty flexBasis)
        {
            throw new NotImplementedException();
        }

        public static nsCSSProperty[] SubpropertyEntryFor (nsCSSProperty aProperty)
        {
            throw new NotImplementedException();
        }

        public static int PropertyParseType (nsCSSProperty aPropId)
        {
            throw new NotImplementedException();
        }

        public static int ValueRestrictions (nsCSSProperty aPropId)
        {
            throw new NotImplementedException();
        }
    }
}