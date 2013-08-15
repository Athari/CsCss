using System;
using System.Collections.Generic;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class nsAttrSelector
    {
        internal string mLowercaseAttr, mCasedAttr;
        internal int mNameSpace;
        internal string mValue;
        internal bool mCaseSensitive;
        internal nsAttrFunc mFunction;
        internal nsAttrSelector mNext;

        internal nsAttrSelector (int aNameSpace, string aAttr, nsAttrFunc aFunction = nsAttrFunc.SET, string aValue = null, bool aCaseSensitive = true)
        {
            mNameSpace = aNameSpace;
            mCasedAttr = String.Intern(aAttr);
            mLowercaseAttr = String.Intern(aAttr.ToLower());
            mFunction = aFunction;
            mValue = aValue;
            mCaseSensitive = aCaseSensitive;
        }

        internal nsAttrSelector Last
        {
            get { return this.TraverseList(i => i.mNext).Last(); }
        }

        // Public interface

        public string Attr
        {
            get { return mCasedAttr ?? mLowercaseAttr; }
        }

        public string AttrCased
        {
            get { return mCasedAttr; }
        }

        public string AttrLower
        {
            get { return mLowercaseAttr; }
        }

        public bool IsCaseSensitive
        {
            get { return mCaseSensitive; }
        }

        public int NamespaceId
        {
            get { return mNameSpace; }
        }

        public string NamespaceUri
        {
            get { return nsNameSpaceManager.Instance.GetNameSpaceURI(mNameSpace); }
        }

        public nsAttrFunc Function
        {
            get { return mFunction; }
        }

        public string Value
        {
            get { return mValue; }
        }

        internal IEnumerable<nsAttrSelector> Items
        {
            get { return this.TraverseList(i => i.mNext); }
        }
    }
}