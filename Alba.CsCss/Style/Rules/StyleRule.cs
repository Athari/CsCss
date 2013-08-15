using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mSelector} \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class StyleRule : Rule
    {
        private readonly nsCSSSelectorList mSelector;
        private readonly CssDeclaration mDeclaration;
        private int mLineNumber;

        internal StyleRule (nsCSSSelectorList aSelector, CssDeclaration aDeclaration)
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

        public IEnumerable<nsCSSSelectorList> SelectorGroups
        {
            get { return mSelector.Items; }
        }

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }

        public int LineNumber
        {
            get { return mLineNumber; }
        }
    }
}