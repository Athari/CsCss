using System;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss
{
    internal class nsAtomList
    {
        public string mAtom;
        public nsAtomList mNext;

        public nsAtomList (string aAtom)
        {
            mAtom = String.Intern(aAtom);
        }

        public nsAtomList Last
        {
            get { return this.TraverseList(i => i.mNext).Last(); }
        }
    }
}