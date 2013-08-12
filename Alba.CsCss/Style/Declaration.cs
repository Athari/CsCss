using System.Collections.Generic;
using System.Diagnostics;

namespace Alba.CsCss.Style
{
    internal class Declaration
    {
        private readonly List<nsCSSProperty> mOrder = new List<nsCSSProperty>();
        private nsCSSCompressedDataBlock mData, mImportantData;
        private bool mImmutable;

        public void ValueAppended (nsCSSProperty aProperty)
        {
            mOrder.Remove(aProperty);
            mOrder.Add(aProperty);
        }

        public void CompressFrom (nsCSSExpandedDataBlock aExpandedData)
        {
            aExpandedData.Compress(out mData, out mImportantData);
            aExpandedData.AssertInitialState();
        }

        public void ExpandTo (nsCSSExpandedDataBlock aExpandedData)
        {
            AssertMutable();
            aExpandedData.AssertInitialState();
            aExpandedData.Expand(mData, mImportantData);
        }

        public bool TryReplaceValue (nsCSSProperty aProperty, bool aIsImportant, nsCSSExpandedDataBlock aFromBlock, ref bool aChanged)
        {
            AssertMutable();
            Debug.Assert(mData != null, "called while expanded");

            if (nsCSSProps.IsShorthand(aProperty)) {
                aChanged = false;
                return false;
            }
            nsCSSCompressedDataBlock block = aIsImportant ? mImportantData : mData;
            if (block == null) {
                aChanged = false;
                return false;
            }
            return block.TryReplaceValue(aProperty, aFromBlock, ref aChanged);
        }

        [Conditional ("DEBUG")]
        public void AssertMutable ()
        {
            Debug.Assert(IsMutable(), "someone forgot to call EnsureMutable");
        }

        public bool IsMutable ()
        {
            return !mImmutable;
        }

        public void SetImmutable ()
        {
            mImmutable = true;
        }

        public void ClearData ()
        {
            AssertMutable();
            mData = null;
            mImportantData = null;
            mOrder.Clear();
        }
    }
}