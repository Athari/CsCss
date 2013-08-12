using System.Diagnostics;

// ReSharper disable LoopCanBeConvertedToQuery
namespace Alba.CsCss.Style
{
    internal class nsCSSExpandedDataBlock : nsCSSDataBlock
    {
        internal readonly nsCSSValue[] mValues = new nsCSSValue[(int)nsCSSProperty.COUNT_no_shorthands];
        internal readonly nsCSSPropertySet mPropertiesSet = new nsCSSPropertySet();
        internal readonly nsCSSPropertySet mPropertiesImportant = new nsCSSPropertySet();

        [Conditional ("DEBUG")]
        public void AssertInitialState ()
        {
            mPropertiesSet.AssertIsEmpty("not initial state");
            mPropertiesImportant.AssertIsEmpty("not initial state");
            for (int i = 0; i < mValues.Length; i++)
                Debug.Assert(mValues[i].GetUnit() == nsCSSUnit.Null);
        }

        public void AddLonghandProperty (nsCSSProperty aPropID, nsCSSValue aValue)
        {
            mValues[(int)aPropID] = aValue;
            mPropertiesSet.AddProperty(aPropID);
        }

        public void ClearProperty (nsCSSProperty aPropID)
        {
            if (!nsCSSProps.IsShorthand(aPropID))
                ClearLonghandProperty(aPropID);
            else
                foreach (nsCSSProperty p in nsCSSProps.SubpropertyEntryFor(aPropID, true))
                    ClearLonghandProperty(p);
        }

        private void ClearLonghandProperty (nsCSSProperty aPropID)
        {
            mPropertiesSet.RemoveProperty(aPropID);
            mPropertiesImportant.RemoveProperty(aPropID);
            mValues[(int)aPropID].Reset();
        }

        public bool TransferFromBlock (nsCSSExpandedDataBlock aFromBlock, nsCSSProperty aPropID,
            bool aIsImportant, bool aOverrideImportant, bool aMustCallValueAppended, Declaration aDeclaration)
        {
            if (!nsCSSProps.IsShorthand(aPropID))
                return DoTransferFromBlock(aFromBlock, aPropID, aIsImportant, aOverrideImportant, aMustCallValueAppended, aDeclaration);
            bool changed = false;
            foreach (nsCSSProperty p in nsCSSProps.SubpropertyEntryFor(aPropID, true))
                changed |= DoTransferFromBlock(aFromBlock, p, aIsImportant, aOverrideImportant, aMustCallValueAppended, aDeclaration);
            return changed;
        }

        private bool DoTransferFromBlock (nsCSSExpandedDataBlock aFromBlock, nsCSSProperty aPropID,
            bool aIsImportant, bool aOverrideImportant, bool aMustCallValueAppended, Declaration aDeclaration)
        {
            bool changed = false;
            if (aIsImportant) {
                if (!mPropertiesImportant.HasProperty(aPropID))
                    changed = true;
                mPropertiesImportant.AddProperty(aPropID);
            }
            else {
                if (mPropertiesImportant.HasProperty(aPropID)) {
                    if (!aOverrideImportant) {
                        aFromBlock.ClearLonghandProperty(aPropID);
                        return false;
                    }
                    changed = true;
                    mPropertiesImportant.RemoveProperty(aPropID);
                }
            }

            if (aMustCallValueAppended || !mPropertiesSet.HasProperty(aPropID)) {
                aDeclaration.ValueAppended(aPropID);
            }

            mPropertiesSet.AddProperty(aPropID);
            aFromBlock.mPropertiesSet.RemoveProperty(aPropID);
            changed |= MoveValue(aFromBlock.mValues[(int)aPropID], ref mValues[(int)aPropID]);

            return changed;
        }

        public void Expand (nsCSSCompressedDataBlock aNormalBlock, nsCSSCompressedDataBlock aImportantBlock)
        {
            AssertInitialState();
            DoExpand(aNormalBlock, false);
            if (aImportantBlock != null)
                DoExpand(aImportantBlock, true);
        }

        private void DoExpand (nsCSSCompressedDataBlock aBlock, bool aImportant)
        {
            for (int i = 0; i < aBlock.mData.Length; i++) {
                nsCSSProperty iProp = aBlock.mData[i].mProperty;
                mPropertiesSet.AddProperty(iProp);
                if (aImportant)
                    mPropertiesImportant.AddProperty(iProp);
                mValues[(int)iProp] = aBlock.mData[i].mValue;
            }
        }

        public void Compress (out nsCSSCompressedDataBlock aNormalBlock, out nsCSSCompressedDataBlock aImportantBlock)
        {
            int numPropsNormal, numPropsImportant;
            ComputeNumProps(out numPropsNormal, out numPropsImportant);

            var result_normal = new nsCSSCompressedDataBlock(numPropsNormal);
            var result_important = numPropsImportant != 0 ? new nsCSSCompressedDataBlock(numPropsImportant) : null;

            int i_normal = 0, i_important = 0;
            for (nsCSSProperty iProp = 0; iProp < nsCSSProperty.COUNT_no_shorthands; iProp++) {
                if (!mPropertiesSet.HasProperty(iProp))
                    continue;
                if (mPropertiesImportant.HasProperty(iProp))
                    CompressProperty(result_important, iProp, ref i_important);
                else
                    CompressProperty(result_normal, iProp, ref i_normal);
            }

            mPropertiesSet.Empty();
            mPropertiesImportant.Empty();
            AssertInitialState();
            aNormalBlock = result_normal;
            aImportantBlock = result_important;
        }

        private void CompressProperty (nsCSSCompressedDataBlock result, nsCSSProperty aPropID, ref int ip)
        {
            nsCSSValue val = mValues[(int)aPropID];
            result.mData[ip].mProperty = aPropID;
            result.mData[ip].mValue = val;
            val.Reset();
            ip++;
            result.mStyleBits |= nsCachedStyleData.GetBitForSID(nsCSSProps.kSIDTable[(int)aPropID]);
        }

        private void ComputeNumProps (out int aNumPropsNormal, out int aNumPropsImportant)
        {
            aNumPropsNormal = aNumPropsImportant = 0;
            for (nsCSSProperty iProp = 0; iProp < nsCSSProperty.COUNT_no_shorthands; iProp++) {
                if (!mPropertiesSet.HasProperty(iProp))
                    continue;
                if (mPropertiesImportant.HasProperty(iProp))
                    aNumPropsImportant++;
                else
                    aNumPropsNormal++;
            }
        }
    }
}