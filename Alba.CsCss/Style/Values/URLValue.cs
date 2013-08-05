using System;
using Alba.CsCss.Internal;

namespace Alba.CsCss.Style
{
    public class URLValue
    {
        internal Uri mURI;
        internal readonly Uri mReferrer;
        internal readonly string mString;
        internal readonly nsIPrincipal mOriginPrincipal;
        internal bool mURIResolved;

        internal URLValue (string aString, Uri aBaseURI, Uri aReferrer, nsIPrincipal aOriginPrincipal)
        {
            mString = aString;
            mURI = aBaseURI;
            mReferrer = aReferrer;
            mOriginPrincipal = aOriginPrincipal;
            mURIResolved = false;
        }

        internal Uri GetURI ()
        {
            if (!mURIResolved) {
                Uri uri;
                CommonUtil.NS_NewURI(out uri, mString, null, mURI);
                mURI = uri;
                mURIResolved = true;
            }
            return mURI;
        }

        // Public interface

        public string OriginalUrl
        {
            get { return mString; }
        }

        public Uri Url
        {
            get { return GetURI(); }
        }
    }
}