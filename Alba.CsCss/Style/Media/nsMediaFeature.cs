using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss.Style
{
    public partial class nsMediaFeature
    {
        internal string mName;
        internal RangeType mRangeType;
        internal ValueType mValueType;

        internal int[] mKeywordTable;
        internal string mMetric;

        // union of mKeywordTable and mMetric
        internal nsMediaFeature mData
        {
            get { return this; }
        }

        private nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType, int[] aKeywordTable, string aMetric)
        {
            mName = aName;
            mRangeType = aRangeType;
            mValueType = aValueType;
            mKeywordTable = aKeywordTable;
            mMetric = aMetric;
        }

        internal nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType, string aMetric)
            : this(aName, aRangeType, aValueType, null, aMetric)
        {}

        internal nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType, int[] aKeywordTable)
            : this(aName, aRangeType, aValueType, aKeywordTable, null)
        {}

        internal nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType)
            : this(aName, aRangeType, aValueType, null, null)
        {}

        internal nsMediaFeature ()
            : this(null, RangeType.MinMaxAllowed, ValueType.Integer, null, null)
        {}

        // Public interface

        public string Name
        {
            get { return mName; }
        }

        public RangeType Range
        {
            get { return mRangeType; }
        }

        public ValueType Value
        {
            get { return mValueType; }
        }

        public string Metric
        {
            get { return mMetric; }
        }

        public IEnumerable<int> PossibleValues
        {
            get { return mKeywordTable.Where((k, i) => i % 2 == 1 && k != -1); }
        }
    }
}