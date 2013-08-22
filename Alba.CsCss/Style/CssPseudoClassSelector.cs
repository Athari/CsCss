using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class CssPseudoClassSelector
    {
        internal CssPseudoClass mType;
        internal CssPseudoClassSelector mNext;
        private object mData;

        internal CssPseudoClassSelector (CssPseudoClass aType, string aString)
        {
            mType = aType;
            mString = aString;
        }

        internal CssPseudoClassSelector (CssPseudoClass aType, int[] aNumbers)
        {
            mType = aType;
            mNumbers = aNumbers;
        }

        internal CssPseudoClassSelector (CssPseudoClass aType, CssSelectorGroup aSelectors)
        {
            mType = aType;
            mSelectors = aSelectors;
        }

        internal CssPseudoClassSelector (CssPseudoClass aType)
        {
            mType = aType;
            mData = null;
        }

        internal string mString
        {
            get { return (string)mData; }
            set { mData = value; }
        }

        internal int[] mNumbers
        {
            get { return (int[])mData; }
            set { mData = value; }
        }

        internal CssSelectorGroup mSelectors
        {
            get { return (CssSelectorGroup)mData; }
            set { mData = value; }
        }

        internal static void AddItem (ref CssPseudoClassSelector @this, CssPseudoClassSelector item)
        {
            while (@this != null)
                @this = @this.mNext;
            @this = item;
        }

        // Public interface

        public CssPseudoClass Type
        {
            get { return mType; }
        }

        public string String
        {
            get { return mString; }
        }

        public IList<int> Numbers
        {
            get { return mNumbers; }
        }

        public IEnumerable<CssSelectorGroup> SelectorGroups
        {
            get { return CssSelectorGroup.TraverseList(mSelectors); }
        }

        internal static IEnumerable<CssPseudoClassSelector> TraverseList (CssPseudoClassSelector @this)
        {
            return @this.TraverseList(i => i.mNext);
        }
    }
}