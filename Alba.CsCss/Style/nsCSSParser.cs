using System;
using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal partial class nsCSSParser
    {
        private nsCSSToken mToken = new nsCSSToken();
        private nsCSSScanner mScanner;
        private ErrorReporter mReporter;
        private Uri mBaseURI;
        private Uri mSheetURI;
        private nsIPrincipal mSheetPrincipal;
        private nsCSSStyleSheet mSheet;
        private CssLoader mChildLoader;
        private nsCSSSection mSection;
        private nsXMLNameSpaceMap mNameSpaceMap;
        private List<GroupRule> mGroupStack;
        private nsCSSExpandedDataBlock mTempData;
        private nsCSSExpandedDataBlock mData;

        // After an UngetToken is done this flag is true. The next call to
        // GetToken clears the flag.
        private bool mHavePushBack;
        // True if we are in quirks mode; false in standards or almost standards mode
        private bool mNavQuirkMode;
        // True when the hashless color quirk applies.
        private bool mHashlessColorQuirk;
        // True when the unitless length quirk applies.
        private bool mUnitlessLengthQuirk;
        // True if unsafe rules should be allowed
        private bool mUnsafeRulesEnabled;
        // True if viewport units should be allowed.
        private bool mViewportUnitsEnabled;
        // True for parsing media lists for HTML attributes, where we have to
        // ignore CSS comments.
        private bool mHTMLMediaMode;
        // This flag is set when parsing a non-box shorthand; it's used to not apply
        // some quirks during shorthand parsing
        private bool mParsingCompoundProperty;
        // True if we are somewhere within a @supports rule whose condition is
        // false.
        private bool mInFailingSupportsRule;
        // True if we will suppress all parse errors (except unexpected EOFs).
        // This is used to prevent errors for declarations inside a failing
        // @supports rule.
        private bool mSuppressErrors;

        internal bool IsSVGMode ()
        {
            return mScanner.IsSVGMode();
        }

        private void SetParsingCompoundProperty (bool aBool)
        {
            mParsingCompoundProperty = aBool;
        }

        private bool IsParsingCompoundProperty ()
        {
            return mParsingCompoundProperty;
        }

        private static void AppendRuleToSheet (Rule aRule, nsCSSParser aParser)
        {
            aParser.AppendRule(aRule);
        }

        private static bool StringBeginsWith (string str, string value)
        {
            return str.StartsWith(value);
        }

        internal delegate void RuleAppendFunc (Rule aRule, void* aData);

        private enum nsSelectorParsingStatus
        {
            // we have parsed a selector and we saw a token that cannot be
            // part of a selector:
            Done,
            // we should continue parsing the selector:
            Continue,
            // we saw an unexpected token or token value,
            // or we saw end-of-file with an unfinished selector:
            Error
        };

        [Flags]
        private enum nsParseDeclaration
        {
            InBraces = 1 << 0,
            AllowImportant = 1 << 1
        };

        private enum nsCSSContextType
        {
            eCSSContext_General,
            eCSSContext_Page
        };

        private enum PriorityParsingStatus
        {
            ePriority_None,
            ePriority_Important,
            ePriority_Error
        };

        private enum ParseAnimationOrTransitionShorthandResult
        {
            Values,
            Inherit,
            Error
        };

        private enum nsCSSSection
        {
            Charset,
            Import,
            NameSpace,
            General
        };

        private class nsAutoParseCompoundProperty : IDisposable
        {
            private readonly nsCSSParser mParser;

            public nsAutoParseCompoundProperty (nsCSSParser aParser)
            {
                mParser = aParser;
                mParser.SetParsingCompoundProperty(true);
            }

            public void Dispose ()
            {
                mParser.SetParsingCompoundProperty(false);
            }
        }

        private class nsAutoFailingSupportsRule : IDisposable
        {
            private readonly nsCSSParser mParser;
            private readonly bool mOriginalValue;

            public nsAutoFailingSupportsRule (nsCSSParser aParser, bool aCondition)
            {
                mParser = aParser;
                mOriginalValue = mParser.mInFailingSupportsRule;
                if (!aCondition)
                    mParser.mInFailingSupportsRule = true;
            }

            public void Dispose ()
            {
                mParser.mInFailingSupportsRule = mOriginalValue;
            }
        }

        private class nsAutoSuppressErrors : IDisposable
        {
            private readonly nsCSSParser mParser;
            private readonly bool mOriginalValue;

            public nsAutoSuppressErrors (nsCSSParser aParser, bool aSuppressErrors = true)
            {
                mParser = aParser;
                mOriginalValue = mParser.mSuppressErrors;
                mParser.mSuppressErrors = aSuppressErrors;
            }

            public void Dispose ()
            {
                mParser.mSuppressErrors = mOriginalValue;
            }
        }

        private const int NS_OK = 0, NS_ERROR_UNEXPECTED = 0;
    }

    internal class nsCSSExpandedDataBlock
    {
        public void AssertInitialState ()
        {}

        public void ClearProperty (nsCSSProperty aPropId)
        {}
    }

    internal class nsXMLNameSpaceMap
    {}

    internal class CssLoader
    {}

    internal class nsCSSStyleSheet
    {
        public nsXMLNameSpaceMap GetNameSpaceMap ()
        {
            return null;
        }

        public Uri GetSheetURI ()
        {
            return null;
        }

        public nsIPrincipal Principal ()
        {
            return null;
        }

        public int StyleRuleCount ()
        {
            return 0;
        }

        public bool GetStyleRuleAt (int i, out Rule lastRule)
        {
            lastRule = null;
            return false;
        }
    }

    internal class nsIPrincipal
    {}

    internal class nsIAtom
    {}

    internal class nsMediaList
    {}

    internal class nsMediaQuery
    {}

    internal class nsCSSSelectorList
    {}

    internal class nsCSSValue
    {}

    internal class Rule
    {
        public static int CHARSET_RULE;
        public static int IMPORT_RULE;
        public static int NAMESPACE_RULE;
    }

    internal class StyleRule
    {}

    internal class GroupRule
    {}

    internal class CharsetRule
    {}

    internal class MediaRule
    {}

    internal class DocumentRule
    {
        internal class URL
        {}
    }

    internal class CSSSupportsRule
    {}

    internal class nsCSSPageRule
    {}

    internal class nsCSSKeyframeRule
    {}

    internal class nsCSSKeyframesRule
    {}

    internal class Declaration
    {
        public void ClearData ()
        {}

        public void CompressFrom (nsCSSExpandedDataBlock mData)
        {}
    }
}