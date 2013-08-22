using System;
using System.Collections.Generic;
using int32_t = System.Int32;
using uint8_t = System.SByte;
using uint16_t = System.Int16;
using uint32_t = System.Int32;
using nsresult = System.UInt32; // TODO

// ReSharper disable ParameterTypeCanBeEnumerable.Local
namespace Alba.CsCss.Style
{
    internal partial class CssParser
    {
        private readonly CssToken mToken = new CssToken();
        private CssScanner mScanner;
        private ErrorReporter mReporter;
        private Uri mBaseURI;
        private Uri mSheetURI;
        private nsIPrincipal mSheetPrincipal;
        private CssStyleSheet mSheet;
        private CssLoader mChildLoader;
        private nsCSSSection mSection;
        private nsXMLNameSpaceMap mNameSpaceMap;
        private readonly List<CssGroupRule> mGroupStack = new List<CssGroupRule>();
        private readonly nsCSSExpandedDataBlock mTempData = new nsCSSExpandedDataBlock();
        private readonly nsCSSExpandedDataBlock mData = new nsCSSExpandedDataBlock();

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

        private static bool StringBeginsWith (string str, string value)
        {
            return str.StartsWith(value);
        }

        private void AppendValues (CssProperty[] aPropIDs, CssValue aValue)
        {
            foreach (CssProperty aPropId in aPropIDs)
                if (aPropId != CssProperty.Unknown)
                    AppendValue(aPropId, aValue);
        }

        private bool ParseVariant (CssValue aValue, Action<CssValue> setValue, int32_t _1, int32_t[] _2)
        {
            var res = ParseVariant(ref aValue, _1, _2);
            setValue(aValue);
            return res;
        }

        private bool ParseNonNegativeVariant (CssValue aValue, Action<CssValue> setValue, int32_t _1, int32_t[] _2)
        {
            var res = ParseNonNegativeVariant(ref aValue, _1, _2);
            setValue(aValue);
            return res;
        }

        private bool ParseSingleValueProperty (CssValue aValue, Action<CssValue> setValue, CssProperty _1)
        {
            var res = ParseSingleValueProperty(ref aValue, _1);
            setValue(aValue);
            return res;
        }

        internal delegate void RuleAppendFunc (CssRule aRule, object aData);

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
        internal enum nsParseDeclaration
        {
            InBraces = 1 << 0,
            AllowImportant = 1 << 1
        };

        internal enum nsCSSContextType
        {
            General,
            Page
        };

        internal enum PriorityParsingStatus
        {
            None,
            Important,
            Error
        };

        internal enum ParseAnimationOrTransitionShorthandResult
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

        internal enum SupportsConditionTermOperator
        {
            And,
            Or
        };

        private struct nsAutoParseCompoundProperty : IDisposable
        {
            private readonly CssParser mParser;

            public nsAutoParseCompoundProperty (CssParser aParser)
            {
                mParser = aParser;
                mParser.SetParsingCompoundProperty(true);
            }

            public void Dispose ()
            {
                mParser.SetParsingCompoundProperty(false);
            }
        }

        private struct nsAutoFailingSupportsRule : IDisposable
        {
            private readonly CssParser mParser;
            private readonly bool mOriginalValue;

            public nsAutoFailingSupportsRule (CssParser aParser, bool aCondition)
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

        private struct nsAutoSuppressErrors : IDisposable
        {
            private readonly CssParser mParser;
            private readonly bool mOriginalValue;

            public nsAutoSuppressErrors (CssParser aParser, bool aSuppressErrors = true)
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
            public CssValue mColor;
            public CssValueList mImage;
            public CssValuePairList mRepeat;
            public CssValueList mAttachment;
            public CssValueList mClip;
            public CssValueList mOrigin;
            public CssValueList mPosition;
            public CssValuePairList mSize;

            public BackgroundParseState (CssValue mColor, CssValueList mImage, CssValuePairList mRepeat, CssValueList mAttachment, CssValueList mClip, CssValueList mOrigin, CssValueList mPosition, CssValuePairList mSize)
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

        internal class ExtractFirstFamilyData
        {
            public string mFamilyName = "";
            public bool mGood;
        };

        private class UnitInfo
        {
            public string name;
            public CssUnit unit;
            public int32_t type;

            public uint32_t length
            {
                get { return name.Length; }
            }
        };

        private static class nsLayoutUtils
        {
            public static bool Are3DTransformsEnabled ()
            {
                return true;
            }
        }
    }
}