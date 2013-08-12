using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal abstract class BasicFloatCalcOps
    {
        public float MergeAdditive (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Plus || aCalcFunction == nsCSSUnit.Calc_Minus, "unexpected unit");
            return aCalcFunction == nsCSSUnit.Calc_Plus ? aValue1 + aValue2 : aValue1 - aValue2;
        }

        public float MergeMultiplicativeL (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Times_L, "unexpected unit");
            return aValue1 * aValue2;
        }

        public float MergeMultiplicativeR (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Times_R || aCalcFunction == nsCSSUnit.Calc_Divided, "unexpected unit");
            return aCalcFunction == nsCSSUnit.Calc_Times_R ? aValue1 * aValue2 : aValue1 / aValue2;
        }
    };
}