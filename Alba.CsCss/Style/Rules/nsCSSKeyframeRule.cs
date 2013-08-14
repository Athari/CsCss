using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mKeys[0]}% \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    internal class nsCSSKeyframeRule : Rule
    {
        private List<float> mKeys;
        private Declaration mDeclaration;

        public nsCSSKeyframeRule (List<float> aKeys, Declaration aDeclaration)
        {
            mKeys = aKeys;
            mDeclaration = aDeclaration;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.KEYFRAME;
        }
    }
}