//
// Generated file. Do not edit manually.
//

// TODO Convert comments to doc-comments
namespace Alba.CsCss.Style
{
    public enum CssUnit
    {
        Null         = 0,      // (n/a) null unit, value is not specified
        Auto         = 1,      // (n/a) value is algorithmic
        Inherit      = 2,      // (n/a) value is inherited
        Initial      = 3,      // (n/a) value is default UA value
        None         = 4,      // (n/a) value is none
        Normal       = 5,      // (n/a) value is normal (algorithmic, different than auto)
        SystemFont  = 6,      // (n/a) value is -moz-use-system-font
        All          = 7,      // (n/a) value is all
        Dummy        = 8,      // (n/a) a fake but specified value, used
                                        //       only in temporary values
        DummyInherit = 9,      // (n/a) a fake but specified value, used
                                        //       only in temporary values
      
        String       = 11,     // (PRUnichar*) a string value
        Ident        = 12,     // (PRUnichar*) a string value
        Families     = 13,     // (PRUnichar*) a string value
        Attr         = 14,     // (PRUnichar*) a attr(string) value
        LocalFont   = 15,     // (PRUnichar*) a local font name
        FontFormat  = 16,     // (PRUnichar*) a font format name
        Element      = 17,     // (PRUnichar*) an element id
      
        Array        = 20,     // (nsCSSValue::Array*) a list of values
        Counter      = 21,     // (nsCSSValue::Array*) a counter(string,[string]) value
        Counters     = 22,     // (nsCSSValue::Array*) a counters(string,string[,string]) value
        CubicBezier = 23,     // (nsCSSValue::Array*) a list of float values
        Steps        = 24,     // (nsCSSValue::Array*) a list of (integer, enumerated)
        Function     = 25,     // (nsCSSValue::Array*) a function with
                                        //  parameters.  First elem of array is name,
                                        //  the rest of the values are arguments.
      
        // The top level of a calc() expression is Calc.  All
        // remaining Calc* units only occur inside these toplevel
        // calc values.
      
        // Calc has an array with exactly 1 element.  Calc
        // exists so we can distinguish calc(2em) from 2em as specified values
        // (but we drop this distinction for nsStyleCoord when we store
        // computed values).
        Calc         = 30,     // (nsCSSValue::Array*) calc() value
        // Plus, Minus, Times_* and Divided have arrays with exactly 2
        // elements.  a + b + c + d is grouped as ((a + b) + c) + d
        CalcPlus    = 31,     // (nsCSSValue::Array*) + node within calc()
        CalcMinus   = 32,     // (nsCSSValue::Array*) - within calc
        CalcTimesL = 33,     // (nsCSSValue::Array*) num * val within calc
        CalcTimesR = 34,     // (nsCSSValue::Array*) val * num within calc
        CalcDivided = 35,     // (nsCSSValue::Array*) / within calc
      
        Url          = 40,     // (nsCSSValue::URL*) value
        Image        = 41,     // (nsCSSValue::Image*) value
        Gradient     = 42,     // (nsCSSValueGradient*) value
      
        Pair         = 50,     // (nsCSSValuePair*) pair of values
        Triplet      = 51,     // (nsCSSValueTriplet*) triplet of values
        Rect         = 52,     // (nsCSSRect*) rectangle (four values)
        List         = 53,     // (nsCSSValueList*) list of values
        ListDep      = 54,     // (nsCSSValueList*) same as List
                                        //   but does not own the list
        PairList     = 55,     // (nsCSSValuePairList*) list of value pairs
        PairListDep  = 56,     // (nsCSSValuePairList*) same as PairList
                                        //   but does not own the list
      
        Integer      = 70,     // (int) simple value
        Enumerated   = 71,     // (int) value has enumerated meaning
      
        EnumColor    = 80,     // (int) enumerated color (kColorKTable)
        Color        = 81,     // (nscolor) an RGBA value
      
        Percent      = 90,     // (float) 1.0 == 100%) value is percentage of something
        Number       = 91,     // (float) value is numeric (usually multiplier, different behavior that percent)
      
        // Physical length units
        PhysicalMillimeter = 200,   // (float) 1/25.4 inch
      
        // Length units - relative
        // Viewport relative measure
        ViewportWidth  = 700,    // (float) 1% of the width of the initial containing block
        ViewportHeight = 701,    // (float) 1% of the height of the initial containing block
        ViewportMin    = 702,    // (float) smaller of ViewportWidth and ViewportHeight
        ViewportMax    = 703,    // (float) larger of ViewportWidth and ViewportHeight
      
        // Font relative measure
        Em           = 800,    // (float) == current font size
        Xheight      = 801,    // (float) distance from top of lower case x to baseline
        Char         = 802,    // (float) number of characters, used for width with monospace font
        RootEm       = 803,    // (float) == root element font size
      
        // Screen relative measure
        Point        = 900,    // (float) 4/3 of a CSS pixel
        Inch         = 901,    // (float) 96 CSS pixels
        Millimeter   = 902,    // (float) 96/25.4 CSS pixels
        Centimeter   = 903,    // (float) 96/2.54 CSS pixels
        Pica         = 904,    // (float) 12 points == 16 CSS pixls
        Pixel        = 905,    // (float) CSS pixel unit
      
        // Angular units
        Degree       = 1000,    // (float) 360 per circle
        Grad         = 1001,    // (float) 400 per circle
        Radian       = 1002,    // (float) 2*pi per circle
        Turn         = 1003,    // (float) 1 per circle
      
        // Frequency units
        Hertz        = 2000,    // (float) 1/seconds
        Kilohertz    = 2001,    // (float) 1000 Hertz
      
        // Time units
        Seconds      = 3000,    // (float) Standard time
        Milliseconds = 3001     // (float) 1/1000 second
    }
}
