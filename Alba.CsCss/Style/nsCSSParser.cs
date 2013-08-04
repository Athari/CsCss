using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Alba.CsCss.Gfx;
using int32_t = System.Int32;
using uint8_t = System.SByte;
using uint16_t = System.Int16;
using uint32_t = System.Int32;
using nsresult = System.UInt32; // TODO
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

        private static bool StringBeginsWith (string str, string value)
        {
            return str.StartsWith(value);
        }

        private static float ComputeCalc (nsCSSValue leftValue, object ops)
        {
            throw new NotImplementedException();
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

        public bool GetStyleRuleAt (int i, ref Rule lastRule)
        {
            lastRule = null;
            return false;
        }

        public void AppendStyleRule (Rule aRule)
        {}
    }

    internal class nsIPrincipal
    {}

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
    {}

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
        public object mData;
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

    internal class nsContentUtils
    {
        public static void ASCIIToLower (StringBuilder mIdent)
        {}
    }

    internal class nsGkAtoms
    {
        public static object all, _not, only;
    }

    internal struct nsCSSValue : IEquatable<nsCSSValue>
    {
        public nsCSSValue (nsCSSUnit auto)
        {}

        public nsCSSValue (float auto, nsCSSUnit number)
        {}

        public nsCSSValue (string mIdentStr, nsCSSUnit fontFormat)
        {}

        public nsCSSValue (nsCSSValue mIdentStr)
        {}

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

        public void SetFloatValue (double d, nsCSSUnit seconds)
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

        public void SetStringValue (StringBuilder mIdent, nsCSSUnit nsCssUnit)
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

        public float GetFloatValue ()
        {
            return 0;
        }

        public bool IsLengthUnit ()
        {
            return false;
        }

        public void Reset ()
        {}

        public void SetGradientValue (nsCSSValueGradient aGradient)
        {}

        public bool IsCalcUnit ()
        {
            return false;
        }

        public bool Equals (nsCSSValue other)
        {
            return false;
        }

        public override bool Equals (object obj)
        {
            return !ReferenceEquals(obj, null) && obj is nsCSSValue && Equals((nsCSSValue)obj);
        }

        public override int GetHashCode ()
        {
            return 0;
        }

        public static bool operator == (nsCSSValue left, nsCSSValue right)
        {
            return left.Equals(right);
        }

        public static bool operator != (nsCSSValue left, nsCSSValue right)
        {
            return !left.Equals(right);
        }

        public void SetColorValue (nscolor nsRgba)
        {}

        public void SetPercentValue (float mNumber)
        {}

        public nsCSSValueList GetListValue ()
        {
            return null;
        }

        public static string BufferFromString (string str)
        {
            return str;
        }

        public string GetStringBufferValue ()
        {
            return null;
        }

        public nsCSSValue[] GetArrayValue ()
        {
            return null;
        }

        public nsCSSValue[] InitFunction (nsCSSKeyword mozImageRect, int kNumArgs)
        {
            return null;
        }

        public void SetPairValue (nsCSSValuePair mXValue)
        {}
    }

    internal class nsCSSValueGradient
    {
        public bool mIsExplicitSize;
        public List<nsCSSValueGradientStop> mStops;
        public nsCSSValuePair mBgPos;
        public nsCSSValue mAngle;
        public bool mIsLegacySyntax;

        public nsCSSValueGradient (bool b, bool aIsRepeating)
        {}

        public nsCSSValue GetRadialShape ()
        {
            return new nsCSSValue();
        }

        public nsCSSValue GetRadialSize ()
        {
            return new nsCSSValue();
        }

        public nsCSSValue GetRadiusX ()
        {
            return new nsCSSValue();
        }

        public nsCSSValue GetRadiusY ()
        {
            return new nsCSSValue();
        }
    }

    internal class nsCSSValueGradientStop
    {
        public nsCSSValue mColor;
        public nsCSSValue mLocation;
    }

    internal class nsCSSValueList
    {
        public nsCSSValue mValue;
        public nsCSSValueList mNext;
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
        public nsCSSValue mTop, mRight, mBottom, mLeft;

        public nsCSSValue this [Side side]
        {
            get
            {
                switch (side) {
                    case Side.Top:
                        return mTop;
                    case Side.Right:
                        return mRight;
                    case Side.Bottom:
                        return mBottom;
                    case Side.Left:
                        return mLeft;
                    default:
                        throw new ArgumentOutOfRangeException("side");
                }
            }
            set
            {
                switch (side) {
                    case Side.Top:
                        mTop = value;
                        break;
                    case Side.Right:
                        mRight = value;
                        break;
                    case Side.Bottom:
                        mBottom = value;
                        break;
                    case Side.Left:
                        mLeft = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("side");
                }
            }
        }

        public void SetAllSidesTo (object nsCssValue)
        {}
    }

    internal class URLValue
    {
        public URLValue (string buffer, Uri mBaseUri, Uri mSheetUri, nsIPrincipal mSheetPrincipal)
        {}
    }

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

    internal class ImportRule : Rule
    {
        public ImportRule (nsMediaList aMedia, string aUrlSpec)
        {}
    }

    internal class StyleRule : Rule
    {
        public StyleRule (object o, Declaration declaration)
        {}

        public void SetLineNumber (int linenum)
        {}
    }

    internal class GroupRule : Rule
    {
        public void AppendStyleRule (Rule aRule)
        {}
    }

    internal class CharsetRule : Rule
    {
        public CharsetRule (string charset)
        {}
    }

    internal class MediaRule : GroupRule
    {
        public void SetMedia (nsMediaList media)
        {}
    }

    internal class NameSpaceRule : Rule
    {
        public NameSpaceRule (string prefix, string aUrlSpec)
        {}
    }

    internal class DocumentRule : GroupRule
    {
        internal class URL
        {}

        public void SetURLs (URL[] urls)
        {}
    }

    internal class CSSSupportsRule : GroupRule
    {
        public CSSSupportsRule (ref bool conditionMet, StringBuilder condition)
        {}

        public static bool PrefEnabled ()
        {
            return false;
        }
    }

    internal class nsCSSPageRule : Rule
    {
        public nsCSSPageRule (Declaration declaration)
        {}
    }

    internal class nsCSSKeyframeRule : Rule
    {
        public nsCSSKeyframeRule (List<float> selectorList, Declaration declaration)
        {}
    }

    internal class nsCSSKeyframesRule : Rule
    {
        public nsCSSKeyframesRule (string name)
        {}

        public void AppendStyleRule (nsCSSKeyframeRule kid)
        {}
    }

    internal class nsCSSFontFaceRule : Rule
    {
        public nsCSSFontFaceRule ()
        {}

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

    internal class nsStyleUtil
    {
        internal static void AppendEscapedCSSIdent (StringBuilder str, StringBuilder buffer)
        {}

        internal static void AppendEscapedCSSString (StringBuilder ident, StringBuilder buffer, char symbol)
        {}

        public static sbyte FloatToColorComponent (float mNumber)
        {
            return 0;
        }
    }

    internal class BasicFloatCalcOps
    {
        //typedef float result_type;

        public float MergeAdditive (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            if (aCalcFunction == nsCSSUnit.Calc_Plus)
                return aValue1 + aValue2;
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Minus, "unexpected unit");
            return aValue1 - aValue2;
        }

        public float MergeMultiplicativeL (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Times_L, "unexpected unit");
            return aValue1 * aValue2;
        }

        public float MergeMultiplicativeR (nsCSSUnit aCalcFunction, float aValue1, float aValue2)
        {
            if (aCalcFunction == nsCSSUnit.Calc_Times_R)
                return aValue1 * aValue2;
            Debug.Assert(aCalcFunction == nsCSSUnit.Calc_Divided, "unexpected unit");
            return aValue1 / aValue2;
        }
    };

    internal class CSSValueInputCalcOps
    {
        //typedef nsCSSValue input_type;
        //typedef nsCSSValue::Array input_array_type;

        public static nsCSSUnit GetUnit (nsCSSValue aValue)
        {
            return aValue.GetUnit();
        }
    }

    internal class ReduceNumberCalcOps : BasicFloatCalcOps /*, CSSValueInputCalcOps*/
    {
        public float ComputeLeafValue (nsCSSValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == nsCSSUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }

        public float ComputeNumber (nsCSSValue aValue)
        {
            //return ComputeCalc(aValue, this);
            throw new NotImplementedException();
        }

        public static nsCSSUnit GetUnit (nsCSSValue aValue)
        {
            return aValue.GetUnit();
        }
    }

    internal class NumbersAlreadyNormalizedOps : CSSValueInputCalcOps
    {
        public float ComputeNumber (nsCSSValue aValue)
        {
            Debug.Assert(aValue.GetUnit() == nsCSSUnit.Number, "unexpected unit");
            return aValue.GetFloatValue();
        }
    };
}