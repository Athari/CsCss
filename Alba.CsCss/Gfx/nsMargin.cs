using System;

// ReSharper disable NonReadonlyFieldInGetHashCode
namespace Alba.CsCss.Gfx
{
    internal struct nsMargin : IEquatable<nsMargin>
    {
        public nscoord top, right, bottom, left;

        public nsMargin (nscoord top, nscoord right, nscoord bottom, nscoord left)
        {
            this.top = top;
            this.right = right;
            this.bottom = bottom;
            this.left = left;
        }

        public bool Equals (nsMargin other)
        {
            return top == other.top && right == other.right && bottom == other.bottom && left == other.left;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(null, obj) && (obj is nsMargin && Equals((nsMargin)obj));
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

        public static bool operator == (nsMargin left, nsMargin right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsMargin left, nsMargin right)
        {
            return !left.Equals(right);
        }
    }
}