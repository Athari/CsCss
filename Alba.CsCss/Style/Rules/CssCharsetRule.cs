using System.Diagnostics;
using System.Text;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@charset ""{mEncoding}\""")]
    public class CssCharsetRule : CssRule
    {
        private readonly string mEncoding;

        internal CssCharsetRule (string aEncoding)
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