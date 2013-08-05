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

        public static uint32_t NS_NewURI (out Uri result, string spec, string charset, Uri baseUri)
        {
            // TODO nsresult NS_OK NS_ERROR_MALFORMED_URI
            return Uri.TryCreate(baseUri, spec, out result) ? 0u : 1u;
        }
    }
}