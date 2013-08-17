using System.Diagnostics;

// ReSharper disable LoopCanBeConvertedToQuery
namespace Alba.CsCss.Style
{
    internal class nsCSSExpandedDataBlock : nsCSSDataBlock
    {
        internal readonly CssValue[] mValues = new CssValue[(int)CssProperty.PropertyCountNoShorthands];
        internal readonly CssPropertySet mPropertiesSet = new CssPropertySet();
        internal readonly CssPropertySet mPropertiesImportant = new CssPropertySet();

        [Conditional ("DEBUG")]
        public void AssertInitialState ()
        {
            mPropertiesSet.AssertIsEmpty("not initial state");
            mPropertiesImportant.AssertIsEmpty("not initial state");
            for (int i = 0; i < mValues.Length; i++)
                Debug.Assert(mValues[i].GetUnit() == CssUnit.Null);
        }

        public void AddLonghandProperty (CssProperty aPropID, CssValue aValue)
        {
            mValues[(int)aPropID] = aValue;
            mPropertiesSet.AddProperty(aPropID);
        }

        public void ClearProperty (CssProperty aPropID)
        {
            if (!nsCSSProps.IsShorthand(aPropID))
                ClearLonghandProperty(aPropID);
            else
                foreach (CssProperty p in nsCSSProps.SubpropertyEntryFor(aPropID, true))
                    ClearLonghandProperty(p);
        }

        private void ClearLonghandProperty (CssProperty aPropID)
        {
            mPropertiesSet.RemoveProperty(aPropID);
            mPropertiesImportant.RemoveProperty(aPropID);
            mValues[(int)aPropID].Reset();
        }

        public bool TransferFromBlock (nsCSSExpandedDataBlock aFromBlock, CssProperty aPropID,
            bool aIsImportant, bool aOverrideImportant, bool aMustCallValueAppended, CssDeclaration aDeclaration)
        {
            if (!nsCSSProps.IsShorthand(aPropID))
                return DoTransferFromBlock(aFromBlock, aPropID, aIsImportant, aOverrideImportant, aMustCallValueAppended, aDeclaration);
            bool changed = false;
            foreach (CssProperty p in nsCSSProps.SubpropertyEntryFor(aPropID, true))
                changed |= DoTransferFromBlock(aFromBlock, p, aIsImportant, aOverrideImportant, aMustCallValueAppended, aDeclaration);
            return changed;
        }

        private bool DoTransferFromBlock (nsCSSExpandedDataBlock aFromBlock, CssProperty aPropID,
            bool aIsImportant, bool aOverrideImportant, bool aMustCallValueAppended, CssDeclaration aDeclaration)
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
            changed |= MoveValue(ref aFromBlock.mValues[(int)aPropID], ref mValues[(int)aPropID]);

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
            foreach (CssPropertyValue pv in aBlock.mData) {
                CssProperty iProp = pv.mProperty;
                mPropertiesSet.AddProperty(iProp);
                if (aImportant)
                    mPropertiesImportant.AddProperty(iProp);
                mValues[(int)iProp] = pv.mValue;
            }
        }

        public void Compress (out nsCSSCompressedDataBlock aNormalBlock, out nsCSSCompressedDataBlock aImportantBlock)
        {
            int numPropsNormal, numPropsImportant;
            ComputeNumProps(out numPropsNormal, out numPropsImportant);

            var result_normal = new nsCSSCompressedDataBlock(numPropsNormal);
            var result_important = numPropsImportant != 0 ? new nsCSSCompressedDataBlock(numPropsImportant) : null;

            int i_normal = 0, i_important = 0;
            for (CssProperty iProp = 0; iProp < CssProperty.PropertyCountNoShorthands; iProp++) {
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

        private void CompressProperty (nsCSSCompressedDataBlock result, CssProperty aPropID, ref int ip)
        {
            result.mData[ip].mProperty = aPropID;
            result.mData[ip].mValue = mValues[(int)aPropID];
            mValues[(int)aPropID].Reset();
            ip++;
            result.mStyleBits |= nsCachedStyleData.GetBitForSID(nsCSSProps.kSIDTable[(int)aPropID]);
        }

        private void ComputeNumProps (out int aNumPropsNormal, out int aNumPropsImportant)
        {
            aNumPropsNormal = aNumPropsImportant = 0;
            for (CssProperty iProp = 0; iProp < CssProperty.PropertyCountNoShorthands; iProp++) {
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