using System.Diagnostics;
using System.Text;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@supports {mCondition} \{ ({mRules.Count}) \}")]
    public class CssSupportsRule : CssGroupRule
    {
        private readonly bool mUseGroup;
        private readonly string mCondition;

        internal CssSupportsRule (ref bool aConditionMet, StringBuilder aCondition)
        {
            mUseGroup = aConditionMet;
            mCondition = aCondition.ToString();
        }

        internal static bool PrefEnabled ()
        {
            return true;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.Supports;
        }

        // Public interface

        public bool IsSupported
        {
            get { return mUseGroup; }
        }

        public string Condition
        {
            get { return mCondition; }
        }
    }
}