using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class nsCSSSelectorList
    {
        internal nsCSSSelectorList mNext;
        internal nsCSSSelector mSelectors;
        internal int mWeight;

        internal nsCSSSelectorList ()
        {}

        internal nsCSSSelector AddSelector (char aOperator)
        {
            var newSel = new nsCSSSelector();
            if (mSelectors != null)
                mSelectors.SetOperator(aOperator);
            newSel.mNext = mSelectors;
            mSelectors = newSel;
            return newSel;
        }

        // Public interface

        public IEnumerable<nsCSSSelector> Selectors
        {
            get { return mSelectors.Items; }
        }

        public int Weight
        {
            get { return mWeight; }
        }

        internal IEnumerable<nsCSSSelectorList> Items
        {
            get { return this.TraverseList(i => i.mNext); }
        }
    }
}