using System;
using System.Diagnostics;
using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{mLeft}, {mTop}, {mRight}, {mBottom}")]
    public class CssRect
    {
        internal CssValue mTop, mRight, mBottom, mLeft;

        internal void SetAllSidesTo (CssValue aValue)
        {
            mTop = mRight = mBottom = mLeft = aValue;
        }

        // Public interface

        public CssValue Top
        {
            get { return mTop; }
        }

        public CssValue Right
        {
            get { return mRight; }
        }

        public CssValue Bottom
        {
            get { return mBottom; }
        }

        public CssValue Left
        {
            get { return mLeft; }
        }

        public CssValue GetSide (Side side)
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

        public void SetSide (Side side, CssValue aValue)
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