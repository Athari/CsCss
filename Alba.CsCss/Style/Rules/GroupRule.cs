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
    }
}