using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@media ... \{ ({mRules.Count}) \}")]
    public class CssMediaRule : CssGroupRule
    {
        private nsMediaList mMedia;

        internal CssMediaRule ()
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

        public IEnumerable<CssMediaQuery> MediaQueries
        {
            get { return mMedia.Queries; }
        }
    }
}