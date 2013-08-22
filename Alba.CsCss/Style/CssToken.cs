using System;
using System.Text;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal partial class CssToken
    {
        internal readonly StringBuilder mIdent = new StringBuilder();
        internal CssTokenType mType = CssTokenType.Whitespace;
        internal float mNumber;
        internal Int32 mInteger;
        internal Int32 mInteger2;
        internal char mSymbol;
        internal bool mIntegerValid;
        internal bool mHasSign;

        // TODO Avoid multiple calls to CssToken.ToString (cache string after calling Next[URL]?)
        internal string mIdentStr
        {
            get { return mIdent.ToString(); }
            set
            {
                mIdent.Clear();
                mIdent.Append(value);
            }
        }

        internal bool IsSymbol (char aSymbol)
        {
            return mType == CssTokenType.Symbol && mSymbol == aSymbol;
        }
    }
}