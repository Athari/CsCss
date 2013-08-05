namespace Alba.CsCss.Style
{
    internal class CharsetRule : Rule
    {
        private string mEncoding;

        public CharsetRule (string aEncoding)
        {
            mEncoding = aEncoding;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.CHARSET;
        }
    }
}