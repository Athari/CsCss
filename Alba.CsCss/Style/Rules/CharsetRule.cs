using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@charset ""{mEncoding}\""")]
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