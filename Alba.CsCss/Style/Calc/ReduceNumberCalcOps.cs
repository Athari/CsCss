using System;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal class ReduceNumberCalcOps : BasicFloatCalcOps /*, CSSValueInputCalcOps*/
    {
        public float ComputeLeafValue (nsCSSValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == nsCSSUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }

        public float ComputeNumber (nsCSSValue aValue)
        {
            //return ComputeCalc(aValue, this);
            throw new NotImplementedException();
        }

        public static nsCSSUnit GetUnit (nsCSSValue aValue)
        {
            return aValue.GetUnit();
        }
    }
}