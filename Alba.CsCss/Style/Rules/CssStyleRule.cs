using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mSelector} \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class CssStyleRule : CssRule
    {
        private readonly CssSelectorGroup mSelector;
        private readonly CssDeclaration mDeclaration;
        private int mLineNumber;

        internal CssStyleRule (CssSelectorGroup aSelector, CssDeclaration aDeclaration)
        {
            mSelector = aSelector;
            mDeclaration = aDeclaration;
        }

        internal void SetLineNumber (int aLineNumber)
        {
            mLineNumber = aLineNumber;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.Style;
        }

        // My

        internal override void Fix ()
        {
            base.Fix();
            mDeclaration.Fix();
        }

        // Public interface

        public IEnumerable<CssSelectorGroup> SelectorGroups
        {
            get { return CssSelectorGroup.TraverseList(mSelector); }
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