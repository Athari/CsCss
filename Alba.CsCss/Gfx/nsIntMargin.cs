using System;

// ReSharper disable NonReadonlyFieldInGetHashCode
namespace Alba.CsCss.Gfx
{
    internal struct nsIntMargin : IEquatable<nsIntMargin>
    {
        public int top, right, bottom, left;

        public nsIntMargin (int top, int right, int bottom, int left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public bool Equals (nsIntMargin other)
        {
            return top == other.top && right == other.right && bottom == other.bottom && left == other.left;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(null, obj) && (obj is nsIntMargin && Equals((nsIntMargin)obj));
        }

        public override int GetHashCode ()
        {
            unchecked {
                var hashCode = top.GetHashCode();
                hashCode = (hashCode * 397) ^ right.GetHashCode();
                hashCode = (hashCode * 397) ^ bottom.GetHashCode();
                hashCode = (hashCode * 397) ^ left.GetHashCode();
                return hashCode;
            }
        }

        public static bool operator == (nsIntMargin left, nsIntMargin right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsIntMargin left, nsIntMargin right)
        {
            return !left.Equals(right);
        }
    }
}