using System.Text;

namespace Alba.CsCss.Internal
{
    internal class nsStyleUtil
    {
        internal static void AppendEscapedCSSIdent (StringBuilder aIdent, StringBuilder aReturn)
        {
            // The relevant parts of the CSS grammar are:
            //   ident    [-]?{nmstart}{nmchar}*
            //   nmstart  [_a-z]|{nonascii}|{escape}
            //   nmchar   [_a-z0-9-]|{nonascii}|{escape}
            //   nonascii [^\0-\177]
            //   escape   {unicode}|\\[^\n\r\f0-9a-f]
            //   unicode  \\[0-9a-f]{1,6}(\r\n|[ \n\r\t\f])?
            // from http://www.w3.org/TR/CSS21/syndata.html#tokenization

            string ident = aIdent.ToString();
            int i = 0;
            int end = ident.Length;

            if (i == end)
                return;

            // A leading dash does not need to be escaped as long as it is not the
            // *only* character i the identifier.
            if (i + 1 != end && ident[i] == '-') {
                aReturn.Append('-');
                ++i;
            }

            // Escape a digit at the start (including after a dash),
            // numerically.  If we didn't escape it numerically, it would get
            // interpreted as a numeric escape for the wrong character.
            // A second dash immediately after a leading dash must also be
            // escaped, but this may be done symbolically.
            if (i != end && (ident[i] == '-' || ('0' <= ident[i] && ident[i] <= '9'))) {
                if (ident[i] == '-') {
                    aReturn.Append("\\-");
                }
                else {
                    aReturn.AppendFormat("\\{0:X} ", (int)ident[i]);
                }
                ++i;
            }

            for (; i != end; ++i) {
                char ch = ident[i];
                if (ch < 0x20 || (0x7F <= ch && ch < 0xA0)) {
                    // Escape U+0000 through U+001F and U+007F through U+009F numerically.
                    aReturn.AppendFormat("\\{0:X} ", (int)ident[i]);
                }
                else {
                    // Escape ASCII non-identifier printables as a backslash plus
                    // the character.
                    if (ch < 0x7F &&
                        ch != '_' && ch != '-' &&
                        (ch < '0' || '9' < ch) &&
                        (ch < 'A' || 'Z' < ch) &&
                        (ch < 'a' || 'z' < ch)) {
                        aReturn.Append('\\');
                    }
                    aReturn.Append(ch);
                }
            }
        }

        internal static void AppendEscapedCSSString (StringBuilder aString, StringBuilder aReturn, char quoteChar = '"')
        {
            aReturn.Append(quoteChar);

            string str = aString.ToString();
            int i = 0;
            int end = str.Length;
            for (; i != end; i++) {
                if (str[i] < 0x20 || (str[i] >= 0x7F && str[i] < 0xA0)) {
                    // Escape U+0000 through U+001F and U+007F through U+009F numerically.
                    aReturn.AppendFormat("\\{0:X} ", (int)str[i]);
                }
                else {
                    if (str[i] == '"' || str[i] == '\'' || str[i] == '\\') {
                        // Escape backslash and quote characters symbolically.
                        // It's not technically necessary to escape the quote
                        // character that isn't being used to delimit the string,
                        // but we do it anyway because that makes testing simpler.
                        aReturn.Append('\\');
                    }
                    aReturn.Append(str[i]);
                }
            }

            aReturn.Append(quoteChar);
        }

        public static byte FloatToColorComponent (float aAlpha)
        {
            return (byte)CommonUtil.NSToIntRound(aAlpha * 255);
        }
    }
}