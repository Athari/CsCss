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

    internal partial class CssScanner
    {
                /* -*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
        /* This Source Code Form is subject to the terms of the Mozilla Public
         * License, v. 2.0. If a copy of the MPL was not distributed with this
         * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
        
        /* tokenization of CSS style sheets */
        
        /* Character class tables and related helper functions. */
        
        private const uint8_t IS_HEX_DIGIT  = 0x01;
        private const uint8_t IS_IDSTART    = 0x02;
        private const uint8_t IS_IDCHAR     = 0x04;
        private const uint8_t IS_URL_CHAR   = 0x08;
        private const uint8_t IS_HSPACE     = 0x10;
        private const uint8_t IS_VSPACE     = 0x20;
        private const uint8_t IS_SPACE      = IS_HSPACE|IS_VSPACE;
        private const uint8_t IS_STRING     = 0x40;
        
        private const uint8_t H = IS_HSPACE;
        private const uint8_t V = IS_VSPACE;
        private const uint8_t I = IS_IDCHAR;
        private const uint8_t J = IS_IDSTART;
        private const uint8_t U = IS_URL_CHAR;
        private const uint8_t S = IS_STRING;
        private const uint8_t X = IS_HEX_DIGIT;
        
        private const uint8_t SH = S|H;
        private const uint8_t SU = S|U;
        private const uint8_t SUI = S|U|I;
        private const uint8_t SUIJ = S|U|I|J;
        private const uint8_t SUIX = S|U|I|X;
        private const uint8_t SUIJX = S|U|I|J|X;
        
        private static readonly uint8_t[] gLexTable = {
        // 00    01    02    03    04    05    06    07
            0,    S,    S,    S,    S,    S,    S,    S,
        // 08   TAB    LF    0B    FF    CR    0E    0F
            S,   SH,    V,    S,    V,    V,    S,    S,
        // 10    11    12    13    14    15    16    17
            S,    S,    S,    S,    S,    S,    S,    S,
        // 18    19    1A    1B    1C    1D    1E    1F
            S,    S,    S,    S,    S,    S,    S,    S,
        //SPC     !     "     #     $     %     &     '
           SH,   SU,    0,   SU,   SU,   SU,   SU,    0,
        //  (     )     *     +     ,     -     .     /
            S,    S,   SU,   SU,   SU,  SUI,   SU,   SU,
        //  0     1     2     3     4     5     6     7
         SUIX, SUIX, SUIX, SUIX, SUIX, SUIX, SUIX, SUIX,
        //  8     9     :     ;     <     =     >     ?
         SUIX, SUIX,   SU,   SU,   SU,   SU,   SU,   SU,
        //  @     A     B     C     D     E     F     G
           SU,SUIJX,SUIJX,SUIJX,SUIJX,SUIJX,SUIJX, SUIJ,
        //  H     I     J     K     L     M     N     O
         SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ,
        //  P     Q     R     S     T     U     V     W
         SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ,
        //  X     Y     Z     [     \     ]     ^     _
         SUIJ, SUIJ, SUIJ,   SU,    J,   SU,   SU, SUIJ,
        //  `     a     b     c     d     e     f     g
           SU,SUIJX,SUIJX,SUIJX,SUIJX,SUIJX,SUIJX, SUIJ,
        //  h     i     j     k     l     m     n     o
         SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ,
        //  p     q     r     s     t     u     v     w
         SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ, SUIJ,
        //  x     y     z     {     |     }     ~    7F
         SUIJ, SUIJ, SUIJ,   SU,   SU,   SU,   SU,    S,
        };
        
        /**
         * True if 'ch' is in character class 'cls', which should be one of
         * the constants above or some combination of them.  All characters
         * above U+007F are considered to be in 'cls'.  EOF is never in 'cls'.
         */
        static  bool
        IsOpenCharClass(int32_t ch, uint8_t cls) {
          return ch >= 0 && (ch >= 128 || (gLexTable[ch] & cls) != 0);
        }
        
        /**
         * True if 'ch' is in character class 'cls', which should be one of
         * the constants above or some combination of them.  No characters
         * above U+007F are considered to be in 'cls'. EOF is never in 'cls'.
         */
        static  bool
        IsClosedCharClass(int32_t ch, uint8_t cls) {
          return ch >= 0 && ch < 128 && (gLexTable[ch] & cls) != 0;
        }
        
        /**
         * True if 'ch' is CSS whitespace, i.e. any of the ASCII characters
         * TAB, LF, FF, CR, or SPC.
         */
        static  bool
        IsWhitespace(int32_t ch) {
          return IsClosedCharClass(ch, IS_SPACE);
        }
        
        /**
         * True if 'ch' is horizontal whitespace, i.e. TAB or SPC.
         */
        static  bool
        IsHorzSpace(int32_t ch) {
          return IsClosedCharClass(ch, IS_HSPACE);
        }
        
        /**
         * True if 'ch' is vertical whitespace, i.e. LF, FF, or CR.  Vertical
         * whitespace requires special handling when consumed, see AdvanceLine.
         */
        static  bool
        IsVertSpace(int32_t ch) {
          return IsClosedCharClass(ch, IS_VSPACE);
        }
        
        /**
         * True if 'ch' is a character that can appear in the middle of an
         * identifier.
         */
        static  bool
        IsIdentChar(int32_t ch) {
          return IsOpenCharClass(ch, IS_IDCHAR);
        }
        
        /**
         * True if 'ch' is a character that by itself begins an identifier.
         * (This is a subset of IsIdentChar.)
         */
        static  bool
        IsIdentStart(int32_t ch) {
          return IsOpenCharClass(ch, IS_IDSTART);
        }
        
        /**
         * True if the two-character sequence aFirstChar+aSecondChar begins an
         * identifier.
         */
        static  bool
        StartsIdent(int32_t aFirstChar, int32_t aSecondChar)
        {
          return IsIdentStart(aFirstChar) ||
            (aFirstChar == '-' && IsIdentStart(aSecondChar));
        }
        
        /**
         * True if 'ch' is a decimal digit.
         */
        static  bool
        IsDigit(int32_t ch) {
          return (ch >= '0') && (ch <= '9');
        }
        
        /**
         * True if 'ch' is a hexadecimal digit.
         */
        static  bool
        IsHexDigit(int32_t ch) {
          return IsClosedCharClass(ch, IS_HEX_DIGIT);
        }
        
        /**
         * Assuming that 'ch' is a decimal digit, return its numeric value.
         */
        static  uint32_t
        DecimalDigitValue(int32_t ch)
        {
          return ch - '0';
        }
        
        /**
         * Assuming that 'ch' is a hexadecimal digit, return its numeric value.
         */
        static  uint32_t
        HexDigitValue(int32_t ch)
        {
          if (IsDigit(ch)) {
            return DecimalDigitValue(ch);
          } else {
            // Note: c&7 just keeps the low three bits which causes
            // upper and lower case alphabetics to both yield their
            // "relative to 10" value for computing the hex value.
            return (ch & 0x7) + 9;
          }
        }
        
        /**
         * If 'ch' can be the first character of a two-character match operator
         * token, return the token type code for that token, otherwise return
         * nsCSSTokenType.Symbol to indicate that it can't.
         */
        static  nsCSSTokenType
        MatchOperatorType(int32_t ch)
        {
          switch (ch) {
          case '~': return nsCSSTokenType.Includes;
          case '|': return nsCSSTokenType.Dashmatch;
          case '^': return nsCSSTokenType.Beginsmatch;
          case '$': return nsCSSTokenType.Endsmatch;
          case '*': return nsCSSTokenType.Containsmatch;
          default:  return nsCSSTokenType.Symbol;
          }
        }
        
        internal void StartRecording()
        {
          Debug.Assert(!mRecording, "already started recording");
          mRecording = true;
          mRecordStartOffset = mOffset;
        }
        
        internal void StopRecording()
        {
          Debug.Assert(mRecording, "haven't started recording");
          mRecording = false;
        }
        
        /**
         * Return the raw UTF-16 code unit at position |mOffset + n| within
         * the read buffer.  If that is beyond the end of the buffer, returns
         * -1 to indicate end of input.
         */
        internal  int32_t Peek(uint32_t n = 0)
        {
          if (mOffset + n >= mCount) {
            return -1;
          }
          return mBuffer[mOffset + n];
        }
        
        /**
         * Advance |mOffset| over |n| code units.  Advance(0) is a no-op.
         * If |n| is greater than the distance to end of input, will silently
         * stop at the end.  May not be used to advance over a line boundary;
         * AdvanceLine() must be used instead.
         */
        internal  void Advance(uint32_t n = 1)
        {
        #if DEBUG
          while (mOffset < mCount && n > 0) {
            Debug.Assert(!IsVertSpace(mBuffer[mOffset]),
                       "may not Advance() over a line boundary");
            mOffset++;
            n--;
          }
        #else
          if (mOffset + n >= mCount || mOffset + n < mOffset)
            mOffset = mCount;
          else
            mOffset += n;
        #endif
        }
        
        /**
         * Advance |mOffset| over a line boundary.
         */
        internal void AdvanceLine()
        {
          Debug.Assert(IsVertSpace(mBuffer[mOffset]),
                     "may not AdvanceLine() over a horizontal character");
          // Advance over \r\n as a unit.
          if (mBuffer[mOffset]   == '\r' && mOffset + 1 < mCount &&
              mBuffer[mOffset+1] == '\n')
            mOffset += 2;
          else
            mOffset += 1;
          // 0 is a magical line number meaning that we don't know (i.e., script)
          if (mLineNumber != 0)
            mLineNumber++;
          mLineOffset = mOffset;
        }
        
        /**
         * Back up |mOffset| over |n| code units.  Backup(0) is a no-op.
         * If |n| is greater than the distance to beginning of input, will
         * silently stop at the beginning.  May not be used to back up over a
         * line boundary.
         */
        internal void Backup(uint32_t n)
        {
        #if DEBUG
          while (mOffset > 0 && n > 0) {
            Debug.Assert(!IsVertSpace(mBuffer[mOffset-1]),
                       "may not Backup() over a line boundary");
            mOffset--;
            n--;
          }
        #else
          if (mOffset < n)
            mOffset = 0;
          else
            mOffset -= n;
        #endif
        }
        
        /**
         * Skip over a sequence of whitespace characters (vertical or
         * horizontal) starting at the current read position.
         */
        internal void SkipWhitespace()
        {
          for (;;) {
            int32_t ch = Peek();
            if (!IsWhitespace(ch)) { // EOF counts as non-whitespace
              break;
            }
            if (IsVertSpace(ch)) {
              AdvanceLine();
            } else {
              Advance();
            }
          }
        }
        
        /**
         * Skip over one CSS comment starting at the current read position.
         */
        internal void SkipComment()
        {
          Debug.Assert(Peek() == '/' && Peek(1) == '*', "should not have been called");
          Advance(2);
          for (;;) {
            int32_t ch = Peek();
            if (ch < 0) {
              mReporter.ReportUnexpectedEOF("PECommentEOF");
              return;
            }
            if (ch == '*' && Peek(1) == '/') {
              Advance(2);
              return;
            }
            if (IsVertSpace(ch)) {
              AdvanceLine();
            } else {
              Advance();
            }
          }
        }
        
        /**
         * If there is a valid escape sequence starting at the current read
         * position, consume it, decode it, append the result to |aOutput|,
         * and return true.  Otherwise, consume nothing, leave |aOutput|
         * unmodified, and return false.  If |aInString| is true, accept the
         * additional form of escape sequence allowed within string-like tokens.
         */
        internal bool GatherEscape(StringBuilder aOutput, bool aInString)
        {
          Debug.Assert(Peek() == '\\', "should not have been called");
          int32_t ch = Peek(1);
          if (ch < 0) {
            // Backslash followed by EOF is not an escape.
            return false;
          }
          if (IsVertSpace(ch)) {
            if (aInString) {
              // In strings (and in url() containing a string), escaped
              // newlines are completely removed, to allow splitting over
              // multiple lines.
              Advance();
              AdvanceLine();
              return true;
            }
            // Outside of strings, backslash followed by a newline is not an escape.
            return false;
          }
        
          if (!IsHexDigit(ch)) {
            // "Any character (except a hexadecimal digit, linefeed, carriage
            // return, or form feed) can be escaped with a backslash to remove
            // its special meaning." -- CSS2.1 section 4.1.3
            Advance(2);
            aOutput.Append(ch);
            return true;
          }
        
          // "[at most six hexadecimal digits following a backslash] stand
          // for the ISO 10646 character with that number, which must not be
          // zero. (It is undefined in CSS 2.1 what happens if a style sheet
          // does contain a character with Unicode codepoint zero.)"
          //   -- CSS2.1 section 4.1.3
        
          // At this point we know we have \ followed by at least one
          // hexadecimal digit, therefore the escape sequence is valid and we
          // can go ahead and consume the backslash.
          Advance();
          uint32_t val = 0;
          int i = 0;
          do {
            val = val * 16 + HexDigitValue(ch);
            i++;
            Advance();
            ch = Peek();
          } while (i < 6 && IsHexDigit(ch));
        
          // Silently deleting \0 opens a content-filtration loophole (see
          // bug 228856), so what we do instead is pretend the "cancels the
          // meaning of special characters" rule applied.
          if (val == 0) {
            do {
              aOutput.Append('0');
            } while (--i != 0);
          } else {
            aOutput.Append(val);
            // Consume exactly one whitespace character after a nonzero
            // hexadecimal escape sequence.
            if (IsVertSpace(ch)) {
              AdvanceLine();
            } else if (IsHorzSpace(ch)) {
              Advance();
            }
          }
          return true;
        }
        
        /**
         * Consume a run of "text" beginning with the current read position,
         * consisting of characters in the class |aClass| (which must be a
         * suitable argument to IsOpenCharClass) plus escape sequences.
         * Append the text to |aText|, after decoding escape sequences.
         *
         * Returns true if at least one character was appended to |aText|,
         * false otherwise.
         */
        internal bool GatherText(uint8_t aClass, StringBuilder aText)
        {
          // This is all of the character classes currently used with
          // GatherText.  If you have a need to use this function with a
          // different class, go ahead and add it.
          Debug.Assert(aClass == IS_STRING ||
                     aClass == IS_IDCHAR ||
                     aClass == IS_URL_CHAR,
                     "possibly-inappropriate character class");
        
          uint32_t start = mOffset;
          bool inString = aClass == IS_STRING;
        
          for (;;) {
            // Consume runs of unescaped characters in one go.
            uint32_t n = mOffset;
            while (n < mCount && IsOpenCharClass(mBuffer[n], aClass)) {
              n++;
            }
            if (n > mOffset) {
              aText.Append(mBuffer, mOffset, n - mOffset);
              mOffset = n;
            }
            if (n == mCount) {
              break;
            }
        
            int32_t ch = Peek();
            Debug.Assert(!IsOpenCharClass(ch, aClass),
                       "should not have exited the inner loop");
        
            if (ch != '\\') {
              break;
            }
            if (!GatherEscape(aText, inString)) {
              break;
            }
          }
        
          return mOffset > start;
        }
        
        /**
         * Scan an Ident token.  This also handles Function and URL tokens,
         * both of which begin indistinguishably from an identifier.  It can
         * produce a Symbol token when an apparent identifier actually led
         * into an invalid escape sequence.
         */
        internal bool ScanIdent(nsCSSToken aToken)
        {
          if (!GatherText(IS_IDCHAR, aToken.mIdent)) {
            aToken.mSymbol = (char)Peek();
            Advance();
            return true;
          }
        
          if (Peek() != '(') {
            aToken.mType = nsCSSTokenType.Ident;
            return true;
          }
        
          Advance();
          aToken.mType = nsCSSTokenType.Function;
          if (aToken.mIdent.LowerCaseEqualsLiteral("url")) {
            NextURL(aToken);
          }
          return true;
        }
        
        /**
         * Scan an AtKeyword token.  Also handles production of Symbol when
         * an '@' is not followed by an identifier.
         */
        internal bool ScanAtKeyword(nsCSSToken aToken)
        {
          Debug.Assert(Peek() == '@', "should not have been called");
        
          // Fall back for when '@' isn't followed by an identifier.
          aToken.mSymbol = '@';
          Advance();
        
          int32_t ch = Peek();
          if (StartsIdent(ch, Peek(1))) {
            if (GatherText(IS_IDCHAR, aToken.mIdent)) {
               aToken.mType = nsCSSTokenType.AtKeyword;
             }
          }
          return true;
        }
        
        /**
         * Scan a Hash token.  Handles the distinction between nsCSSTokenType.ID
         * and nsCSSTokenType.Hash, and handles production of Symbol when a '#'
         * is not followed by identifier characters.
         */
        internal bool ScanHash(nsCSSToken aToken)
        {
          Debug.Assert(Peek() == '#', "should not have been called");
        
          // Fall back for when '#' isn't followed by identifier characters.
          aToken.mSymbol = '#';
          Advance();
        
          int32_t ch = Peek();
          if (IsIdentChar(ch) || ch == '\\') {
            nsCSSTokenType type =
              StartsIdent(ch, Peek(1)) ? nsCSSTokenType.ID : nsCSSTokenType.Hash;
            aToken.mIdent.SetLength(0);
            if (GatherText(IS_IDCHAR, aToken.mIdent)) {
              aToken.mType = type;
            }
          }
        
          return true;
        }
        
        /**
         * Scan a Number, Percentage, or Dimension token (all of which begin
         * like a Number).  Can produce a Symbol when a '.' is not followed by
         * digits, or when '+' or '-' are not followed by either a digit or a
         * '.' and then a digit.  Can also produce a HTMLComment when it
         * encounters '-.'.
         */
        internal bool ScanNumber(nsCSSToken aToken)
        {
          int32_t c = Peek();
        #if DEBUG
          {
            int32_t c2 = Peek(1);
            int32_t c3 = Peek(2);
            Debug.Assert(IsDigit(c) ||
                       (IsDigit(c2) && (c == '.' || c == '+' || c == '-')) ||
                       (IsDigit(c3) && (c == '+' || c == '-') && c2 == '.'),
                       "should not have been called");
          }
        #endif
        
          // Sign of the mantissa (-1 or 1).
          int32_t sign = c == '-' ? -1 : 1;
          // Absolute value of the integer part of the mantissa.  This is a double so
          // we don't run into overflow issues for consumers that only care about our
          // floating-point value while still being able to express the full int32_t
          // range for consumers who want integers.
          double intPart = 0;
          // Fractional part of the mantissa.  This is a double so that when we convert
          // to float at the end we'll end up rounding to nearest float instead of
          // truncating down (as we would if fracPart were a float and we just
          // effectively lost the last several digits).
          double fracPart = 0;
          // Absolute value of the Math.Power of 10 that we should multiply by (only
          // relevant for numbers in scientific notation).  Has to be a signed integer,
          // because multiplication of signed by unsigned converts the unsigned to
          // signed, so if we plan to actually multiply by expSign...
          int32_t exponent = 0;
          // Sign of the exponent.
          int32_t expSign = 1;
        
          aToken.mHasSign = (c == '+' || c == '-');
          if (aToken.mHasSign) {
            Advance();
            c = Peek();
          }
        
          bool gotDot = (c == '.');
        
          if (!gotDot) {
            // Scan the integer part of the mantissa.
            Debug.Assert(IsDigit(c), "should have been excluded by logic above");
            do {
              intPart = 10*intPart + DecimalDigitValue(c);
              Advance();
              c = Peek();
            } while (IsDigit(c));
        
            gotDot = (c == '.') && IsDigit(Peek(1));
          }
        
          if (gotDot) {
            // Scan the fractional part of the mantissa.
            Advance();
            c = Peek();
            Debug.Assert(IsDigit(c), "should have been excluded by logic above");
            // Power of ten by which we need to divide our next digit
            double divisor = 10;
            do {
              fracPart += DecimalDigitValue(c) / divisor;
              divisor *= 10;
              Advance();
              c = Peek();
            } while (IsDigit(c));
          }
        
          bool gotE = false;
          if (IsSVGMode() && (c == 'e' || c == 'E')) {
            int32_t expSignChar = Peek(1);
            int32_t nextChar = Peek(2);
            if (IsDigit(expSignChar) ||
                ((expSignChar == '-' || expSignChar == '+') && IsDigit(nextChar))) {
              gotE = true;
              if (expSignChar == '-') {
                expSign = -1;
              }
              Advance(); // consumes the E
              if (expSignChar == '-' || expSignChar == '+') {
                Advance();
                c = nextChar;
              } else {
                c = expSignChar;
              }
              Debug.Assert(IsDigit(c), "should have been excluded by logic above");
              do {
                exponent = 10*exponent + DecimalDigitValue(c);
                Advance();
                c = Peek();
              } while (IsDigit(c));
            }
          }
        
          nsCSSTokenType type = nsCSSTokenType.Number;
        
          // Set mIntegerValid for all cases (except %, below) because we need
          // it for the "2n" in :nth-child(2n).
          aToken.mIntegerValid = false;
        
          // Time to reassemble our number.
          // Do all the math in double precision so it's truncated only once.
          double value = sign * (intPart + fracPart);
          if (gotE) {
            // Explicitly cast expSign*exponent to double to avoid issues with
            // overloaded Math.Pow() on Windows.
            value *= Math.Pow(10.0, ((double)(expSign * exponent)));
          } else if (!gotDot) {
            // Clamp values outside of integer range.
            if (sign > 0) {
              aToken.mInteger = ((int32_t)(Math.Min(intPart, ((double)(Int32.MaxValue)))));
            } else {
              aToken.mInteger = ((int32_t)(Math.Max(-intPart, ((double)(Int32.MinValue)))));
            }
            aToken.mIntegerValid = true;
          }
        
          StringBuilder ident = aToken.mIdent;
        
          // Check for Dimension and Percentage tokens.
          if (c >= 0) {
            if (StartsIdent(c, Peek(1))) {
              if (GatherText(IS_IDCHAR, ident)) {
                type = nsCSSTokenType.Dimension;
              }
            } else if (c == '%') {
              Advance();
              type = nsCSSTokenType.Percentage;
              value = value / 100.0f;
              aToken.mIntegerValid = false;
            }
          }
          aToken.mNumber = (float)value;
          aToken.mType = type;
          return true;
        }
        
        /**
         * Scan a string constant ('foo' or "foo").  Will always produce
         * either a String or a Bad_String token; the latter occurs when the
         * close quote is missing.  Always returns true (for convenience in Next()).
         */
        internal bool ScanString(nsCSSToken aToken)
        {
          int32_t aStop = Peek();
          Debug.Assert(aStop == '"' || aStop == '\'', "should not have been called");
          aToken.mType = nsCSSTokenType.String;
          aToken.mSymbol = ((PRUnichar)(aStop)); // Remember how it's quoted.
          Advance();
        
          for (;;) {
            GatherText(IS_STRING, aToken.mIdent);
        
            int32_t ch = Peek();
            if (ch == -1) {
              break; // EOF ends a string token with no error.
            }
            if (ch == aStop) {
              Advance();
              break;
            }
            // Both " and ' are excluded from IS_STRING.
            if (ch == '"' || ch == '\'') {
              aToken.mIdent.Append(ch);
              Advance();
              continue;
            }
        
            aToken.mType = nsCSSTokenType.Bad_String;
            mReporter.ReportUnexpected("SEUnterminatedString", aToken);
            break;
          }
          return true;
        }
        
        /**
         * Scan a unicode-range token.  These match the regular expression
         *
         *     u\+[0-9a-f?]{1,6}(-[0-9a-f]{1,6})?
         *
         * However, some such tokens are "invalid".  There are three valid forms:
         *
         *     u+[0-9a-f]{x}              1 <= x <= 6
         *     u+[0-9a-f]{x}\?{y}         1 <= x+y <= 6
         *     u+[0-9a-f]{x}-[0-9a-f]{y}  1 <= x <= 6, 1 <= y <= 6
         *
         * All unicode-range tokens have their text recorded in mIdent; valid ones
         * are also decoded into mInteger and mInteger2, and mIntegerValid is set.
         * Note that this does not validate the numeric range, only the syntactic
         * form.
         */
        internal bool ScanURange(nsCSSToken aResult)
        {
          int32_t intro1 = Peek();
          int32_t intro2 = Peek(1);
          int32_t ch = Peek(2);
        
          Debug.Assert((intro1 == 'u' || intro1 == 'U') &&
                     intro2 == '+' &&
                     (IsHexDigit(ch) || ch == '?'),
                     "should not have been called");
        
          aResult.mIdent.Append(intro1);
          aResult.mIdent.Append(intro2);
          Advance(2);
        
          bool valid = true;
          bool haveQues = false;
          uint32_t low = 0;
          uint32_t high = 0;
          int i = 0;
        
          do {
            aResult.mIdent.Append(ch);
            if (IsHexDigit(ch)) {
              if (haveQues) {
                valid = false; // All question marks should be at the end.
              }
              low = low*16 + HexDigitValue(ch);
              high = high*16 + HexDigitValue(ch);
            } else {
              haveQues = true;
              low = low*16 + 0x0;
              high = high*16 + 0xF;
            }
        
            i++;
            Advance();
            ch = Peek();
          } while (i < 6 && (IsHexDigit(ch) || ch == '?'));
        
          if (ch == '-' && IsHexDigit(Peek(1))) {
            if (haveQues) {
              valid = false;
            }
        
            aResult.mIdent.Append(ch);
            Advance();
            ch = Peek();
            high = 0;
            i = 0;
            do {
              aResult.mIdent.Append(ch);
              high = high*16 + HexDigitValue(ch);
        
              i++;
              Advance();
              ch = Peek();
            } while (i < 6 && IsHexDigit(ch));
          }
        
          aResult.mInteger = low;
          aResult.mInteger2 = high;
          aResult.mIntegerValid = valid;
          aResult.mType = nsCSSTokenType.URange;
          return true;
        }
        
        /**
         * Consume the part of an URL token after the initial 'url('.  Caller
         * is assumed to have consumed 'url(' already.  Will always produce
         * either an URL or a Bad_URL token.
         *
         * Exposed for use by nsCSSParser.ParseMozDocumentRule, which applies
         * the special lexical rules for URL tokens in a nonstandard context.
         */
        internal bool NextURL(nsCSSToken aToken)
        {
          SkipWhitespace();
        
          int32_t ch = Peek();
          if (ch < 0) {
            return false;
          }
        
          // aToken.mIdent may be "url" at this point; clear that out
          aToken.mIdent.Truncate();
        
          // Do we have a string?
          if (ch == '"' || ch == '\'') {
            ScanString(aToken);
            if (aToken.mType == nsCSSTokenType.Bad_String) {
              aToken.mType = nsCSSTokenType.Bad_URL;
              return true;
            }
            Debug.Assert(aToken.mType == nsCSSTokenType.String, "unexpected token type");
        
          } else {
            // Otherwise, this is the start of a non-quoted url (which may be empty).
            aToken.mSymbol = ((PRUnichar)(0));
            GatherText(IS_URL_CHAR, aToken.mIdent);
          }
        
          // Consume trailing whitespace and then look for a close parenthesis.
          SkipWhitespace();
          ch = Peek();
          if (ch < 0 || ch == ')') {
            Advance();
            aToken.mType = nsCSSTokenType.URL;
          } else {
            aToken.mType = nsCSSTokenType.Bad_URL;
          }
          return true;
        }
        
        /**
         * Primary scanner entry point.  Consume one token and fill in
         * |aToken| accordingly.  Will skip over any number of comments first,
         * and will also skip over rather than return whitespace tokens if
         * |aSkipWS| is true.
         *
         * Returns true if it successfully consumed a token, false if EOF has
         * been reached.  Will always advance the current read position by at
         * least one character unless called when already at EOF.
         */
        internal bool Next(nsCSSToken aToken, bool aSkipWS)
        {
          int32_t ch;
        
          // do this here so we don't have to do it in dozens of other places
          aToken.mIdent.Truncate();
          aToken.mType = nsCSSTokenType.Symbol;
        
          for (;;) {
            // Consume any number of comments, and possibly also whitespace tokens,
            // in between other tokens.
            mTokenOffset = mOffset;
            mTokenLineOffset = mLineOffset;
            mTokenLineNumber = mLineNumber;
        
            ch = Peek();
            if (IsWhitespace(ch)) {
              SkipWhitespace();
              if (!aSkipWS) {
                aToken.mType = nsCSSTokenType.Whitespace;
                return true;
              }
              continue; // start again at the beginning
            }
            if (ch == '/' && !IsSVGMode() && Peek(1) == '*') {
              // FIXME: Editor wants comments to be preserved (bug 60290).
              SkipComment();
              continue; // start again at the beginning
            }
            break;
          }
        
          // EOF
          if (ch < 0) {
            return false;
          }
        
          // 'u' could be UNICODE-RANGE or an identifier-family token
          if (ch == 'u' || ch == 'U') {
            int32_t c2 = Peek(1);
            int32_t c3 = Peek(2);
            if (c2 == '+' && (IsHexDigit(c3) || c3 == '?')) {
              return ScanURange(aToken);
            }
            return ScanIdent(aToken);
          }
        
          // identifier family
          if (IsIdentStart(ch)) {
            return ScanIdent(aToken);
          }
        
          // number family
          if (IsDigit(ch)) {
            return ScanNumber(aToken);
          }
        
          if (ch == '.' && IsDigit(Peek(1))) {
            return ScanNumber(aToken);
          }
        
          if (ch == '+') {
            int32_t c2 = Peek(1);
            if (IsDigit(c2) || (c2 == '.' && IsDigit(Peek(2)))) {
              return ScanNumber(aToken);
            }
          }
        
          // '-' can start an identifier-family token, a number-family token,
          // or an HTML-comment
          if (ch == '-') {
            int32_t c2 = Peek(1);
            int32_t c3 = Peek(2);
            if (IsIdentStart(c2)) {
              return ScanIdent(aToken);
            }
            if (IsDigit(c2) || (c2 == '.' && IsDigit(c3))) {
              return ScanNumber(aToken);
            }
            if (c2 == '-' && c3 == '>') {
              Advance(3);
              aToken.mType = nsCSSTokenType.HTMLComment;
              aToken.mIdent.AssignLiteral("-.");
              return true;
            }
          }
        
          // the other HTML-comment token
          if (ch == '<' && Peek(1) == '!' && Peek(2) == '-' && Peek(3) == '-') {
            Advance(4);
            aToken.mType = nsCSSTokenType.HTMLComment;
            aToken.mIdent.AssignLiteral("<!--");
            return true;
          }
        
          // AT_KEYWORD
          if (ch == '@') {
            return ScanAtKeyword(aToken);
          }
        
          // HASH
          if (ch == '#') {
            return ScanHash(aToken);
          }
        
          // STRING
          if (ch == '"' || ch == '\'') {
            return ScanString(aToken);
          }
        
          // Match operators: ~= |= ^= $= *=
          nsCSSTokenType opType = MatchOperatorType(ch);
          if (opType != nsCSSTokenType.Symbol && Peek(1) == '=') {
            aToken.mType = opType;
            Advance(2);
            return true;
          }
        
          // Otherwise, a symbol (DELIM).
          aToken.mSymbol = (char)ch;
          Advance();
          return true;
        }
    }
}
