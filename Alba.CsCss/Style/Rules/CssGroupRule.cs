using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Style
{
    public abstract class CssGroupRule : CssRule
    {
        private readonly List<CssRule> mRules = new List<CssRule>();

        internal void AppendStyleRule (CssRule aRule)
        {
            mRules.Add(aRule);
        }

        internal override void SetStyleSheet (CssStyleSheet aSheet)
        {
            if (aSheet == GetStyleSheet())
                return;
            foreach (CssRule rule in mRules)
                if (rule != null)
                    rule.SetStyleSheet(aSheet);
            base.SetStyleSheet(aSheet);
        }

        // Public interface

        public IList<CssRule> Rules
        {
            get { return mRules; }
        }

        public IEnumerable<TRule> GetRules<TRule> () where TRule : CssRule
        {
            return mRules.OfType<TRule>();
        }
    }
}