using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@media ... \{ ({mRules.Count}) \}")]
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

        public override void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            if (mMedia != null) {
                mMedia.SetStyleSheet(null);
                mMedia.SetStyleSheet(aSheet);
            }
            base.SetStyleSheet(aSheet);
        }
    }
}