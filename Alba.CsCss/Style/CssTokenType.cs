namespace Alba.CsCss.Style
{
    // Token types; in close but not perfect correspondence to the token
    // categorization in section 4.1.1 of CSS2.1.  (The deviations are all
    // the fault of css3-selectors, which has requirements that can only be
    // met by changing the generic tokenization.)  The comment on each line
    // illustrates the form of each identifier.
    public enum CssTokenType
    {
        // White space of any kind.  No value fields are used.  Note that
        // comments do *not* count as white space; comments separate tokens
        // but are not themselves tokens.
        Whitespace, //

        // Identifier-like tokens.  mIdent is the text of the identifier.
        // The difference between ID and Hash is: if the text after the #
        // would have been a valid Ident if the # hadn't been there, the
        // scanner produces an ID token.  Otherwise it produces a Hash token.
        // (This distinction is required by css3-selectors.)
        Ident, // word
        Function, // word(
        AtKeyword, // @word
        ID, // #word
        Hash, // #0word

        // Numeric tokens.  mNumber is the floating-point value of the
        // number, and mHasSign indicates whether there was an explicit sign
        // (+ or -) in front of the number.  If mIntegerValid is true, the
        // number had the lexical form of an integer, and mInteger is its
        // integer value.  Lexically integer values outside the range of a
        // 32-bit signed number are clamped to the maximum values; mNumber
        // will indicate a 'truer' value in that case.  Percentage tokens
        // are always considered not to be integers, even if their numeric
        // value is integral (100% => mNumber = 1.0).  For Dimension
        // tokens, mIdent holds the text of the unit.
        Number, // 1 -5 +2e3 3.14159 7.297352e-3
        Dimension, // 24px 8.5in
        Percentage, // 85% 1280.4%

        // String-like tokens.  In all cases, mIdent holds the text
        // belonging to the string, and mSymbol holds the delimiter
        // character, which may be ', ", or zero (only for unquoted URLs).
        // Bad_String and Bad_URL tokens are emitted when the closing
        // delimiter or parenthesis was missing.
        String, // 'foo bar' "foo bar"
        Bad_String, // 'foo bar
        URL, // url(foobar) url("foo bar")
        Bad_URL, // url(foo

        // Any one-character symbol.  mSymbol holds the character.
        Symbol, // . ; { } ! *

        // Match operators.  These are single tokens rather than pairs of
        // Symbol tokens because css3-selectors forbids the presence of
        // comments between the two characters.  No value fields are used;
        // the token type indicates which operator.
        Includes, // ~=
        Dashmatch, // |=
        Beginsmatch, // ^=
        Endsmatch, // $=
        Containsmatch, // *=

        // Unicode-range token: currently used only in @font-face.
        // The lexical rule for this token includes several forms that are
        // semantically invalid.  Therefore, mIdent always holds the
        // complete original text of the token (so we can print it
        // accurately in diagnostics), and mIntegerValid is true iff the
        // token is semantically valid.  In that case, mInteger holds the
        // lowest value included in the range, and mInteger2 holds the
        // highest value included in the range.
        URange, // U+007e U+01?? U+2000-206F

        // HTML comment delimiters, ignored as a unit when they appear at
        // the top level of a style sheet, for compatibility with websites
        // written for compatibility with pre-CSS browsers.  This token type
        // subsumes the css2.1 CDO and CDC tokens, which are always treated
        // the same by the parser.  mIdent holds the text of the token, for
        // diagnostics.
        HTMLComment, // <!-- -->
    };
}