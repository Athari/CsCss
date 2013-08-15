using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@page \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class nsCSSPageRule : Rule
    {
        private readonly CssDeclaration mDeclaration;

        internal nsCSSPageRule (CssDeclaration aDeclaration)
        {
            mDeclaration = aDeclaration;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.PAGE;
        }

        // Public interface

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}