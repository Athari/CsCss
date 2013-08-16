using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mProperty}: {mValue}")]
    public struct CssPropertyValue
    {
        internal CssProperty mProperty;
        internal CssValue mValue;

        public CssProperty Property
        {
            get { return mProperty; }
        }

        public CssValue Value
        {
            get { return mValue; }
        }
    }
}