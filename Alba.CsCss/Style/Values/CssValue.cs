using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Alba.CsCss.Gfx;
using int32_t = System.Int32;

// TODO Convert unit type checks from nsCSSValue.h instead of copy-pasting
// ReSharper disable NonReadonlyFieldInGetHashCode
namespace Alba.CsCss.Style
{
    using ICalcOpsInput = ICalcOpsInput<CssValue>;

    [DebuggerDisplay ("{mValue}")]
    public struct CssValue : ICalcOpsInput<CssValue>, IEquatable<CssValue>
    {
        internal static readonly CssValue NullValue = new CssValue();

        private CssUnit mUnit /*= CssUnit.Null*/;
        private object mValue;
        /*union {
            int32_t                     mInt;
            float                       mFloat;
            nsStringBuffer*             mString;
            nscolor                     mColor;
            Array*                      mArray;
            mozilla::css::URLValue*     mURL;
            mozilla::css::ImageValue*   mImage;
            nsCSSValueGradient*         mGradient;
            nsCSSValuePair_heap*        mPair;
            nsCSSRect_heap*             mRect;
            nsCSSValueTriplet_heap*     mTriplet;
            nsCSSValueList_heap*        mList;
            nsCSSValueList*             mListDependent;
            nsCSSValuePairList_heap*    mPairList;
            nsCSSValuePairList*         mPairListDependent;
        } mValue;*/

        internal CssValue (CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = null;
        }

        internal CssValue (CssValue aValue)
        {
            mUnit = aValue.mUnit;
            mValue = aValue.mValue;
        }

        internal CssValue (int32_t aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit == CssUnit.Integer || aUnit == CssUnit.Enumerated || aUnit == CssUnit.EnumColor)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal CssValue (float aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit >= CssUnit.Percent)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal CssValue (string aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasStringValue() && mValue != null)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal CssValue (CssValue[] aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasArrayValue() && mValue != null)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal CssUnit GetUnit ()
        {
            return mUnit;
        }

        internal int GetIntValue ()
        {
            return (int)mValue;
        }

        internal float GetFloatValue ()
        {
            return (float)mValue;
        }

        internal float GetPercentValue ()
        {
            return (float)mValue;
        }

        internal float GetAngleValue ()
        {
            return (float)mValue;
        }

        internal float GetAngleValueInRadians ()
        {
            double angle = GetAngleValue();
            switch (GetUnit()) {
                case CssUnit.Radian:
                    return (float)angle;
                case CssUnit.Turn:
                    return (float)(angle * 2 * Math.PI);
                case CssUnit.Degree:
                    return (float)(angle * Math.PI / 180.0);
                case CssUnit.Grad:
                    return (float)(angle * Math.PI / 200.0);
                default:
                    return (float)0.0;
            }
        }

        // ReSharper disable once RedundantAssignment

        internal void GetStringValue (ref string valueStr)
        {
            valueStr = GetStringBufferValue();
        }

        internal string GetStringBufferValue ()
        {
            return (string)mValue;
        }

        internal CssValue[] GetArrayValue ()
        {
            return (CssValue[])mValue;
        }

        internal Uri GetURLValue ()
        {
            return GetURLStructValue().GetURI();
        }

        internal string GetOriginalURLValue ()
        {
            return GetURLStructValue().mString;
        }

        internal CssUriValue GetURLStructValue ()
        {
            return (CssUriValue)mValue;
        }

        internal CssColor GetColorValue ()
        {
            return (CssColor)mValue;
        }

        internal CssValueGradient GetGradientValue ()
        {
            return (CssValueGradient)mValue;
        }

        internal CssRect GetRectValue ()
        {
            return (CssRect)mValue;
        }

        internal CssValueList GetListValue ()
        {
            return (CssValueList)mValue;
        }

        internal CssValuePair GetPairValue ()
        {
            return (CssValuePair)mValue;
        }

        internal CssValueTriplet GetTripletValue ()
        {
            return (CssValueTriplet)mValue;
        }

        internal CssValuePairList GetPairListValue ()
        {
            return (CssValuePairList)mValue;
        }

        internal void SetIntValue (int aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetFloatValue (float aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetFloatValue (double aValue, CssUnit aUnit)
        {
            SetFloatValue((float)aValue, aUnit);
        }

        internal void SetPercentValue (float aValue)
        {
            mUnit = CssUnit.Percent;
            mValue = aValue;
        }

        internal void SetStringValue (string aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasStringValue() && aValue != null)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal void SetStringValue (StringBuilder aValue, CssUnit aUnit)
        {
            SetStringValue(aValue.ToString(), aUnit);
        }

        internal void SetArrayValue (CssValue[] aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetURLValue (CssUriValue aValue)
        {
            mUnit = CssUnit.Url;
            mValue = aValue;
        }

        internal void SetColorValue (CssColor aValue)
        {
            mUnit = CssUnit.Color;
            mValue = aValue;
        }

        internal void SetGradientValue (CssValueGradient aValue)
        {
            mUnit = CssUnit.Gradient;
            mValue = aValue;
        }

        internal CssRect SetRectValue ()
        {
            var value = new CssRect();
            mUnit = CssUnit.Rect;
            mValue = value;
            return value;
        }

        internal CssValueList SetListValue ()
        {
            var value = new CssValueList();
            mUnit = CssUnit.List;
            mValue = value;
            return value;
        }

        internal void SetPairValue (CssValuePair aValue)
        {
            mUnit = CssUnit.Pair;
            mValue = aValue;
        }

        internal void SetPairValue (CssValue xValue, CssValue yValue)
        {
            SetPairValue(new CssValuePair { mXValue = xValue, mYValue = yValue });
        }

        internal void SetTripletValue (CssValueTriplet aValue)
        {
            mUnit = CssUnit.Triplet;
            mValue = aValue;
        }

        internal void SetTripletValue (CssValue xValue, CssValue yValue, CssValue zValue)
        {
            SetTripletValue(new CssValueTriplet { mXValue = xValue, mYValue = yValue, mZValue = zValue });
        }

        internal CssValuePairList SetPairListValue ()
        {
            var value = new CssValuePairList();
            mUnit = CssUnit.PairList;
            mValue = value;
            return value;
        }

        internal CssValue[] InitFunction (CssKeyword aFunctionId, int aNumArgs)
        {
            var value = new CssValue[aNumArgs + 1];
            value[0].SetIntValue((int)aFunctionId, CssUnit.Enumerated);
            SetArrayValue(value, CssUnit.Function);
            return value;
        }

        internal void SetAutoValue ()
        {
            mUnit = CssUnit.Auto;
            mValue = null;
        }

        internal void SetInheritValue ()
        {
            mUnit = CssUnit.Inherit;
            mValue = null;
        }

        internal void SetInitialValue ()
        {
            mUnit = CssUnit.Initial;
            mValue = null;
        }

        internal void SetNoneValue ()
        {
            mUnit = CssUnit.None;
            mValue = null;
        }

        internal void SetAllValue ()
        {
            mUnit = CssUnit.All;
            mValue = null;
        }

        internal void SetNormalValue ()
        {
            mUnit = CssUnit.Normal;
            mValue = null;
        }

        internal void SetSystemFontValue ()
        {
            mUnit = CssUnit.SystemFont;
            mValue = null;
        }

        internal void Reset ()
        {
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal bool IsLengthUnit ()
        {
            return CssUnit.PhysicalMillimeter <= mUnit && mUnit <= CssUnit.Pixel;
        }

        internal bool IsFixedLengthUnit ()
        {
            return mUnit == CssUnit.PhysicalMillimeter;
        }

        internal bool IsRelativeLengthUnit ()
        {
            return CssUnit.Em <= mUnit && mUnit <= CssUnit.RootEm;
        }

        internal bool IsPixelLengthUnit ()
        {
            return CssUnit.Point <= mUnit && mUnit <= CssUnit.Pixel;
        }

        internal bool IsAngularUnit ()
        {
            return CssUnit.Degree <= mUnit && mUnit <= CssUnit.Turn;
        }

        internal bool IsFrequencyUnit ()
        {
            return CssUnit.Hertz <= mUnit && mUnit <= CssUnit.Kilohertz;
        }

        internal bool IsTimeUnit ()
        {
            return CssUnit.Seconds <= mUnit && mUnit <= CssUnit.Milliseconds;
        }

        internal bool IsCalcUnit ()
        {
            return CssUnit.Calc <= mUnit && mUnit <= CssUnit.CalcDivided;
        }

        internal static string BufferFromString (string str)
        {
            return str;
        }

        internal bool UnitHasStringValue ()
        {
            return CssUnit.String <= mUnit && mUnit <= CssUnit.Element;
        }

        internal bool UnitHasArrayValue ()
        {
            return CssUnit.Array <= mUnit && mUnit <= CssUnit.CalcDivided;
        }

        // Comparison

        public bool Equals (CssValue other)
        {
            return mUnit == other.mUnit && Equals(mValue, other.mValue);
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(obj, null) && obj is CssValue && Equals((CssValue)obj);
        }

        public override int GetHashCode ()
        {
            return unchecked(((int)mUnit * 397) ^ (mValue != null ? mValue.GetHashCode() : 0));
        }

        public static bool operator == (CssValue left, CssValue right)
        {
            return left.Equals(right);
        }

        public static bool operator != (CssValue left, CssValue right)
        {
            return !left.Equals(right);
        }

        public override string ToString ()
        {
            return mValue.ToString();
        }

        // Public interface

        public CssUnit Unit
        {
            get { return GetUnit(); }
        }

        public int Int
        {
            get { return GetIntValue(); }
        }

        public float Float
        {
            get { return GetFloatValue(); }
        }

        public float Percent
        {
            get { return GetPercentValue(); }
        }

        public float Angle
        {
            get { return GetAngleValue(); }
        }

        public float AngleInRadians
        {
            get { return GetAngleValueInRadians(); }
        }

        public string String
        {
            get { return GetStringBufferValue(); }
        }

        public IList<CssValue> Array
        {
            get { return GetArrayValue(); }
        }

        public Uri Uri
        {
            get { return GetURLValue(); }
        }

        public string OriginalUri
        {
            get { return GetOriginalURLValue(); }
        }

        public CssColor Color
        {
            get { return GetColorValue(); }
        }

        public CssColor CalculatedColor
        {
            get
            {
                switch (GetUnit()) {
                    case CssUnit.Color:
                        return Color;
                    case CssUnit.Ident:
                        var result = new CssColor();
                        if (CssColor.ColorNameToRGB(String, ref result))
                            return result;
                        else
                            throw new InvalidOperationException(string.Format("Unknown color name: {0}", String));
                    default:
                        throw new InvalidOperationException(string.Format("Cannot convert {0} value to color.", GetUnit()));
                }
            }
        }

        public CssValueGradient Gradient
        {
            get { return GetGradientValue(); }
        }

        public CssRect Rect
        {
            get { return GetRectValue(); }
        }

        public IEnumerable<CssValue> List
        {
            get { return CssValueList.TraverseList(GetListValue()); }
        }

        public CssValuePair Pair
        {
            get { return GetPairValue(); }
        }

        public CssValueTriplet Triplet
        {
            get { return GetTripletValue(); }
        }

        public IEnumerable<CssValuePair> PairList
        {
            get { return CssValuePairList.TraverseList(GetPairListValue()); }
        }

        CssValue[] ICalcOpsInput.GetArrayValue ()
        {
            return GetArrayValue();
        }
    }
}