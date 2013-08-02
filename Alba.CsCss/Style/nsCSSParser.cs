using System;
using System.Collections.Generic;
using System.Text;

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

        internal enum nsSelectorParsingStatus
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
            General,
            Page
        };

        private enum PriorityParsingStatus
        {
            None,
            Important,
            Error
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

        internal class BackgroundParseState
        {
            public nsCSSValue mColor;
            public nsCSSValueList mImage;
            public nsCSSValuePairList mRepeat;
            public nsCSSValueList mAttachment;
            public nsCSSValueList mClip;
            public nsCSSValueList mOrigin;
            public nsCSSValueList mPosition;
            public nsCSSValuePairList mSize;

            public BackgroundParseState (nsCSSValue mColor, nsCSSValueList mImage, nsCSSValuePairList mRepeat, nsCSSValueList mAttachment, nsCSSValueList mClip, nsCSSValueList mOrigin, nsCSSValueList mPosition, nsCSSValuePairList mSize)
            {
                this.mColor = mColor;
                this.mImage = mImage;
                this.mRepeat = mRepeat;
                this.mAttachment = mAttachment;
                this.mClip = mClip;
                this.mOrigin = mOrigin;
                this.mPosition = mPosition;
                this.mSize = mSize;
            }
        }

        private const int NS_OK = 0, NS_ERROR_UNEXPECTED = 0, NS_ERROR_DOM_SYNTAX_ERR = 0, NS_ERROR_MALFORMED_URI = 0;
    }

    internal class nsCSSExpandedDataBlock
    {
        public void AssertInitialState ()
        {}

        public void ClearProperty (nsCSSProperty aPropId)
        {}

        public bool TransferFromBlock (nsCSSExpandedDataBlock mTempData, nsCSSProperty aPropId, bool aIsImportant, bool b, bool b1, Declaration aDeclaration)
        {
            return false;
        }
    }

    internal class nsXMLNameSpaceMap
    {}

    internal class CssLoader
    {
        public void LoadChildSheet (nsCSSStyleSheet mSheet, Uri url, nsMediaList aMedia, ImportRule rule)
        {}
    }

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

        public void AppendStyleRule (Rule aRule)
        {}
    }

    internal class nsIPrincipal
    {}

    internal class nsIAtom
    {}

    internal class nsCSSSelector
    {
        public nsCSSSelector mNegations;

        public void AddID (StringBuilder mIdent)
        {}

        public void SetTag (StringBuilder mIdent)
        {}

        public void AddClass (StringBuilder mIdent)
        {}

        public void AddPseudoClass (object pseudoClassType)
        {}
    }

    internal class nsMediaExpression
    {
        public nsMediaFeature mFeature;
    }

    internal class nsMediaFeatures
    {}

    internal class nsMediaFeature
    {
        public string mName;
    }

    internal class nsMediaList
    {
        public void Clear ()
        {}

        public int Count ()
        {
            return 0;
        }

        public void AppendQuery (nsMediaQuery query)
        {}
    }

    internal class nsMediaQuery
    {
        public void SetTypeOmitted ()
        {}

        public void SetHadUnknownExpression ()
        {}

        public void SetNegated ()
        {}

        public void SetHasOnly ()
        {}

        public void SetType (object mediaType)
        {}

        public nsMediaExpression NewExpression ()
        {
            return null;
        }
    }

    internal class nsCSSSelectorList
    {}

    internal class nsContentUtils
    {
        public static void ASCIIToLower (StringBuilder mIdent)
        {}
    }

    internal class nsGkAtoms
    {
        public static object all, _not, only;
    }

    internal class nsCSSValue
    {
        public nsCSSUnit GetUnit ()
        {
            return 0;
        }

        public void SetArrayValue (Array val, nsCSSUnit steps)
        {}

        public nsCSSValueList SetListValue ()
        {
            return null;
        }

        public void SetFloatValue (float f, nsCSSUnit pixel)
        {}

        public void SetTripletValue (object mXValue, object mYValue, nsCSSValue depth)
        {}

        public void SetPairValue (object mXValue, object mYValue)
        {}

        public nsCSSValuePairList SetPairListValue ()
        {
            return null;
        }

        public void SetStringValue (string mIdent, nsCSSUnit nsCssUnit)
        {}

        public void SetIntValue (int p0, nsCSSUnit integer)
        {}

        public nsCSSRect SetRectValue ()
        {
            return null;
        }

        public void SetNoneValue ()
        {}

        public void SetURLValue (URLValue urlVal)
        {}

        public void SetAutoValue ()
        {}

        public void SetInheritValue ()
        {}

        public void SetInitialValue ()
        {}

        public void SetAllValue ()
        {}

        public void SetNormalValue ()
        {}

        public void SetSystemFontValue ()
        {}

        public int GetIntValue ()
        {
            return 0;
        }

        public decimal GetPercentValue ()
        {
            return 0;
        }

        public double GetFloatValue ()
        {
            return 0;
        }

        public bool IsLengthUnit ()
        {
            return false;
        }

        public void Reset ()
        {}
    }

    internal class nsCSSValueGradient
    {
        public bool mIsExplicitSize;

        public nsCSSValueGradient (bool b, bool aIsRepeating)
        {}

        public nsCSSValue GetRadialShape ()
        {
            return null;
        }

        public nsCSSValue GetRadialSize ()
        {
            return null;
        }

        public nsCSSValue GetRadiusX ()
        {
            return null;
        }

        public nsCSSValue GetRadiusY ()
        {
            return null;
        }
    }

    internal class nsCSSValueList
    {
        public nsCSSValue mValue;
    }

    internal class nsCSSValuePairList
    {
        public nsCSSValue mXValue, mYValue;
        public nsCSSValuePairList mNext;
    }

    internal class nsCSSValuePair
    {
        public nsCSSValue mXValue, mYValue;

        public void SetBothValuesTo (object nsCssValue)
        {}
    }

    internal class nsCSSRect
    {
        public void SetAllSidesTo (object nsCssValue)
        {}
    }

    internal class URLValue
    {}

    internal class nsLayoutUtils
    {
        public static bool Are3DTransformsEnabled ()
        {
            return false;
        }
    }

    internal class Rule
    {
        public static int CHARSET_RULE;
        public static int IMPORT_RULE;
        public static int NAMESPACE_RULE;
    }

    internal class ImportRule
    {}

    internal class StyleRule
    {
        public void SetLineNumber (int linenum)
        {}
    }

    internal class GroupRule
    {
        public void AppendStyleRule (Rule aRule)
        {}
    }

    internal class CharsetRule
    {}

    internal class MediaRule
    {}

    internal class NameSpaceRule
    {}

    internal class DocumentRule
    {
        internal class URL
        {}

        public void SetURLs (URL[] urls)
        {}
    }

    internal class CSSSupportsRule
    {}

    internal class nsCSSPageRule
    {}

    internal class nsCSSKeyframeRule
    {
        public nsCSSKeyframeRule forget ()
        {
            return null;
        }
    }

    internal class nsCSSKeyframesRule
    {
        public void AppendStyleRule (nsCSSKeyframeRule kid)
        {}
    }

    internal class nsCSSFontFaceRule
    {
        public void SetDesc (nsCSSFontDesc descId, nsCSSValue value)
        {}
    }

    internal class Declaration
    {
        public void ClearData ()
        {}

        public void CompressFrom (nsCSSExpandedDataBlock mData)
        {}

        public void AssertMutable ()
        {}

        public bool TryReplaceValue (nsCSSProperty aPropId, bool aIsImportant, nsCSSExpandedDataBlock mTempData, bool aChanged)
        {
            return false;
        }

        public void ExpandTo (nsCSSExpandedDataBlock mData)
        {}
    }
}