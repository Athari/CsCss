using System.Collections.Generic;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class nsCSSValueList
    {
        internal nsCSSValue mValue;
        internal nsCSSValueList mNext;

        // Public interface

        public IEnumerable<nsCSSValue> Values
        {
            get { return this.TraverseList(i => i.mNext).Select(i => i.mValue); }
        }
    }
}