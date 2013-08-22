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

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.Media;
        }

        internal override void SetStyleSheet (CssStyleSheet aSheet)
        {
            if (mMedia != null) {
                mMedia.SetStyleSheet(null);
                mMedia.SetStyleSheet(aSheet);
            }
            base.SetStyleSheet(aSheet);
        }

        // Public interface

        public IList<CssMediaQuery> MediaQueries
        {
            get { return mMedia.Queries; }
        }
    }
}