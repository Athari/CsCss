using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@page \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class CssPageRule : CssRule
    {
        private readonly CssDeclaration mDeclaration;

        internal CssPageRule (CssDeclaration aDeclaration)
        {
            mDeclaration = aDeclaration;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.Page;
        }

        // Public interface

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}