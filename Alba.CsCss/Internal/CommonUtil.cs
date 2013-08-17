using System;
using System.Diagnostics;
using Alba.CsCss.Internal.Extensions;
using Alba.CsCss.Style;
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

        internal static TResult ComputeCalc<TInput, TResult> (TInput aValue, ICalcOps<TInput, TResult> aOps)
            where TInput : ICalcOpsInput<TInput>
        {
            switch (aOps.GetUnit(aValue)) {
                case CssUnit.Calc: {
                    TInput[] arr = aValue.GetArrayValue();
                    Debug.Assert(arr.Count() == 1, "unexpected length");
                    return ComputeCalc(arr.Item(0), aOps);
                }
                case CssUnit.CalcPlus:
                case CssUnit.CalcMinus: {
                    TInput[] arr = aValue.GetArrayValue();
                    Debug.Assert(arr.Count() == 2, "unexpected length");
                    TResult lhs = ComputeCalc(arr.Item(0), aOps), rhs = ComputeCalc(arr.Item(1), aOps);
                    return aOps.MergeAdditive(aOps.GetUnit(aValue), lhs, rhs);
                }
                case CssUnit.CalcTimesL: {
                    TInput[] arr = aValue.GetArrayValue();
                    Debug.Assert(arr.Count() == 2, "unexpected length");
                    TResult lhs = aOps.ComputeNumber(arr.Item(0)), rhs = ComputeCalc(arr.Item(1), aOps);
                    return aOps.MergeMultiplicativeL(aOps.GetUnit(aValue), lhs, rhs);
                }
                case CssUnit.CalcTimesR:
                case CssUnit.CalcDivided: {
                    TInput[] arr = aValue.GetArrayValue();
                    Debug.Assert(arr.Count() == 2, "unexpected length");
                    TResult lhs = ComputeCalc(arr.Item(0), aOps), rhs = aOps.ComputeNumber(arr.Item(1));
                    return aOps.MergeMultiplicativeR(aOps.GetUnit(aValue), lhs, rhs);
                }
                default: {
                    return aOps.ComputeLeafValue(aValue);
                }
            }
        }
    }
}