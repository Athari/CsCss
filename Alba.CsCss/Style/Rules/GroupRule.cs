using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Style
{
    public abstract class GroupRule : Rule
    {
        private readonly List<Rule> mRules = new List<Rule>();

        internal void AppendStyleRule (Rule aRule)
        {
            mRules.Add(aRule);
        }

        internal override void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            if (aSheet == GetStyleSheet())
                return;
            foreach (Rule rule in mRules)
                if (rule != null)
                    rule.SetStyleSheet(aSheet);
            base.SetStyleSheet(aSheet);
        }

        // Public interface

        public IEnumerable<Rule> Rules
        {
            get { return mRules.AsReadOnly(); }
        }

        public IEnumerable<TRule> GetRules<TRule> () where TRule : Rule
        {
            return mRules.OfType<TRule>();
        }
    }
}