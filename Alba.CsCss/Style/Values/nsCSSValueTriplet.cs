using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mXValue}, {mYValue}, {mZValue}")]
    public class nsCSSValueTriplet
    {
        internal nsCSSValue mXValue, mYValue, mZValue;

        internal void SetBothValuesTo (nsCSSValue aValue)
        {
            mXValue = mYValue = mZValue = aValue;
        }

        // Public interface

        public nsCSSValue X
        {
            get { return mXValue; }
        }

        public nsCSSValue Y
        {
            get { return mYValue; }
        }

        public nsCSSValue Z
        {
            get { return mZValue; }
        }
    }
}