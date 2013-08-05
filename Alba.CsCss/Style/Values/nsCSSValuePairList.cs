using System.Collections.Generic;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class nsCSSValuePairList
    {
        internal nsCSSValue mXValue, mYValue;
        internal nsCSSValuePairList mNext;

        // Public interface

        public IEnumerable<nsCSSValuePair> Items
        {
            get { return this.TraverseList(i => i.mNext).Select(i => new nsCSSValuePair { mXValue = i.mXValue, mYValue = i.mYValue }); }
        }
    }
}