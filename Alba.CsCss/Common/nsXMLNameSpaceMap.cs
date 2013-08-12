using System.Collections.Generic;
using System.Linq;

namespace Alba.CsCss
{
    internal class nsXMLNameSpaceMap
    {
        private readonly Dictionary<string, int> mNameSpaces = new Dictionary<string, int>();

        public nsXMLNameSpaceMap (bool aForXML)
        {
            if (aForXML) {
                AddPrefix("xmlns", nsNameSpace.XMLNS);
                AddPrefix("xml", nsNameSpace.XML);
            }
        }

        public nsresult AddPrefix (string aPrefix, int aNameSpaceID)
        {
            mNameSpaces[aPrefix] = aNameSpaceID;
            return nsresult.OK;
        }

        public nsresult AddPrefix (string aPrefix, string aURI)
        {
            int id;
            nsNameSpaceManager.Instance.RegisterNameSpace(aURI, out id);
            return AddPrefix(aPrefix, id);
        }

        public int FindNameSpaceID (string aPrefix)
        {
            int id;
            if (mNameSpaces.TryGetValue(aPrefix, out id))
                return id;
            else
                return aPrefix != null ? nsNameSpace.Unknown : nsNameSpace.None;
        }

        public string FindPrefix (int aNameSpaceID)
        {
            return mNameSpaces.FirstOrDefault(ns => ns.Value == aNameSpaceID).Key;
        }
    }
}