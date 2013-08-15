using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@namespace {mPrefix} ""{mUrlSpec}""")]
    public class NameSpaceRule : Rule
    {
        private readonly string mPrefix;
        private readonly string mUrlSpec;

        internal NameSpaceRule (string aPrefix, string aUrlSpec)
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

        internal override RuleKind GetKind ()
        {
            return RuleKind.NAMESPACE;
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