namespace Alba.CsCss.Style
{
    public abstract class CssRule
    {
        private CssStyleSheet mSheet;

        internal virtual void SetStyleSheet (CssStyleSheet aSheet)
        {
            mSheet = aSheet;
        }

        internal CssStyleSheet GetStyleSheet ()
        {
            return mSheet;
        }

        internal abstract CssRuleKind GetKind ();

        // My

        internal virtual void Fix ()
        {}

        // Public interface

        public CssRuleKind Kind
        {
            get { return GetKind(); }
        }
    }
}