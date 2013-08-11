using System;
using int32_t = System.Int32;
using uint32_t = System.UInt32;

namespace Alba.CsCss.Internal
{
    internal static class CommonUtil
    {
        public static int32_t NSToIntRound (float x)
        {
            return x >= 0.0f ? (int32_t)(x + 0.5f) : (int32_t)(x - 0.5f);
        }

        public static nsresult NS_NewURI (out Uri result, string spec, string charset, Uri baseUri)
        {
            return Uri.TryCreate(baseUri, spec, out result) ? nsresult.OK : nsresult.ERROR_MALFORMED_URI;
        }
    }
}