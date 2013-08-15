using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"{mKeys[0]}% \{ {mDeclaration.DebugDisplayCount,nq} \}")]
    public class nsCSSKeyframeRule : Rule
    {
        private readonly List<float> mKeys;
        private readonly CssDeclaration mDeclaration;

        internal nsCSSKeyframeRule (List<float> aKeys, CssDeclaration aDeclaration)
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

        public CssDeclaration Declaration
        {
            get { return mDeclaration; }
        }
    }
}