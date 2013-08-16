using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mXValue}, {mYValue}, {mZValue}")]
    public class CssValueTriplet
    {
        internal CssValue mXValue, mYValue, mZValue;

        internal void SetBothValuesTo (CssValue aValue)
        {
            mXValue = mYValue = mZValue = aValue;
        }

        // Public interface

        public CssValue X
        {
            get { return mXValue; }
        }

        public CssValue Y
        {
            get { return mYValue; }
        }

        public CssValue Z
        {
            get { return mZValue; }
        }
    }
}