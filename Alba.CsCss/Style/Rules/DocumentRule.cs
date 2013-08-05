namespace Alba.CsCss.Style
{
    // TODO support for @document
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