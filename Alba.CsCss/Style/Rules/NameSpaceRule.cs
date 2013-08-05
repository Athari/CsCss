namespace Alba.CsCss.Style
{
    internal class NameSpaceRule : Rule
    {
        private string mPrefix;
        private string mUrlSpec;

        public NameSpaceRule (string aPrefix, string aUrlSpec)
        {
            mPrefix = aPrefix;
            mUrlSpec = aUrlSpec;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.NAMESPACE;
        }
    }
}