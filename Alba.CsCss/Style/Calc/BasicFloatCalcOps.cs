using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal class BasicFloatCalcOps
    {
        //typedef float result_type;

        public float MergeAdditive (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            if (aCalcFunction == nsCSSUnit.Calc_Plus)
                return aValue1 + aValue2;
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Minus, "unexpected unit");
            return aValue1 - aValue2;
        }

        public float MergeMultiplicativeL (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Times_L, "unexpected unit");
            return aValue1 * aValue2;
        }

        public float MergeMultiplicativeR (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            if (aCalcFunction == nsCSSUnit.Calc_Times_R)
                return aValue1 * aValue2;
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Divided, "unexpected unit");
            return aValue1 / aValue2;
        }
    };
}