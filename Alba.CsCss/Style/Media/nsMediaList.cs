using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal class nsMediaList
    {
        private readonly List<nsMediaQuery> mArray = new List<nsMediaQuery>();
        private nsCSSStyleSheet mStyleSheet;

        internal void AppendQuery (nsMediaQuery query)
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

        internal IEnumerable<nsMediaQuery> Queries
        {
            get { return mArray.AsReadOnly(); }
        }
    }
}