using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    public class nsMediaQuery
    {
        private readonly List<nsMediaExpression> mExpressions = new List<nsMediaExpression>();
        private bool mNegated;
        private bool mHasOnly; // only needed for serialization
        private bool mTypeOmitted; // only needed for serialization
        private bool mHadUnknownExpression;
        private string mMediaType;

        internal void SetNegated ()
        {
            mNegated = true;
        }

        internal void SetHasOnly ()
        {
            mHasOnly = true;
        }

        internal void SetTypeOmitted ()
        {
            mTypeOmitted = true;
        }

        internal void SetHadUnknownExpression ()
        {
            mHadUnknownExpression = true;
        }

        internal void SetType (string aMediaType)
        {
            mMediaType = aMediaType;
        }

        internal nsMediaExpression NewExpression ()
        {
            return mExpressions.AppendElement();
        }

        // Public interface

        public IEnumerable<nsMediaExpression> Expressions
        {
            get { return mExpressions.AsReadOnly(); }
        }

        public bool IsNegated
        {
            get { return mNegated; }
        }

        public string MediaType
        {
            get { return mMediaType; }
        }
    }
}