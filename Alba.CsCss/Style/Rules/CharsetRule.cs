using System.Diagnostics;
using System.Text;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@charset ""{mEncoding}\""")]
    public class CharsetRule : Rule
    {
        private readonly string mEncoding;

        internal CharsetRule (string aEncoding)
        {
            mEncoding = aEncoding;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.CHARSET;
        }

        // Public interface

        public string EncodingName
        {
            get { return mEncoding; }
        }

        public Encoding Encoding
        {
            get { return Encoding.GetEncoding(mEncoding); }
        }
    }
}