using System.Diagnostics;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("Count = {mData.Length}")]
    internal class nsCSSCompressedDataBlock : nsCSSDataBlock
    {
        internal CssPropertyValue[] mData;
        internal int mStyleBits;

        public nsCSSCompressedDataBlock (int aNumProps)
        {
            mData = new CssPropertyValue[aNumProps];
        }

        internal int IndexFor (CssProperty aProperty)
        {
            Debug.Assert(!nsCSSProps.IsShorthand(aProperty), "Don't call for shorthands");
            if ((nsCachedStyleData.GetBitForSID(nsCSSProps.kSIDTable[(int)aProperty]) & mStyleBits) == 0)
                return -1;
            for (int i = 0; i < mData.Length; i++)
                if (mData[i].mProperty == aProperty)
                    return i;
            return -1;
        }

        internal CssValue ValueFor (CssProperty aProperty)
        {
            int index = IndexFor(aProperty);
            return index != -1 ? mData[index].mValue : CssValue.NullValue;
        }

        public bool TryReplaceValue (CssProperty aProperty, nsCSSExpandedDataBlock aFromBlock, ref bool aChanged)
        {
            CssValue newValue = aFromBlock.mValues[(int)aProperty];

            int oldValue = IndexFor(aProperty);
            if (oldValue == -1) {
                aChanged = false;
                return false;
            }

            aChanged = MoveValue(ref newValue, ref mData[oldValue].mValue);
            aFromBlock.mPropertiesSet.RemoveProperty(aProperty);
            return true;
        }
    }
}