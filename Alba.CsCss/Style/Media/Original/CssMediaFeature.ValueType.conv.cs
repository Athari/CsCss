//
// Generated file. Do not edit manually.
//
// ReSharper disable RedundantUsingDirective
// ReSharper disable RedundantCast

namespace Alba.CsCss.Style
{
    public partial class CssMediaFeature
    {
        public enum ValueType {
            // All value types allow CSSUnit_Null to indicate that no value
            // was given (in addition to the types listed below).
            Length,     // values are such that nsCSSValue::IsLengthUnit() is true
            Integer,    // values are CSSUnit_Integer
            Float,      // values are CSSUnit_Number
            BoolInteger,// values are CSSUnit_Integer (0, -0, or 1 only)
            IntRatio,   // values are CSSUnit_Array of two CSSUnit_Integer
            Resolution, // values are in CSSUnit_Inch (for dpi),
                         //   CSSUnit_Pixel (for dppx), or
                         //   CSSUnit_Centimeter (for dpcm)
            Enumerated, // values are CSSUnit_Enumerated (uses keyword table)
            Ident       // values are CSSUnit_Ident
            // Note that a number of pieces of code (both for parsing and
            // for matching of valueless xpressions) assume that all numeric
            // value types cannot be negative.  The parsing code also does
            // not allow zeros in IntRatio types.
        }
    }
}
