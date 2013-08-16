using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mXValue}, {mYValue}")]
    public class CssValuePair
    {
        internal CssValue mXValue, mYValue;

        internal void SetBothValuesTo (CssValue aValue)
        {
            mXValue = mYValue = aValue;
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
    }
}