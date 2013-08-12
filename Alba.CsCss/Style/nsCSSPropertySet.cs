using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Alba.CsCss.Style
{
    internal class nsCSSPropertySet
    {
        private readonly BitArray mProperties = new BitArray((int)nsCSSProperty.COUNT_no_shorthands);

        public void AddProperty (nsCSSProperty aProperty)
        {
            mProperties[(int)aProperty] = true;
        }

        public void RemoveProperty (nsCSSProperty aProperty)
        {
            mProperties[(int)aProperty] = false;
        }

        public bool HasProperty (nsCSSProperty aProperty)
        {
            return mProperties[(int)aProperty];
        }

        public void Empty ()
        {
            mProperties.SetAll(false);
        }

        [Conditional ("DEBUG")]
        public void AssertIsEmpty (string message)
        {
            Debug.Assert(mProperties.Cast<bool>().All(v => !v), message);
        }
    }
}