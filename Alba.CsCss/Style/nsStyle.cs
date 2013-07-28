using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    internal partial class nsStyle
    {
        public const Side SIDE_TOP = Side.Top;
        public const Side SIDE_RIGHT = Side.Right;
        public const Side SIDE_BOTTOM = Side.Bottom;
        public const Side SIDE_LEFT = Side.Left;

        public bool HALF_CORNER_IS_X (int var)
        {
            return var % 2 == 0;
        }

        public int HALF_TO_FULL_CORNER (int var)
        {
            return var / 2;
        }

        public int FULL_TO_HALF_CORNER (int var, int vert)
        {
            return var * 2 + (vert != 0 ? 1 : 0);
        }

        public bool SIDE_IS_VERTICAL (int side)
        {
            return side % 2 != 0;
        }

        public int SIDE_TO_FULL_CORNER (int side, int second)
        {
            return (side + (second != 0 ? 1 : 0)) % 4;
        }

        public int SIDE_TO_HALF_CORNER (int side, int second, bool parallel)
        {
            return ((side + (second != 0 ? 1 : 0)) * 2 + (side + (parallel ? 0 : 1)) % 2) % 8;
        }
    }
}