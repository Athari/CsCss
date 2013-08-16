using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mKeys[0]}% \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class CssKeyframeRule : CssRule
    {
        private readonly List<float> mKeys;
        private readonly CssDeclaration mDeclaration;

        internal CssKeyframeRule (List<float> aKeys, CssDeclaration aDeclaration)
        {
            mKeys = aKeys;
            mDeclaration = aDeclaration;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.KEYFRAME;
        }

        // Public interface

        public IEnumerable<float> Keys
        {
            get { return mKeys.AsReadOnly(); }
        }

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}