namespace Alba.CsCss.Style
{
    internal class nsCSSDataBlock
    {
        protected static bool MoveValue (nsCSSValue aSource, ref nsCSSValue aDest)
        {
            bool changed = aSource != aDest;
            aDest = aSource;
            aSource.Reset();
            return changed;
        }
    }
}