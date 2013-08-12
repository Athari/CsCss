using System.Diagnostics;
using Alba.CsCss.Internal;

namespace Alba.CsCss.Style
{
    internal class ReduceNumberCalcOps : BasicFloatCalcOps /*, CSSValueInputCalcOps*/, ICalcOps<nsCSSValue, float>
    {
        public float ComputeLeafValue (nsCSSValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == nsCSSUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }

        public float ComputeNumber (nsCSSValue aValue)
        {
            return CommonUtil.ComputeCalc(aValue, this);
        }

        public nsCSSUnit GetUnit (nsCSSValue aValue)
        {
            return aValue.GetUnit();
        }
    }
}