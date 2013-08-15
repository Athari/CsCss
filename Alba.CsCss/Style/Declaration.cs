using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

// TODO Sort CssPropertyValues when compressing?
namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("{DebugDisplayCount,nq}")]
    public class Declaration
    {
        private readonly List<nsCSSProperty> mOrder = new List<nsCSSProperty>();
        private nsCSSCompressedDataBlock mData, mImportantData;
        private bool mImmutable;

        internal void ValueAppended (nsCSSProperty aProperty)
        {
            mOrder.Remove(aProperty);
            mOrder.Add(aProperty);
        }

        internal void CompressFrom (nsCSSExpandedDataBlock aExpandedData)
        {
            aExpandedData.Compress(out mData, out mImportantData);
            aExpandedData.AssertInitialState();
        }

        internal void ExpandTo (nsCSSExpandedDataBlock aExpandedData)
        {
            AssertMutable();
            aExpandedData.AssertInitialState();
            aExpandedData.Expand(mData, mImportantData);
        }

        internal bool TryReplaceValue (nsCSSProperty aProperty, bool aIsImportant, nsCSSExpandedDataBlock aFromBlock, ref bool aChanged)
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
        internal void AssertMutable ()
        {
            Debug.Assert(IsMutable(), "someone forgot to call EnsureMutable");
        }

        internal bool IsMutable ()
        {
            return !mImmutable;
        }

        internal void SetImmutable ()
        {
            mImmutable = true;
        }

        internal void ClearData ()
        {
            AssertMutable();
            mData = null;
            mImportantData = null;
            mOrder.Clear();
        }

        // Public interface

        public IEnumerable<CssPropertyValue> Data
        {
            get { return new ReadOnlyCollection<CssPropertyValue>(mData.mData); }
        }

        public IEnumerable<CssPropertyValue> ImportantData
        {
            get { return new ReadOnlyCollection<CssPropertyValue>(mData.mData); }
        }

        public IEnumerable<CssPropertyValue> OrderedData
        {
            get { return OrderDataByOrder(mData.mData); }
        }

        public IEnumerable<CssPropertyValue> OrderedImportantData
        {
            get { return OrderDataByOrder(mImportantData.mData); }
        }

        public nsCSSValue GetValue (nsCSSProperty prop)
        {
            return mData.ValueFor(prop);
        }

        public nsCSSValue GetImportantValue (nsCSSProperty prop)
        {
            return mData.ValueFor(prop);
        }

        private IEnumerable<CssPropertyValue> OrderDataByOrder (IEnumerable<CssPropertyValue> data)
        {
            return mOrder.Join(data, p => p, pv => pv.mProperty, (p, pv) => pv);
        }

        internal string DebugDisplayCount
        {
            get
            {
                return mImportantData != null
                    ? string.Format("Count = {0} + {1}", mData.mData.Length, mImportantData.mData.Length)
                    : string.Format("Count = {0}", mData.mData.Length);
            }
        }
    }
}