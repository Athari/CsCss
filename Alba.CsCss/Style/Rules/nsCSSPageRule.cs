namespace Alba.CsCss.Style
{
    internal class nsCSSPageRule : Rule
    {
        private Declaration mDeclaration;

        public nsCSSPageRule (Declaration aDeclaration)
        {
            mDeclaration = aDeclaration;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.PAGE;
        }
    }
}