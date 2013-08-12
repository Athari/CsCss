namespace Alba.CsCss.Style
{
    internal class nsMediaExpression
    {
        public nsMediaFeature mFeature;
        public Range mRange;
        public nsCSSValue mValue;

        public enum Range
        {
            Min,
            Max,
            Equal
        };
    }
}