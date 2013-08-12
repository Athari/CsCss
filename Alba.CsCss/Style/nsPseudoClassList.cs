using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal class nsPseudoClassList
    {
        public nsCSSPseudoClass mType;
        public nsPseudoClassList mNext;
        private object mData;

        public nsPseudoClassList (nsCSSPseudoClass aType, string aString)
        {
            mType = aType;
            mString = aString;
        }

        public nsPseudoClassList (nsCSSPseudoClass aType, int[] aNumbers)
        {
            mType = aType;
            mNumbers = aNumbers;
        }

        public nsPseudoClassList (nsCSSPseudoClass aType, nsCSSSelectorList aSelectors)
        {
            mType = aType;
            mSelectors = aSelectors;
        }

        public nsPseudoClassList (nsCSSPseudoClass aType)
        {
            mType = aType;
            mData = null;
        }

        public string mString
        {
            get { return (string)mData; }
            set { mData = value; }
        }

        public int[] mNumbers
        {
            get { return (int[])mData; }
            set { mData = value; }
        }

        public nsCSSSelectorList mSelectors
        {
            get { return (nsCSSSelectorList)mData; }
            set { mData = value; }
        }

        public nsPseudoClassList Last
        {
            get { return this.TraverseList(i => i.mNext).Last(); }
        }
    }
}