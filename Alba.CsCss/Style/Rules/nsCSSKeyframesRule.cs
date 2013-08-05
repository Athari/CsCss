namespace Alba.CsCss.Style
{
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