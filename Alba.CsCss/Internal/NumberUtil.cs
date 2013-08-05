using int32_t = System.Int32;

namespace Alba.CsCss.Internal
{
    internal static class NumberUtil
    {
        public static int32_t NSToIntRound (float x)
        {
            return x >= 0.0f ? (int32_t)(x + 0.5f) : (int32_t)(x - 0.5f);
        }
    }
}