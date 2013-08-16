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
    using ICalcOpsInput = ICalcOpsInput<nsCSSValue>;

    [DebuggerDisplay ("{mValue}")]
    public struct nsCSSValue : ICalcOpsInput<nsCSSValue>, IEquatable<nsCSSValue>
    {
        internal static readonly nsCSSValue NullValue = new nsCSSValue();

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

        internal nsCSSValue (CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = null;
        }

        internal nsCSSValue (nsCSSValue aValue)
        {
            mUnit = aValue.mUnit;
            mValue = aValue.mValue;
        }

        internal nsCSSValue (int32_t aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit == CssUnit.Integer || aUnit == CssUnit.Enumerated || aUnit == CssUnit.EnumColor)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (float aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit >= CssUnit.Percent)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (string aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasStringValue() && mValue != null)
                return;
            mUnit = CssUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (nsCSSValue[] aValue, CssUnit aUnit)
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

        internal nsCSSValue[] GetArrayValue ()
        {
            return (nsCSSValue[])mValue;
        }

        internal Uri GetURLValue ()
        {
            return GetURLStructValue().GetURI();
        }

        internal string GetOriginalURLValue ()
        {
            return GetURLStructValue().mString;
        }

        internal URLValue GetURLStructValue ()
        {
            return (URLValue)mValue;
        }

        internal nscolor GetColorValue ()
        {
            return (nscolor)mValue;
        }

        internal nsCSSValueGradient GetGradientValue ()
        {
            return (nsCSSValueGradient)mValue;
        }

        internal nsCSSRect GetRectValue ()
        {
            return (nsCSSRect)mValue;
        }

        internal nsCSSValueList GetListValue ()
        {
            return (nsCSSValueList)mValue;
        }

        internal nsCSSValuePair GetPairValue ()
        {
            return (nsCSSValuePair)mValue;
        }

        internal nsCSSValueTriplet GetTripletValue ()
        {
            return (nsCSSValueTriplet)mValue;
        }

        internal nsCSSValuePairList GetPairListValue ()
        {
            return (nsCSSValuePairList)mValue;
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

        internal void SetArrayValue (nsCSSValue[] aValue, CssUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetURLValue (URLValue aValue)
        {
            mUnit = CssUnit.URL;
            mValue = aValue;
        }

        internal void SetColorValue (nscolor aValue)
        {
            mUnit = CssUnit.Color;
            mValue = aValue;
        }

        internal void SetGradientValue (nsCSSValueGradient aValue)
        {
            mUnit = CssUnit.Gradient;
            mValue = aValue;
        }

        internal nsCSSRect SetRectValue ()
        {
            var value = new nsCSSRect();
            mUnit = CssUnit.Rect;
            mValue = value;
            return value;
        }

        internal nsCSSValueList SetListValue ()
        {
            var value = new nsCSSValueList();
            mUnit = CssUnit.List;
            mValue = value;
            return value;
        }

        internal void SetPairValue (nsCSSValuePair aValue)
        {
            mUnit = CssUnit.Pair;
            mValue = aValue;
        }

        internal void SetPairValue (nsCSSValue xValue, nsCSSValue yValue)
        {
            SetPairValue(new nsCSSValuePair { mXValue = xValue, mYValue = yValue });
        }

        internal void SetTripletValue (nsCSSValueTriplet aValue)
        {
            mUnit = CssUnit.Triplet;
            mValue = aValue;
        }

        internal void SetTripletValue (nsCSSValue xValue, nsCSSValue yValue, nsCSSValue zValue)
        {
            SetTripletValue(new nsCSSValueTriplet { mXValue = xValue, mYValue = yValue, mZValue = zValue });
        }

        internal nsCSSValuePairList SetPairListValue ()
        {
            var value = new nsCSSValuePairList();
            mUnit = CssUnit.PairList;
            mValue = value;
            return value;
        }

        internal nsCSSValue[] InitFunction (nsCSSKeyword aFunctionId, int aNumArgs)
        {
            var value = new nsCSSValue[aNumArgs + 1];
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
            mUnit = CssUnit.System_Font;
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
            return CssUnit.EM <= mUnit && mUnit <= CssUnit.RootEM;
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
            return CssUnit.Calc <= mUnit && mUnit <= CssUnit.Calc_Divided;
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
            return CssUnit.Array <= mUnit && mUnit <= CssUnit.Calc_Divided;
        }

        // Comparison

        public bool Equals (nsCSSValue other)
        {
            return mUnit == other.mUnit && Equals(mValue, other.mValue);
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(obj, null) && obj is nsCSSValue && Equals((nsCSSValue)obj);
        }

        public override int GetHashCode ()
        {
            return unchecked(((int)mUnit * 397) ^ (mValue != null ? mValue.GetHashCode() : 0));
        }

        public static bool operator == (nsCSSValue left, nsCSSValue right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsCSSValue left, nsCSSValue right)
        {
            return !left.Equals(right);
        }

        public override string ToString ()
        {
            return mValue.ToString();
        }

        // Public interface

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

        public IEnumerable<nsCSSValue> Array
        {
            get { return GetArrayValue(); }
        }

        public Uri Url
        {
            get { return GetURLValue(); }
        }

        public string OriginalUrl
        {
            get { return GetOriginalURLValue(); }
        }

        public nscolor Color
        {
            get { return GetColorValue(); }
        }

        public nsCSSValueGradient Gradient
        {
            get { return GetGradientValue(); }
        }

        public nsCSSRect Rect
        {
            get { return GetRectValue(); }
        }

        public IEnumerable<nsCSSValue> List
        {
            get { return GetListValue().Items; }
        }

        public nsCSSValuePair Pair
        {
            get { return GetPairValue(); }
        }

        public nsCSSValueTriplet Triplet
        {
            get { return GetTripletValue(); }
        }

        public IEnumerable<nsCSSValuePair> PairList
        {
            get { return GetPairListValue().Items; }
        }

        nsCSSValue[] ICalcOpsInput.GetArrayValue ()
        {
            return GetArrayValue();
        }
    }
}