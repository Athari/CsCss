using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal abstract class GroupRule : Rule
    {
        private readonly List<Rule> mRules = new List<Rule>();

        public void AppendStyleRule (Rule aRule)
        {
            mRules.Add(aRule);
        }

        public override void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            if (aSheet == GetStyleSheet())
                return;
            foreach (Rule rule in mRules)
                if (rule != null)
                    rule.SetStyleSheet(aSheet);
            base.SetStyleSheet(aSheet);
        }
    }
}