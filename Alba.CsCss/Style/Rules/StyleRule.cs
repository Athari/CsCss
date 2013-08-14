using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mSelector} \{ {mDeclaration.DebugDisplayCount,nq} \}")]
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