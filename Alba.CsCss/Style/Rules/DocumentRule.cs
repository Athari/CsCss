using System.Collections.Generic;
using System.Diagnostics;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    // TODO support for @document
    [DebuggerDisplay (@"@document {mURLs.url} \{ ({mRules.Count}) \}")]
    public class DocumentRule : GroupRule
    {
        private URL mURLs;

        internal DocumentRule ()
        {}

        internal void SetURLs (URL aURLs)
        {
            mURLs = aURLs;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.DOCUMENT;
        }

        // Public interface

        public IEnumerable<URL> Uris
        {
            get { return mURLs.TraverseList(i => i.next); }
        }

        public enum Function
        {
            eURL,
            eURLPrefix,
            eDomain,
            eRegExp
        };

        public class URL
        {
            public Function func;
            public string url;
            public URL next;
        }
    }
}