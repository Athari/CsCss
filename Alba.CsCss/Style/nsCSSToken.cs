using System;
using System.Text;

namespace Alba.CsCss.Style
{
    internal partial class nsCSSToken
    {
        internal readonly StringBuilder mIdent = new StringBuilder();
        internal nsCSSTokenType mType = nsCSSTokenType.Whitespace;
        internal float mNumber;
        internal Int32 mInteger;
        internal Int32 mInteger2;
        internal char mSymbol;
        internal bool mIntegerValid;
        internal bool mHasSign;

        // TODO Avoid multiple calls to nsCSSToken.ToString (cache string after calling Next[URL]?)
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
            return mType == nsCSSTokenType.Symbol && mSymbol == aSymbol;
        }
    }
}