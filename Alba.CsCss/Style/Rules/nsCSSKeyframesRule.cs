using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@keyframes {mName} \{ ({mRules.Count}) \}")]
    internal class nsCSSKeyframesRule : GroupRule
    {
        private string mName;

        public nsCSSKeyframesRule (string aName)
        {
            mName = aName;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.KEYFRAMES;
        }
    }
}