using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@media ... \{ ({mRules.Count}) \}")]
    public class MediaRule : GroupRule
    {
        private nsMediaList mMedia;

        internal MediaRule ()
        {}

        internal void SetMedia (nsMediaList aMedia)
        {
            mMedia = aMedia;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.MEDIA;
        }

        internal override void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            if (mMedia != null) {
                mMedia.SetStyleSheet(null);
                mMedia.SetStyleSheet(aSheet);
            }
            base.SetStyleSheet(aSheet);
        }

        // Public interface

        public IEnumerable<nsMediaQuery> MediaQueries
        {
            get { return mMedia.Queries; }
        }
    }
}