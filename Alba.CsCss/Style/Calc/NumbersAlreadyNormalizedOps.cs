using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal class NumbersAlreadyNormalizedOps : CSSValueInputCalcOps
    {
        public float ComputeNumber (nsCSSValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == nsCSSUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }
    };
}