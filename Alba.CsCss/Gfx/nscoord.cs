using System;

namespace Alba.CsCss.Gfx
{
    /// <summary>
    /// Basic type used for the geometry classes.
    /// 
    /// Normally all coordinates are maintained in an app unit coordinate
    /// space. An app unit is 1/60th of a CSS device pixel, which is, in turn
    /// an integer number of device pixels, such at the CSS DPI is as close to
    /// 96dpi as possible.
    /// </summary>
    internal struct nscoord : IEquatable<nscoord>
    {
        private readonly int _value;

        private nscoord (int value)
        {
            _value = value;
        }

        public static readonly nscoord MAX = new nscoord(1 << 30);
        public static readonly nscoord MIN = new nscoord(-MAX._value);

        public bool Equals (nscoord other)
        {
            return _value == other._value;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(null, obj) && (obj is nscoord && Equals((nscoord)obj));
        }

        public override int GetHashCode ()
        {
            return _value;
        }

        public static bool operator == (nscoord left, nscoord right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nscoord left, nscoord right)
        {
            return !left.Equals(right);
        }
    }
}