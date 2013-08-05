using System.Collections.Generic;

namespace Alba.CsCss.Style
{
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