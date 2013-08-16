using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal class nsMediaList
    {
        private readonly List<CssMediaQuery> mArray = new List<CssMediaQuery>();
        private nsCSSStyleSheet mStyleSheet;

        internal void AppendQuery (CssMediaQuery query)
        {
            mArray.Add(query);
        }

        internal void Clear ()
        {
            mArray.Clear();
        }

        internal int Count ()
        {
            return mArray.Count;
        }

        internal void SetStyleSheet (nsCSSStyleSheet aSheet)
        {
            mStyleSheet = aSheet;
        }

        // Public interface

        internal IEnumerable<CssMediaQuery> Queries
        {
            get { return mArray.AsReadOnly(); }
        }
    }
}