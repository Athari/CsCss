using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mKeys[0]}% \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class nsCSSKeyframeRule : Rule
    {
        private readonly List<float> mKeys;
        private readonly Declaration mDeclaration;

        internal nsCSSKeyframeRule (List<float> aKeys, Declaration aDeclaration)
        {
            mKeys = aKeys;
            mDeclaration = aDeclaration;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.KEYFRAME;
        }

        // Public interface

        public IEnumerable<float> Keys
        {
            get { return mKeys.AsReadOnly(); }
        }

        public Declaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}