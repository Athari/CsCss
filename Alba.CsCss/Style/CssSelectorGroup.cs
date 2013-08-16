using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class CssSelectorGroup
    {
        internal CssSelectorGroup mNext;
        internal CssSelector mSelectors;
        internal int mWeight;

        internal CssSelectorGroup ()
        {}

        internal CssSelector AddSelector (char aOperator)
        {
            var newSel = new CssSelector();
            if (mSelectors != null)
                mSelectors.SetOperator(aOperator);
            newSel.mNext = mSelectors;
            mSelectors = newSel;
            return newSel;
        }

        // Public interface

        public IEnumerable<CssSelector> Selectors
        {
            get { return mSelectors.Items; }
        }

        public int Weight
        {
            get { return mWeight; }
        }

        internal IEnumerable<CssSelectorGroup> Items
        {
            get { return this.TraverseList(i => i.mNext); }
        }
    }
}