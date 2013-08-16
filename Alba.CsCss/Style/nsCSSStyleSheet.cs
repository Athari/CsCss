using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alba.CsCss.Internal.Extensions;

namespace Alba.CsCss.Style
{
    [DebuggerDisplay ("StyleSheet {mSheetURI}: Rules.Count = {mOrderedRules.Count}")]
    public class nsCSSStyleSheet
    {
        // from nsCSSStyleSheetInner
        private nsXMLNameSpaceMap mNameSpaceMap;
        private Uri mBaseURI, mSheetURI;
        private readonly List<CssRule> mOrderedRules = new List<CssRule>();

        internal nsXMLNameSpaceMap GetNameSpaceMap ()
        {
            return mNameSpaceMap;
        }

        internal Uri GetSheetURI ()
        {
            return mSheetURI;
        }

        internal Uri GetBaseURI ()
        {
            return mBaseURI;
        }

        internal void SetURIs (Uri aSheetURI, Uri aBaseURI)
        {
            mSheetURI = aSheetURI;
            mBaseURI = aBaseURI;
        }

        internal nsIPrincipal Principal ()
        {
            return nsIPrincipal.Default;
        }

        internal int StyleRuleCount ()
        {
            return mOrderedRules.Count;
        }

        internal nsresult GetStyleRuleAt (int aIndex, ref CssRule aRule)
        {
            aRule = mOrderedRules[aIndex];
            return nsresult.OK;
        }

        internal void AppendStyleRule (CssRule aRule)
        {
            mOrderedRules.Add(aRule);
            aRule.SetStyleSheet(this);
            if (aRule.GetKind() == RuleKind.NAMESPACE)
                RegisterNamespaceRule((CssNamespaceRule)aRule);
        }

        private void RegisterNamespaceRule (CssNamespaceRule aRule)
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

        // Public interface

        public Uri SheetUri
        {
            get { return mSheetURI; }
            set { mSheetURI = value; }
        }

        public Uri BaseUri
        {
            get { return mBaseURI; }
            set { mBaseURI = value; }
        }

        public IEnumerable<CssRule> Rules
        {
            get { return mOrderedRules.AsReadOnly(); }
        }

        public IEnumerable<TRule> GetRules<TRule> () where TRule : CssRule
        {
            return mOrderedRules.OfType<TRule>();
        }

        public IEnumerable<CssRule> AllRules
        {
            get
            {
                return mOrderedRules.SelectMany(rule => rule.TraverseTree(subRule => {
                    var groupRule = subRule as CssGroupRule;
                    return groupRule != null ? groupRule.Rules : Enumerable.Empty<CssRule>();
                }));
            }
        }

        public IEnumerable<TRule> GetAllRules<TRule> () where TRule : CssRule
        {
            return AllRules.OfType<TRule>();
        }
    }
}