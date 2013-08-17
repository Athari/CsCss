using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal abstract class BasicFloatCalcOps
    {
        public float MergeAdditive (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.CalcPlus || aCalcFunction == CssUnit.CalcMinus, "unexpected unit");
            return aCalcFunction == CssUnit.CalcPlus ? aValue1 + aValue2 : aValue1 - aValue2;
        }

        public float MergeMultiplicativeL (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.CalcTimesL, "unexpected unit");
            return aValue1 * aValue2;
        }

        public float MergeMultiplicativeR (CssUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == CssUnit.CalcTimesR || aCalcFunction == CssUnit.CalcDivided, "unexpected unit");
            return aCalcFunction == CssUnit.CalcTimesR ? aValue1 * aValue2 : aValue1 / aValue2;
        }
    };
}