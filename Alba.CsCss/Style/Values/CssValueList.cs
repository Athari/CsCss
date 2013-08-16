using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mValue} ...")]
    internal class CssValueList
    {
        internal CssValue mValue;
        internal CssValueList mNext;

        // Public interface

        internal IEnumerable<CssValue> Items
        {
            get { return this.TraverseList(i => i.mNext).Select(i => i.mValue); }
        }
    }
}