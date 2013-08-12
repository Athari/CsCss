namespace Alba.CsCss.Style
{
    internal abstract class Rule
    {
        private nsCSSStyleSheet mSheet;

        public virtual void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            mSheet = aSheet;
        }

        public nsCSSStyleSheet GetStyleSheet ()
        {
            return mSheet;
        }

        public abstract RuleKind GetKind ();
    }
}