using System;
using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal class nsCSSStyleSheet
    {
        // from nsCSSStyleSheetInner
        private nsXMLNameSpaceMap mNameSpaceMap;
        private Uri mBaseURI, mSheetURI;
        private readonly List<Rule> mOrderedRules = new List<Rule>();

        public nsXMLNameSpaceMap GetNameSpaceMap ()
        {
            return mNameSpaceMap;
        }

        public Uri GetSheetURI ()
        {
            return mSheetURI;
        }

        public Uri GetBaseURI ()
        {
            return mBaseURI;
        }

        public void SetURIs (Uri aSheetURI, Uri aBaseURI)
        {
            mSheetURI = aSheetURI;
            mBaseURI = aBaseURI;
        }

        public nsIPrincipal Principal ()
        {
            return nsIPrincipal.Default;
        }

        public int StyleRuleCount ()
        {
            return mOrderedRules.Count;
        }

        public nsresult GetStyleRuleAt (int aIndex, ref Rule aRule)
        {
            aRule = mOrderedRules[aIndex];
            return nsresult.OK;
        }

        public void AppendStyleRule (Rule aRule)
        {
            mOrderedRules.Add(aRule);
            aRule.SetStyleSheet(this);
            if (aRule.GetKind() == RuleKind.NAMESPACE)
                RegisterNamespaceRule((NameSpaceRule)aRule);
        }

        private void RegisterNamespaceRule (NameSpaceRule aRule)
        {
            if (mNameSpaceMap == null)
                CreateNamespaceMap();
            // ReSharper disable once PossibleNullReferenceException - CreateNamespaceMap ensures it is not null
            mNameSpaceMap.AddPrefix(aRule.GetPrefix(), aRule.GetURLSpec());
        }

        private void CreateNamespaceMap ()
        {
            mNameSpaceMap = new nsXMLNameSpaceMap(false);
            mNameSpaceMap.AddPrefix(null, nsNameSpace.Unknown);
        }
    }
}