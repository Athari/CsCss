using System;
using System.Diagnostics;
using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mLeft}, {mTop}, {mRight}, {mBottom}")]
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

        public nsCSSValue GetSide (Side side)
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

        public void SetSide (Side side, nsCSSValue aValue)
        {
            switch (side) {
                case Side.Top:
                    mTop = aValue;
                    break;
                case Side.Right:
                    mRight = aValue;
                    break;
                case Side.Bottom:
                    mBottom = aValue;
                    break;
                case Side.Left:
                    mLeft = aValue;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("side");
            }
        }
    }
}