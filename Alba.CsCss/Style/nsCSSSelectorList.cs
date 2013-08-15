using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<Item> Items
        {
            get { return this.TraverseList(i => i.mNext).Select(i => new Item(i.mSelectors, i.mWeight)); }
        }

        public struct Item
        {
            private readonly nsCSSSelector _selectors;
            private readonly int _weight;

            public Item (nsCSSSelector selectors, int weight)
            {
                _selectors = selectors;
                _weight = weight;
            }

            public IEnumerable<nsCSSSelector> Selectors
            {
                get { return _selectors.TraverseList(i => i.mNext); }
            }

            public int Weight
            {
                get { return _weight; }
            }
        }
    }
}