using System.Collections.Generic;
using Alba.CsCss.Internal.Extensions;

// Somewhat similar to XmlNamespaceManager.
namespace Alba.CsCss
{
    internal class nsNameSpaceManager
    {
        private readonly Dictionary<string, int> mURIToIDTable = new Dictionary<string, int>();
        private readonly List<string> mURIArray = new List<string>();

        public static readonly nsNameSpaceManager Instance = new nsNameSpaceManager();

        public nsNameSpaceManager ()
        {
            RegisterNameSpace("http://www.w3.org/2000/xmlns/", nsNameSpace.XMLNS);
            RegisterNameSpace("http://www.w3.org/XML/1998/namespace", nsNameSpace.XML);
            RegisterNameSpace("http://www.w3.org/1999/xhtml", nsNameSpace.XHTML);
            RegisterNameSpace("http://www.w3.org/1999/xlink", nsNameSpace.XLink);
            RegisterNameSpace("http://www.w3.org/1999/XSL/Transform", nsNameSpace.XSLT);
            RegisterNameSpace("http://www.mozilla.org/xbl", nsNameSpace.XBL);
            RegisterNameSpace("http://www.w3.org/1998/Math/MathML", nsNameSpace.MathML);
            RegisterNameSpace("http://www.w3.org/1999/02/22-rdf-syntax-ns#", nsNameSpace.RDF);
            RegisterNameSpace("http://www.mozilla.org/keymaster/gatekeeper/there.is.only.xul", nsNameSpace.XUL);
            RegisterNameSpace("http://www.w3.org/2000/svg", nsNameSpace.SVG);
        }

        public nsresult RegisterNameSpace (string aURI, int aNameSpaceID)
        {
            return RegisterNameSpace(aURI, out aNameSpaceID);
        }

        public nsresult RegisterNameSpace (string aURI, out int aNameSpaceID)
        {
            if (aURI == "") {
                aNameSpaceID = nsNameSpace.None;
            }
            else if (!mURIToIDTable.TryGetValue(aURI, out aNameSpaceID)) {
                aNameSpaceID = mURIArray.Count + 1;
                mURIToIDTable.Add(aURI, aNameSpaceID);
                mURIArray.Add(aURI);
            }
            return nsresult.OK;
        }

        public nsresult GetNameSpaceURI (int aNameSpaceID, ref string aURI)
        {
            int index = aNameSpaceID - 1;
            if (0 <= index && index < mURIArray.Count) {
                aURI = mURIArray[index];
                return nsresult.OK;
            }
            else {
                aURI = aURI.Trim(); // yes, the original code is fucked up
                return nsresult.ERROR_ILLEGAL_VALUE;
            }
        }

        public string GetNameSpaceURI (int aNameSpaceID)
        {
            string uri = "";
            return GetNameSpaceURI(aNameSpaceID, ref uri).Succeeded() ? uri : null;
        }

        public int GetNameSpaceID (string aURI)
        {
            return aURI == "" ? nsNameSpace.None : mURIToIDTable.GetOrDefault(aURI, nsNameSpace.Unknown);
        }
    }
}