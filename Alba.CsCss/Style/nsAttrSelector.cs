using System;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal class nsAttrSelector
    {
        public string mValue;
        public nsAttrSelector mNext;
        public string mLowercaseAttr, mCasedAttr;
        public int mNameSpace;
        public nsAttrFunc mFunction;
        public bool mCaseSensitive;

        public nsAttrSelector (int aNameSpace, string aAttr, nsAttrFunc aFunction = nsAttrFunc.SET, string aValue = null, bool aCaseSensitive = true)
        {
            mNameSpace = aNameSpace;
            mCasedAttr = String.Intern(aAttr);
            mLowercaseAttr = String.Intern(aAttr.ToLower());
            mFunction = aFunction;
            mValue = aValue;
            mCaseSensitive = aCaseSensitive;
        }

        public nsAttrSelector Last
        {
            get { return this.TraverseList(i => i.mNext).Last(); }
        }
    }
}