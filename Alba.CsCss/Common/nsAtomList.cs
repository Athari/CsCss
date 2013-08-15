using System;
using System.Collections.Generic;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss
{
    internal class nsAtomList
    {
        public string mAtom;
        public nsAtomList mNext;

        public nsAtomList ()
        {}

        public nsAtomList (string aAtom)
        {
            mAtom = String.Intern(aAtom);
        }

        internal static void AddItem (ref nsAtomList @this, nsAtomList item)
        {
            while (@this != null)
                @this = @this.mNext;
            @this = item;
        }

        // Public interface

        internal IEnumerable<string> Items
        {
            get { return this.TraverseList(i => i.mNext).Select(i => i.mAtom); }
        }
    }
}