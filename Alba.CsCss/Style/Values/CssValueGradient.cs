using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("gradient()")]
    public class CssValueGradient
    {
        internal readonly List<CssValueGradientStop> mStops = new List<CssValueGradientStop>();
        internal readonly CssValue[] mRadialValues = new CssValue[2];
        internal bool mIsRadial, mIsRepeating, mIsExplicitSize, mIsLegacySyntax;
        internal CssValuePair mBgPos = new CssValuePair();
        internal CssValue mAngle;

        internal CssValueGradient (bool aIsRadial, bool aIsRepeating)
        {
            mIsRadial = aIsRadial;
            mIsRepeating = aIsRepeating;
        }

        internal CssValue GetRadialShape ()
        {
            return mRadialValues[0];
        }

        internal CssValue GetRadialSize ()
        {
            return mRadialValues[1];
        }

        internal CssValue GetRadiusX ()
        {
            return mRadialValues[0];
        }

        internal CssValue GetRadiusY ()
        {
            return mRadialValues[1];
        }

        internal void SetRadialShape (CssValue aValue)
        {
            mRadialValues[0] = aValue;
        }

        internal void SetRadialSize (CssValue aValue)
        {
            mRadialValues[1] = aValue;
        }

        internal void SetRadiusX (CssValue aValue)
        {
            mRadialValues[0] = aValue;
        }

        internal void SetRadiusY (CssValue aValue)
        {
            mRadialValues[1] = aValue;
        }

        // public interface

        public IList<CssValueGradientStop> Stops
        {
            get { return mStops; }
        }

        public bool IsRadial
        {
            get { return mIsRadial; }
        }

        public bool IsRepeating
        {
            get { return mIsRepeating; }
        }

        public bool IsExplicitSize
        {
            get { return mIsExplicitSize; }
        }

        public CssValuePair BgPos
        {
            get { return mBgPos; }
        }

        public CssValue Angle
        {
            get { return mAngle; }
        }

        public CssValue RadialShape
        {
            get { return mRadialValues[0]; }
        }

        public CssValue RadialSize
        {
            get { return mRadialValues[1]; }
        }

        public CssValue RadiusX
        {
            get { return mRadialValues[0]; }
        }

        public CssValue RadiusY
        {
            get { return mRadialValues[1]; }
        }
    }
}