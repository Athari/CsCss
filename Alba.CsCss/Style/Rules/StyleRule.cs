using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mSelector} \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class StyleRule : Rule
    {
        private readonly nsCSSSelectorList mSelector;
        private readonly Declaration mDeclaration;
        private int mLineNumber;

        internal StyleRule (nsCSSSelectorList aSelector, Declaration aDeclaration)
        {
            mSelector = aSelector;
            mDeclaration = aDeclaration;
        }

        internal void SetLineNumber (int aLineNumber)
        {
            mLineNumber = aLineNumber;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.STYLE;
        }

        // Public interface

        public nsCSSSelectorList Selector
        {
            get { return mSelector; }
        }

        public Declaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}