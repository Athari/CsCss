using System.Diagnostics;

namespace Alba.CsCss.Style
{
    // TODO support for @document
    [DebuggerDisplay (@"@document {mURLs.url} \{ ({mRules.Count}) \}")]
    internal class DocumentRule : GroupRule
    {
        private URL mURLs;

        public void SetURLs (URL aURLs)
        {
            mURLs = aURLs;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.DOCUMENT;
        }

        internal enum Function
        {
            eURL,
            eURLPrefix,
            eDomain,
            eRegExp
        };

        internal class URL
        {
            public Function func;
            public string url;
            public URL next;
        }
    }
}