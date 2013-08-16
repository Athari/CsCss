using System.Diagnostics;
using Alba.CsCss.Internal;

namespace Alba.CsCss.Style
{
    internal class ReduceNumberCalcOps : BasicFloatCalcOps /*, CSSValueInputCalcOps*/, ICalcOps<CssValue, float>
    {
        public float ComputeLeafValue (CssValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == CssUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }

        public float ComputeNumber (CssValue aValue)
        {
            return CommonUtil.ComputeCalc(aValue, this);
        }

        public CssUnit GetUnit (CssValue aValue)
        {
            return aValue.GetUnit();
        }
    }
}