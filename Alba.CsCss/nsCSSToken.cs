using System;

namespace Alba.CsCss
{
    internal partial class nsCSSToken
    {
        public string mIdent;
        public float mNumber;
        public Int32 mInteger;
        public Int32 mInteger2;
        public nsCSSTokenType mType = nsCSSTokenType.Whitespace;
        public char mSymbol;
        public bool mIntegerValid;
        public bool mHasSign;

        public bool IsSymbol (char aSymbol)
        {
            return mType == nsCSSTokenType.Symbol && mSymbol == aSymbol;
        }
    }
}