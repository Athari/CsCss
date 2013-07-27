using System;

// ReSharper disable NonReadonlyFieldInGetHashCode
namespace Alba.CsCss.Gfx
{
    internal struct nsIntPoint : IEquatable<nsIntPoint>
    {
        public int x, y;

        public nsIntPoint (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public bool Equals (nsIntPoint other)
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

        public static bool operator == (nsIntPoint left, nsIntPoint right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsIntPoint left, nsIntPoint right)
        {
            return !left.Equals(right);
        }
    }
}