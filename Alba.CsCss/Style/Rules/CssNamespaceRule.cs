using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@namespace {mPrefix} ""{mUrlSpec}""")]
    public class CssNamespaceRule : CssRule
    {
        private readonly string mPrefix;
        private readonly string mUrlSpec;

        internal CssNamespaceRule (string aPrefix, string aUrlSpec)
        {
            mPrefix = aPrefix;
            mUrlSpec = aUrlSpec;
        }

        internal string GetPrefix ()
        {
            return mPrefix;
        }

        internal string GetURLSpec ()
        {
            return mUrlSpec;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.Namespace;
        }

        // Public interface

        public string Prefix
        {
            get { return mPrefix; }
        }

        public string Uri
        {
            get { return mUrlSpec; }
        }
    }
}