namespace Alba.CsCss.Style
{
    public abstract class Rule
    {
        private nsCSSStyleSheet mSheet;

        internal virtual void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            mSheet = aSheet;
        }

        internal nsCSSStyleSheet GetStyleSheet ()
        {
            return mSheet;
        }

        internal abstract RuleKind GetKind ();

        // Public interface

        public RuleKind Kind
        {
            get { return GetKind(); }
        }
    }
}