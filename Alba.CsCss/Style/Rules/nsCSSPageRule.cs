using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@page \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class nsCSSPageRule : Rule
    {
        private readonly Declaration mDeclaration;

        internal nsCSSPageRule (Declaration aDeclaration)
        {
            mDeclaration = aDeclaration;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.PAGE;
        }

        // Public interface

        public Declaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}