namespace Alba.CsCss.Style
{
    internal class StyleRule : Rule
    {
        private nsCSSSelectorList mSelector;
        private Declaration mDeclaration;
        private int mLineNumber;

        public StyleRule (nsCSSSelectorList aSelector, Declaration aDeclaration)
        {
            mSelector = aSelector;
            mDeclaration = aDeclaration;
        }

        public void SetLineNumber (int aLineNumber)
        {
            mLineNumber = aLineNumber;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.STYLE;
        }
    }
}