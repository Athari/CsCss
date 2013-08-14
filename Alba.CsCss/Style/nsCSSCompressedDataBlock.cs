using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("Count = {mData.Length}")]
    internal class nsCSSCompressedDataBlock : nsCSSDataBlock
    {
        internal readonly PropertyValue[] mData;
        internal int mStyleBits;

        public nsCSSCompressedDataBlock (int aNumProps)
        {
            mData = new PropertyValue[aNumProps];
        }

        private int IndexFor (nsCSSProperty aProperty)
        {
            Debug.Assert(!nsCSSProps.IsShorthand(aProperty), "Don't call for shorthands");
            if ((nsCachedStyleData.GetBitForSID(nsCSSProps.kSIDTable[(int)aProperty]) & mStyleBits) == 0)
                return -1;
            for (int i = 0; i < mData.Length; i++)
                if (mData[i].mProperty == aProperty)
                    return i;
            return -1;
        }

        private nsCSSValue ValueFor (nsCSSProperty aProperty)
        {
            int index = IndexFor(aProperty);
            return index != -1 ? mData[index].mValue : nsCSSValue.NullValue;
        }

        public bool TryReplaceValue (nsCSSProperty aProperty, nsCSSExpandedDataBlock aFromBlock, ref bool aChanged)
        {
            nsCSSValue newValue = aFromBlock.mValues[(int)aProperty];

            int oldValue = IndexFor(aProperty);
            if (oldValue == -1) {
                aChanged = false;
                return false;
            }

            aChanged = MoveValue(newValue, ref mData[oldValue].mValue);
            aFromBlock.mPropertiesSet.RemoveProperty(aProperty);
            return true;
        }

        [DebuggerDisplay ("{mProperty}: {mValue}")]
        internal struct PropertyValue
        {
            public nsCSSValue mValue;
            public nsCSSProperty mProperty;
        }
    }
}