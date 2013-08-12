using System;

namespace Alba.CsCss.Style
{
    internal class nsCSSSelector
    {
        // For case-sensitive documents, mLowercaseTag is the same as mCasedTag, but in case-insensitive documents (HTML) mLowercaseTag is lowercase.
        // Also, for pseudo-elements mCasedTag will be null but mLowercaseTag contains their name.
        public string mLowercaseTag, mCasedTag;
        public int mNameSpace = nsNameSpace.Unknown;
        public char mOperator;
        public nsCSSSelector mNegations;
        public nsCSSPseudoElement mPseudoType = nsCSSPseudoElement.NotPseudoElement;
        public nsAtomList mIDList, mClassList;
        public nsPseudoClassList mPseudoClassList;
        public nsAttrSelector mAttrList;
        public nsCSSSelector mNext;

        public void AddClass (string aClass)
        {
            if (aClass != "")
                mClassList.Last.mNext = new nsAtomList(aClass);
        }

        public void AddID (string aID)
        {
            if (aID != "")
                mIDList.Last.mNext = new nsAtomList(aID);
        }

        public void AddAttribute (int aNameSpace, string aAttr, nsAttrFunc aFunc, string aValue, bool aCaseSensitive)
        {
            AddAttributeInternal(new nsAttrSelector(aNameSpace, aAttr, aFunc, aValue, aCaseSensitive));
        }

        public void AddAttribute (int aNameSpace, string aAttr)
        {
            AddAttributeInternal(new nsAttrSelector(aNameSpace, aAttr));
        }

        private void AddAttributeInternal (nsAttrSelector aAttribute)
        {
            mAttrList.Last.mNext = aAttribute;
        }

        public void AddPseudoClass (nsCSSPseudoClass aType, string aString)
        {
            AddPseudoClassInternal(new nsPseudoClassList(aType, aString));
        }

        public void AddPseudoClass (nsCSSPseudoClass aType, int[] aIntPair)
        {
            AddPseudoClassInternal(new nsPseudoClassList(aType, aIntPair));
        }

        public void AddPseudoClass (nsCSSPseudoClass aType, nsCSSSelectorList aSelectorList)
        {
            AddPseudoClassInternal(new nsPseudoClassList(aType, aSelectorList));
        }

        public void AddPseudoClass (nsCSSPseudoClass aType)
        {
            AddPseudoClassInternal(new nsPseudoClassList(aType));
        }

        private void AddPseudoClassInternal (nsPseudoClassList aPseudoClass)
        {
            mPseudoClassList.Last.mNext = aPseudoClass;
        }

        public bool IsPseudoElement ()
        {
            return mLowercaseTag != null && mCasedTag == null;
        }

        public void SetNameSpace (int aNameSpace)
        {
            mNameSpace = aNameSpace;
        }

        public void SetOperator (char aOperator)
        {
            mOperator = aOperator;
        }

        public void SetPseudoType (nsCSSPseudoElement aPseudoType)
        {
            mPseudoType = aPseudoType;
        }

        public void SetTag (string aTag)
        {
            if (aTag == "") {
                mLowercaseTag = mCasedTag = null;
                return;
            }
            mCasedTag = String.Intern(aTag);
            mLowercaseTag = String.Intern(aTag.ToLower());
        }

        public int CalcWeight ()
        {
            return 0; // not supported (complex code, likely to change)
        }
    }
}