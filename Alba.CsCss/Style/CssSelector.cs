using System;
using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class CssSelector
    {
        // For case-sensitive documents, mLowercaseTag is the same as mCasedTag, but in case-insensitive documents (HTML) mLowercaseTag is lowercase.
        // Also, for pseudo-elements mCasedTag will be null but mLowercaseTag contains their name.
        internal string mLowercaseTag, mCasedTag;
        internal int mNameSpace = nsNameSpace.Unknown;
        internal char mOperator;
        internal CssSelector mNegations;
        internal CssPseudoElement mPseudoType = CssPseudoElement.NotPseudoElement;
        internal nsAtomList mIDList, mClassList;
        internal CssPseudoClassSelector mPseudoClassList;
        internal CssAttrSelector mAttrList;
        internal CssSelector mNext;

        internal void AddClass (string aClass)
        {
            if (aClass != "")
                nsAtomList.AddItem(ref mClassList, new nsAtomList(aClass));
        }

        internal void AddID (string aID)
        {
            if (aID != "")
                nsAtomList.AddItem(ref mIDList, new nsAtomList(aID));
        }

        internal void AddAttribute (int aNameSpace, string aAttr, CssAttrFunction aFunc, string aValue, bool aCaseSensitive)
        {
            AddAttributeInternal(new CssAttrSelector(aNameSpace, aAttr, aFunc, aValue, aCaseSensitive));
        }

        internal void AddAttribute (int aNameSpace, string aAttr)
        {
            AddAttributeInternal(new CssAttrSelector(aNameSpace, aAttr));
        }

        internal void AddAttributeInternal (CssAttrSelector aAttribute)
        {
            CssAttrSelector.AddItem(ref mAttrList, aAttribute);
        }

        internal void AddPseudoClass (CssPseudoClass aType, string aString)
        {
            AddPseudoClassInternal(new CssPseudoClassSelector(aType, aString));
        }

        internal void AddPseudoClass (CssPseudoClass aType, int[] aIntPair)
        {
            AddPseudoClassInternal(new CssPseudoClassSelector(aType, aIntPair));
        }

        internal void AddPseudoClass (CssPseudoClass aType, CssSelectorGroup aSelectorList)
        {
            AddPseudoClassInternal(new CssPseudoClassSelector(aType, aSelectorList));
        }

        internal void AddPseudoClass (CssPseudoClass aType)
        {
            AddPseudoClassInternal(new CssPseudoClassSelector(aType));
        }

        internal void AddPseudoClassInternal (CssPseudoClassSelector aPseudoClass)
        {
            CssPseudoClassSelector.AddItem(ref mPseudoClassList, aPseudoClass);
        }

        internal bool IsPseudoElement ()
        {
            return mLowercaseTag != null && mCasedTag == null;
        }

        internal void SetNameSpace (int aNameSpace)
        {
            mNameSpace = aNameSpace;
        }

        internal void SetOperator (char aOperator)
        {
            mOperator = aOperator;
        }

        internal void SetPseudoType (CssPseudoElement aPseudoType)
        {
            mPseudoType = aPseudoType;
        }

        internal void SetTag (string aTag)
        {
            if (aTag == "") {
                mLowercaseTag = mCasedTag = null;
                return;
            }
            mCasedTag = String.Intern(aTag);
            mLowercaseTag = String.Intern(aTag.ToLower());
        }

        internal int CalcWeight ()
        {
            return 0; // not supported (complex code, likely to change)
        }

        // Public interface

        public string Tag
        {
            get { return mCasedTag ?? mLowercaseTag; }
        }

        public string TagCased
        {
            get { return mCasedTag; }
        }

        public string TagLower
        {
            get { return mLowercaseTag; }
        }

        public int NamespaceId
        {
            get { return mNameSpace; }
        }

        public string NamespaceUri
        {
            get { return nsNameSpaceManager.Instance.GetNameSpaceURI(mNameSpace); }
        }

        public char Operator
        {
            get { return mOperator; }
        }

        public IEnumerable<CssSelector> Negations
        {
            get { return TraverseList(mNegations); }
        }

        public CssPseudoElement PseudoType
        {
            get { return mPseudoType; }
        }

        public IEnumerable<string> Ids
        {
            get { return nsAtomList.TraverseList(mIDList); }
        }

        public IEnumerable<string> Classes
        {
            get { return nsAtomList.TraverseList(mClassList); }
        }

        public IEnumerable<CssPseudoClassSelector> PseudoClasses
        {
            get { return CssPseudoClassSelector.TraverseList(mPseudoClassList); }
        }

        public IEnumerable<CssAttrSelector> Attrs
        {
            get { return CssAttrSelector.TraverseList(mAttrList); }
        }

        internal static IEnumerable<CssSelector> TraverseList (CssSelector @this)
        {
            return @this.TraverseList(i => i.mNext);
        }
    }
}