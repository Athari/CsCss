namespace Alba.CsCss.Style
{
    public class nsMediaExpression
    {
        internal nsMediaFeature mFeature;
        internal RangeType mRange;
        internal nsCSSValue mValue;

        // Public interface

        public nsMediaFeature Feature
        {
            get { return mFeature; }
        }

        public RangeType Range
        {
            get { return mRange; }
        }

        public nsCSSValue Value
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