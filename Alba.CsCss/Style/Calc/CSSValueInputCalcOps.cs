namespace Alba.CsCss.Style
{
    internal class CSSValueInputCalcOps
    {
        //typedef nsCSSValue input_type;
        //typedef nsCSSValue::Array input_array_type;

        public static CssUnit GetUnit (CssValue aValue)
        {
            return aValue.GetUnit();
        }
    }
}