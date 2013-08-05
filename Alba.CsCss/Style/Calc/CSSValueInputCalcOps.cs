namespace Alba.CsCss.Style
{
    internal class CSSValueInputCalcOps
    {
        //typedef nsCSSValue input_type;
        //typedef nsCSSValue::Array input_array_type;

        public static nsCSSUnit GetUnit (nsCSSValue aValue)
        {
            return aValue.GetUnit();
        }
    }
}