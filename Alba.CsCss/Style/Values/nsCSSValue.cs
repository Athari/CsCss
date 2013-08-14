using System;
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

        private nsCSSUnit mUnit /*= nsCSSUnit.Null*/;
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

        internal nsCSSValue (nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = null;
        }

        internal nsCSSValue (nsCSSValue aValue)
        {
            mUnit = aValue.mUnit;
            mValue = aValue.mValue;
        }

        internal nsCSSValue (int32_t aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit == nsCSSUnit.Integer || aUnit == nsCSSUnit.Enumerated || aUnit == nsCSSUnit.EnumColor)
                return;
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (float aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (aUnit >= nsCSSUnit.Percent)
                return;
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (string aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasStringValue() && mValue != null)
                return;
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal nsCSSValue (nsCSSValue[] aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasArrayValue() && mValue != null)
                return;
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal nsCSSUnit GetUnit ()
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
                case nsCSSUnit.Radian:
                    return (float)angle;
                case nsCSSUnit.Turn:
                    return (float)(angle * 2 * Math.PI);
                case nsCSSUnit.Degree:
                    return (float)(angle * Math.PI / 180.0);
                case nsCSSUnit.Grad:
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

        internal void SetIntValue (int aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetFloatValue (float aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetFloatValue (double aValue, nsCSSUnit aUnit)
        {
            SetFloatValue((float)aValue, aUnit);
        }

        internal void SetPercentValue (float aValue)
        {
            mUnit = nsCSSUnit.Percent;
            mValue = aValue;
        }

        internal void SetStringValue (string aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
            if (UnitHasStringValue() && aValue != null)
                return;
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal void SetStringValue (StringBuilder aValue, nsCSSUnit aUnit)
        {
            SetStringValue(aValue.ToString(), aUnit);
        }

        internal void SetArrayValue (nsCSSValue[] aValue, nsCSSUnit aUnit)
        {
            mUnit = aUnit;
            mValue = aValue;
        }

        internal void SetURLValue (URLValue aValue)
        {
            mUnit = nsCSSUnit.URL;
            mValue = aValue;
        }

        internal void SetColorValue (nscolor aValue)
        {
            mUnit = nsCSSUnit.Color;
            mValue = aValue;
        }

        internal void SetGradientValue (nsCSSValueGradient aValue)
        {
            mUnit = nsCSSUnit.Gradient;
            mValue = aValue;
        }

        internal nsCSSRect SetRectValue ()
        {
            var value = new nsCSSRect();
            mUnit = nsCSSUnit.Rect;
            mValue = value;
            return value;
        }

        internal nsCSSValueList SetListValue ()
        {
            var value = new nsCSSValueList();
            mUnit = nsCSSUnit.List;
            mValue = value;
            return value;
        }

        internal void SetPairValue (nsCSSValuePair aValue)
        {
            mUnit = nsCSSUnit.Pair;
            mValue = aValue;
        }

        internal void SetPairValue (nsCSSValue xValue, nsCSSValue yValue)
        {
            SetPairValue(new nsCSSValuePair { mXValue = xValue, mYValue = yValue });
        }

        internal void SetTripletValue (nsCSSValueTriplet aValue)
        {
            mUnit = nsCSSUnit.Triplet;
            mValue = aValue;
        }

        internal void SetTripletValue (nsCSSValue xValue, nsCSSValue yValue, nsCSSValue zValue)
        {
            SetTripletValue(new nsCSSValueTriplet { mXValue = xValue, mYValue = yValue, mZValue = zValue });
        }

        internal nsCSSValuePairList SetPairListValue ()
        {
            var value = new nsCSSValuePairList();
            mUnit = nsCSSUnit.PairList;
            mValue = value;
            return value;
        }

        internal nsCSSValue[] InitFunction (nsCSSKeyword aFunctionId, int aNumArgs)
        {
            var value = new nsCSSValue[aNumArgs + 1];
            value[0].SetIntValue((int)aFunctionId, nsCSSUnit.Enumerated);
            SetArrayValue(value, nsCSSUnit.Function);
            return value;
        }

        internal void SetAutoValue ()
        {
            mUnit = nsCSSUnit.Auto;
            mValue = null;
        }

        internal void SetInheritValue ()
        {
            mUnit = nsCSSUnit.Inherit;
            mValue = null;
        }

        internal void SetInitialValue ()
        {
            mUnit = nsCSSUnit.Initial;
            mValue = null;
        }

        internal void SetNoneValue ()
        {
            mUnit = nsCSSUnit.None;
            mValue = null;
        }

        internal void SetAllValue ()
        {
            mUnit = nsCSSUnit.All;
            mValue = null;
        }

        internal void SetNormalValue ()
        {
            mUnit = nsCSSUnit.Normal;
            mValue = null;
        }

        internal void SetSystemFontValue ()
        {
            mUnit = nsCSSUnit.System_Font;
            mValue = null;
        }

        internal void Reset ()
        {
            mUnit = nsCSSUnit.Null;
            mValue = null;
        }

        internal bool IsLengthUnit ()
        {
            return nsCSSUnit.PhysicalMillimeter <= mUnit && mUnit <= nsCSSUnit.Pixel;
        }

        internal bool IsFixedLengthUnit ()
        {
            return mUnit == nsCSSUnit.PhysicalMillimeter;
        }

        internal bool IsRelativeLengthUnit ()
        {
            return nsCSSUnit.EM <= mUnit && mUnit <= nsCSSUnit.RootEM;
        }

        internal bool IsPixelLengthUnit ()
        {
            return nsCSSUnit.Point <= mUnit && mUnit <= nsCSSUnit.Pixel;
        }

        internal bool IsAngularUnit ()
        {
            return nsCSSUnit.Degree <= mUnit && mUnit <= nsCSSUnit.Turn;
        }

        internal bool IsFrequencyUnit ()
        {
            return nsCSSUnit.Hertz <= mUnit && mUnit <= nsCSSUnit.Kilohertz;
        }

        internal bool IsTimeUnit ()
        {
            return nsCSSUnit.Seconds <= mUnit && mUnit <= nsCSSUnit.Milliseconds;
        }

        internal bool IsCalcUnit ()
        {
            return nsCSSUnit.Calc <= mUnit && mUnit <= nsCSSUnit.Calc_Divided;
        }

        internal static string BufferFromString (string str)
        {
            return str;
        }

        internal bool UnitHasStringValue ()
        {
            return nsCSSUnit.String <= mUnit && mUnit <= nsCSSUnit.Element;
        }

        internal bool UnitHasArrayValue ()
        {
            return nsCSSUnit.Array <= mUnit && mUnit <= nsCSSUnit.Calc_Divided;
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

        public nsCSSValue[] Array
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

        public nsCSSValueList List
        {
            get { return GetListValue(); }
        }

        public nsCSSValuePair Pair
        {
            get { return GetPairValue(); }
        }

        public nsCSSValueTriplet Triplet
        {
            get { return GetTripletValue(); }
        }

        public nsCSSValuePairList PairList
        {
            get { return GetPairListValue(); }
        }

        nsCSSValue[] ICalcOpsInput.GetArrayValue ()
        {
            return GetArrayValue();
        }
    }
}