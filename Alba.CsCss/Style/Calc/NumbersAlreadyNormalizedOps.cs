using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal class NumbersAlreadyNormalizedOps : CSSValueInputCalcOps
    {
        public float ComputeNumber (CssValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == CssUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }
    };
}