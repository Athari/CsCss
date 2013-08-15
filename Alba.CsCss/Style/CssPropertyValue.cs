using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mProperty}: {mValue}")]
    public struct CssPropertyValue
    {
        internal nsCSSProperty mProperty;
        internal nsCSSValue mValue;

        public nsCSSProperty Property
        {
            get { return mProperty; }
        }

        public nsCSSValue Value
        {
            get { return mValue; }
        }
    }
}