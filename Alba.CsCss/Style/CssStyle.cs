using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    public partial class CssStyle
    {
        public const Side SideTop = Side.Top;
        public const Side SideRight = Side.Right;
        public const Side SideBottom = Side.Bottom;
        public const Side SideLeft = Side.Left;

        internal bool HALF_CORNER_IS_X (int var)
        {
            return var % 2 == 0;
        }

        internal int HALF_TO_FULL_CORNER (int var)
        {
            return var / 2;
        }

        internal int FULL_TO_HALF_CORNER (int var, int vert)
        {
            return var * 2 + (vert != 0 ? 1 : 0);
        }

        internal bool SIDE_IS_VERTICAL (int side)
        {
            return side % 2 != 0;
        }

        internal int SIDE_TO_FULL_CORNER (int side, int second)
        {
            return (side + (second != 0 ? 1 : 0)) % 4;
        }

        internal int SIDE_TO_HALF_CORNER (int side, int second, bool parallel)
        {
            return ((side + (second != 0 ? 1 : 0)) * 2 + (side + (parallel ? 0 : 1)) % 2) % 8;
        }
    }
}