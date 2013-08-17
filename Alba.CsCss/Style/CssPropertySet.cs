using System.Collections;
using System.Diagnostics;
using System.Linq;

namespace Alba.CsCss.Style
{
    internal class CssPropertySet
    {
        private readonly BitArray mProperties = new BitArray((int)CssProperty.PropertyCountNoShorthands);

        public void AddProperty (CssProperty aProperty)
        {
            mProperties[(int)aProperty] = true;
        }

        public void RemoveProperty (CssProperty aProperty)
        {
            mProperties[(int)aProperty] = false;
        }

        public bool HasProperty (CssProperty aProperty)
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