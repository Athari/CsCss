using System;
using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    public class nsCSSRect
    {
        internal nsCSSValue mTop, mRight, mBottom, mLeft;

        internal void SetAllSidesTo (nsCSSValue aValue)
        {
            mTop = mRight = mBottom = mLeft = aValue;
        }

        // Public interface

        public nsCSSValue Top
        {
            get { return mTop; }
        }

        public nsCSSValue Right
        {
            get { return mRight; }
        }

        public nsCSSValue Bottom
        {
            get { return mBottom; }
        }

        public nsCSSValue Left
        {
            get { return mLeft; }
        }

        public nsCSSValue this [Side side]
        {
            get
            {
                switch (side) {
                    case Side.Top:
                        return mTop;
                    case Side.Right:
                        return mRight;
                    case Side.Bottom:
                        return mBottom;
                    case Side.Left:
                        return mLeft;
                    default:
                        throw new ArgumentOutOfRangeException("side");
                }
            }
            set
            {
                switch (side) {
                    case Side.Top:
                        mTop = value;
                        break;
                    case Side.Right:
                        mRight = value;
                        break;
                    case Side.Bottom:
                        mBottom = value;
                        break;
                    case Side.Left:
                        mLeft = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("side");
                }
            }
        }
    }
}