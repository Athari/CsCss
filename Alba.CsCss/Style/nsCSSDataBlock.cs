namespace Alba.CsCss.Style
{
    internal class nsCSSDataBlock
    {
        protected static bool MoveValue (ref CssValue aSource, ref CssValue aDest)
        {
            bool changed = aSource != aDest;
            aDest = aSource;
            aSource.Reset();
            return changed;
        }
    }
}