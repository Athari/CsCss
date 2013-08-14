using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@page \{ {mDeclaration.DebugDisplayCount,nq} \}")]
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