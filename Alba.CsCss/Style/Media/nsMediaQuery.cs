using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    internal class nsMediaQuery
    {
        private bool mNegated;
        private bool mHasOnly; // only needed for serialization
        private bool mTypeOmitted; // only needed for serialization
        private bool mHadUnknownExpression;
        private string mMediaType;
        private readonly List<nsMediaExpression> mExpressions = new List<nsMediaExpression>();

        public void SetNegated ()
        {
            mNegated = true;
        }

        public void SetHasOnly ()
        {
            mHasOnly = true;
        }

        public void SetTypeOmitted ()
        {
            mTypeOmitted = true;
        }

        public void SetHadUnknownExpression ()
        {
            mHadUnknownExpression = true;
        }

        public void SetType (string aMediaType)
        {
            mMediaType = aMediaType;
        }

        public nsMediaExpression NewExpression ()
        {
            return mExpressions.AppendElement();
        }
    }
}