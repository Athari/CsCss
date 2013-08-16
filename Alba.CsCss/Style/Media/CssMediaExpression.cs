namespace Alba.CsCss.Style
{
    public class CssMediaExpression
    {
        internal CssMediaFeature mFeature;
        internal RangeType mRange;
        internal CssValue mValue;

        // Public interface

        public CssMediaFeature Feature
        {
            get { return mFeature; }
        }

        public RangeType Range
        {
            get { return mRange; }
        }

        public CssValue Value
        {
            get { return mValue; }
        }

        public enum RangeType
        {
            Min,
            Max,
            Equal
        };
    }
}