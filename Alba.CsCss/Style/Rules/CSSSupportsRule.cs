using System.Text;

namespace Alba.CsCss.Style
{
    internal class CSSSupportsRule : GroupRule
    {
        private bool mUseGroup;
        private string mCondition;

        public CSSSupportsRule (ref bool aConditionMet, StringBuilder aCondition)
        {
            mUseGroup = aConditionMet;
            mCondition = aCondition.ToString();
        }

        public static bool PrefEnabled ()
        {
            return true;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.SUPPORTS;
        }
    }
}