using System;

// ReSharper disable NonReadonlyFieldInGetHashCode
namespace Alba.CsCss.Gfx
{
    internal struct nsPoint : IEquatable<nsPoint>
    {
        public nscoord x, y;

        public nsPoint (nscoord x, nscoord y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Equals (nsPoint other)
        {
            return x == other.x && y == other.y;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(null, obj) && (obj is nsPoint && Equals((nsPoint)obj));
        }

        public override int GetHashCode ()
        {
            return unchecked ((x.GetHashCode() * 397) ^ y.GetHashCode());
        }

        public static bool operator == (nsPoint left, nsPoint right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsPoint left, nsPoint right)
        {
            return !left.Equals(right);
        }
    }
}