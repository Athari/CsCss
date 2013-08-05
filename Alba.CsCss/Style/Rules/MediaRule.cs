namespace Alba.CsCss.Style
{
    internal class MediaRule : GroupRule
    {
        private nsMediaList mMedia;

        public void SetMedia (nsMediaList aMedia)
        {
            mMedia = aMedia;
        }

        public override RuleKind GetKind ()
        {
            return RuleKind.MEDIA;
        }
    }
}