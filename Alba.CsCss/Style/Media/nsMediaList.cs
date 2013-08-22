using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal class nsMediaList
    {
        private readonly List<CssMediaQuery> mArray = new List<CssMediaQuery>();
        private CssStyleSheet mStyleSheet;

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

        internal void SetStyleSheet (CssStyleSheet aSheet)
        {
            mStyleSheet = aSheet;
        }

        // Public interface

        internal IList<CssMediaQuery> Queries
        {
            get { return mArray; }
        }
    }
}