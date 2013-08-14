namespace Alba.CsCss.Style
{
    internal class nsCSSDataBlock
    {
        protected static bool MoveValue (ref nsCSSValue aSource, ref nsCSSValue aDest)
        {
            bool changed = aSource != aDest;
            aDest = aSource;
            aSource.Reset();
            return changed;
        }
    }
}