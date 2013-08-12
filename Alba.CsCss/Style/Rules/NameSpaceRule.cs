namespace Alba.CsCss.Style
{
    internal class NameSpaceRule : Rule
    {
        private readonly string mPrefix;
        private readonly string mUrlSpec;

        public NameSpaceRule (string aPrefix, string aUrlSpec)
        {
            mPrefix = aPrefix;
            mUrlSpec = aUrlSpec;
        }

        public string GetPrefix ()
        {
            return mPrefix;
        }

        public string GetURLSpec ()
        {
            return mUrlSpec;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.NAMESPACE;
        }
    }
}