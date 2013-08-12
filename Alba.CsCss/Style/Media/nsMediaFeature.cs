namespace Alba.CsCss.Style
{
    internal partial class nsMediaFeature
    {
        public string mName;
        public RangeType mRangeType;
        public ValueType mValueType;

        public int[] mKeywordTable;
        public string mMetric;

        // union of mKeywordTable and mMetric
        public nsMediaFeature mData
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

        public nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType, string aMetric)
            : this(aName, aRangeType, aValueType, null, aMetric)
        {}

        public nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType, int[] aKeywordTable)
            : this(aName, aRangeType, aValueType, aKeywordTable, null)
        {}

        public nsMediaFeature (string aName, RangeType aRangeType, ValueType aValueType)
            : this(aName, aRangeType, aValueType, null, null)
        {}

        public nsMediaFeature ()
            : this(null, RangeType.MinMaxAllowed, ValueType.Integer, null, null)
        {}
    }
}