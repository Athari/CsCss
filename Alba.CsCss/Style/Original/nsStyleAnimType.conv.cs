//
// Generated file. Do not edit manually.
//

namespace Alba.CsCss.Style
{
    internal enum nsStyleAnimType
    {
        // requires a custom implementation in
        // nsStyleAnimation::ExtractComputedValue
        Custom,
      
        // nsStyleCoord with animatable values
        Coord,
      
        // same as Coord, except for one side of an nsStyleSides
        // listed in the same order as the NS_STYLE_* constants
        Sides_Top,
        Sides_Right,
        Sides_Bottom,
        Sides_Left,
      
        // similar, but for the *pair* of coord members of an nsStyleCorners
        // for the relevant corner
        Corner_TopLeft,
        Corner_TopRight,
        Corner_BottomRight,
        Corner_BottomLeft,
      
        // nscoord values
        nscoord,
      
        // enumerated values (stored in a uint8_t)
        // In order for a property to use this unit, _all_ of its enumerated values
        // must be listed in its keyword table, so that any enumerated value can be
        // converted into a string via a nsCSSValue of type eCSSUnit_Enumerated.
        EnumU8,
      
        // @float values
        @float,
      
        // nscolor values
        Color,
      
        // nsStyleSVGPaint values
        PaintServer,
      
        // nsRefPtr<nsCSSShadowArray> values
        Shadow,
      
        // property not animatable
        None
    }
} // namespace Alba.CsCss.Style
