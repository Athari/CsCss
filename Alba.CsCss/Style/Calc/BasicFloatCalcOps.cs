using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal abstract class BasicFloatCalcOps
    {
        public float MergeAdditive (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.Calc_Plus || aCalcFunction == CssUnit.Calc_Minus, "unexpected unit");
            return aCalcFunction == CssUnit.Calc_Plus ? aValue1 + aValue2 : aValue1 - aValue2;
        }

        public float MergeMultiplicativeL (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.Calc_Times_L, "unexpected unit");
            return aValue1 * aValue2;
        }

        public float MergeMultiplicativeR (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.Calc_Times_R || aCalcFunction == CssUnit.Calc_Divided, "unexpected unit");
            return aCalcFunction == CssUnit.Calc_Times_R ? aValue1 * aValue2 : aValue1 / aValue2;
        }
    };
}