using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal class nsMediaList
    {
        private readonly List<nsMediaQuery> mArray = new List<nsMediaQuery>();

        public void AppendQuery (nsMediaQuery query)
        {
            mArray.Add(query);
        }

        public void Clear ()
        {
            mArray.Clear();
        }

        public int Count ()
        {
            return mArray.Count;
        }
    }
}