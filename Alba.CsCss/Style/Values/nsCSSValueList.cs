using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mValue} ...")]
    internal class nsCSSValueList
    {
        internal nsCSSValue mValue;
        internal nsCSSValueList mNext;

        // Public interface

        internal IEnumerable<nsCSSValue> Items
        {
            get { return this.TraverseList(i => i.mNext).Select(i => i.mValue); }
        }
    }
}