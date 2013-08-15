using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay (@"@import ""{mUrlSpec}""")]
    public class ImportRule : Rule
    {
        private readonly nsMediaList mMedia;
        private readonly string mUrlSpec;

        internal ImportRule (nsMediaList aMedia, string aUrlSpec)
        {
            mMedia = aMedia;
            mUrlSpec = aUrlSpec;
        }

        internal override RuleKind GetKind ()
        {
            return RuleKind.IMPORT;
        }

        // Public interface

        public string Uri
        {
            get { return mUrlSpec; }
        }

        public IEnumerable<nsMediaQuery> MediaQueries
        {
            get { return mMedia.Queries; }
        }
    }
}