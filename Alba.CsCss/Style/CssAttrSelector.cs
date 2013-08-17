using System;
using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class CssAttrSelector
    {
        internal string mLowercaseAttr, mCasedAttr;
        internal int mNameSpace;
        internal string mValue;
        internal bool mCaseSensitive;
        internal CssAttrFunction mFunction;
        internal CssAttrSelector mNext;

        internal CssAttrSelector (int aNameSpace, string aAttr, CssAttrFunction aFunction = CssAttrFunction.Set, string aValue = null, bool aCaseSensitive = true)
        {
            mNameSpace = aNameSpace;
            mCasedAttr = String.Intern(aAttr);
            mLowercaseAttr = String.Intern(aAttr.ToLower());
            mFunction = aFunction;
            mValue = aValue;
            mCaseSensitive = aCaseSensitive;
        }

        internal static void AddItem (ref CssAttrSelector @this, CssAttrSelector item)
        {
            while (@this != null)
                @this = @this.mNext;
            @this = item;
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

        public CssAttrFunction Function
        {
            get { return mFunction; }
        }

        public string Value
        {
            get { return mValue; }
        }

        internal static IEnumerable<CssAttrSelector> TraverseList (CssAttrSelector @this)
        {
            return @this.TraverseList(i => i.mNext);
        }
    }
}