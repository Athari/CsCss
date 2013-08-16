using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@keyframes {mName} \{ ({mRules.Count}) \}")]
    public class CssKeyframesRule : CssGroupRule
    {
        private readonly string mName;

        internal CssKeyframesRule (string aName)
        {
            mName = aName;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.KEYFRAMES;
        }

        // Public interface

        public string Name
        {
            get { return mName; }
        }
    }
}