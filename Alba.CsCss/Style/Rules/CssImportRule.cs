using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@import ""{mUrlSpec}""")]
    public class CssImportRule : CssRule
    {
        private readonly nsMediaList mMedia;
        private readonly string mUrlSpec;

        internal CssImportRule (nsMediaList aMedia, string aUrlSpec)
        {
            mMedia = aMedia;
            mUrlSpec = aUrlSpec;
        }

        internal override CssRuleKind GetKind ()
        {
            return CssRuleKind.IMPORT;
        }

        // Public interface

        public string Uri
        {
            get { return mUrlSpec; }
        }

        public IReadOnlyList<CssMediaQuery> MediaQueries
        {
            get { return mMedia.Queries; }
        }
    }
}