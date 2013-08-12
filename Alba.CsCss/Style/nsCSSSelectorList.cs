namespace Alba.CsCss.Style
{
    internal class nsCSSSelectorList
    {
        public nsCSSSelectorList mNext;
        public nsCSSSelector mSelectors;
        public int mWeight;

        public nsCSSSelector AddSelector (char aOperator)
        {
            var newSel = new nsCSSSelector();
            if (mSelectors != null)
                mSelectors.SetOperator(aOperator);
            newSel.mNext = mSelectors;
            mSelectors = newSel;
            return newSel;
        }
    }
}