using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mProperty}: {mValue}")]
    public struct CssPropertyValue
    {
        internal CssProperty mProperty;
        internal nsCSSValue mValue;

        public CssProperty Property
        {
            get { return mProperty; }
        }

        public nsCSSValue Value
        {
            get { return mValue; }
        }
    }
}