namespace Alba.CsCss.Style
{
    public class nsCSSValuePair
    {
        internal nsCSSValue mXValue, mYValue;

        internal void SetBothValuesTo (nsCSSValue aValue)
        {
            mXValue = mYValue = aValue;
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
    }
}