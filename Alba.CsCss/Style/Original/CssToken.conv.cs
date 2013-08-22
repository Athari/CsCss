//
// Generated file. Do not edit manually.
//
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantCast

using System;
using System.Diagnostics;
using System.Text;
using Alba.CsCss.Internal;
using Alba.CsCss.Internal.Extensions;

using int32_t = System.Int32;
using uint8_t = System.Byte;
using uint32_t = System.Int32;
using PRUnichar = System.Char;

namespace Alba.CsCss.Style
{
    using nsCSSToken = CssToken;
    using nsCSSTokenType = CssTokenType;

    internal partial class CssToken
    {
                /**
         * Append the textual representation of |this| to |aBuffer|.
         */
        internal void AppendToString(StringBuilder aBuffer)
        {
          switch (mType) {
            case nsCSSTokenType.Ident:
              nsStyleUtil.AppendEscapedCSSIdent(mIdent, aBuffer);
              break;
        
            case nsCSSTokenType.AtKeyword:
              aBuffer.Append('@');
              nsStyleUtil.AppendEscapedCSSIdent(mIdent, aBuffer);
              break;
        
            case nsCSSTokenType.ID:
            case nsCSSTokenType.Hash:
              aBuffer.Append('#');
              nsStyleUtil.AppendEscapedCSSIdent(mIdent, aBuffer);
              break;
        
            case nsCSSTokenType.Function:
              nsStyleUtil.AppendEscapedCSSIdent(mIdent, aBuffer);
              aBuffer.Append('(');
              break;
        
            case nsCSSTokenType.URL:
            case nsCSSTokenType.Bad_URL:
              aBuffer.AppendLiteral("url(");
              if (mSymbol != ((PRUnichar)(0))) {
                nsStyleUtil.AppendEscapedCSSString(mIdent, aBuffer, mSymbol);
              } else {
                aBuffer.Append(mIdent);
              }
              if (mType == nsCSSTokenType.URL) {
                aBuffer.Append(((PRUnichar)(')')));
              }
              break;
        
            case nsCSSTokenType.Number:
              if (mIntegerValid) {
                aBuffer.AppendInt(mInteger, 10);
              } else {
                aBuffer.AppendFloat(mNumber);
              }
              break;
        
            case nsCSSTokenType.Percentage:
              aBuffer.AppendFloat(mNumber * 100.0f);
              aBuffer.Append(((PRUnichar)('%')));
              break;
        
            case nsCSSTokenType.Dimension:
              if (mIntegerValid) {
                aBuffer.AppendInt(mInteger, 10);
              } else {
                aBuffer.AppendFloat(mNumber);
              }
              nsStyleUtil.AppendEscapedCSSIdent(mIdent, aBuffer);
              break;
        
            case nsCSSTokenType.Bad_String:
              nsStyleUtil.AppendEscapedCSSString(mIdent, aBuffer, mSymbol);
              // remove the trailing quote character
              aBuffer.Truncate(aBuffer.Length() - 1);
              break;
        
            case nsCSSTokenType.String:
              nsStyleUtil.AppendEscapedCSSString(mIdent, aBuffer, mSymbol);
              break;
        
            case nsCSSTokenType.Symbol:
              aBuffer.Append(mSymbol);
              break;
        
            case nsCSSTokenType.Whitespace:
              aBuffer.Append(' ');
              break;
        
            case nsCSSTokenType.HTMLComment:
            case nsCSSTokenType.URange:
              aBuffer.Append(mIdent);
              break;
        
            case nsCSSTokenType.Includes:
              aBuffer.AppendLiteral("~=");
              break;
            case nsCSSTokenType.Dashmatch:
              aBuffer.AppendLiteral("|=");
              break;
            case nsCSSTokenType.Beginsmatch:
              aBuffer.AppendLiteral("^=");
              break;
            case nsCSSTokenType.Endsmatch:
              aBuffer.AppendLiteral("$=");
              break;
            case nsCSSTokenType.Containsmatch:
              aBuffer.AppendLiteral("*=");
              break;
        
            default:
              throw new Exception("invalid token type");
              break;
          }
        }
    }
}
