using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mXValue}, {mYValue} ...")]
    internal class CssValuePairList
    {
        internal CssValue mXValue, mYValue;
        internal CssValuePairList mNext;

        // Public interface

        internal static IEnumerable<CssValuePair> TraverseList (CssValuePairList @this)
        {
            return @this.TraverseList(i => i.mNext).Select(i => new CssValuePair { mXValue = i.mXValue, mYValue = i.mYValue });
        }
    }
}