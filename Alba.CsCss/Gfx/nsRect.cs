namespace Alba.CsCss.Gfx
{
    /// <summary>
    /// Rectangles have two interpretations: a set of (zero-size) points,
    /// and a rectangular area of the plane. Most rectangle operations behave
    /// the same no matter what interpretation is being used, but some operations
    /// differ:
    /// -- Equality tests behave differently. When a rectangle represents an area,
    /// all zero-width and zero-height rectangles are equal to each other since they
    /// represent the empty area. But when a rectangle represents a set of
    /// mathematical points, zero-width and zero-height rectangles can be unequal.
    /// -- The union operation can behave differently. When rectangles represent
    /// areas, taking the union of a zero-width or zero-height rectangle with
    /// another rectangle can just ignore the empty rectangle. But when rectangles
    /// represent sets of mathematical points, we may need to extend the latter
    /// rectangle to include the points of a zero-width or zero-height rectangle.
    ///
    /// To ensure that these interpretations are explicitly disambiguated, we
    /// deny access to the == and != operators and require use of IsEqualEdges and
    /// IsEqualInterior instead. Similarly we provide separate Union and UnionEdges
    /// methods.
    /// </summary>
    internal struct nsRect
    {
        public nscoord x, y, width, height;

        public nsRect (nscoord x, nscoord y, nscoord width, nscoord height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}