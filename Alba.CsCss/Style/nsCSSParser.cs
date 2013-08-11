using System;
using System.Collections.Generic;
using int32_t = System.Int32;
using uint8_t = System.SByte;
using uint16_t = System.Int16;
using uint32_t = System.Int32;
using nsresult = System.UInt32; // TODO
namespace Alba.CsCss.Style
{
    internal partial class nsCSSParser
    {
        private readonly nsCSSToken mToken = new nsCSSToken();
        private nsCSSScanner mScanner;
        private ErrorReporter mReporter;
        private Uri mBaseURI;
        private Uri mSheetURI;
        private nsIPrincipal mSheetPrincipal;
        private nsCSSStyleSheet mSheet;
        private CssLoader mChildLoader;
        private nsCSSSection mSection;
        private nsXMLNameSpaceMap mNameSpaceMap;
        private readonly List<GroupRule> mGroupStack = new List<GroupRule>();
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

        private static float ComputeCalc (nsCSSValue leftValue, object ops)
        {
            throw new NotImplementedException();
        }

        private void AppendValues (nsCSSProperty[] aPropIDs, nsCSSValue aValue)
        {
            foreach (nsCSSProperty aPropId in aPropIDs)
                if (aPropId != nsCSSProperty.UNKNOWN)
                    AppendValue(aPropId, aValue);
        }

        internal delegate void RuleAppendFunc (Rule aRule, object aData);

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

        private struct nsAutoFailingSupportsRule : IDisposable
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

        private struct nsAutoSuppressErrors : IDisposable
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

        internal class ExtractFirstFamilyData
        {
            public string mFamilyName = "";
            public bool mGood;
        };

        private class UnitInfo
        {
            public string name;
            public nsCSSUnit unit;
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

        public void AddLonghandProperty (nsCSSProperty aPropId, nsCSSValue aValue)
        {}
    }

    internal class nsXMLNameSpaceMap
    {
        public int FindNameSpaceID (string prefix)
        {
            return 0;
        }
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
            return nsIPrincipal.Default;
        }

        public int StyleRuleCount ()
        {
            return 0;
        }

        public bool GetStyleRuleAt (int i, ref Rule lastRule)
        {
            lastRule = null;
            return false;
        }

        public void AppendStyleRule (Rule aRule)
        {}
    }

    internal class nsAtomList
    {}

    internal class nsCSSSelector
    {
        public nsCSSSelector mNegations;
        public int mNameSpace;
        public string mLowercaseTag;
        public object mIDList, mClassList, mAttrList, mPseudoClassList;
        public nsCSSSelector mNext;

        public void AddID (string mIdent)
        {}

        public void SetTag (string mIdent)
        {}

        public void AddClass (string mIdent)
        {}

        public void AddPseudoClass (object pseudoClassType)
        {}

        public void SetNameSpace (int nameSpaceId)
        {}

        public void AddAttribute (int nameSpaceId, string attr)
        {}

        public void AddAttribute (int nameSpaceId, string attr, nsAttrFunc func, string value, bool isCaseSensitive)
        {}

        public void AddPseudoClass (nsCSSPseudoClass pseudoClassType, string mIdentStr)
        {}

        public void AddPseudoClass (nsCSSPseudoClass pseudoClassType, int[] mIdentStr)
        {}

        public void AddPseudoClass (nsCSSPseudoClass pseudoClassType, nsCSSSelectorList mIdentStr)
        {}

        public void SetPseudoType (object pseudoElementType)
        {}

        public bool IsPseudoElement ()
        {
            return false;
        }

        public int CalcWeight ()
        {
            return 0;
        }
    }

    internal class nsMediaExpression
    {
        public enum Range
        {
            Min,
            Max,
            Equal
        };

        public nsMediaFeature mFeature;
        public Range mRange;
        public nsCSSValue mValue;
    }

    internal class nsMediaFeatures
    {
        public static nsMediaFeature GetFeature (string aAtom)
        {
            return null;
        }
    }

    internal class nsMediaFeature
    {
        public string mName;

        public enum RangeType
        {
            MinMaxAllowed,
            MinMaxNotAllowed
        };

        public RangeType mRangeType;

        public enum ValueType
        {
            // All value types allow nsCSSUnit.Null to indicate that no value
            // was given (in addition to the types listed below).
            Length, // values are such that nsCSSValue::IsLengthUnit() is true
            Integer, // values are nsCSSUnit.Integer
            Float, // values are nsCSSUnit.Number
            BoolInteger, // values are nsCSSUnit.Integer (0, -0, or 1 only)
            IntRatio, // values are nsCSSUnit.Array of two nsCSSUnit.Integer
            Resolution, // values are in nsCSSUnit.Inch (for dpi),
            //   nsCSSUnit.Pixel (for dppx), or
            //   nsCSSUnit.Centimeter (for dpcm)
            Enumerated, // values are nsCSSUnit.Enumerated (uses keyword table)
            Ident // values are nsCSSUnit.Ident
            // Note that a number of pieces of code (both for parsing and
            // for matching of valueless expressions) assume that all numeric
            // value types cannot be negative.  The parsing code also does
            // not allow zeros in eIntRatio types.
        };

        public ValueType mValueType;
        public nsMediaFeature mData;
        public int[] mKeywordTable;
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
    {
        public nsCSSSelectorList mNext;
        public nsCSSSelector mSelectors;
        public int mWeight;

        public nsCSSSelector AddSelector (char aPrevCombinator)
        {
            return null;
        }
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