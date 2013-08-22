//
// Generated file. Do not edit manually.
//
// ReSharper disable RedundantCast
// ReSharper disable DoubleNegationOperator
// ReSharper disable NegativeEqualityExpression
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
// ReSharper disable EmptyStatement
// ReSharper disable FieldCanBeMadeReadOnly.Local
// ReSharper disable ConvertToConstant.Local
// ReSharper disable RedundantArrayCreationExpression
// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable RedundantAssignment
// ReSharper disable JoinDeclarationAndInitializer
// ReSharper disable TooWideLocalVariableScope
// ReSharper disable UseObjectOrCollectionInitializer

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Alba.CsCss.Gfx;
using Alba.CsCss.Internal;
using Alba.CsCss.Internal.Extensions;

using int32_t = System.Int32;
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.Int32; // O RLY?
using size_t = System.Int32; // O RLY?

namespace Alba.CsCss.Style
{
    using CharsetRule = CssCharsetRule;
    using CSSSupportsRule = CssSupportsRule;
    using Declaration = CssDeclaration;
    using DocumentRule = CssDocumentRule;
    using GroupRule = CssGroupRule;
    using ImportRule = CssImportRule;
    using MediaRule = CssMediaRule;
    using NameSpaceRule = CssNamespaceRule;
    using nsAttrFunc = CssAttrFunction;
    using nsAttrSelector = CssAttrSelector;
    using nscolor = CssColor;
    using nsCSSFontFaceRule = CssFontFaceRule;
    using nsCSSFontFaceStyleDecl = CssFontFace;
    using nsCSSKeyframeRule = CssKeyframeRule;
    using nsCSSKeyframesRule = CssKeyframesRule;
    using nsCSSKeyword = CssKeyword;
    using nsCSSPageRule = CssPageRule;
    using nsCSSParser = CssParser;
    using nsCSSProperty = CssProperty;
    using nsCSSPseudoClass = CssPseudoClass;
    using nsCSSPseudoElement = CssPseudoElement;
    using nsCSSRect = CssRect;
    using nsCSSScanner = CssScanner;
    using nsCSSSelector = CssSelector;
    using nsCSSSelectorList = CssSelectorGroup;
    using nsCSSStyleSheet = CssStyleSheet;
    using nsCSSToken = CssToken;
    using nsCSSTokenType = CssTokenType;
    using nsCSSUnit = CssUnit;
    using nsCSSValue = CssValue;
    using nsCSSValueGradient = CssValueGradient;
    using nsCSSValueGradientStop = CssValueGradientStop;
    using nsCSSValueList = CssValueList;
    using nsCSSValuePair = CssValuePair;
    using nsCSSValuePairList = CssValuePairList;
    using nsCSSValueTriplet = CssValueTriplet;
    using nsMediaExpression = CssMediaExpression;
    using nsMediaFeature = CssMediaFeature;
    using nsMediaQuery = CssMediaQuery;
    using nsPseudoClassList = CssPseudoClassSelector;
    using Rule = CssRule;
    using RuleKind = CssRuleKind;
    using StyleRule = CssStyleRule;
    using URLValue = CssUriValue;

    internal partial class CssParser
    {
        internal const int VARIANT_KEYWORD = 0x000001; // K
        internal const int VARIANT_LENGTH = 0x000002; // L
        internal const int VARIANT_PERCENT = 0x000004; // P
        internal const int VARIANT_COLOR = 0x000008; // C eCSSUnit_Color, eCSSUnit_Ident (e.g.  "red")
        internal const int VARIANT_URL = 0x000010; // U
        internal const int VARIANT_NUMBER = 0x000020; // N
        internal const int VARIANT_INTEGER = 0x000040; // I
        internal const int VARIANT_ANGLE = 0x000080; // G
        internal const int VARIANT_FREQUENCY = 0x000100; // F
        internal const int VARIANT_TIME = 0x000200; // T
        internal const int VARIANT_STRING = 0x000400; // S
        internal const int VARIANT_COUNTER = 0x000800; //
        internal const int VARIANT_ATTR = 0x001000; //
        internal const int VARIANT_IDENTIFIER = 0x002000; // D
        internal const int VARIANT_IDENTIFIER_NO_INHERIT = 0x004000; // like above, but excluding
        internal const int VARIANT_AUTO = 0x010000; // A
        internal const int VARIANT_INHERIT = 0x020000; // H eCSSUnit_Initial, eCSSUnit_Inherit
        internal const int VARIANT_NONE = 0x040000; // O
        internal const int VARIANT_NORMAL = 0x080000; // M
        internal const int VARIANT_SYSFONT = 0x100000; // eCSSUnit_System_Font
        internal const int VARIANT_GRADIENT = 0x200000; // eCSSUnit_Gradient
        internal const int VARIANT_TIMING_FUNCTION = 0x400000; // cubic-bezier() and steps()
        internal const int VARIANT_ALL = 0x800000; //
        internal const int VARIANT_IMAGE_RECT = 0x01000000; // eCSSUnit_Function
        internal const int VARIANT_ZERO_ANGLE = 0x02000000; // unitless zero for angles
        internal const int VARIANT_CALC = 0x04000000; // eCSSUnit_Calc
        internal const int VARIANT_ELEMENT = 0x08000000; // eCSSUnit_Element
        internal const int VARIANT_POSITIVE_DIMENSION = 0x10000000; // Only lengths greater than 0.0
        internal const int VARIANT_NONNEGATIVE_DIMENSION = 0x20000000; // Only lengths greater than or equal to 0.0
        internal const int SEL_MASK_NSPACE = 0x01;
        internal const int SEL_MASK_ELEM = 0x02;
        internal const int SEL_MASK_ID = 0x04;
        internal const int SEL_MASK_CLASS = 0x08;
        internal const int SEL_MASK_ATTRIB = 0x10;
        internal const int SEL_MASK_PCLASS = 0x20;
        internal const int SEL_MASK_PELEM = 0x40;
        internal const int COLOR_TYPE_UNKNOWN = 0;
        internal const int COLOR_TYPE_INTEGERS = 1;
        internal const int COLOR_TYPE_PERCENTAGES = 2;
        internal const int FEATURE_TAG_LENGTH = 4;
        internal const int VARIANT_AL = VARIANT_AUTO | VARIANT_LENGTH;
        internal const int VARIANT_LP = VARIANT_LENGTH | VARIANT_PERCENT;
        internal const int VARIANT_LN = VARIANT_LENGTH | VARIANT_NUMBER;
        internal const int VARIANT_AH = VARIANT_AUTO | VARIANT_INHERIT;
        internal const int VARIANT_AHLP = VARIANT_AH | VARIANT_LP;
        internal const int VARIANT_AHI = VARIANT_AH | VARIANT_INTEGER;
        internal const int VARIANT_AHK = VARIANT_AH | VARIANT_KEYWORD;
        internal const int VARIANT_AHKLP = VARIANT_AHLP | VARIANT_KEYWORD;
        internal const int VARIANT_AHL = VARIANT_AH | VARIANT_LENGTH;
        internal const int VARIANT_AHKL = VARIANT_AHK | VARIANT_LENGTH;
        internal const int VARIANT_HK = VARIANT_INHERIT | VARIANT_KEYWORD;
        internal const int VARIANT_HKF = VARIANT_HK | VARIANT_FREQUENCY;
        internal const int VARIANT_HKI = VARIANT_HK | VARIANT_INTEGER;
        internal const int VARIANT_HKL = VARIANT_HK | VARIANT_LENGTH;
        internal const int VARIANT_HKLP = VARIANT_HK | VARIANT_LP;
        internal const int VARIANT_HKLPO = VARIANT_HKLP | VARIANT_NONE;
        internal const int VARIANT_HL = VARIANT_INHERIT | VARIANT_LENGTH;
        internal const int VARIANT_HI = VARIANT_INHERIT | VARIANT_INTEGER;
        internal const int VARIANT_HLP = VARIANT_HL | VARIANT_PERCENT;
        internal const int VARIANT_HLPN = VARIANT_HLP | VARIANT_NUMBER;
        internal const int VARIANT_HLPO = VARIANT_HLP | VARIANT_NONE;
        internal const int VARIANT_HTP = VARIANT_INHERIT | VARIANT_TIME | VARIANT_PERCENT;
        internal const int VARIANT_HMK = VARIANT_HK | VARIANT_NORMAL;
        internal const int VARIANT_HC = VARIANT_INHERIT | VARIANT_COLOR;
        internal const int VARIANT_HCK = VARIANT_HK | VARIANT_COLOR;
        internal const int VARIANT_HUK = VARIANT_HK | VARIANT_URL;
        internal const int VARIANT_HUO = VARIANT_INHERIT | VARIANT_URL | VARIANT_NONE;
        internal const int VARIANT_AHUO = VARIANT_AUTO | VARIANT_HUO;
        internal const int VARIANT_HPN = VARIANT_INHERIT | VARIANT_PERCENT | VARIANT_NUMBER;
        internal const int VARIANT_PN = VARIANT_PERCENT | VARIANT_NUMBER;
        internal const int VARIANT_ALPN = VARIANT_AL | VARIANT_PN;
        internal const int VARIANT_HN = VARIANT_INHERIT | VARIANT_NUMBER;
        internal const int VARIANT_HON = VARIANT_HN | VARIANT_NONE;
        internal const int VARIANT_HOS = VARIANT_INHERIT | VARIANT_NONE | VARIANT_STRING;
        internal const int VARIANT_LPN = VARIANT_LP | VARIANT_NUMBER;
        internal const int VARIANT_UK = VARIANT_URL | VARIANT_KEYWORD;
        internal const int VARIANT_UO = VARIANT_URL | VARIANT_NONE;
        internal const int VARIANT_ANGLE_OR_ZERO = VARIANT_ANGLE | VARIANT_ZERO_ANGLE;
        internal const int VARIANT_LPCALC = VARIANT_LENGTH | VARIANT_CALC | VARIANT_PERCENT;
        internal const int VARIANT_LNCALC = VARIANT_LENGTH | VARIANT_CALC | VARIANT_NUMBER;
        internal const int VARIANT_LPNCALC = VARIANT_LNCALC | VARIANT_PERCENT;
        internal const int VARIANT_IMAGE = VARIANT_URL | VARIANT_NONE | VARIANT_GRADIENT |                        VARIANT_IMAGE_RECT | VARIANT_ELEMENT;
        internal const int VARIANT_ALL_NONNUMERIC = VARIANT_KEYWORD |   VARIANT_COLOR |   VARIANT_URL |   VARIANT_STRING |   VARIANT_COUNTER |   VARIANT_ATTR |   VARIANT_IDENTIFIER |   VARIANT_IDENTIFIER_NO_INHERIT |   VARIANT_AUTO |   VARIANT_INHERIT |   VARIANT_NONE |   VARIANT_NORMAL |   VARIANT_SYSFONT |   VARIANT_GRADIENT |   VARIANT_TIMING_FUNCTION |   VARIANT_ALL |   VARIANT_CALC;
        internal const int BG_CENTER = nsStyle.BG_POSITION_CENTER;
        internal const int BG_TOP = nsStyle.BG_POSITION_TOP;
        internal const int BG_BOTTOM = nsStyle.BG_POSITION_BOTTOM;
        internal const int BG_LEFT = nsStyle.BG_POSITION_LEFT;
        internal const int BG_RIGHT = nsStyle.BG_POSITION_RIGHT;
        internal const int BG_CTB = BG_CENTER | BG_TOP | BG_BOTTOM;
        internal const int BG_TB = BG_TOP | BG_BOTTOM;
        internal const int BG_CLR = BG_CENTER | BG_LEFT | BG_RIGHT;
        internal const int BG_LR = BG_LEFT | BG_RIGHT;
        internal const int BG_SIZE_VARIANT = VARIANT_LP | VARIANT_AUTO | VARIANT_CALC;
        internal const int VARIANT_CONTENT = VARIANT_STRING | VARIANT_URL | VARIANT_COUNTER | VARIANT_ATTR |                          VARIANT_KEYWORD;

        internal nsresult SetStyleSheet(nsCSSStyleSheet aSheet)
        {
          if (aSheet != mSheet) {
            // Switch to using the new sheet, if any
            mGroupStack.Clear();
            mSheet = aSheet;
            if (mSheet != null) {
              mNameSpaceMap = mSheet.GetNameSpaceMap();
            } else {
              mNameSpaceMap = null;
            }
          } else if (mSheet != null) {
            mNameSpaceMap = mSheet.GetNameSpaceMap();
          }
        
          return nsresult.OK;
        }
        
        internal nsresult SetQuirkMode(bool aQuirkMode)
        {
          mNavQuirkMode = aQuirkMode;
          return nsresult.OK;
        }
        
        internal nsresult SetChildLoader(CssLoader aChildLoader)
        {
          mChildLoader = aChildLoader;  // not ref counted, it owns us
          return nsresult.OK;
        }
        
        internal void Reset()
        {
          Debug.Assert(mScanner == null, "resetting with scanner active");
          SetStyleSheet(null);
          SetQuirkMode(false);
          SetChildLoader(null);
        }
        
        internal void InitScanner(nsCSSScanner aScanner,
                                   ErrorReporter aReporter,
                                   Uri aSheetURI, Uri aBaseURI,
                                   nsIPrincipal aSheetPrincipal)
        {
          if (!(!mHTMLMediaMode)) throw new ArgumentException("Bad initial state");
          if (!(!mParsingCompoundProperty)) throw new ArgumentException("Bad initial state");
          if (!(mScanner == null)) throw new ArgumentException("already have scanner");
        
          mScanner = aScanner;
          mReporter = aReporter;
          mScanner.SetErrorReporter(mReporter);
        
          mBaseURI = aBaseURI;
          mSheetURI = aSheetURI;
          mSheetPrincipal = aSheetPrincipal;
          mHavePushBack = false;
        }
        
        internal void ReleaseScanner()
        {
          mScanner = null;
          mReporter = null;
          mBaseURI = null;
          mSheetURI = null;
          mSheetPrincipal = null;
        }
        
        internal nsresult ParseSheet(string aInput,
                                  Uri          aSheetURI,
                                  Uri          aBaseURI,
                                  nsIPrincipal    aSheetPrincipal,
                                  uint32_t         aLineNumber,
                                  bool             aAllowUnsafeRules)
        {
          if (aSheetPrincipal == null) throw new ArgumentException("Must have principal here!");
          if (aBaseURI == null) throw new ArgumentException("need base URI");
          if (aSheetURI == null) throw new ArgumentException("need sheet URI");
          if (mSheet == null) throw new ArgumentException("Must have sheet to parse into");
          if (mSheet == null) return nsresult.ERROR_UNEXPECTED;
        
        #if DEBUG
          Uri uri = mSheet.GetSheetURI();
          bool equal;
          Debug.Assert(aSheetURI.Equals(uri, out equal).Succeeded() && equal,
                       "Sheet URI does not match passed URI");
          Debug.Assert(mSheet.Principal().Equals(aSheetPrincipal,
                                                                out equal).Succeeded() &&
                       equal,
                       "Sheet principal does not match passed principal");
        #endif
        
          var scanner = new nsCSSScanner(aInput, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aSheetURI);
          InitScanner(scanner, reporter, aSheetURI, aBaseURI, aSheetPrincipal);
        
          int32_t ruleCount = mSheet.StyleRuleCount();
          if (0 < ruleCount) {
            Rule lastRule = null;
            mSheet.GetStyleRuleAt(ruleCount - 1, ref lastRule);
            if (lastRule != null) {
              switch (lastRule.GetKind()) {
                case CssRuleKind.Charset:
                case CssRuleKind.Import:
                  mSection = nsCSSSection.Import;
                  break;
                case CssRuleKind.Namespace:
                  mSection = nsCSSSection.NameSpace;
                  break;
                default:
                  mSection = nsCSSSection.General;
                  break;
              }
              lastRule = null;
            }
          }
          else {
            mSection = nsCSSSection.Charset; // sheet is empty, any rules are fair
          }
        
          mUnsafeRulesEnabled = aAllowUnsafeRules;
        
          nsCSSToken tk = mToken;
          for (;;) {
            // Get next non-whitespace token
            if (!GetToken(true)) {
              mReporter.OutputError();
              break;
            }
            if (nsCSSTokenType.HTMLComment == tk.mType) {
              continue; // legal here only
            }
            if (nsCSSTokenType.AtKeyword == tk.mType) {
              ParseAtRule((rule, _) => AppendRule(rule), this, false);
              continue;
            }
            UngetToken();
            if (ParseRuleSet((rule, _) => AppendRule(rule), this)) {
              mSection = nsCSSSection.General;
            }
          }
          ReleaseScanner();
        
          mUnsafeRulesEnabled = false;
        
          // XXX check for low level errors
          return nsresult.OK;
        }
        
        /**
         * Determines whether the identifier contained in the given string is a
         * vendor-specific identifier, as described in CSS 2.1 section 4.1.2.1.
         */
        static bool
        NonMozillaVendorIdentifier(string ident)
        {
          return (ident.First() == '-' &&
                  !StringBeginsWith(ident, "-moz-")) ||
                 ident.First() == '_';
        
        }
        
        internal nsresult ParseStyleAttribute(string aAttributeValue,
                                           Uri          aDocURI,
                                           Uri          aBaseURI,
                                           nsIPrincipal    aNodePrincipal,
                                           ref StyleRule aResult)
        {
          if (aNodePrincipal == null) throw new ArgumentException("Must have principal here!");
          if (aBaseURI == null) throw new ArgumentException("need base URI");
        
          // XXX line number?
          var scanner = new nsCSSScanner(aAttributeValue, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aDocURI);
          InitScanner(scanner, reporter, aDocURI, aBaseURI, aNodePrincipal);
        
          mSection = nsCSSSection.General;
        
          // In quirks mode, allow style declarations to have braces or not
          // (bug 99554).
          bool haveBraces;
          if (mNavQuirkMode && GetToken(true)) {
            haveBraces = nsCSSTokenType.Symbol == mToken.mType &&
                         '{' == mToken.mSymbol;
            UngetToken();
          }
          else {
            haveBraces = false;
          }
        
          nsParseDeclaration parseFlags = nsParseDeclaration.AllowImportant;
          if (haveBraces) {
            parseFlags |= nsParseDeclaration.InBraces;
          }
        
          Declaration declaration = ParseDeclarationBlock(parseFlags);
          if (declaration != null) {
            // Create a style rule for the declaration
            aResult = new StyleRule(null, declaration);
          } else {
            aResult = null;
          }
        
          ReleaseScanner();
        
          // XXX check for low level errors
          return nsresult.OK;
        }
        
        internal nsresult ParseDeclarations(string  aBuffer,
                                         Uri           aSheetURI,
                                         Uri           aBaseURI,
                                         nsIPrincipal     aSheetPrincipal,
                                         Declaration aDeclaration,
                                         ref bool           aChanged)
        {
          aChanged = false;
        
          if (aSheetPrincipal == null) throw new ArgumentException("Must have principal here!");
        
          var scanner = new nsCSSScanner(aBuffer, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aSheetURI);
          InitScanner(scanner, reporter, aSheetURI, aBaseURI, aSheetPrincipal);
        
          mSection = nsCSSSection.General;
        
          mData.AssertInitialState();
          aDeclaration.ClearData();
          // We could check if it was already empty, but...
          aChanged = true;
        
          for (;;) {
            // If we cleared the old decl, then we want to be calling
            // ValueAppended as we parse.
            if (!ParseDeclaration(aDeclaration, nsParseDeclaration.AllowImportant,
                                  true, ref aChanged)) {
              if (!SkipDeclaration(false)) {
                break;
              }
            }
          }
        
          aDeclaration.CompressFrom(mData);
          ReleaseScanner();
          return nsresult.OK;
        }
        
        internal nsresult ParseRule(string        aRule,
                                 Uri                 aSheetURI,
                                 Uri                 aBaseURI,
                                 nsIPrincipal           aSheetPrincipal,
                                 ref Rule             aResult)
        {
          if (aSheetPrincipal == null) throw new ArgumentException("Must have principal here!");
          if (aBaseURI == null) throw new ArgumentException("need base URI");
        
          aResult = null;
        
          var scanner = new nsCSSScanner(aRule, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aSheetURI);
          InitScanner(scanner, reporter, aSheetURI, aBaseURI, aSheetPrincipal);
        
          mSection = nsCSSSection.Charset; // callers are responsible for rejecting invalid rules.
        
          nsCSSToken tk = mToken;
          // Get first non-whitespace token
          nsresult rv = nsresult.OK;
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEParseRuleWSOnly"); };
            mReporter.OutputError();
            rv = nsresult.ERROR_DOM_SYNTAX_ERR;
          } else {
            if (nsCSSTokenType.AtKeyword == tk.mType) {
              // FIXME: perhaps aInsideBlock should be true when we are?
              Rule result = null; ParseAtRule((rule, _) => result = rule, aResult, false); aResult = result;
            } else {
              UngetToken();
              Rule result = null; ParseRuleSet((rule, _) => result = rule, aResult); aResult = result;
            }
        
            if (aResult != null && GetToken(true)) {
              // garbage after rule
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PERuleTrailing", mToken); };
              aResult = null;
            }
        
            if (aResult == null) {
              rv = nsresult.ERROR_DOM_SYNTAX_ERR;
              mReporter.OutputError();
            }
          }
        
          ReleaseScanner();
          return rv;
        }
        
        // See Bug 723197
        #if _MSC_VER
        
        #endif
        internal nsresult ParseProperty(nsCSSProperty aPropID,
                                     string aPropValue,
                                     Uri aSheetURI,
                                     Uri aBaseURI,
                                     nsIPrincipal aSheetPrincipal,
                                     Declaration aDeclaration,
                                     ref bool aChanged,
                                     bool aIsImportant,
                                     bool aIsSVGMode)
        {
          if (aSheetPrincipal == null) throw new ArgumentException("Must have principal here!");
          if (aBaseURI == null) throw new ArgumentException("need base URI");
          if (aDeclaration == null) throw new ArgumentException("Need declaration to parse into!");
        
          mData.AssertInitialState();
          mTempData.AssertInitialState();
          aDeclaration.AssertMutable();
        
          var scanner = new nsCSSScanner(aPropValue, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aSheetURI);
          InitScanner(scanner, reporter, aSheetURI, aBaseURI, aSheetPrincipal);
          mSection = nsCSSSection.General;
          scanner.SetSVGMode(aIsSVGMode);
        
          aChanged = false;
        
          // Check for unknown or preffed off properties
          if (nsCSSProperty.Unknown == aPropID || !nsCSSProps.IsEnabled(aPropID)) {
            string propName = nsCSSProps.GetStringValue(aPropID);
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEUnknownProperty", propName); };
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
            mReporter.OutputError();
            ReleaseScanner();
            return nsresult.OK;
          }
        
          bool parsedOK = ParseProperty(aPropID);
          // We should now be at EOF
          if (parsedOK && GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectEndValue", mToken); };
            parsedOK = false;
          }
        
          if (!parsedOK) {
            string propName = nsCSSProps.GetStringValue(aPropID);
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEValueParsingError", propName); };
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
            mReporter.OutputError();
            mTempData.ClearProperty(aPropID);
          } else {
        
            // We know we don't need to force a ValueAppended call for the new
            // value.  So if we are not processing a shorthand, and there's
            // already a value for this property in the declaration at the
            // same importance level, then we can just copy our parsed value
            // directly into the declaration without going through the whole
            // expand/compress thing.
            if (!aDeclaration.TryReplaceValue(aPropID, aIsImportant, mTempData, ref aChanged)) {
              // Do it the slow way
              aDeclaration.ExpandTo(mData);
              aChanged = mData.TransferFromBlock(mTempData, aPropID, aIsImportant,
                                                  true, false, aDeclaration);
              aDeclaration.CompressFrom(mData);
            }
            mReporter.ClearError();
          }
        
          mTempData.AssertInitialState();
        
          ReleaseScanner();
          return nsresult.OK;
        }
        #if _MSC_VER
        
        #endif
        
        internal nsresult ParseMediaList(string aBuffer,
                                      Uri aURI, // for error reporting
                                      uint32_t aLineNumber, // for error reporting
                                      nsMediaList aMediaList,
                                      bool aHTMLMode)
        {
          // XXX Are there cases where the caller wants to keep what it already
          // has in case of parser error?  If GatherMedia ever changes to return
          // a value other than true, we probably should avoid modifying aMediaList.
          aMediaList.Clear();
        
          // fake base URI since media lists don't have URIs in them
          var scanner = new nsCSSScanner(aBuffer, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aURI);
          InitScanner(scanner, reporter, aURI, aURI, null);
        
          mHTMLMediaMode = aHTMLMode;
        
            // XXXldb We need to make the scanner not skip CSS comments!  (Or
            // should we?)
        
          // For aHTMLMode, we used to follow the parsing rules in
          // http://www.w3.org/TR/1999/REC-html401-19991224/types.html#type-media-descriptors
          // which wouldn't work for media queries since they remove all but the
          // first word.  However, they're changed in
          // http://www.whatwg.org/specs/web-apps/current-work/multipage/section-document.html#media2
          // (as of 2008-05-29) which says that the media attribute just points
          // to a media query.  (The main substative difference is the relative
          // precedence of commas and paretheses.)
        
          bool parsedOK = GatherMedia(aMediaList, false);
          Debug.Assert(parsedOK, "GatherMedia returned false; we probably want to avoid trashing aMediaList");
        
          mReporter.ClearError();
          ReleaseScanner();
          mHTMLMediaMode = false;
        
          return nsresult.OK;
        }
        
        internal bool ParseColorString(string aBuffer,
                                        Uri aURI, // for error reporting
                                        uint32_t aLineNumber, // for error reporting
                                        ref nsCSSValue aValue)
        {
          var scanner = new nsCSSScanner(aBuffer, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aURI);
          InitScanner(scanner, reporter, aURI, aURI, null);
        
          // Parse a color, and check that there's nothing else after it.
          bool colorParsed = ParseColor(ref aValue) && !GetToken(true);
          mReporter.OutputError();
          ReleaseScanner();
          return colorParsed;
        }
        
        internal nsresult ParseSelectorString(string aSelectorString,
                                           Uri aURI, // for error reporting
                                           uint32_t aLineNumber, // for error reporting
                                           ref nsCSSSelectorList aSelectorList)
        {
          var scanner = new nsCSSScanner(aSelectorString, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aURI);
          InitScanner(scanner, reporter, aURI, aURI, null);
        
          bool success = ParseSelectorList(ref aSelectorList, '\0');
        
          // We deliberately do not call OUTPUT_ERROR here, because all our
          // callers map a failure return to a JS exception, and if that JS
          // exception is caught, people don't want to see parser diagnostics;
          // see e.g. http://bugs.jquery.com/ticket/7535
          // It would be nice to be able to save the parser diagnostics into
          // the exception, so that if it _isn't_ caught we can report them
          // along with the usual uncaught-exception message, but we don't
          // have any way to do that at present; see bug 631621.
          mReporter.ClearError();
          ReleaseScanner();
        
          if (success) {
            Debug.Assert(aSelectorList != null, "Should have list!");
            return nsresult.OK;
          }
        
          Debug.Assert(aSelectorList == null, "Shouldn't have list!");
        
          return nsresult.ERROR_DOM_SYNTAX_ERR;
        }
        
        internal nsCSSKeyframeRule ParseKeyframeRule(string  aBuffer,
                                         Uri             aURI,
                                         uint32_t            aLineNumber)
        {
          var scanner = new nsCSSScanner(aBuffer, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aURI);
          InitScanner(scanner, reporter, aURI, aURI, null);
        
          nsCSSKeyframeRule result = ParseKeyframeRule();
          if (GetToken(true)) {
            // extra garbage at the end
            result = null;
          }
        
          mReporter.OutputError();
          ReleaseScanner();
        
          return result;
        }
        
        internal bool ParseKeyframeSelectorString(string aSelectorString,
                                                   Uri aURI, // for error reporting
                                                   uint32_t aLineNumber, // for error reporting
                                                   List<float> aSelectorList)
        {
          Debug.Assert(aSelectorList.IsEmpty(), "given list should start empty");
        
          var scanner = new nsCSSScanner(aSelectorString, aLineNumber);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aURI);
          InitScanner(scanner, reporter, aURI, aURI, null);
        
          bool success = ParseKeyframeSelectorList(aSelectorList) &&
                         // must consume entire input string
                         !GetToken(true);
        
          mReporter.OutputError();
          ReleaseScanner();
        
          if (success) {
            Debug.Assert(!aSelectorList.IsEmpty(), "should not be empty");
          } else {
            aSelectorList.Clear();
          }
        
          return success;
        }
        
        internal bool EvaluateSupportsDeclaration(string aProperty,
                                                   string aValue,
                                                   Uri aDocURL,
                                                   Uri aBaseURL,
                                                   nsIPrincipal aDocPrincipal)
        {
          nsCSSProperty propID = nsCSSProps.LookupProperty(aProperty,
                                                            nsCSSProps.EnabledState.Enabled);
          if (propID == nsCSSProperty.Unknown) {
            return false;
          }
        
          var scanner = new nsCSSScanner(aValue, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aDocURL);
          InitScanner(scanner, reporter, aDocURL, aBaseURL, aDocPrincipal);
          using (/*var suppressErrors = */new nsAutoSuppressErrors(this)) {  
          
            bool parsedOK = ParseProperty(propID) && !GetToken(true);
          
            mReporter.ClearError();
            ReleaseScanner();
          
            mTempData.ClearProperty(propID);
            mTempData.AssertInitialState();
          
            return parsedOK;
          }
        }
        
        internal bool EvaluateSupportsCondition(string aDeclaration,
                                                 Uri aDocURL,
                                                 Uri aBaseURL,
                                                 nsIPrincipal aDocPrincipal)
        {
          var scanner = new nsCSSScanner(aDeclaration, 0);
          var reporter = new ErrorReporter(scanner, mSheet, mChildLoader, aDocURL);
          InitScanner(scanner, reporter, aDocURL, aBaseURL, aDocPrincipal);
          using (/*var suppressErrors = */new nsAutoSuppressErrors(this)) {  
          
            bool conditionMet = false;
            bool parsedOK = ParseSupportsCondition(ref conditionMet) && !GetToken(true);
          
            mReporter.ClearError();
            ReleaseScanner();
          
            return parsedOK && conditionMet;
          }
        }
        
        //----------------------------------------------------------------------
        
        internal bool GetToken(bool aSkipWS)
        {
          if (mHavePushBack) {
            mHavePushBack = false;
            if (!aSkipWS || mToken.mType != nsCSSTokenType.Whitespace) {
              return true;
            }
          }
          return mScanner.Next(mToken, aSkipWS);
        }
        
        internal void UngetToken()
        {
          if (!(!mHavePushBack)) throw new ArgumentException("double pushback");
          mHavePushBack = true;
        }
        
        internal bool ExpectSymbol(char aSymbol,
                                    bool aSkipWS)
        {
          if (!GetToken(aSkipWS)) {
            // CSS2.1 specifies that all "open constructs" are to be closed at
            // EOF.  It simplifies higher layers if we claim to have found an
            // ), ], }, or ; if we encounter EOF while looking for one of them.
            // Do still issue a diagnostic, to aid debugging.
            if (aSymbol == ')' || aSymbol == ']' ||
                aSymbol == '}' || aSymbol == ';') {
              { if (!mSuppressErrors) mReporter.ReportUnexpected(aSymbol); };
              return true;
            }
            else
              return false;
          }
          if (mToken.IsSymbol(aSymbol)) {
            return true;
          }
          UngetToken();
          return false;
        }
        
        // Checks to see if we're at the end of a property.  If an error occurs during
        // the check, does not signal a parse error.
        internal bool CheckEndProperty()
        {
          if (!GetToken(true)) {
            return true; // properties may end with eof
          }
          if ((nsCSSTokenType.Symbol == mToken.mType) &&
              ((';' == mToken.mSymbol) ||
               ('!' == mToken.mSymbol) ||
               ('}' == mToken.mSymbol) ||
               (')' == mToken.mSymbol))) {
            // XXX need to verify that ! is only followed by "important [;|}]
            // XXX this requires a multi-token pushback buffer
            UngetToken();
            return true;
          }
          UngetToken();
          return false;
        }
        
        // Checks if we're at the end of a property, raising an error if we're not.
        internal bool ExpectEndProperty()
        {
          if (CheckEndProperty())
            return true;
        
          // If we're here, we read something incorrect, so we should report it.
          { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectEndValue", mToken); };
          return false;
        }
        
        // Parses the priority suffix on a property, which at present may be
        // either '!important' or nothing.
        internal PriorityParsingStatus ParsePriority()
        {
          if (!GetToken(true)) {
            return PriorityParsingStatus.None; // properties may end with EOF
          }
          if (!mToken.IsSymbol('!')) {
            UngetToken();
            return PriorityParsingStatus.None; // dunno what it is, but it's not a priority
          }
        
          if (!GetToken(true)) {
            // EOF is not ok after !
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEImportantEOF"); };
            return PriorityParsingStatus.Error;
          }
        
          if (mToken.mType != nsCSSTokenType.Ident ||
              !mToken.mIdentStr.LowerCaseEqualsLiteral("important")) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedImportant", mToken); };
            UngetToken();
            return PriorityParsingStatus.Error;
          }
        
          return PriorityParsingStatus.Important;
        }
        
        internal string NextIdent()
        {
          // XXX Error reporting?
          if (!GetToken(true)) {
            return null;
          }
          if (nsCSSTokenType.Ident != mToken.mType) {
            UngetToken();
            return null;
          }
          return mToken.mIdentStr;
        }
        
        internal bool SkipAtRule(bool aInsideBlock)
        {
          for (;;) {
            if (!GetToken(true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESkipAtRuleEOF2"); };
              return false;
            }
            if (nsCSSTokenType.Symbol == mToken.mType) {
              char symbol = mToken.mSymbol;
              if (symbol == ';') {
                break;
              }
              if (aInsideBlock && symbol == '}') {
                // The closing } doesn't belong to us.
                UngetToken();
                break;
              }
              if (symbol == '{') {
                SkipUntil('}');
                break;
              } else if (symbol == '(') {
                SkipUntil(')');
              } else if (symbol == '[') {
                SkipUntil(']');
              }
            } else if (nsCSSTokenType.Function == mToken.mType ||
                       nsCSSTokenType.Bad_URL == mToken.mType) {
              SkipUntil(')');
            }
          }
          return true;
        }
        
        internal bool ParseAtRule(RuleAppendFunc aAppendFunc,
                                   object aData,
                                   bool aInAtRule)
        {
        
          nsCSSSection newSection;
          Func<RuleAppendFunc, object, bool> parseFunc;
        
          if ((mSection <= nsCSSSection.Charset) &&
              (mToken.mIdentStr.LowerCaseEqualsLiteral("charset"))) {
            parseFunc = ParseCharsetRule;
            newSection = nsCSSSection.Import;  // only one charset allowed
        
          } else if ((mSection <= nsCSSSection.Import) &&
                     mToken.mIdentStr.LowerCaseEqualsLiteral("import")) {
            parseFunc = ParseImportRule;
            newSection = nsCSSSection.Import;
        
          } else if ((mSection <= nsCSSSection.NameSpace) &&
                     mToken.mIdentStr.LowerCaseEqualsLiteral("namespace")) {
            parseFunc = ParseNameSpaceRule;
            newSection = nsCSSSection.NameSpace;
        
          } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("media")) {
            parseFunc = ParseMediaRule;
            newSection = nsCSSSection.General;
        
          } 
          // TODO support @document
          else if (mToken.mIdentStr.LowerCaseEqualsLiteral("font-face")) {
            parseFunc = ParseFontFaceRule;
            newSection = nsCSSSection.General;
        
          } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("page")) {
            parseFunc = ParsePageRule;
            newSection = nsCSSSection.General;
        
          } else if ((nsCSSProps.IsEnabled(nsCSSProperty.AliasMozAnimation) &&
                      mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-keyframes")) ||
                     mToken.mIdentStr.LowerCaseEqualsLiteral("keyframes")) {
            parseFunc = ParseKeyframesRule;
            newSection = nsCSSSection.General;
        
          } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("supports") &&
                     CSSSupportsRule.PrefEnabled()) {
            parseFunc = ParseSupportsRule;
            newSection = nsCSSSection.General;
        
          } else {
            if (!NonMozillaVendorIdentifier(mToken.mIdentStr)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEUnknownAtRule", mToken); };
              mReporter.OutputError();
            }
            // Skip over unsupported at rule, don't advance section
            return SkipAtRule(aInAtRule);
          }
        
          // Inside of @-rules, only the rules that can occur anywhere
          // are allowed.
          bool unnestable = aInAtRule && newSection != nsCSSSection.General;
          if (unnestable) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGroupRuleNestedAtRule", mToken); };
          }
          
          if (unnestable || !parseFunc(aAppendFunc, aData)) {
            // Skip over invalid at rule, don't advance section
            mReporter.OutputError();
            return SkipAtRule(aInAtRule);
          }
        
          // Nested @-rules don't affect the top-level rule chain requirement
          if (!aInAtRule) {
            mSection = newSection;
          }
          
          return true;
        }
        
        internal bool ParseCharsetRule(RuleAppendFunc aAppendFunc,
                                        object aData)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PECharsetRuleEOF"); };
            return false;
          }
        
          if (nsCSSTokenType.String != mToken.mType) {
            UngetToken();
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PECharsetRuleNotString", mToken); };
            return false;
          }
        
          string charset = mToken.mIdentStr;
        
          if (!ExpectSymbol(';', true)) {
            return false;
          }
        
          CharsetRule rule = new CharsetRule(charset);
          aAppendFunc(rule, aData);
        
          return true;
        }
        
        internal bool ParseURLOrString(ref string aURL)
        {
          if (!GetToken(true)) {
            return false;
          }
          if (nsCSSTokenType.String == mToken.mType || nsCSSTokenType.URL == mToken.mType) {
            aURL = mToken.mIdentStr;
            return true;
          }
          UngetToken();
          return false;
        }
        
        internal bool ParseMediaQuery(bool aInAtRule,
                                       ref nsMediaQuery aQuery,
                                       ref bool aHitStop)
        {
          aQuery = null;
          aHitStop = false;
        
          // "If the comma-separated list is the empty list it is assumed to
          // specify the media query 'all'."  (css3-mediaqueries, section
          // "Media Queries")
          if (!GetToken(true)) {
            aHitStop = true;
            // expected termination by EOF
            if (!aInAtRule)
              return true;
        
            // unexpected termination by EOF
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGatherMediaEOF"); };
            return true;
          }
        
          if (nsCSSTokenType.Symbol == mToken.mType && aInAtRule &&
              (mToken.mSymbol == ';' || mToken.mSymbol == '{' || mToken.mSymbol == '}' )) {
            aHitStop = true;
            UngetToken();
            return true;
          }
          UngetToken();
        
          nsMediaQuery query = new nsMediaQuery();
          aQuery = query;
        
          if (ExpectSymbol('(', true)) {
            // we got an expression without a media type
            UngetToken(); // so ParseMediaQueryExpression can handle it
            query.SetType(nsGkAtoms.all);
            query.SetTypeOmitted();
            // Just parse the first expression here.
            if (!ParseMediaQueryExpression(query)) {
              mReporter.OutputError();
              query.SetHadUnknownExpression();
            }
          } else {
            string mediaType;
            bool gotNotOrOnly = false;
            for (;;) {
              if (!GetToken(true)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGatherMediaEOF"); };
                return false;
              }
              if (nsCSSTokenType.Ident != mToken.mType) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGatherMediaNotIdent", mToken); };
                UngetToken();
                return false;
              }
              // case insensitive from CSS - must be lower cased
              mToken.mIdentStr = mToken.mIdentStr.ToLower();
              mediaType = String.Intern(mToken.mIdentStr);
              if (mediaType == null) {
                Debug.Fail("String.Intern failed - out of memory?");
              }
              if (gotNotOrOnly ||
                  (mediaType != nsGkAtoms._not && mediaType != nsGkAtoms.only))
                break;
              gotNotOrOnly = true;
              if (mediaType == nsGkAtoms._not)
                query.SetNegated();
              else
                query.SetHasOnly();
            }
            query.SetType(mediaType);
          }
        
          for (;;) {
            if (!GetToken(true)) {
              aHitStop = true;
              // expected termination by EOF
              if (!aInAtRule)
                break;
        
              // unexpected termination by EOF
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGatherMediaEOF"); };
              break;
            }
        
            if (nsCSSTokenType.Symbol == mToken.mType && aInAtRule &&
                (mToken.mSymbol == ';' || mToken.mSymbol == '{' || mToken.mSymbol == '}')) {
              aHitStop = true;
              UngetToken();
              break;
            }
            if (nsCSSTokenType.Symbol == mToken.mType && mToken.mSymbol == ',') {
              // Done with the expressions for this query
              break;
            }
            if (nsCSSTokenType.Ident != mToken.mType ||
                !mToken.mIdentStr.LowerCaseEqualsLiteral("and")) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGatherMediaNotComma", mToken); };
              UngetToken();
              return false;
            }
            if (!ParseMediaQueryExpression(query)) {
              mReporter.OutputError();
              query.SetHadUnknownExpression();
            }
          }
          return true;
        }
        
        // Returns false only when there is a low-level error in the scanner
        // (out-of-memory).
        internal bool GatherMedia(nsMediaList aMedia,
                                   bool aInAtRule)
        {
          for (;;) {
            nsMediaQuery query = null;
            bool hitStop = false;
            if (!ParseMediaQuery(aInAtRule, ref query,
                                 ref hitStop)) {
              Debug.Assert(!hitStop, "should return true when hit stop");
              mReporter.OutputError();
              if (query != null) {
                query.SetHadUnknownExpression();
              }
              if (aInAtRule) {
                char[] stopChars =
                  { ',', '{', ';', '}', '\0' };
                SkipUntilOneOf(stopChars);
              } else {
                SkipUntil(',');
              }
              // Rely on SkipUntilOneOf leaving mToken around as the last token read.
              if (mToken.mType == nsCSSTokenType.Symbol && aInAtRule &&
                  (mToken.mSymbol == '{' || mToken.mSymbol == ';'  || mToken.mSymbol == '}')) {
                UngetToken();
                hitStop = true;
              }
            }
            if (query != null) {
              aMedia.AppendQuery(query);
            }
            if (hitStop) {
              break;
            }
          }
          return true;
        }
        
        internal bool ParseMediaQueryExpression(nsMediaQuery aQuery)
        {
          if (!ExpectSymbol('(', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpectedExpressionStart", mToken); };
            return false;
          }
          if (! GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpressionEOF"); };
            return false;
          }
          if (nsCSSTokenType.Ident != mToken.mType) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpectedFeatureName", mToken); };
            UngetToken();
            SkipUntil(')');
            return false;
          }
        
          nsMediaExpression expr = aQuery.NewExpression();
        
          // case insensitive from CSS - must be lower cased
          mToken.mIdentStr = mToken.mIdentStr.ToLower();
          string featureString;
          if (StringBeginsWith(mToken.mIdentStr, "min-")) {
            expr.mRange = nsMediaExpression.RangeType.Min;
            featureString = mToken.mIdentStr.Substring(4);
          } else if (StringBeginsWith(mToken.mIdentStr, "max-")) {
            expr.mRange = nsMediaExpression.RangeType.Max;
            featureString = mToken.mIdentStr.Substring(4);
          } else {
            expr.mRange = nsMediaExpression.RangeType.Equal;
            featureString = mToken.mIdentStr;
          }
        
          string mediaFeatureAtom = String.Intern(featureString);
          if (mediaFeatureAtom == null) {
            Debug.Fail("String.Intern failed - out of memory?");
          }
          nsMediaFeature feature = nsMediaFeatures.GetFeature(mediaFeatureAtom);
          if (feature.mName == null ||
              (expr.mRange != nsMediaExpression.RangeType.Equal &&
               feature.mRangeType != nsMediaFeature.RangeType.MinMaxAllowed)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpectedFeatureName", mToken); };
            SkipUntil(')');
            return false;
          }
          expr.mFeature = feature;
        
          if (!GetToken(true) || mToken.IsSymbol(')')) {
            // Query expressions for any feature can be given without a value.
            // However, min/max prefixes are not allowed.
            if (expr.mRange != nsMediaExpression.RangeType.Equal) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQNoMinMaxWithoutValue"); };
              return false;
            }
            expr.mValue.Reset();
            return true;
          }
        
          if (!mToken.IsSymbol(':')) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpectedFeatureNameEnd", mToken); };
            UngetToken();
            SkipUntil(')');
            return false;
          }
        
          bool rv = false;
          switch (feature.mValueType) {
            case nsMediaFeature.ValueType.Length:
              rv = ParseNonNegativeVariant(ref expr.mValue, VARIANT_LENGTH, null);
              break;
            case nsMediaFeature.ValueType.Integer:
            case nsMediaFeature.ValueType.BoolInteger:
              rv = ParseNonNegativeVariant(ref expr.mValue, VARIANT_INTEGER, null);
              // Enforce extra restrictions for eBoolInteger
              if (rv &&
                  feature.mValueType == nsMediaFeature.ValueType.BoolInteger &&
                  expr.mValue.GetIntValue() > 1)
                rv = false;
              break;
            case nsMediaFeature.ValueType.Float:
              rv = ParseNonNegativeVariant(ref expr.mValue, VARIANT_NUMBER, null);
              break;
            case nsMediaFeature.ValueType.IntRatio:
              {
                // Two integers separated by '/', with optional whitespace on
                // either side of the '/'.
                nsCSSValue[] a = new nsCSSValue[2];
                expr.mValue.SetArrayValue(a, nsCSSUnit.Array);
                // We don't bother with ParseNonNegativeVariant since we have to
                // check for != 0 as well; no need to worry about the UngetToken
                // since we're throwing out up to the next ')' anyway.
                rv = ParseVariant(ref a[0], VARIANT_INTEGER, null) &&
                     a[0].GetIntValue() > 0 &&
                     ExpectSymbol('/', true) &&
                     ParseVariant(ref a[1], VARIANT_INTEGER, null) &&
                     a[1].GetIntValue() > 0;
              }
              break;
            case nsMediaFeature.ValueType.Resolution:
              rv = GetToken(true);
              if (!rv)
                break;
              rv = mToken.mType == nsCSSTokenType.Dimension && mToken.mNumber > 0.0f;
              if (!rv) {
                UngetToken();
                break;
              }
              // No worries about whether unitless zero is allowed, since the
              // value must be positive (and we checked that above).
              Debug.Assert(!mToken.mIdentStr.IsEmpty(), "unit lied");
              if (mToken.mIdentStr.LowerCaseEqualsLiteral("dpi")) {
                expr.mValue.SetFloatValue(mToken.mNumber, nsCSSUnit.Inch);
              } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("dppx")) {
                expr.mValue.SetFloatValue(mToken.mNumber, nsCSSUnit.Pixel);
              } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("dpcm")) {
                expr.mValue.SetFloatValue(mToken.mNumber, nsCSSUnit.Centimeter);
              } else {
                rv = false;
              }
              break;
            case nsMediaFeature.ValueType.Enumerated:
              rv = ParseVariant(ref expr.mValue, VARIANT_KEYWORD,
                                feature.mData.mKeywordTable);
              break;
            case nsMediaFeature.ValueType.Ident:
              rv = ParseVariant(ref expr.mValue, VARIANT_IDENTIFIER, null);
              break;
          }
          if (!rv || !ExpectSymbol(')', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEMQExpectedFeatureValue"); };
            SkipUntil(')');
            return false;
          }
        
          return true;
        }
        
        // Parse a CSS2 import rule: "@import STRING | URL [medium [, medium]]"
        internal bool ParseImportRule(RuleAppendFunc aAppendFunc, object aData)
        {
          nsMediaList media = new nsMediaList();
        
          string url = "";
          if (!ParseURLOrString(ref url)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEImportNotURI", mToken); };
            return false;
          }
        
          if (!ExpectSymbol(';', true)) {
            if (!GatherMedia(media, true) ||
                !ExpectSymbol(';', true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEImportUnexpected", mToken); };
              // don't advance section, simply ignore invalid @import
              return false;
            }
        
            // Safe to assert this, since we ensured that there is something
            // other than the ';' coming after the @import's url() token.
            Debug.Assert(media.Count() != 0, "media list must be nonempty");
          }
        
          ProcessImport(url, media, aAppendFunc, aData);
          return true;
        }
        
        internal void ProcessImport(string aURLSpec,
                                     nsMediaList aMedia,
                                     RuleAppendFunc aAppendFunc,
                                     object aData)
        {
          ImportRule rule = new ImportRule(aMedia, aURLSpec);
          aAppendFunc(rule, aData);
        
          // Diagnose bad URIs even if we don't have a child loader.
          Uri url;
          // Charset will be deduced from mBaseURI, which is more or less correct.
          nsresult rv = CommonUtil.NS_NewURI(out url, aURLSpec, null, mBaseURI);
        
          if (rv.Failed()) {
            if (rv == nsresult.ERROR_MALFORMED_URI) {
              // import url is bad
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEImportBadURI", aURLSpec); };
              mReporter.OutputError();
            }
            return;
          }
        
          if (mChildLoader != null) {
            mChildLoader.LoadChildSheet(mSheet, url, aMedia, rule);
          }
        }
        
        // Parse the {} part of an @media or @-moz-document rule.
        internal bool ParseGroupRule(GroupRule aRule,
                                      RuleAppendFunc aAppendFunc,
                                      object aData)
        {
          // XXXbz this could use better error reporting throughout the method
          if (!ExpectSymbol('{', true)) {
            return false;
          }
        
          // push rule on stack, loop over children
          PushGroup(aRule);
          nsCSSSection holdSection = mSection;
          mSection = nsCSSSection.General;
        
          for (;;) {
            // Get next non-whitespace token
            if (! GetToken(true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEGroupRuleEOF2"); };
              break;
            }
            if (mToken.IsSymbol('}')) { // done!
              UngetToken();
              break;
            }
            if (nsCSSTokenType.AtKeyword == mToken.mType) {
              // Parse for nested rules
              ParseAtRule(aAppendFunc, aData, true);
              continue;
            }
            UngetToken();
            ParseRuleSet((rule, _) => AppendRule(rule), this, true);
          }
          PopGroup();
        
          if (!ExpectSymbol('}', true)) {
            mSection = holdSection;
            return false;
          }
          aAppendFunc(aRule, aData);
          return true;
        }
        
        // Parse a CSS2 media rule: "@media medium [, medium] { ... }"
        internal bool ParseMediaRule(RuleAppendFunc aAppendFunc, object aData)
        {
          nsMediaList media = new nsMediaList();
        
          if (GatherMedia(media, true)) {
            // XXXbz this could use better error reporting throughout the method
            MediaRule rule = new MediaRule();
            // Append first, so when we do SetMedia() the rule
            // knows what its stylesheet is.
            if (ParseGroupRule(rule, aAppendFunc, aData)) {
              rule.SetMedia(media);
              return true;
            }
          }
        
          return false;
        }
        
        // Parse a @-moz-document rule.  This is like an @media rule, but instead
        // of a medium it has a nonempty list of items where each item is either
        // url(), url-prefix(), or domain().
        
        // Parse a CSS3 namespace rule: "@namespace [prefix] STRING | URL;"
        internal bool ParseNameSpaceRule(RuleAppendFunc aAppendFunc, object aData)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAtNSPrefixEOF"); };
            return false;
          }
        
          string prefix = "";
          string url = "";
        
          if (nsCSSTokenType.Ident == mToken.mType) {
            prefix = mToken.mIdentStr;
            // user-specified identifiers are case-sensitive (bug 416106)
          } else {
            UngetToken();
          }
        
          if (!ParseURLOrString(ref url) || !ExpectSymbol(';', true)) {
            if (mHavePushBack) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAtNSUnexpected", mToken); };
            } else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAtNSURIEOF"); };
            }
            return false;
          }
        
          ProcessNameSpace(prefix, url, aAppendFunc, aData);
          return true;
        }
        
        internal void ProcessNameSpace(string aPrefix,
                                        string aURLSpec,
                                        RuleAppendFunc aAppendFunc,
                                        object aData)
        {
          string prefix = "";
        
          if (!aPrefix.IsEmpty()) {
            prefix = String.Intern(aPrefix);
            if (prefix == null) {
              Debug.Fail("String.Intern failed - out of memory?");
            }
          }
        
          NameSpaceRule rule = new NameSpaceRule(prefix, aURLSpec);
          aAppendFunc(rule, aData);
        
          // If this was the first namespace rule encountered, it will trigger
          // creation of a namespace map.
          if (mNameSpaceMap == null) {
            mNameSpaceMap = mSheet.GetNameSpaceMap();
          }
        }
        
        // font-face-rule: '@font-face' '{' font-description '}'
        // font-description: font-descriptor+
        internal bool ParseFontFaceRule(RuleAppendFunc aAppendFunc, object aData)
        {
          if (!ExpectSymbol('{', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadFontBlockStart", mToken); };
            return false;
          }
        
          var rule = new nsCSSFontFaceRule();
        
          for (;;) {
            if (!GetToken(true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEFontFaceEOF"); };
              break;
            }
            if (mToken.IsSymbol('}')) { // done!
              UngetToken();
              break;
            }
        
            // ignore extra semicolons
            if (mToken.IsSymbol(';'))
              continue;
        
            if (!ParseFontDescriptor(rule)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclSkipped"); };
              mReporter.OutputError();
              if (!SkipDeclaration(true))
                break;
            }
          }
          if (!ExpectSymbol('}', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadFontBlockEnd", mToken); };
            return false;
          }
          aAppendFunc(rule, aData);
          return true;
        }
        
        // font-descriptor: font-family-desc
        //                | font-style-desc
        //                | font-weight-desc
        //                | font-stretch-desc
        //                | font-src-desc
        //                | unicode-range-desc
        //
        // All font-*-desc productions follow the pattern
        //    IDENT ':' value ';'
        //
        // On entry to this function, mToken is the IDENT.
        
        internal bool ParseFontDescriptor(nsCSSFontFaceRule aRule)
        {
          if (nsCSSTokenType.Ident != mToken.mType) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEFontDescExpected", mToken); };
            return false;
          }
        
          string descName = mToken.mIdentStr;
          if (!ExpectSymbol(':', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEParseDeclarationNoColon", mToken); };
            mReporter.OutputError();
            return false;
          }
        
          nsCSSFontDesc descID = nsCSSProps.LookupFontDesc(descName);
          var value = new nsCSSValue();
        
          if (descID == nsCSSFontDesc.UNKNOWN) {
            if (NonMozillaVendorIdentifier(descName)) {
              // silently skip other vendors' extensions
              SkipDeclaration(true);
              return true;
            } else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEUnknownFontDesc", descName); };
              return false;
            }
          }
        
          if (!ParseFontDescriptorValue(descID, ref value)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEValueParsingError", descName); };
            return false;
          }
        
          if (!ExpectEndProperty())
            return false;
        
          aRule.SetDesc(descID, value);
          return true;
        }
        
        internal bool ParseKeyframesRule(RuleAppendFunc aAppendFunc, object aData)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEKeyframeNameEOF"); };
            return false;
          }
        
          if (mToken.mType != nsCSSTokenType.Ident) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEKeyframeBadName", mToken); };
            UngetToken();
            return false;
          }
          string name = mToken.mIdentStr;
        
          if (!ExpectSymbol('{', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEKeyframeBrace", mToken); };
            return false;
          }
        
          nsCSSKeyframesRule rule = new nsCSSKeyframesRule(name);
        
          while (!ExpectSymbol('}', true)) {
            nsCSSKeyframeRule kid = ParseKeyframeRule();
            if (kid != null) {
              rule.AppendStyleRule(kid);
            } else {
              mReporter.OutputError();
              SkipRuleSet(true);
            }
          }
        
          aAppendFunc(rule, aData);
          return true;
        }
        
        internal bool ParsePageRule(RuleAppendFunc aAppendFunc, object aData)
        {
          // TODO: There can be page selectors after @page such as ":first", ":left".
          nsParseDeclaration parseFlags = nsParseDeclaration.InBraces |
                                nsParseDeclaration.AllowImportant;
        
          // Forbid viewport units in @page rules. See bug 811391.
          
          mViewportUnitsEnabled = false;
          Declaration declaration = 
                                        ParseDeclarationBlock(parseFlags,
                                                              nsCSSContextType.Page);
          mViewportUnitsEnabled = true;
        
          if (declaration == null) {
            return false;
          }
        
          // Takes ownership of declaration.
          nsCSSPageRule rule = new nsCSSPageRule(declaration);
        
          aAppendFunc(rule, aData);
          return true;
        }
        
        internal nsCSSKeyframeRule ParseKeyframeRule()
        {
          var selectorList = new List<float>();
          if (!ParseKeyframeSelectorList(selectorList)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadSelectorKeyframeRuleIgnored"); };
            return null;
          }
        
          // Ignore !important in keyframe rules
          nsParseDeclaration parseFlags = nsParseDeclaration.InBraces;
          Declaration declaration = ParseDeclarationBlock(parseFlags);
          if (declaration == null) {
            return null;
          }
        
          // Takes ownership of declaration, and steals contents of selectorList.
          nsCSSKeyframeRule rule =
            new nsCSSKeyframeRule(selectorList, declaration);
        
          return rule;
        }
        
        internal bool ParseKeyframeSelectorList(List<float> aSelectorList)
        {
          for (;;) {
            if (!GetToken(true)) {
              // The first time through the loop, this means we got an empty
              // list.  Otherwise, it means we have a trailing comma.
              return false;
            }
            float value = 0;
            switch (mToken.mType) {
              case nsCSSTokenType.Percentage:
                value = mToken.mNumber;
                break;
              case nsCSSTokenType.Ident:
                if (mToken.mIdentStr.LowerCaseEqualsLiteral("from")) {
                  value = 0.0f;
                  break;
                }
                if (mToken.mIdentStr.LowerCaseEqualsLiteral("to")) {
                  value = 1.0f;
                  break;
                }
                // fall through
                goto default;
              default:
                UngetToken();
                // The first time through the loop, this means we got an empty
                // list.  Otherwise, it means we have a trailing comma.
                return false;
            }
            aSelectorList.AppendElement(value);
            if (!ExpectSymbol(',', true)) {
              return true;
            }
          }
        }
        
        // supports_rule
        //   : "@supports" supports_condition group_rule_body
        //   ;
        internal bool ParseSupportsRule(RuleAppendFunc aAppendFunc, object aProcessData)
        {
          bool conditionMet = false;
          var condition = new StringBuilder();
        
          mScanner.StartRecording();
          bool parsed = ParseSupportsCondition(ref conditionMet);
        
          if (!parsed) {
            mScanner.StopRecording();
            return false;
          }
        
          if (!ExpectSymbol('{', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsGroupRuleStart", mToken); };
            mScanner.StopRecording();
            return false;
          }
        
          UngetToken();
          mScanner.StopRecording(condition);
        
          // Remove the "{" that would follow the condition.
          if (condition.Length() != 0) {
            condition.Truncate(condition.Length() - 1);
          }
        
          // Remove spaces from the start and end of the recorded supports condition.
          condition.Trim(" ", true, true, false);
        
          // Record whether we are in a failing @supports, so that property parse
          // errors don't get reported.
          using (/*var failing = */new nsAutoFailingSupportsRule(this, conditionMet)) {  
          
            GroupRule rule = new CSSSupportsRule(ref conditionMet, condition);
            return ParseGroupRule(rule, aAppendFunc, aProcessData);
          }
        }
        
        // supports_condition
        //   : supports_condition_in_parens supports_condition_terms
        //   | supports_condition_negation
        //   ;
        internal bool ParseSupportsCondition(ref bool aConditionMet)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionStartEOF2"); };
            return false;
          }
        
          UngetToken();
        
          if (mToken.IsSymbol('(') ||
              mToken.mType == nsCSSTokenType.Function ||
              mToken.mType == nsCSSTokenType.URL ||
              mToken.mType == nsCSSTokenType.Bad_URL) {
            return ParseSupportsConditionInParens(ref aConditionMet) &&
                   ParseSupportsConditionTerms(ref aConditionMet);
          }
        
          if (mToken.mType == nsCSSTokenType.Ident &&
              mToken.mIdentStr.LowerCaseEqualsLiteral("not")) {
            return ParseSupportsConditionNegation(ref aConditionMet);
          }
        
          { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionExpectedStart", mToken); };
          return false;
        }
        
        // supports_condition_negation
        //   : 'not' S+ supports_condition_in_parens
        //   ;
        internal bool ParseSupportsConditionNegation(ref bool aConditionMet)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionNotEOF"); };
            return false;
          }
        
          if (mToken.mType != nsCSSTokenType.Ident ||
              !mToken.mIdentStr.LowerCaseEqualsLiteral("not")) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionExpectedNot", mToken); };
            return false;
          }
        
          if (!RequireWhitespace()) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsWhitespaceRequired"); };
            return false;
          }
        
          if (ParseSupportsConditionInParens(ref aConditionMet)) {
            aConditionMet = !aConditionMet;
            return true;
          }
        
          return false;
        }
        
        // supports_condition_in_parens
        //   : '(' S* supports_condition_in_parens_inside_parens ')' S*
        //   | general_enclosed
        //   ;
        internal bool ParseSupportsConditionInParens(ref bool aConditionMet)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionInParensStartEOF"); };
            return false;
          }
        
          if (mToken.mType == nsCSSTokenType.URL) {
            aConditionMet = false;
            return true;
          }
        
          if (mToken.mType == nsCSSTokenType.Function ||
              mToken.mType == nsCSSTokenType.Bad_URL) {
            if (!SkipUntil(')')) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionInParensEOF"); };
              return false;
            }
            aConditionMet = false;
            return true;
          }
        
          if (!mToken.IsSymbol('(')) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionExpectedOpenParenOrFunction", mToken); };
            UngetToken();
            return false;
          }
        
          if (!ParseSupportsConditionInParensInsideParens(ref aConditionMet)) {
            if (!SkipUntil(')')) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionInParensEOF"); };
              return false;
            }
            aConditionMet = false;
            return true;
          }
        
          if (!(ExpectSymbol(')', true))) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsConditionExpectedCloseParen", mToken); };
            SkipUntil(')');
            return false;
          }
        
          return true;
        }
        
        // supports_condition_in_parens_inside_parens
        //   : core_declaration
        //   | supports_condition_negation
        //   | supports_condition_in_parens supports_condition_terms
        //   ;
        internal bool ParseSupportsConditionInParensInsideParens(ref bool aConditionMet)
        {
          if (!GetToken(true)) {
            return false;
          }
        
          if (mToken.mType == nsCSSTokenType.Ident) {
            if (!mToken.mIdentStr.LowerCaseEqualsLiteral("not")) {
              string propertyName = mToken.mIdentStr;
              if (!ExpectSymbol(':', true)) {
                return false;
              }
        
              if (ExpectSymbol(')', true)) {
                UngetToken();
                return false;
              }
        
              nsCSSProperty propID = nsCSSProps.LookupProperty(propertyName,
                                                                nsCSSProps.EnabledState.Enabled);
              if (propID == nsCSSProperty.Unknown) {
                aConditionMet = false;
                SkipUntil(')');
                UngetToken();
              } else {
                aConditionMet = ParseProperty(propID) &&
                                ParsePriority() != PriorityParsingStatus.Error;
                if (!aConditionMet) {
                  SkipUntil(')');
                  UngetToken();
                }
                mTempData.ClearProperty(propID);
                mTempData.AssertInitialState();
              }
              return true;
            }
        
            UngetToken();
            return ParseSupportsConditionNegation(ref aConditionMet);
          }
        
          UngetToken();
          return ParseSupportsConditionInParens(ref aConditionMet) &&
                 ParseSupportsConditionTerms(ref aConditionMet);
        }
        
        // supports_condition_terms
        //   : S+ 'and' supports_condition_terms_after_operator('and')
        //   | S+ 'or' supports_condition_terms_after_operator('or')
        //   |
        //   ;
        internal bool ParseSupportsConditionTerms(ref bool aConditionMet)
        {
          if (!RequireWhitespace() || !GetToken(false)) {
            return true;
          }
        
          if (mToken.mType != nsCSSTokenType.Ident) {
            UngetToken();
            return true;
          }
        
          if (mToken.mIdentStr.LowerCaseEqualsLiteral("and")) {
            return ParseSupportsConditionTermsAfterOperator(ref aConditionMet, SupportsConditionTermOperator.And);
          }
        
          if (mToken.mIdentStr.LowerCaseEqualsLiteral("or")) {
            return ParseSupportsConditionTermsAfterOperator(ref aConditionMet, SupportsConditionTermOperator.Or);
          }
        
          UngetToken();
          return true;
        }
        
        // supports_condition_terms_after_operator(operator)
        //   : S+ supports_condition_in_parens ( <operator> supports_condition_in_parens )*
        //   ;
        internal bool ParseSupportsConditionTermsAfterOperator(
                                 ref bool aConditionMet,
                                 SupportsConditionTermOperator aOperator)
        {
          if (!RequireWhitespace()) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESupportsWhitespaceRequired"); };
            return false;
          }
        
          string token = aOperator == SupportsConditionTermOperator.And ? "and" : "or";
          for (;;) {
            bool termConditionMet = false;
            if (!ParseSupportsConditionInParens(ref termConditionMet)) {
              return false;
            }
            aConditionMet = aOperator == SupportsConditionTermOperator.And ? aConditionMet && termConditionMet :
                                                aConditionMet || termConditionMet;
        
            if (!GetToken(true)) {
              return true;
            }
        
            if (mToken.mType != nsCSSTokenType.Ident ||
                !mToken.mIdentStr.LowerCaseEqualsASCII(token)) {
              UngetToken();
              return true;
            }
          }
        }
        
        internal bool SkipUntil(char aStopSymbol)
        {
          nsCSSToken tk = mToken;
          var stack = new List<char>(16);
          stack.AppendElement(aStopSymbol);
          for (;;) {
            if (!GetToken(true)) {
              return false;
            }
            if (nsCSSTokenType.Symbol == tk.mType) {
              char symbol = tk.mSymbol;
              uint32_t stackTopIndex = stack.Length() - 1;
              if (symbol == stack.ElementAt(stackTopIndex)) {
                stack.RemoveElementAt(stackTopIndex);
                if (stackTopIndex == 0) {
                  return true;
                }
        
              // Just handle out-of-memory by parsing incorrectly.  It's
              // highly unlikely we're dealing with a legitimate style sheet
              // anyway.
              } else if ('{' == symbol) {
                stack.AppendElement('}');
              } else if ('[' == symbol) {
                stack.AppendElement(']');
              } else if ('(' == symbol) {
                stack.AppendElement(')');
              }
            } else if (nsCSSTokenType.Function == tk.mType ||
                       nsCSSTokenType.Bad_URL == tk.mType) {
              stack.AppendElement(')');
            }
          }
        }
        
        internal void SkipUntilOneOf(char[] aStopSymbolChars)
        {
          nsCSSToken tk = mToken;
          char[] stopSymbolChars = aStopSymbolChars;
          for (;;) {
            if (!GetToken(true)) {
              break;
            }
            if (nsCSSTokenType.Symbol == tk.mType) {
              char symbol = tk.mSymbol;
              if (stopSymbolChars.FindChar(symbol) != -1) {
                break;
              } else if ('{' == symbol) {
                SkipUntil('}');
              } else if ('[' == symbol) {
                SkipUntil(']');
              } else if ('(' == symbol) {
                SkipUntil(')');
              }
            } else if (nsCSSTokenType.Function == tk.mType ||
                       nsCSSTokenType.Bad_URL == tk.mType) {
              SkipUntil(')');
            }
          }
        }
        
        internal bool SkipDeclaration(bool aCheckForBraces)
        {
          nsCSSToken tk = mToken;
          for (;;) {
            if (!GetToken(true)) {
              if (aCheckForBraces) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PESkipDeclBraceEOF"); };
              }
              return false;
            }
            if (nsCSSTokenType.Symbol == tk.mType) {
              char symbol = tk.mSymbol;
              if (';' == symbol) {
                break;
              }
              if (aCheckForBraces) {
                if ('}' == symbol) {
                  UngetToken();
                  break;
                }
              }
              if ('{' == symbol) {
                SkipUntil('}');
              } else if ('(' == symbol) {
                SkipUntil(')');
              } else if ('[' == symbol) {
                SkipUntil(']');
              }
            } else if (nsCSSTokenType.Function == tk.mType ||
                       nsCSSTokenType.Bad_URL == tk.mType) {
              SkipUntil(')');
            }
          }
          return true;
        }
        
        internal void SkipRuleSet(bool aInsideBraces = false)
        {
          nsCSSToken tk = mToken;
          for (;;) {
            if (!GetToken(true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESkipRSBraceEOF"); };
              break;
            }
            if (nsCSSTokenType.Symbol == tk.mType) {
              char symbol = tk.mSymbol;
              if ('}' == symbol && aInsideBraces) {
                // leave block closer for higher-level grammar to consume
                UngetToken();
                break;
              } else if ('{' == symbol) {
                SkipUntil('}');
                break;
              } else if ('(' == symbol) {
                SkipUntil(')');
              } else if ('[' == symbol) {
                SkipUntil(']');
              }
            } else if (nsCSSTokenType.Function == tk.mType ||
                       nsCSSTokenType.Bad_URL == tk.mType) {
              SkipUntil(')');
            }
          }
        }
        
        internal void PushGroup(GroupRule aRule)
        {
          mGroupStack.AppendElement(aRule);
        }
        
        internal void PopGroup()
        {
          uint32_t count = mGroupStack.Length();
          if (0 < count) {
            mGroupStack.RemoveElementAt(count - 1);
          }
        }
        
        internal void AppendRule(Rule aRule)
        {
          uint32_t count = mGroupStack.Length();
          if (0 < count) {
            mGroupStack[count - 1].AppendStyleRule(aRule);
          }
          else {
            mSheet.AppendStyleRule(aRule);
          }
        }
        
        internal bool ParseRuleSet(RuleAppendFunc aAppendFunc, object aData,
                                    bool aInsideBraces = false)
        {
          // First get the list of selectors for the rule
          nsCSSSelectorList slist = null;
          uint32_t linenum = mScanner.GetLineNumber();
          if (! ParseSelectorList(ref slist, '{')) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadSelectorRSIgnored"); };
            mReporter.OutputError();
            SkipRuleSet(aInsideBraces);
            return false;
          }
          Debug.Assert(null != slist, "null selector list");
          mReporter.ClearError();
        
          // Next parse the declaration block
          nsParseDeclaration parseFlags = nsParseDeclaration.InBraces |
                                nsParseDeclaration.AllowImportant;
          Declaration declaration = ParseDeclarationBlock(parseFlags);
          if (null == declaration) {
            return false;
          }
        
          // Translate the selector list and declaration block into style data
        
          StyleRule rule = new StyleRule(slist, declaration);
          rule.SetLineNumber(linenum);
          aAppendFunc(rule, aData);
        
          return true;
        }
        
        internal bool ParseSelectorList(ref nsCSSSelectorList aListHead,
                                         char aStopChar)
        {
          nsCSSSelectorList list = null;
          if (! ParseSelectorGroup(ref list)) {
            // must have at least one selector group
            aListHead = null;
            return false;
          }
          Debug.Assert(null != list, "no selector list");
          aListHead = list;
        
          // After that there must either be a "," or a "{" (the latter if
          // StopChar is nonzero)
          nsCSSToken tk = mToken;
          for (;;) {
            if (! GetToken(true)) {
              if (aStopChar == '\0') {
                return true;
              }
        
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorListExtraEOF"); };
              break;
            }
        
            if (nsCSSTokenType.Symbol == tk.mType) {
              if (',' == tk.mSymbol) {
                nsCSSSelectorList newList = null;
                // Another selector group must follow
                if (! ParseSelectorGroup(ref newList)) {
                  break;
                }
                // add new list to the end of the selector list
                list.mNext = newList;
                list = newList;
                continue;
              } else if (aStopChar == tk.mSymbol && aStopChar != '\0') {
                UngetToken();
                return true;
              }
            }
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorListExtra", mToken); };
            UngetToken();
            break;
          }
        
          aListHead = null;
          return false;
        }
        
        static bool IsUniversalSelector(nsCSSSelector aSelector)
        {
          return ((bool)((aSelector.mNameSpace == nsNameSpace.Unknown) &&
                        (aSelector.mLowercaseTag == null) &&
                        (aSelector.mIDList == null) &&
                        (aSelector.mClassList == null) &&
                        (aSelector.mAttrList == null) &&
                        (aSelector.mNegations == null) &&
                        (aSelector.mPseudoClassList == null)));
        }
        
        internal bool ParseSelectorGroup(ref nsCSSSelectorList aList)
        {
          char combinator = '\0';
          var list = new nsCSSSelectorList();
        
          for (;;) {
            if (!ParseSelector(list, combinator)) {
              return false;
            }
        
            // Look for a combinator.
            if (!GetToken(false)) {
              break; // EOF ok here
            }
        
            combinator = '\0';
            if (mToken.mType == nsCSSTokenType.Whitespace) {
              if (!GetToken(true)) {
                break; // EOF ok here
              }
              combinator = ' ';
            }
        
            if (mToken.mType != nsCSSTokenType.Symbol) {
              UngetToken(); // not a combinator
            } else {
              char symbol = mToken.mSymbol;
              if (symbol == '+' || symbol == '>' || symbol == '~') {
                combinator = mToken.mSymbol;
              } else {
                UngetToken(); // not a combinator
                if (symbol == ',' || symbol == '{' || symbol == ')') {
                  break; // end of selector group
                }
              }
            }
        
            if (combinator == 0) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorListExtra", mToken); };
              return false;
            }
          }
        
          aList = list;
          return true;
        }
        
        //
        // Parses an ID selector #name
        //
        internal nsSelectorParsingStatus ParseIDSelector(ref int32_t       aDataMask,
                                       nsCSSSelector aSelector)
        {
          Debug.Assert(!mToken.mIdentStr.IsEmpty(),
                       "Empty mIdent in nsCSSTokenType.ID token?");
          aDataMask |= SEL_MASK_ID;
          aSelector.AddID(mToken.mIdentStr);
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parses a class selector .name
        //
        internal nsSelectorParsingStatus ParseClassSelector(ref int32_t       aDataMask,
                                          nsCSSSelector aSelector)
        {
          if (! GetToken(false)) { // get ident
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEClassSelEOF"); };
            return nsSelectorParsingStatus.Error;
          }
          if (nsCSSTokenType.Ident != mToken.mType) {  // malformed selector
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEClassSelNotIdent", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
          aDataMask |= SEL_MASK_CLASS;
        
          aSelector.AddClass(mToken.mIdentStr);
        
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse a type element selector or a universal selector
        // namespace|type or namespace|* or *|* or *
        //
        internal nsSelectorParsingStatus ParseTypeOrUniversalSelector(ref int32_t       aDataMask,
                                                    nsCSSSelector aSelector,
                                                    bool           aIsNegated)
        {
          string buffer;
          if (mToken.IsSymbol('*')) {  // universal element selector, or universal namespace
            if (ExpectSymbol('|', false)) {  // was namespace
              aDataMask |= SEL_MASK_NSPACE;
              aSelector.SetNameSpace(nsNameSpace.Unknown); // namespace wildcard
        
              if (! GetToken(false)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelEOF"); };
                return nsSelectorParsingStatus.Error;
              }
              if (nsCSSTokenType.Ident == mToken.mType) {  // element name
                aDataMask |= SEL_MASK_ELEM;
        
                aSelector.SetTag(mToken.mIdentStr);
              }
              else if (mToken.IsSymbol('*')) {  // universal selector
                aDataMask |= SEL_MASK_ELEM;
                // don't set tag
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelNotType", mToken); };
                UngetToken();
                return nsSelectorParsingStatus.Error;
              }
            }
            else {  // was universal element selector
              SetDefaultNamespaceOnSelector(aSelector);
              aDataMask |= SEL_MASK_ELEM;
              // don't set any tag in the selector
            }
            if (! GetToken(false)) {   // premature eof is ok (here!)
              return nsSelectorParsingStatus.Done;
            }
          }
          else if (nsCSSTokenType.Ident == mToken.mType) {    // element name or namespace name
            buffer = mToken.mIdentStr; // hang on to ident
        
            if (ExpectSymbol('|', false)) {  // was namespace
              aDataMask |= SEL_MASK_NSPACE;
              int32_t nameSpaceID = GetNamespaceIdForPrefix(buffer);
              if (nameSpaceID == nsNameSpace.Unknown) {
                return nsSelectorParsingStatus.Error;
              }
              aSelector.SetNameSpace(nameSpaceID);
        
              if (! GetToken(false)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelEOF"); };
                return nsSelectorParsingStatus.Error;
              }
              if (nsCSSTokenType.Ident == mToken.mType) {  // element name
                aDataMask |= SEL_MASK_ELEM;
                aSelector.SetTag(mToken.mIdentStr);
              }
              else if (mToken.IsSymbol('*')) {  // universal selector
                aDataMask |= SEL_MASK_ELEM;
                // don't set tag
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelNotType", mToken); };
                UngetToken();
                return nsSelectorParsingStatus.Error;
              }
            }
            else {  // was element name
              SetDefaultNamespaceOnSelector(aSelector);
              aSelector.SetTag(buffer);
        
              aDataMask |= SEL_MASK_ELEM;
            }
            if (! GetToken(false)) {   // premature eof is ok (here!)
              return nsSelectorParsingStatus.Done;
            }
          }
          else if (mToken.IsSymbol('|')) {  // No namespace
            aDataMask |= SEL_MASK_NSPACE;
            aSelector.SetNameSpace(nsNameSpace.None);  // explicit NO namespace
        
            // get mandatory tag
            if (! GetToken(false)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelEOF"); };
              return nsSelectorParsingStatus.Error;
            }
            if (nsCSSTokenType.Ident == mToken.mType) {  // element name
              aDataMask |= SEL_MASK_ELEM;
              aSelector.SetTag(mToken.mIdentStr);
            }
            else if (mToken.IsSymbol('*')) {  // universal selector
              aDataMask |= SEL_MASK_ELEM;
              // don't set tag
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PETypeSelNotType", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
            if (! GetToken(false)) {   // premature eof is ok (here!)
              return nsSelectorParsingStatus.Done;
            }
          }
          else {
            SetDefaultNamespaceOnSelector(aSelector);
          }
        
          if (aIsNegated) {
            // restore last token read in case of a negated type selector
            UngetToken();
          }
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse attribute selectors [attr], [attr=value], [attr|=value],
        // [attr~=value], [attr^=value], [attr$=value] and [attr*=value]
        //
        internal nsSelectorParsingStatus ParseAttributeSelector(ref int32_t       aDataMask,
                                              nsCSSSelector aSelector)
        {
          if (! GetToken(true)) { // premature EOF
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
            return nsSelectorParsingStatus.Error;
          }
        
          int32_t nameSpaceID = nsNameSpace.None;
          string  attr;
          if (mToken.IsSymbol('*')) { // wildcard namespace
            nameSpaceID = nsNameSpace.Unknown;
            if (ExpectSymbol('|', false)) {
              if (! GetToken(false)) { // premature EOF
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
                return nsSelectorParsingStatus.Error;
              }
              if (nsCSSTokenType.Ident == mToken.mType) { // attr name
                attr = mToken.mIdentStr;
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
                UngetToken();
                return nsSelectorParsingStatus.Error;
               }
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelNoBar", mToken); };
              return nsSelectorParsingStatus.Error;
            }
          }
          else if (mToken.IsSymbol('|')) { // NO namespace
            if (! GetToken(false)) { // premature EOF
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
              return nsSelectorParsingStatus.Error;
            }
            if (nsCSSTokenType.Ident == mToken.mType) { // attr name
              attr = mToken.mIdentStr;
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
          }
          else if (nsCSSTokenType.Ident == mToken.mType) { // attr name or namespace
            attr = mToken.mIdentStr; // hang on to it
            if (ExpectSymbol('|', false)) {  // was a namespace
              nameSpaceID = GetNamespaceIdForPrefix(attr);
              if (nameSpaceID == nsNameSpace.Unknown) {
                return nsSelectorParsingStatus.Error;
              }
              if (! GetToken(false)) { // premature EOF
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
                return nsSelectorParsingStatus.Error;
              }
              if (nsCSSTokenType.Ident == mToken.mType) { // attr name
                attr = mToken.mIdentStr;
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
                UngetToken();
                return nsSelectorParsingStatus.Error;
              }
            }
          }
          else {  // malformed
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameOrNamespaceExpected", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
        
          if (! GetToken(true)) { // premature EOF
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelInnerEOF"); };
            return nsSelectorParsingStatus.Error;
          }
          if ((nsCSSTokenType.Symbol == mToken.mType) ||
              (nsCSSTokenType.Includes == mToken.mType) ||
              (nsCSSTokenType.Dashmatch == mToken.mType) ||
              (nsCSSTokenType.Beginsmatch == mToken.mType) ||
              (nsCSSTokenType.Endsmatch == mToken.mType) ||
              (nsCSSTokenType.Containsmatch == mToken.mType)) {
            nsAttrFunc func;
            if (nsCSSTokenType.Includes == mToken.mType) {
              func = nsAttrFunc.Includes;
            }
            else if (nsCSSTokenType.Dashmatch == mToken.mType) {
              func = nsAttrFunc.DashMatch;
            }
            else if (nsCSSTokenType.Beginsmatch == mToken.mType) {
              func = nsAttrFunc.BeginsMatch;
            }
            else if (nsCSSTokenType.Endsmatch == mToken.mType) {
              func = nsAttrFunc.EndsMatch;
            }
            else if (nsCSSTokenType.Containsmatch == mToken.mType) {
              func = nsAttrFunc.ContainsMatch;
            }
            else if (']' == mToken.mSymbol) {
              aDataMask |= SEL_MASK_ATTRIB;
              aSelector.AddAttribute(nameSpaceID, attr);
              func = nsAttrFunc.Set;
            }
            else if ('=' == mToken.mSymbol) {
              func = nsAttrFunc.Equals;
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelUnexpected", mToken); };
              UngetToken(); // bad function
              return nsSelectorParsingStatus.Error;
            }
            if (nsAttrFunc.Set != func) { // get value
              if (! GetToken(true)) { // premature EOF
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelValueEOF"); };
                return nsSelectorParsingStatus.Error;
              }
              if ((nsCSSTokenType.Ident == mToken.mType) || (nsCSSTokenType.String == mToken.mType)) {
                string value = mToken.mIdentStr;
                if (! GetToken(true)) { // premature EOF
                  { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelCloseEOF"); };
                  return nsSelectorParsingStatus.Error;
                }
                if (mToken.IsSymbol(']')) {
                  bool isCaseSensitive = true;
        
                  // For cases when this style sheet is applied to an HTML
                  // element in an HTML document, and the attribute selector is
                  // for a non-namespaced attribute, then check to see if it's
                  // one of the known attributes whose VALUE is
                  // case-insensitive.
                  if (nameSpaceID == nsNameSpace.None) {
                    /*TODO: static*/ string[] caseInsensitiveHTMLAttribute = {
                      // list based on http://www.w3.org/TR/html4/
                      "lang",
                      "dir",
                      "http-equiv",
                      "text",
                      "link",
                      "vlink",
                      "alink",
                      "compact",
                      "align",
                      "frame",
                      "rules",
                      "valign",
                      "scope",
                      "axis",
                      "nowrap",
                      "hreflang",
                      "rel",
                      "rev",
                      "charset",
                      "codetype",
                      "declare",
                      "valuetype",
                      "shape",
                      "nohref",
                      "media",
                      "bgcolor",
                      "clear",
                      "color",
                      "face",
                      "noshade",
                      "noresize",
                      "scrolling",
                      "target",
                      "method",
                      "enctype",
                      "accept-charset",
                      "accept",
                      "checked",
                      "multiple",
                      "selected",
                      "disabled",
                      "readonly",
                      "language",
                      "defer",
                      "type",
                      // additional attributes not in HTML4
                      "direction", // marquee
                      null
                    };
                    short i = 0;
                    string htmlAttr;
                    while ((htmlAttr = caseInsensitiveHTMLAttribute[i++]) != null) {
                      if (attr.LowerCaseEqualsASCII(htmlAttr)) {
                        isCaseSensitive = false;
                        break;
                      }
                    }
                  }
                  aDataMask |= SEL_MASK_ATTRIB;
                  aSelector.AddAttribute(nameSpaceID, attr, func, value, isCaseSensitive);
                }
                else {
                  { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelNoClose", mToken); };
                  UngetToken();
                  return nsSelectorParsingStatus.Error;
                }
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelBadValue", mToken); };
                UngetToken();
                return nsSelectorParsingStatus.Error;
              }
            }
          }
          else {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttSelUnexpected", mToken); };
            UngetToken(); // bad dog, no biscut!
            return nsSelectorParsingStatus.Error;
           }
           return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse pseudo-classes and pseudo-elements
        //
        internal nsSelectorParsingStatus ParsePseudoSelector(ref int32_t       aDataMask,
                                           nsCSSSelector aSelector,
                                           bool           aIsNegated,
                                           ref string      aPseudoElement,
                                           object   aPseudoElementArgs,
                                           ref nsCSSPseudoElement aPseudoElementType)
        {
          
          Debug.Assert(!aIsNegated || (aPseudoElement == null && aPseudoElementArgs == null),
                       "negated selectors shouldn't have a place to store pseudo elements");
          if (! GetToken(false)) { // premature eof
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelEOF"); };
            return nsSelectorParsingStatus.Error;
          }
        
          // First, find out whether we are parsing a CSS3 pseudo-element
          bool parsingPseudoElement = false;
          if (mToken.IsSymbol(':')) {
            parsingPseudoElement = true;
            if (! GetToken(false)) { // premature eof
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelEOF"); };
              return nsSelectorParsingStatus.Error;
            }
          }
        
          // Do some sanity-checking on the token
          if (nsCSSTokenType.Ident != mToken.mType && nsCSSTokenType.Function != mToken.mType) {
            // malformed selector
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelBadName", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
        
          // OK, now we know we have an mIdent.  Atomize it.  All the atoms, for
          // pseudo-classes as well as pseudo-elements, start with a single ':'
          string pseudo = String.Intern(":" + mToken.mIdentStr);
        
          // stash away some info about this pseudo so we only have to get it once.
          bool isTreePseudo = false;
          nsCSSPseudoElement pseudoElementType =
            nsCSSPseudoElements.GetPseudoType(pseudo);
          nsCSSPseudoClass pseudoClassType =
            nsCSSPseudoClasses.GetPseudoType(pseudo);
        
          // We currently allow :-moz-placeholder and .-moz-placeholder. We have to
          // be a bit stricter regarding the pseudo-element parsing rules.
          if (pseudoElementType == nsCSSPseudoElement.MozPlaceholder &&
              pseudoClassType == nsCSSPseudoClass.MozPlaceholder) {
            if (parsingPseudoElement) {
              pseudoClassType = nsCSSPseudoClass.NotPseudoClass;
            } else {
              pseudoElementType = nsCSSPseudoElement.NotPseudoElement;
            }
          }
        
        #if MOZ_XUL
          isTreePseudo = (pseudoElementType == nsCSSPseudoElement.Xultree);
          // If a tree pseudo-element is using the function syntax, it will
          // get isTree set here and will pass the check below that only
          // allows functions if they are in our list of things allowed to be
          // functions.  If it is _not_ using the function syntax, isTree will
          // be false, and it will still pass that check.  So the tree
          // pseudo-elements are allowed to be either functions or not, as
          // desired.
          bool isTree = (nsCSSTokenType.Function == mToken.mType) && isTreePseudo;
        #endif
          bool isPseudoElement =
            (pseudoElementType < nsCSSPseudoElement.PseudoElementCount);
          // anonymous boxes are only allowed if they're the tree boxes or we have
          // enabled unsafe rules
          bool isAnonBox = isTreePseudo ||
            (pseudoElementType == nsCSSPseudoElement.AnonBox &&
             mUnsafeRulesEnabled);
          bool isPseudoClass =
            (pseudoClassType != nsCSSPseudoClass.NotPseudoClass);
        
          Debug.Assert(!isPseudoClass ||
                       pseudoElementType == nsCSSPseudoElement.NotPseudoElement,
                       "Why is this atom both a pseudo-class and a pseudo-element?");
          Debug.Assert((isPseudoClass?1:0) + (isPseudoElement?1:0) + (isAnonBox?1:0) <= 1,
                       "Shouldn't be more than one of these");
        
          if (!isPseudoClass && !isPseudoElement && !isAnonBox) {
            // Not a pseudo-class, not a pseudo-element.... forget it
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelUnknown", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
        
          // If it's a function token, it better be on our "ok" list, and if the name
          // is that of a function pseudo it better be a function token
          if ((nsCSSTokenType.Function == mToken.mType) !=
              (
        #if MOZ_XUL
               isTree ||
        #endif
               nsCSSPseudoClass.NotPseudo == pseudoClassType ||
               nsCSSPseudoClasses.HasStringArg(pseudoClassType) ||
               nsCSSPseudoClasses.HasNthPairArg(pseudoClassType) ||
               nsCSSPseudoClasses.HasSelectorListArg(pseudoClassType))) {
            // There are no other function pseudos
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelNonFunc", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
        
          // If it starts with ".", it better be a pseudo-element
          if (parsingPseudoElement &&
              !isPseudoElement &&
              !isAnonBox) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelNotPE", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error;
          }
        
          if (!parsingPseudoElement &&
              nsCSSPseudoClass.NotPseudo == pseudoClassType) {
            if (aIsNegated) { // :not() can't be itself negated
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelDoubleNot", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
            // CSS 3 Negation pseudo-class takes one simple selector as argument
            nsSelectorParsingStatus parsingStatus =
              ParseNegatedSimpleSelector(ref aDataMask, aSelector);
            if (nsSelectorParsingStatus.Continue != parsingStatus) {
              return parsingStatus;
            }
          }
          else if (!parsingPseudoElement && isPseudoClass) {
            aDataMask |= SEL_MASK_PCLASS;
            if (nsCSSTokenType.Function == mToken.mType) {
              nsSelectorParsingStatus parsingStatus;
              if (nsCSSPseudoClasses.HasStringArg(pseudoClassType)) {
                parsingStatus =
                  ParsePseudoClassWithIdentArg(aSelector, pseudoClassType);
              }
              else if (nsCSSPseudoClasses.HasNthPairArg(pseudoClassType)) {
                parsingStatus =
                  ParsePseudoClassWithNthPairArg(aSelector, pseudoClassType);
              }
              else {
                Debug.Assert(nsCSSPseudoClasses.HasSelectorListArg(pseudoClassType),
                                  "unexpected pseudo with function token");
                parsingStatus = ParsePseudoClassWithSelectorListArg(aSelector,
                                                                    pseudoClassType);
              }
              if (nsSelectorParsingStatus.Continue != parsingStatus) {
                if (nsSelectorParsingStatus.Error == parsingStatus) {
                  SkipUntil(')');
                }
                return parsingStatus;
              }
            }
            else {
              aSelector.AddPseudoClass(pseudoClassType);
            }
          }
          else if (isPseudoElement || isAnonBox) {
            // Pseudo-element.  Make some more sanity checks.
        
            if (aIsNegated) { // pseudo-elements can't be negated
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelPEInNot", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
            // CSS2 pseudo-elements and -moz-tree-* pseudo-elements are allowed
            // to have a single ':' on them.  Others (CSS3+ pseudo-elements and
            // various -moz-* pseudo-elements) must have |parsingPseudoElement|
            // set.
            if (!parsingPseudoElement &&
                !nsCSSPseudoElements.IsCSS2PseudoElement(pseudo)
        #if MOZ_XUL
                && !isTreePseudo
        #endif
                ) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelNewStyleOnly", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
        
            if (0 == (aDataMask & SEL_MASK_PELEM)) {
              aDataMask |= SEL_MASK_PELEM;
              aPseudoElement = pseudo;
              aPseudoElementType = pseudoElementType;
        
        #if MOZ_XUL
              if (isTree) {
                // We have encountered a pseudoelement of the form
                // -moz-tree-xxxx(a,b,c).  We parse (a,b,c) and add each
                // item in the list to the pseudoclass list.  They will be pulled
                // from the list later along with the pseudo-element.
                if (!ParseTreePseudoElement(aPseudoElementArgs)) {
                  return nsSelectorParsingStatus.Error;
                }
              }
        #endif
        
              // the next *non*whitespace token must be '{' or ',' or EOF
              if (!GetToken(true)) { // premature eof is ok (here!)
                return nsSelectorParsingStatus.Done;
              }
              if ((mToken.IsSymbol('{') || mToken.IsSymbol(','))) {
                UngetToken();
                return nsSelectorParsingStatus.Done;
              }
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelTrailing", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
            else {  // multiple pseudo elements, not legal
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoSelMultiplePE", mToken); };
              UngetToken();
              return nsSelectorParsingStatus.Error;
            }
          }
        #if DEBUG
          else {
            // We should never end up here.  Indeed, if we ended up here, we know (from
            // the current if/else cascade) that !isPseudoElement and !isAnonBox.  But
            // then due to our earlier check we know that isPseudoClass.  Since we
            // didn't fall into the isPseudoClass case in this cascade, we must have
            // parsingPseudoElement.  But we've already checked the
            // parsingPseudoElement && !isPseudoClass && !isAnonBox case and bailed if
            // it's happened.
            Debug.Fail("How did this happen?");
          }
        #endif
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse the argument of a negation pseudo-class :not()
        //
        internal nsSelectorParsingStatus ParseNegatedSimpleSelector(ref int32_t       aDataMask,
                                                  nsCSSSelector aSelector)
        {
          if (! GetToken(true)) { // premature eof
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PENegationEOF"); };
            return nsSelectorParsingStatus.Error;
          }
        
          if (mToken.IsSymbol(')')) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PENegationBadArg", mToken); };
            return nsSelectorParsingStatus.Error;
          }
        
          // Create a new nsCSSSelector and add it to the end of
          // aSelector.mNegations.
          // Given the current parsing rules, every selector in mNegations
          // contains only one simple selector (css3 definition) within it.
          // This could easily change in future versions of CSS, and the only
          // thing we need to change to support that is this parsing code and the
          // serialization code for nsCSSSelector.
          nsCSSSelector newSel = new nsCSSSelector();
          nsCSSSelector negations = aSelector;
          while (negations.mNegations != null) {
            negations = negations.mNegations;
          }
          negations.mNegations = newSel;
        
          nsSelectorParsingStatus parsingStatus;
          if (nsCSSTokenType.ID == mToken.mType) { // #id
            parsingStatus = ParseIDSelector(ref aDataMask, newSel);
          }
          else if (mToken.IsSymbol('.')) {    // .class
            parsingStatus = ParseClassSelector(ref aDataMask, newSel);
          }
          else if (mToken.IsSymbol(':')) {    // :pseudo
            { string _1 = null; nsCSSPseudoElement _2 = 0; parsingStatus = ParsePseudoSelector(ref aDataMask, newSel, true, ref _1, null, ref _2); }
          }
          else if (mToken.IsSymbol('[')) {    // [attribute
            parsingStatus = ParseAttributeSelector(ref aDataMask, newSel);
            if (nsSelectorParsingStatus.Error == parsingStatus) {
              // Skip forward to the matching ']'
              SkipUntil(']');
            }
          }
          else {
            // then it should be a type element or universal selector
            parsingStatus = ParseTypeOrUniversalSelector(ref aDataMask, newSel, true);
          }
          if (nsSelectorParsingStatus.Error == parsingStatus) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PENegationBadInner", mToken); };
            SkipUntil(')');
            return parsingStatus;
          }
          // close the parenthesis
          if (!ExpectSymbol(')', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PENegationNoClose", mToken); };
            SkipUntil(')');
            return nsSelectorParsingStatus.Error;
          }
        
          Debug.Assert(newSel.mNameSpace == nsNameSpace.Unknown ||
                       (newSel.mIDList == null && newSel.mClassList == null &&
                        newSel.mPseudoClassList == null && newSel.mAttrList == null),
                       "Need to fix the serialization code to deal with this");
        
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse the argument of a pseudo-class that has an ident arg
        //
        internal nsSelectorParsingStatus ParsePseudoClassWithIdentArg(nsCSSSelector aSelector,
                                                    nsCSSPseudoClass aType)
        {
          if (! GetToken(true)) { // premature eof
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgEOF"); };
            return nsSelectorParsingStatus.Error;
          }
          // We expect an identifier with a language abbreviation
          if (nsCSSTokenType.Ident != mToken.mType) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotIdent", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
        
          // -moz-locale-dir and -moz-dir can only have values of 'ltr' or 'rtl'.
          if (aType == nsCSSPseudoClass.MozLocaleDir ||
              aType == nsCSSPseudoClass.Dir) {
            mToken.mIdentStr = mToken.mIdentStr.ToLower(); // case insensitive
            if (!mToken.mIdentStr.EqualsLiteral("ltr") &&
                !mToken.mIdentStr.EqualsLiteral("rtl")) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadDirValue", mToken); };
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
          }
        
          // Add the pseudo with the language parameter
          aSelector.AddPseudoClass(aType, mToken.mIdentStr);
        
          // close the parenthesis
          if (!ExpectSymbol(')', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassNoClose", mToken); };
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
        
          return nsSelectorParsingStatus.Continue;
        }
        
        internal nsSelectorParsingStatus ParsePseudoClassWithNthPairArg(nsCSSSelector aSelector,
                                                      nsCSSPseudoClass aType)
        {
          int32_t[] numbers = { 0, 0 };
          bool lookForB = true;
        
          // Follow the whitespace rules as proposed in
          // http://lists.w3.org/Archives/Public/www-style/2008Mar/0121.html
        
          if (! GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgEOF"); };
            return nsSelectorParsingStatus.Error;
          }
        
          if (nsCSSTokenType.Ident == mToken.mType || nsCSSTokenType.Dimension == mToken.mType) {
            // The CSS tokenization doesn't handle :nth-child() containing - well:
            //   2n-1 is a dimension
            //   n-1 is an identifier
            // The easiest way to deal with that is to push everything from the
            // minus on back onto the scanner's pushback buffer.
            uint32_t truncAt = 0;
            if (StringBeginsWith(mToken.mIdentStr, "n-")) {
              truncAt = 1;
            } else if (StringBeginsWith(mToken.mIdentStr, "-n-")) {
              truncAt = 2;
            }
            if (truncAt != 0) {
              mScanner.Backup(mToken.mIdentStr.Length() - truncAt);
              mToken.mIdentStr = mToken.mIdentStr.Substring(0, truncAt);
            }
          }
        
          if (nsCSSTokenType.Ident == mToken.mType) {
            if (mToken.mIdentStr.LowerCaseEqualsLiteral("odd")) {
              numbers[0] = 2;
              numbers[1] = 1;
              lookForB = false;
            }
            else if (mToken.mIdentStr.LowerCaseEqualsLiteral("even")) {
              numbers[0] = 2;
              numbers[1] = 0;
              lookForB = false;
            }
            else if (mToken.mIdentStr.LowerCaseEqualsLiteral("n")) {
              numbers[0] = 1;
            }
            else if (mToken.mIdentStr.LowerCaseEqualsLiteral("-n")) {
              numbers[0] = -1;
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotNth", mToken); };
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
          }
          else if (nsCSSTokenType.Number == mToken.mType) {
            if (!mToken.mIntegerValid) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotNth", mToken); };
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
            numbers[1] = mToken.mInteger;
            lookForB = false;
          }
          else if (nsCSSTokenType.Dimension == mToken.mType) {
            if (!mToken.mIntegerValid || !mToken.mIdentStr.LowerCaseEqualsLiteral("n")) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotNth", mToken); };
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
            numbers[0] = mToken.mInteger;
          }
          // XXX If it's a ')', is that valid?  (as 0n+0)
          else {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotNth", mToken); };
            UngetToken();
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
        
          if (! GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgEOF"); };
            return nsSelectorParsingStatus.Error;
          }
          if (lookForB && !mToken.IsSymbol(')')) {
            // The '+' or '-' sign can optionally be separated by whitespace.
            // If it is separated by whitespace from what follows it, it appears
            // as a separate token rather than part of the number token.
            bool haveSign = false;
            int32_t sign = 1;
            if (mToken.IsSymbol('+') || mToken.IsSymbol('-')) {
              haveSign = true;
              if (mToken.IsSymbol('-')) {
                sign = -1;
              }
              if (! GetToken(true)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgEOF"); };
                return nsSelectorParsingStatus.Error;
              }
            }
            if (nsCSSTokenType.Number != mToken.mType ||
                !mToken.mIntegerValid || mToken.mHasSign == haveSign) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgNotNth", mToken); };
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
            numbers[1] = mToken.mInteger * sign;
            if (! GetToken(true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassArgEOF"); };
              return nsSelectorParsingStatus.Error;
            }
          }
          if (!mToken.IsSymbol(')')) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassNoClose", mToken); };
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
          aSelector.AddPseudoClass(aType, numbers);
          return nsSelectorParsingStatus.Continue;
        }
        
        //
        // Parse the argument of a pseudo-class that has a selector list argument.
        // Such selector lists cannot contain combinators, but can contain
        // anything that goes between a pair of combinators.
        //
        internal nsSelectorParsingStatus ParsePseudoClassWithSelectorListArg(nsCSSSelector aSelector,
                                                           nsCSSPseudoClass aType)
        {
          var slist = new nsCSSSelectorList();
          if (! ParseSelectorList(ref slist, ')')) {
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
        
          // Check that none of the selectors in the list have combinators or
          // pseudo-elements.
          for (nsCSSSelectorList l = slist; l != null; l = l.mNext) {
            nsCSSSelector s = l.mSelectors;
            if (s.mNext != null || s.IsPseudoElement()) {
              return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
            }
          }
        
          // Add the pseudo with the selector list parameter
          aSelector.AddPseudoClass(aType, slist);
        
          // close the parenthesis
          if (!ExpectSymbol(')', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEPseudoClassNoClose", mToken); };
            return nsSelectorParsingStatus.Error; // our caller calls SkipUntil(')')
          }
        
          return nsSelectorParsingStatus.Continue;
        }
        
        /**
         * This is the format for selectors:
         * operator? [[namespace |]? element_name]? [ ID | class | attrib | pseudo ]*
         */
        internal bool ParseSelector(nsCSSSelectorList aList,
                                     char aPrevCombinator)
        {
          if (! GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorEOF"); };
            return false;
          }
        
          nsCSSSelector selector = aList.AddSelector(aPrevCombinator);
          string pseudoElement = null;
          nsAtomList pseudoElementArgs = null;
          nsCSSPseudoElement pseudoElementType =
            nsCSSPseudoElement.NotPseudoElement;
        
          int32_t dataMask = 0;
          nsSelectorParsingStatus parsingStatus =
            ParseTypeOrUniversalSelector(ref dataMask, selector, false);
        
          while (parsingStatus == nsSelectorParsingStatus.Continue) {
            if (nsCSSTokenType.ID == mToken.mType) { // #id
              parsingStatus = ParseIDSelector(ref dataMask, selector);
            }
            else if (mToken.IsSymbol('.')) {    // .class
              parsingStatus = ParseClassSelector(ref dataMask, selector);
            }
            else if (mToken.IsSymbol(':')) {    // :pseudo
              parsingStatus = ParsePseudoSelector(ref dataMask, selector, false,
                                                  ref pseudoElement,
                                                  pseudoElementArgs,
                                                  ref pseudoElementType);
            }
            else if (mToken.IsSymbol('[')) {    // [attribute
              parsingStatus = ParseAttributeSelector(ref dataMask, selector);
              if (nsSelectorParsingStatus.Error == parsingStatus) {
                SkipUntil(']');
              }
            }
            else {  // not a selector token, we're done
              parsingStatus = nsSelectorParsingStatus.Done;
              UngetToken();
              break;
            }
        
            if (parsingStatus != nsSelectorParsingStatus.Continue) {
              break;
            }
        
            if (! GetToken(false)) { // premature eof is ok (here!)
              parsingStatus = nsSelectorParsingStatus.Done;
              break;
            }
          }
        
          if (parsingStatus == nsSelectorParsingStatus.Error) {
            return false;
          }
        
          if (dataMask == 0) {
            if (selector.mNext != null) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorGroupExtraCombinator"); };
            } else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PESelectorGroupNoSelector"); };
            }
            return false;
          }
        
          if (pseudoElementType == nsCSSPseudoElement.AnonBox) {
            // We got an anonymous box pseudo-element; it must be the only
            // thing in this selector group.
            if (selector.mNext != null || !IsUniversalSelector(selector)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAnonBoxNotAlone"); };
              return false;
            }
        
            // Rewrite the current selector as this pseudo-element.
            // It does not contribute to selector weight.
            { var t = selector.mLowercaseTag; selector.mLowercaseTag = pseudoElement; pseudoElement = t; };
            selector.mClassList = pseudoElementArgs;
            selector.SetPseudoType(pseudoElementType);
            return true;
          }
        
          aList.mWeight += selector.CalcWeight();
        
          // Pseudo-elements other than anonymous boxes are represented as
          // direct children ('>' combinator) of the rest of the selector.
          if (pseudoElement != null) {
            selector = aList.AddSelector('>');
        
            { var t = selector.mLowercaseTag; selector.mLowercaseTag = pseudoElement; pseudoElement = t; };
            selector.mClassList = pseudoElementArgs;
            selector.SetPseudoType(pseudoElementType);
          }
        
          return true;
        }
        
        internal Declaration ParseDeclarationBlock(nsParseDeclaration aFlags, nsCSSContextType aContext = nsCSSContextType.General)
        {
          bool checkForBraces = (aFlags & nsParseDeclaration.InBraces) != 0;
        
          if (checkForBraces) {
            if (!ExpectSymbol('{', true)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadDeclBlockStart", mToken); };
              mReporter.OutputError();
              return null;
            }
          }
          Declaration declaration = new Declaration();
          mData.AssertInitialState();
          if (declaration != null) {
            for (;;) {
              bool changed = false;
              if (!ParseDeclaration(declaration, aFlags, true, ref changed, aContext)) {
                if (!SkipDeclaration(checkForBraces)) {
                  break;
                }
                if (checkForBraces) {
                  if (ExpectSymbol('}', true)) {
                    break;
                  }
                }
                // Since the skipped declaration didn't end the block we parse
                // the next declaration.
              }
            }
            declaration.CompressFrom(mData);
          }
          return declaration;
        }
        
        // The types to pass to ParseColorComponent.  These correspond to the
        // various datatypes that can go within rgb().
        
        internal bool ParseColor(ref nsCSSValue aValue)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorEOF"); };
            return false;
          }
        
          nsCSSToken tk = mToken;
          var rgba = new nscolor();
          switch (tk.mType) {
            case nsCSSTokenType.ID:
            case nsCSSTokenType.Hash:
              // #xxyyzz
              if (nscolor.HexToRGB(tk.mIdentStr, ref rgba)) {
                aValue.SetColorValue(rgba);
                return true;
              }
              break;
        
            case nsCSSTokenType.Ident:
              if (nscolor.ColorNameToRGB(tk.mIdentStr, ref rgba)) {
                aValue.SetStringValue(tk.mIdentStr, nsCSSUnit.Ident);
                return true;
              }
              else {
                nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(tk.mIdentStr);
                if (nsCSSKeyword.Unknown < keyword) { // known keyword
                  int32_t value = 0;
                  if (nsCSSProps.FindKeyword(keyword, nsCSSProps.kColorKTable, ref value)) {
                    aValue.SetIntValue(value, nsCSSUnit.EnumColor);
                    return true;
                  }
                }
              }
              break;
            case nsCSSTokenType.Function:
              if (mToken.mIdentStr.LowerCaseEqualsLiteral("rgb")) {
                // rgb ( component , component , component )
                uint8_t r = 0, g = 0, b = 0;
                int32_t type = COLOR_TYPE_UNKNOWN;
                if (ParseColorComponent(ref r, ref type, ',') &&
                    ParseColorComponent(ref g, ref type, ',') &&
                    ParseColorComponent(ref b, ref type, ')')) {
                  aValue.SetColorValue(nscolor.RGB(r,g,b));
                  return true;
                }
                SkipUntil(')');
                return false;
              }
              else if (mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-rgba") ||
                       mToken.mIdentStr.LowerCaseEqualsLiteral("rgba")) {
                // rgba ( component , component , component , opacity )
                uint8_t r = 0, g = 0, b = 0, a = 0;
                int32_t type = COLOR_TYPE_UNKNOWN;
                if (ParseColorComponent(ref r, ref type, ',') &&
                    ParseColorComponent(ref g, ref type, ',') &&
                    ParseColorComponent(ref b, ref type, ',') &&
                    ParseColorOpacity(ref a)) {
                  aValue.SetColorValue(nscolor.RGBA(r, g, b, a));
                  return true;
                }
                SkipUntil(')');
                return false;
              }
              else if (mToken.mIdentStr.LowerCaseEqualsLiteral("hsl")) {
                // hsl ( hue , saturation , lightness )
                // "hue" is a number, "saturation" and "lightness" are percentages.
                if (ParseHSLColor(ref rgba, ')')) {
                  aValue.SetColorValue(rgba);
                  return true;
                }
                SkipUntil(')');
                return false;
              }
              else if (mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-hsla") ||
                       mToken.mIdentStr.LowerCaseEqualsLiteral("hsla")) {
                // hsla ( hue , saturation , lightness , opacity )
                // "hue" is a number, "saturation" and "lightness" are percentages,
                // "opacity" is a number.
                uint8_t a = 0;
                if (ParseHSLColor(ref rgba, ',') &&
                    ParseColorOpacity(ref a)) {
                  aValue.SetColorValue(nscolor.RGBA(rgba.R, rgba.G,
                                               rgba.B, a));
                  return true;
                }
                SkipUntil(')');
                return false;
              }
              break;
            default:
              break;
          }
        
          // try 'xxyyzz' without '#' prefix for compatibility with IE and Nav4x (bug 23236 and 45804)
          // TODO support hashless colors
        
          // It's not a color
          { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorNotColor", mToken); };
          UngetToken();
          return false;
        }
        
        // aType will be set if we have already parsed other color components
        // in this color spec
        internal bool ParseColorComponent(ref uint8_t aComponent,
                                           ref int32_t aType,
                                           char aStop)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorComponentEOF"); };
            return false;
          }
          float value = 0;
          nsCSSToken tk = mToken;
          switch (tk.mType) {
          case nsCSSTokenType.Number:
            switch (aType) {
              case COLOR_TYPE_UNKNOWN:
                aType = COLOR_TYPE_INTEGERS;
                break;
              case COLOR_TYPE_INTEGERS:
                break;
              case COLOR_TYPE_PERCENTAGES:
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedPercent", mToken); };
                UngetToken();
                return false;
              default:
                Debug.Fail("Someone forgot to add the new color component type in here");
                break;
            }
        
            if (!mToken.mIntegerValid) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedInt", mToken); };
              UngetToken();
              return false;
            }
            value = tk.mNumber;
            break;
          case nsCSSTokenType.Percentage:
            switch (aType) {
              case COLOR_TYPE_UNKNOWN:
                aType = COLOR_TYPE_PERCENTAGES;
                break;
              case COLOR_TYPE_INTEGERS:
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedInt", mToken); };
                UngetToken();
                return false;
              case COLOR_TYPE_PERCENTAGES:
                break;
              default:
                Debug.Fail("Someone forgot to add the new color component type in here");
                break;
            }
            value = tk.mNumber * 255.0f;
            break;
          default:
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorBadRGBContents", mToken); };
            UngetToken();
            return false;
          }
          if (ExpectSymbol(aStop, true)) {
            if (value < 0.0f) value = 0.0f;
            if (value > 255.0f) value = 255.0f;
            aComponent = (uint8_t)CommonUtil.NSToIntRound(value);
            return true;
          }
          { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorComponentBadTerm", mToken, aStop); };
          return false;
        }
        
        internal bool ParseHSLColor(ref nscolor aColor,
                                     char aStop)
        {
          float h = 0, s = 0, l = 0;
        
          // Get the hue
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorHueEOF"); };
            return false;
          }
          if (mToken.mType != nsCSSTokenType.Number) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedNumber", mToken); };
            UngetToken();
            return false;
          }
          h = mToken.mNumber;
          h /= 360.0f;
          // hue values are wraparound
          h = h - (float)Math.Floor(h);
        
          if (!ExpectSymbol(',', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedComma", mToken); };
            return false;
          }
        
          // Get the saturation
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorSaturationEOF"); };
            return false;
          }
          if (mToken.mType != nsCSSTokenType.Percentage) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedPercent", mToken); };
            UngetToken();
            return false;
          }
          s = mToken.mNumber;
          if (s < 0.0f) s = 0.0f;
          if (s > 1.0f) s = 1.0f;
        
          if (!ExpectSymbol(',', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedComma", mToken); };
            return false;
          }
        
          // Get the lightness
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorLightnessEOF"); };
            return false;
          }
          if (mToken.mType != nsCSSTokenType.Percentage) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedPercent", mToken); };
            UngetToken();
            return false;
          }
          l = mToken.mNumber;
          if (l < 0.0f) l = 0.0f;
          if (l > 1.0f) l = 1.0f;
        
          if (ExpectSymbol(aStop, true)) {
            aColor = nscolor.HSL2RGB(h, s, l);
            return true;
          }
        
          { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorComponentBadTerm", mToken, aStop); };
          return false;
        }
        
        internal bool ParseColorOpacity(ref uint8_t aOpacity)
        {
          if (!GetToken(true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEColorOpacityEOF"); };
            return false;
          }
        
          if (mToken.mType != nsCSSTokenType.Number) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedNumber", mToken); };
            UngetToken();
            return false;
          }
        
          if (mToken.mNumber < 0.0f) {
            mToken.mNumber = 0.0f;
          } else if (mToken.mNumber > 1.0f) {
            mToken.mNumber = 1.0f;
          }
        
          uint8_t value = nsStyleUtil.FloatToColorComponent(mToken.mNumber);
          // Need to compare to something slightly larger
          // than 0.5 due to floating point inaccuracies.
          Debug.Assert(Math.Abs(255.0f*mToken.mNumber - value) <= 0.51f,
                       "FloatToColorComponent did something weird");
        
          if (!ExpectSymbol(')', true)) {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedCloseParen", mToken); };
            return false;
          }
        
          aOpacity = value;
        
          return true;
        }
        
        #if MOZ_XUL
        internal bool ParseTreePseudoElement(nsAtomList **aPseudoElementArgs)
        {
          // The argument to a tree pseudo-element is a sequence of identifiers
          // that are either space- or comma-separated.  (Was the intent to
          // allow only comma-separated?  That's not what was done.)
          nsCSSSelector fakeSelector; // so we can reuse AddPseudoClass
        
          while (!ExpectSymbol(')', true)) {
            if (!GetToken(true)) {
              return false;
            }
            if (nsCSSTokenType.Ident == mToken.mType) {
              fakeSelector.AddClass(mToken.mIdentStr);
            }
            else if (!mToken.IsSymbol(',')) {
              UngetToken();
              SkipUntil(')');
              return false;
            }
          }
          *aPseudoElementArgs = fakeSelector.mClassList;
          fakeSelector.mClassList = null;
          return true;
        }
        #endif
        
        //----------------------------------------------------------------------
        
        internal bool ParseDeclaration(Declaration aDeclaration,
                                        nsParseDeclaration aFlags,
                                        bool aMustCallValueAppended,
                                        ref bool aChanged,
                                        nsCSSContextType aContext = nsCSSContextType.General)
        {
          if (!(aContext == nsCSSContextType.General ||
                          aContext == nsCSSContextType.Page)) throw new ArgumentException("Must be page or general context");
          bool checkForBraces = (aFlags & nsParseDeclaration.InBraces) != 0;
        
          mTempData.AssertInitialState();
        
          // Get property name
          nsCSSToken tk = mToken;
          string propertyName;
          for (;;) {
            if (!GetToken(true)) {
              if (checkForBraces) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclEndEOF"); };
              }
              return false;
            }
            if (nsCSSTokenType.Ident == tk.mType) {
              propertyName = tk.mIdentStr;
              // grab the ident before the ExpectSymbol trashes the token
              if (!ExpectSymbol(':', true)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEParseDeclarationNoColon", mToken); };
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
                mReporter.OutputError();
                return false;
              }
              break;
            }
            if (tk.IsSymbol(';')) {
              // dangling semicolons are skipped
              continue;
            }
        
            if (!tk.IsSymbol('}')) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEParseDeclarationDeclExpected", mToken); };
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclSkipped"); };
              mReporter.OutputError();
            }
            // Not a declaration...
            UngetToken();
            return false;
          }
        
          // Don't report property parse errors if we're inside a failing @supports
          // rule.
          using (/*var suppressErrors = */new nsAutoSuppressErrors(this, mInFailingSupportsRule)) {  
          
            // Map property name to its ID and then parse the property
            nsCSSProperty propID = nsCSSProps.LookupProperty(propertyName,
                                                              nsCSSProps.EnabledState.Enabled);
            if (nsCSSProperty.Unknown == propID ||
               (aContext == nsCSSContextType.Page &&
                !nsCSSProps.PropHasFlags(propID, nsCSSProps.APPLIES_TO_PAGE_RULE))) { // unknown property
              if (!NonMozillaVendorIdentifier(propertyName)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEUnknownProperty", propertyName); };
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
                mReporter.OutputError();
              }
          
              return false;
            }
            if (! ParseProperty(propID)) {
              // XXX Much better to put stuff in the value parsers instead...
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEValueParsingError", propertyName); };
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
              mReporter.OutputError();
              mTempData.ClearProperty(propID);
              mTempData.AssertInitialState();
              return false;
            }
            mReporter.ClearError();
          
            // Look for "!important".
            PriorityParsingStatus status;
            if ((aFlags & nsParseDeclaration.AllowImportant) != 0) {
              status = ParsePriority();
            }
            else {
              status = PriorityParsingStatus.None;
            }
          
            // Look for a semicolon or close brace.
            if (status != PriorityParsingStatus.Error) {
              if (!GetToken(true)) {
                // EOF is always ok
              } else if (mToken.IsSymbol(';')) {
                // semicolon is always ok
              } else if (mToken.IsSymbol('}')) {
                // brace is ok if checkForBraces, but don't eat it
                UngetToken();
                if (!checkForBraces) {
                  status = PriorityParsingStatus.Error;
                }
              } else {
                UngetToken();
                status = PriorityParsingStatus.Error;
              }
            }
          
            if (status == PriorityParsingStatus.Error) {
              if (checkForBraces) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadDeclOrRuleEnd2", mToken); };
              } else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEBadDeclEnd", mToken); };
              }
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEDeclDropped"); };
              mReporter.OutputError();
              mTempData.ClearProperty(propID);
              mTempData.AssertInitialState();
              return false;
            }
          
            aChanged |= mData.TransferFromBlock(mTempData, propID,
                                                 status == PriorityParsingStatus.Important,
                                                 false, aMustCallValueAppended,
                                                 aDeclaration);
            return true;
          }
        }
        
        static nsCSSProperty[] kBorderTopIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderTopWidth,
          nsCSSProperty.BorderTopStyle,
          nsCSSProperty.BorderTopColor
        };
        static nsCSSProperty[] kBorderRightIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderRightWidthValue,
          nsCSSProperty.BorderRightStyleValue,
          nsCSSProperty.BorderRightColorValue,
          nsCSSProperty.BorderRightWidth,
          nsCSSProperty.BorderRightStyle,
          nsCSSProperty.BorderRightColor
        };
        static nsCSSProperty[] kBorderBottomIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderBottomWidth,
          nsCSSProperty.BorderBottomStyle,
          nsCSSProperty.BorderBottomColor
        };
        static nsCSSProperty[] kBorderLeftIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderLeftWidthValue,
          nsCSSProperty.BorderLeftStyleValue,
          nsCSSProperty.BorderLeftColorValue,
          nsCSSProperty.BorderLeftWidth,
          nsCSSProperty.BorderLeftStyle,
          nsCSSProperty.BorderLeftColor
        };
        static nsCSSProperty[] kBorderStartIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderStartWidthValue,
          nsCSSProperty.BorderStartStyleValue,
          nsCSSProperty.BorderStartColorValue,
          nsCSSProperty.BorderStartWidth,
          nsCSSProperty.BorderStartStyle,
          nsCSSProperty.BorderStartColor
        };
        static nsCSSProperty[] kBorderEndIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderEndWidthValue,
          nsCSSProperty.BorderEndStyleValue,
          nsCSSProperty.BorderEndColorValue,
          nsCSSProperty.BorderEndWidth,
          nsCSSProperty.BorderEndStyle,
          nsCSSProperty.BorderEndColor
        };
        static nsCSSProperty[] kColumnRuleIDs = new nsCSSProperty[] {
          nsCSSProperty.MozColumnRuleWidth,
          nsCSSProperty.MozColumnRuleStyle,
          nsCSSProperty.MozColumnRuleColor
        };
        
        internal bool ParseEnum(ref nsCSSValue aValue,
                                 int32_t[] aKeywordTable)
        {
          string ident = NextIdent();
          if (null == ident) {
            return false;
          }
          nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(ident);
          if (nsCSSKeyword.Unknown < keyword) {
            int32_t value = 0;
            if (nsCSSProps.FindKeyword(keyword, aKeywordTable, ref value)) {
              aValue.SetIntValue(value, nsCSSUnit.Enumerated);
              return true;
            }
          }
        
          // Put the unknown identifier back and return
          UngetToken();
          return false;
        }
        
        static UnitInfo[] UnitData = new UnitInfo[] {
          new UnitInfo { name = "px", unit = nsCSSUnit.Pixel, type = VARIANT_LENGTH },
          new UnitInfo { name = "em", unit = nsCSSUnit.Em, type = VARIANT_LENGTH },
          new UnitInfo { name = "ex", unit = nsCSSUnit.Xheight, type = VARIANT_LENGTH },
          new UnitInfo { name = "pt", unit = nsCSSUnit.Point, type = VARIANT_LENGTH },
          new UnitInfo { name = "in", unit = nsCSSUnit.Inch, type = VARIANT_LENGTH },
          new UnitInfo { name = "cm", unit = nsCSSUnit.Centimeter, type = VARIANT_LENGTH },
          new UnitInfo { name = "ch", unit = nsCSSUnit.Char, type = VARIANT_LENGTH },
          new UnitInfo { name = "rem", unit = nsCSSUnit.RootEm, type = VARIANT_LENGTH },
          new UnitInfo { name = "mm", unit = nsCSSUnit.Millimeter, type = VARIANT_LENGTH },
          new UnitInfo { name = "mozmm", unit = nsCSSUnit.PhysicalMillimeter, type = VARIANT_LENGTH },
          new UnitInfo { name = "vw", unit = nsCSSUnit.ViewportWidth, type = VARIANT_LENGTH },
          new UnitInfo { name = "vh", unit = nsCSSUnit.ViewportHeight, type = VARIANT_LENGTH },
          new UnitInfo { name = "vmin", unit = nsCSSUnit.ViewportMin, type = VARIANT_LENGTH },
          new UnitInfo { name = "vmax", unit = nsCSSUnit.ViewportMax, type = VARIANT_LENGTH },
          new UnitInfo { name = "pc", unit = nsCSSUnit.Pica, type = VARIANT_LENGTH },
          new UnitInfo { name = "deg", unit = nsCSSUnit.Degree, type = VARIANT_ANGLE },
          new UnitInfo { name = "grad", unit = nsCSSUnit.Grad, type = VARIANT_ANGLE },
          new UnitInfo { name = "rad", unit = nsCSSUnit.Radian, type = VARIANT_ANGLE },
          new UnitInfo { name = "turn", unit = nsCSSUnit.Turn, type = VARIANT_ANGLE },
          new UnitInfo { name = "hz", unit = nsCSSUnit.Hertz, type = VARIANT_FREQUENCY },
          new UnitInfo { name = "khz", unit = nsCSSUnit.Kilohertz, type = VARIANT_FREQUENCY },
          new UnitInfo { name = "s", unit = nsCSSUnit.Seconds, type = VARIANT_TIME },
          new UnitInfo { name = "ms", unit = nsCSSUnit.Milliseconds, type = VARIANT_TIME }
        };
        
        internal bool TranslateDimension(ref nsCSSValue aValue,
                                          int32_t aVariantMask,
                                          float aNumber,
                                          string aUnit)
        {
          nsCSSUnit units = 0;
          int32_t   type = 0;
          if (!aUnit.IsEmpty()) {
            uint32_t i = 0;
            for (i = 0; i < UnitData.Length; ++i) {
              if (aUnit.LowerCaseEqualsASCII(UnitData[i].name,
                                             UnitData[i].length)) {
                units = UnitData[i].unit;
                type = UnitData[i].type;
                break;
              }
            }
        
            if (!mViewportUnitsEnabled &&
                (nsCSSUnit.ViewportWidth == units  ||
                 nsCSSUnit.ViewportHeight == units ||
                 nsCSSUnit.ViewportMin == units    ||
                 nsCSSUnit.ViewportMax == units)) {
              // Viewport units aren't allowed right now, probably because we're
              // inside an @page declaration. Fail.
              return false;
            }
        
            if (i == UnitData.Length) {
              // Unknown unit
              return false;
            }
          } else {
            // Must be a zero number...
            Debug.Assert(0 == aNumber, "numbers without units must be 0");
            if ((VARIANT_LENGTH & aVariantMask) != 0) {
              units = nsCSSUnit.Pixel;
              type = VARIANT_LENGTH;
            }
            else if ((VARIANT_ANGLE & aVariantMask) != 0) {
              Debug.Assert(((aVariantMask & VARIANT_ZERO_ANGLE) != 0),
                           "must have allowed zero angle");
              units = nsCSSUnit.Degree;
              type = VARIANT_ANGLE;
            }
            else {
              throw new Exception("Variant mask does not include dimension; why were we called?");
              return false;
            }
          }
          if ((type & aVariantMask) != 0) {
            aValue.SetFloatValue(aNumber, units);
            return true;
          }
          return false;
        }
        
        // Note that this does include VARIANT_CALC, which is numeric.  This is
        // because calc() parsing, as proposed, drops range restrictions inside
        // the calc() expression and clamps the result of the calculation to the
        // range.
        
        // Note that callers passing VARIANT_CALC in aVariantMask will get
        // full-range parsing inside the calc() expression, and the code that
        // computes the calc will be required to clamp the resulting value to an
        // appropriate range.
        internal bool ParseNonNegativeVariant(ref nsCSSValue aValue,
                                               int32_t aVariantMask,
                                               int32_t[] aKeywordTable)
        {
          // The variant mask must only contain non-numeric variants or the ones
          // that we specifically handle.
          Debug.Assert((aVariantMask & ~(VARIANT_ALL_NONNUMERIC |
                                              VARIANT_NUMBER |
                                              VARIANT_LENGTH |
                                              VARIANT_PERCENT |
                                              VARIANT_INTEGER)) == 0,
                            "need to update code below to handle additional variants");
        
          if (ParseVariant(ref aValue, aVariantMask, aKeywordTable)) {
            if (nsCSSUnit.Number == aValue.GetUnit() ||
                aValue.IsLengthUnit()){
              if (aValue.GetFloatValue() < 0) {
                UngetToken();
                return false;
              }
            }
            else if (aValue.GetUnit() == nsCSSUnit.Percent) {
              if (aValue.GetPercentValue() < 0) {
                UngetToken();
                return false;
              }
            } else if (aValue.GetUnit() == nsCSSUnit.Integer) {
              if (aValue.GetIntValue() < 0) {
                UngetToken();
                return false;
              }
            }
            return true;
          }
          return false;
        }
        
        // Note that callers passing VARIANT_CALC in aVariantMask will get
        // full-range parsing inside the calc() expression, and the code that
        // computes the calc will be required to clamp the resulting value to an
        // appropriate range.
        internal bool ParseOneOrLargerVariant(ref nsCSSValue aValue,
                                               int32_t aVariantMask,
                                               int32_t[] aKeywordTable)
        {
          // The variant mask must only contain non-numeric variants or the ones
          // that we specifically handle.
          Debug.Assert((aVariantMask & ~(VARIANT_ALL_NONNUMERIC |
                                              VARIANT_NUMBER |
                                              VARIANT_INTEGER)) == 0,
                            "need to update code below to handle additional variants");
        
          if (ParseVariant(ref aValue, aVariantMask, aKeywordTable)) {
            if (aValue.GetUnit() == nsCSSUnit.Integer) {
              if (aValue.GetIntValue() < 1) {
                UngetToken();
                return false;
              }
            } else if (nsCSSUnit.Number == aValue.GetUnit()) {
              if (aValue.GetFloatValue() < 1.0f) {
                UngetToken();
                return false;
              }
            }
            return true;
          }
          return false;
        }
        
        // Assigns to aValue iff it returns true.
        internal bool ParseVariant(ref nsCSSValue aValue,
                                    int32_t aVariantMask,
                                    int32_t[] aKeywordTable)
        {
          Debug.Assert(!(mHashlessColorQuirk && ((aVariantMask & VARIANT_COLOR) != 0)) ||
                       !((aVariantMask & VARIANT_NUMBER) != 0),
                       "can't distinguish colors from numbers");
          Debug.Assert(!(mHashlessColorQuirk && ((aVariantMask & VARIANT_COLOR) != 0)) ||
                       !(mUnitlessLengthQuirk && ((aVariantMask & VARIANT_LENGTH) != 0)),
                       "can't distinguish colors from lengths");
          Debug.Assert(!(mUnitlessLengthQuirk && ((aVariantMask & VARIANT_LENGTH) != 0)) ||
                       !((aVariantMask & VARIANT_NUMBER) != 0),
                       "can't distinguish lengths from numbers");
          Debug.Assert(!((aVariantMask & VARIANT_IDENTIFIER) != 0) ||
                            !((aVariantMask & VARIANT_IDENTIFIER_NO_INHERIT) != 0),
                            "must not set both VARIANT_IDENTIFIER and VARIANT_IDENTIFIER_NO_INHERIT");
        
          if (!GetToken(true)) {
            return false;
          }
          nsCSSToken tk = mToken;
          if (((aVariantMask & (VARIANT_AHK | VARIANT_NORMAL | VARIANT_NONE | VARIANT_ALL)) != 0) &&
              (nsCSSTokenType.Ident == tk.mType)) {
            nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(tk.mIdentStr);
            if (nsCSSKeyword.Unknown < keyword) { // known keyword
              if ((aVariantMask & VARIANT_AUTO) != 0) {
                if (nsCSSKeyword.Auto == keyword) {
                  aValue.SetAutoValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_INHERIT) != 0) {
                // XXX Should we check IsParsingCompoundProperty, or do all
                // callers handle it?  (Not all callers set it, though, since
                // they want the quirks that are disabled by setting it.)
                if (nsCSSKeyword.Inherit == keyword) {
                  aValue.SetInheritValue();
                  return true;
                }
                else if (nsCSSKeyword.MozInitial == keyword ||
                         nsCSSKeyword.Initial == keyword) { // anything that can inherit can also take an initial val.
                  aValue.SetInitialValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_NONE) != 0) {
                if (nsCSSKeyword.None == keyword) {
                  aValue.SetNoneValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_ALL) != 0) {
                if (nsCSSKeyword.All == keyword) {
                  aValue.SetAllValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_NORMAL) != 0) {
                if (nsCSSKeyword.Normal == keyword) {
                  aValue.SetNormalValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_SYSFONT) != 0) {
                if (nsCSSKeyword.MozUseSystemFont == keyword &&
                    !IsParsingCompoundProperty()) {
                  aValue.SetSystemFontValue();
                  return true;
                }
              }
              if ((aVariantMask & VARIANT_KEYWORD) != 0) {
                int32_t value = 0;
                if (nsCSSProps.FindKeyword(keyword, aKeywordTable, ref value)) {
                  aValue.SetIntValue(value, nsCSSUnit.Enumerated);
                  return true;
                }
              }
            }
          }
          // Check VARIANT_NUMBER and VARIANT_INTEGER before VARIANT_LENGTH or
          // VARIANT_ZERO_ANGLE.
          if (((aVariantMask & VARIANT_NUMBER) != 0) &&
              (nsCSSTokenType.Number == tk.mType)) {
            aValue.SetFloatValue(tk.mNumber, nsCSSUnit.Number);
            return true;
          }
          if (((aVariantMask & VARIANT_INTEGER) != 0) &&
              (nsCSSTokenType.Number == tk.mType) && tk.mIntegerValid) {
            aValue.SetIntValue(tk.mInteger, nsCSSUnit.Integer);
            return true;
          }
          if (((aVariantMask & (VARIANT_LENGTH | VARIANT_ANGLE |
                                VARIANT_FREQUENCY | VARIANT_TIME)) != 0 &&
               nsCSSTokenType.Dimension == tk.mType) ||
              ((aVariantMask & (VARIANT_LENGTH | VARIANT_ZERO_ANGLE)) != 0 &&
               nsCSSTokenType.Number == tk.mType &&
               tk.mNumber == 0.0f)) {
            if (((aVariantMask & VARIANT_POSITIVE_DIMENSION) != 0 && 
                 tk.mNumber <= 0.0) ||
                ((aVariantMask & VARIANT_NONNEGATIVE_DIMENSION) != 0 && 
                 tk.mNumber < 0.0)) {
                UngetToken();
                return false;
            }
            if (TranslateDimension(ref aValue, aVariantMask, tk.mNumber, tk.mIdentStr)) {
              return true;
            }
            // Put the token back; we didn't parse it, so we shouldn't consume it
            UngetToken();
            return false;
          }
          if (((aVariantMask & VARIANT_PERCENT) != 0) &&
              (nsCSSTokenType.Percentage == tk.mType)) {
            aValue.SetPercentValue(tk.mNumber);
            return true;
          }
          if (mUnitlessLengthQuirk) { // NONSTANDARD: Nav interprets unitless numbers as px
            if (((aVariantMask & VARIANT_LENGTH) != 0) &&
                (nsCSSTokenType.Number == tk.mType)) {
              aValue.SetFloatValue(tk.mNumber, nsCSSUnit.Pixel);
              return true;
            }
          }
        
          if (IsSVGMode() && !IsParsingCompoundProperty()) {
            // STANDARD: SVG Spec states that lengths and coordinates can be unitless
            // in which case they default to user-units (1 px = 1 user unit)
            if (((aVariantMask & VARIANT_LENGTH) != 0) &&
                (nsCSSTokenType.Number == tk.mType)) {
              aValue.SetFloatValue(tk.mNumber, nsCSSUnit.Pixel);
              return true;
            }
          }
        
          if (((aVariantMask & VARIANT_URL) != 0) &&
              nsCSSTokenType.URL == tk.mType) {
            SetValueToURL(ref aValue, tk.mIdentStr);
            return true;
          }
          if ((aVariantMask & VARIANT_GRADIENT) != 0 &&
              nsCSSTokenType.Function == tk.mType) {
            // a generated gradient
            string tmp = tk.mIdentStr;
            bool isLegacy = false;
            if (StringBeginsWith(tmp, "-moz-")) {
              tmp = tmp.Substring(5);
              isLegacy = true;
            }
            bool isRepeating = false;
            if (StringBeginsWith(tmp, "repeating-")) {
              tmp = tmp.Substring(10);
              isRepeating = true;
            }
        
            if (tmp.LowerCaseEqualsLiteral("linear-gradient")) {
              return ParseLinearGradient(ref aValue, isRepeating, isLegacy);
            }
            if (tmp.LowerCaseEqualsLiteral("radial-gradient")) {
              return ParseRadialGradient(ref aValue, isRepeating, isLegacy);
            }
          }
          if ((aVariantMask & VARIANT_IMAGE_RECT) != 0 &&
              nsCSSTokenType.Function == tk.mType &&
              tk.mIdentStr.LowerCaseEqualsLiteral("-moz-image-rect")) {
            return ParseImageRect(ref aValue);
          }
          if ((aVariantMask & VARIANT_ELEMENT) != 0 &&
              nsCSSTokenType.Function == tk.mType &&
              tk.mIdentStr.LowerCaseEqualsLiteral("-moz-element")) {
            return ParseElement(ref aValue);
          }
          if ((aVariantMask & VARIANT_COLOR) != 0) {
            if (mHashlessColorQuirk || // NONSTANDARD: Nav interprets 'xxyyzz' values even without '#' prefix
                (nsCSSTokenType.ID == tk.mType) ||
                (nsCSSTokenType.Hash == tk.mType) ||
                (nsCSSTokenType.Ident == tk.mType) ||
                ((nsCSSTokenType.Function == tk.mType) &&
                 (tk.mIdentStr.LowerCaseEqualsLiteral("rgb") ||
                  tk.mIdentStr.LowerCaseEqualsLiteral("hsl") ||
                  tk.mIdentStr.LowerCaseEqualsLiteral("-moz-rgba") ||
                  tk.mIdentStr.LowerCaseEqualsLiteral("-moz-hsla") ||
                  tk.mIdentStr.LowerCaseEqualsLiteral("rgba") ||
                  tk.mIdentStr.LowerCaseEqualsLiteral("hsla"))))
            {
              // Put token back so that parse color can get it
              UngetToken();
              if (ParseColor(ref aValue)) {
                return true;
              }
              return false;
            }
          }
          if (((aVariantMask & VARIANT_STRING) != 0) &&
              (nsCSSTokenType.String == tk.mType)) {
            string  buffer;
            buffer = tk.mIdentStr;
            aValue.SetStringValue(buffer, nsCSSUnit.String);
            return true;
          }
          if (((aVariantMask &
                (VARIANT_IDENTIFIER | VARIANT_IDENTIFIER_NO_INHERIT)) != 0) &&
              (nsCSSTokenType.Ident == tk.mType) &&
              ((aVariantMask & VARIANT_IDENTIFIER) != 0 ||
               !(tk.mIdentStr.LowerCaseEqualsLiteral("inherit") ||
                 tk.mIdentStr.LowerCaseEqualsLiteral("initial")))) {
            aValue.SetStringValue(tk.mIdentStr, nsCSSUnit.Ident);
            return true;
          }
          if (((aVariantMask & VARIANT_COUNTER) != 0) &&
              (nsCSSTokenType.Function == tk.mType) &&
              (tk.mIdentStr.LowerCaseEqualsLiteral("counter") ||
               tk.mIdentStr.LowerCaseEqualsLiteral("counters"))) {
            return ParseCounter(ref aValue);
          }
          if (((aVariantMask & VARIANT_ATTR) != 0) &&
              (nsCSSTokenType.Function == tk.mType) &&
              tk.mIdentStr.LowerCaseEqualsLiteral("attr")) {
            if (!ParseAttr(ref aValue)) {
              SkipUntil(')');
              return false;
            }
            return true;
          }
          if (((aVariantMask & VARIANT_TIMING_FUNCTION) != 0) &&
              (nsCSSTokenType.Function == tk.mType)) {
            if (tk.mIdentStr.LowerCaseEqualsLiteral("cubic-bezier")) {
              if (!ParseTransitionTimingFunctionValues(ref aValue)) {
                SkipUntil(')');
                return false;
              }
              return true;
            }
            if (tk.mIdentStr.LowerCaseEqualsLiteral("steps")) {
              if (!ParseTransitionStepTimingFunctionValues(ref aValue)) {
                SkipUntil(')');
                return false;
              }
              return true;
            }
          }
          if (((aVariantMask & VARIANT_CALC) != 0) &&
              (nsCSSTokenType.Function == tk.mType) &&
              (tk.mIdentStr.LowerCaseEqualsLiteral("calc") ||
               tk.mIdentStr.LowerCaseEqualsLiteral("-moz-calc"))) {
            // calc() currently allows only lengths and percents inside it.
            return ParseCalc(ref aValue, aVariantMask & VARIANT_LP);
          }
        
          UngetToken();
          return false;
        }
        
        internal bool ParseCounter(ref nsCSSValue aValue)
        {
          nsCSSUnit unit = (mToken.mIdentStr.LowerCaseEqualsLiteral("counter") ?
                            nsCSSUnit.Counter : nsCSSUnit.Counters);
        
          // A non-iterative for loop to break out when an error occurs.
          for (;;) {
            if (!GetToken(true)) {
              break;
            }
            if (nsCSSTokenType.Ident != mToken.mType) {
              UngetToken();
              break;
            }
        
            nsCSSValue[] val =
              new nsCSSValue[unit == nsCSSUnit.Counter ? 2 : 3];
        
            val[0].SetStringValue(mToken.mIdentStr, nsCSSUnit.Ident);
        
            if (nsCSSUnit.Counters == unit) {
              // must have a comma and then a separator string
              if (!ExpectSymbol(',', true) || !GetToken(true)) {
                break;
              }
              if (nsCSSTokenType.String != mToken.mType) {
                UngetToken();
                break;
              }
              val[1].SetStringValue(mToken.mIdentStr, nsCSSUnit.String);
            }
        
            // get optional type
            int32_t type = nsStyle.LIST_STYLE_DECIMAL;
            if (ExpectSymbol(',', true)) {
              if (!GetToken(true)) {
                break;
              }
              nsCSSKeyword keyword;
              if (nsCSSTokenType.Ident != mToken.mType ||
                  (keyword = nsCSSKeywords.LookupKeyword(mToken.mIdentStr)) ==
                    nsCSSKeyword.Unknown ||
                  !nsCSSProps.FindKeyword(keyword, nsCSSProps.kListStyleKTable, ref type)) {
                UngetToken();
                break;
              }
            }
        
            int32_t typeItem = nsCSSUnit.Counters == unit ? 2 : 1;
            val[typeItem].SetIntValue(type, nsCSSUnit.Enumerated);
        
            if (!ExpectSymbol(')', true)) {
              break;
            }
        
            aValue.SetArrayValue(val, unit);
            return true;
          }
        
          SkipUntil(')');
          return false;
        }
        
        internal bool ParseAttr(ref nsCSSValue aValue)
        {
          if (!GetToken(true)) {
            return false;
          }
        
          var attr = new StringBuilder();
          if (nsCSSTokenType.Ident == mToken.mType) {  // attr name or namespace
            string holdIdent = mToken.mIdentStr;
            if (ExpectSymbol('|', false)) {  // namespace
              int32_t nameSpaceID = GetNamespaceIdForPrefix(holdIdent);
              if (nameSpaceID == nsNameSpace.Unknown) {
                return false;
              }
              attr.AppendInt(nameSpaceID, 10);
              attr.Append('|');
              if (! GetToken(false)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
                return false;
              }
              if (nsCSSTokenType.Ident == mToken.mType) {
                attr.Append(mToken.mIdentStr);
              }
              else {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
                UngetToken();
                return false;
              }
            }
            else {  // no namespace
              attr.AssignLiteral(holdIdent);
            }
          }
          else if (mToken.IsSymbol('*')) {  // namespace wildcard
            // Wildcard namespace makes no sense here and is not allowed
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
            UngetToken();
            return false;
          }
          else if (mToken.IsSymbol('|')) {  // explicit NO namespace
            if (! GetToken(false)) {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameEOF"); };
              return false;
            }
            if (nsCSSTokenType.Ident == mToken.mType) {
              attr.Append(mToken.mIdentStr);
            }
            else {
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameExpected", mToken); };
              UngetToken();
              return false;
            }
          }
          else {
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEAttributeNameOrNamespaceExpected", mToken); };
            UngetToken();
            return false;
          }
          if (!ExpectSymbol(')', true)) {
            return false;
          }
          aValue.SetStringValue(attr, nsCSSUnit.Attr);
          return true;
        }
        
        internal bool SetValueToURL(ref nsCSSValue aValue, string aURL)
        {
          if (mSheetPrincipal == null) {
            Debug.Fail("Codepaths that expect to parse URLs MUST pass in an origin principal");
            return false;
          }
        
          string buffer = nsCSSValue.BufferFromString(aURL);
        
          // Note: urlVal retains its own reference to |buffer|.
          URLValue urlVal =
            new URLValue(buffer, mBaseURI, mSheetURI, mSheetPrincipal);
          aValue.SetURLValue(urlVal);
          return true;
        }
        
        /**
         * Parse the arguments of -moz-image-rect() function.
         * -moz-image-rect(<uri>, <top>, <right>, <bottom>, <left>)
         */
        internal bool ParseImageRect(ref nsCSSValue aImage)
        {
          // A non-iterative for loop to break out when an error occurs.
          for (;;) {
            var newFunction = new nsCSSValue();
            const uint32_t kNumArgs = 5;
            nsCSSValue[] func =
              newFunction.InitFunction(nsCSSKeyword.MozImageRect, kNumArgs);
        
            // func[0] is reserved for the function name.
            nsCSSValue url    = func[1];
            nsCSSValue top    = func[2];
            nsCSSValue right  = func[3];
            nsCSSValue bottom = func[4];
            nsCSSValue left   = func[5];
        
            string urlString = "";
            if (!ParseURLOrString(ref urlString) ||
                !SetValueToURL(ref url, urlString) ||
                !ExpectSymbol(',', true)) {
              break;
            }
        
            const int32_t VARIANT_SIDE = VARIANT_NUMBER | VARIANT_PERCENT;
            if (!ParseNonNegativeVariant(ref top, VARIANT_SIDE, null) ||
                !ExpectSymbol(',', true) ||
                !ParseNonNegativeVariant(ref right, VARIANT_SIDE, null) ||
                !ExpectSymbol(',', true) ||
                !ParseNonNegativeVariant(ref bottom, VARIANT_SIDE, null) ||
                !ExpectSymbol(',', true) ||
                !ParseNonNegativeVariant(ref left, VARIANT_SIDE, null) ||
                !ExpectSymbol(')', true))
              break;
        
            aImage = newFunction;
            return true;
          }
        
          SkipUntil(')');
          return false;
        }
        
        // <element>: -moz-element(# <element_id> )
        internal bool ParseElement(ref nsCSSValue aValue)
        {
          // A non-iterative for loop to break out when an error occurs.
          for (;;) {
            if (!GetToken(true))
              break;
        
            if (mToken.mType == nsCSSTokenType.ID) {
              aValue.SetStringValue(mToken.mIdentStr, nsCSSUnit.Element);
            } else {
              UngetToken();
              break;
            }
        
            if (!ExpectSymbol(')', true))
              break;
        
            return true;
          }
        
          // If we detect a syntax error, we must match the opening parenthesis of the
          // function with the closing parenthesis and skip all the tokens in between.
          SkipUntil(')');
          return false;
        }
        
        #if MOZ_FLEXBOX
        // flex: none | [ <'flex-grow'> <'flex-shrink'>? || <'flex-basis'> ]
        internal bool ParseFlex()
        {
          // First check for inherit / initial
          var tmpVal = new nsCSSValue();
          if (ParseVariant(ref tmpVal, VARIANT_INHERIT, null)) {
            AppendValue(nsCSSProperty.FlexGrow, tmpVal);
            AppendValue(nsCSSProperty.FlexShrink, tmpVal);
            AppendValue(nsCSSProperty.FlexBasis, tmpVal);
            return true;
          }
        
          // Next, check for 'none' == '0 0 auto'
          if (ParseVariant(ref tmpVal, VARIANT_NONE, null)) {
            AppendValue(nsCSSProperty.FlexGrow, new nsCSSValue(0.0f, nsCSSUnit.Number));
            AppendValue(nsCSSProperty.FlexShrink, new nsCSSValue(0.0f, nsCSSUnit.Number));
            AppendValue(nsCSSProperty.FlexBasis, new nsCSSValue(nsCSSUnit.Auto));
            return true;
          }
        
          // OK, try parsing our value as individual per-subproperty components:
          //   [ <'flex-grow'> <'flex-shrink'>? || <'flex-basis'> ]
        
          // Each subproperty has a default value that it takes when it's omitted in a
          // "flex" shorthand value. These default values are *only* for the shorthand
          // syntax -- they're distinct from the subproperties' own initial values.  We
          // start with each subproperty at its default, as if we had "flex: 1 1 0%".
          var flexGrow = new nsCSSValue(1.0f, nsCSSUnit.Number);
          var flexShrink = new nsCSSValue(1.0f, nsCSSUnit.Number);
          var flexBasis = new nsCSSValue(0.0f, nsCSSUnit.Percent);
        
          // OVERVIEW OF PARSING STRATEGY:
          // =============================
          // a) Parse the first component as either flex-basis or flex-grow.
          // b) If it wasn't flex-grow, parse the _next_ component as flex-grow.
          // c) Now we've just parsed flex-grow -- so try parsing the next thing as
          //    flex-shrink.
          // d) Finally: If we didn't get flex-basis at the beginning, try to parse
          //    it now, at the end.
          //
          // More details in each section below.
        
          uint32_t flexBasisVariantMask =
            (nsCSSProps.ParserVariant(nsCSSProperty.FlexBasis) & ~(VARIANT_INHERIT));
        
          // (a) Parse first component. It can be either be a 'flex-basis' value or a
          // 'flex-grow' value, so we use the flex-basis-specific variant mask, along
          //  with VARIANT_NUMBER to accept 'flex-grow' values.
          //
          // NOTE: if we encounter unitless 0 here, we *must* interpret it as a
          // 'flex-grow' value (a number), *not* as a 'flex-basis' value (a length).
          // Conveniently, that's the behavior this combined variant-mask gives us --
          // it'll treat unitless 0 as a number. The flexbox spec requires this:
          // "a unitless zero that is not already preceded by two flex factors must be
          //  interpreted as a flex factor.
          if (!ParseNonNegativeVariant(ref tmpVal, flexBasisVariantMask | VARIANT_NUMBER,
                                       nsCSSProps.kWidthKTable)) {
            // First component was not a valid flex-basis or flex-grow value. Fail.
            return false;
          }
        
          // Record what we just parsed as either flex-basis or flex-grow:
          bool wasFirstComponentFlexBasis = (tmpVal.GetUnit() != nsCSSUnit.Number);
          if (wasFirstComponentFlexBasis) flexBasis = tmpVal; else flexGrow = tmpVal;
        
          // (b) If we didn't get flex-grow yet, parse _next_ component as flex-grow.
          bool doneParsing = false;
          if (wasFirstComponentFlexBasis) {
            if (ParseNonNegativeVariant(ref tmpVal, VARIANT_NUMBER, null)) {
              flexGrow = tmpVal;
            } else {
              // Failed to parse anything after our flex-basis -- that's fine. We can
              // skip the remaining parsing.
              doneParsing = true;
            }
          }
        
          if (!doneParsing) {
            // (c) OK -- the last thing we parsed was flex-grow, so look for a
            //     flex-shrink in the next position.
            if (ParseNonNegativeVariant(ref tmpVal, VARIANT_NUMBER, null)) {
              flexShrink = tmpVal;
            }
         
            // d) Finally: If we didn't get flex-basis at the beginning, try to parse
            //    it now, at the end.
            //
            // NOTE: If we encounter unitless 0 in this final position, we'll parse it
            // as a 'flex-basis' value.  That's OK, because we know it must have
            // been "preceded by 2 flex factors" (justification below), which gets us
            // out of the spec's requirement of otherwise having to treat unitless 0
            // as a flex factor.
            //
            // JUSTIFICATION: How do we know that a unitless 0 here must have been
            // preceded by 2 flex factors? Well, suppose we had a unitless 0 that
            // was preceded by only 1 flex factor.  Then, we would have already
            // accepted this unitless 0 as the 'flex-shrink' value, up above (since
            // it's a valid flex-shrink value), and we'd have moved on to the next
            // token (if any). And of course, if we instead had a unitless 0 preceded
            // by *no* flex factors (if it were the first token), we would've already
            // parsed it in our very first call to ParseNonNegativeVariant().  So, any
            // unitless 0 encountered here *must* have been preceded by 2 flex factors.
            if (!wasFirstComponentFlexBasis &&
                ParseNonNegativeVariant(ref tmpVal, flexBasisVariantMask,
                                        nsCSSProps.kWidthKTable)) {
              flexBasis = tmpVal;
            }
          }
        
          AppendValue(nsCSSProperty.FlexGrow,   flexGrow);
          AppendValue(nsCSSProperty.FlexShrink, flexShrink);
          AppendValue(nsCSSProperty.FlexBasis,  flexBasis);
        
          return true;
        }
        #endif
        
        // <color-stop> : <color> [ <percentage> | <length> ]?
        internal bool ParseColorStop(nsCSSValueGradient aGradient)
        {
          nsCSSValueGradientStop stop = aGradient.mStops.AppendElement();
          if (!ParseVariant(ref stop.mColor, VARIANT_COLOR, null)) {
            return false;
          }
        
          // Stop positions do not have to fall between the starting-point and
          // ending-point, so we don't use ParseNonNegativeVariant.
          if (!ParseVariant(ref stop.mLocation, VARIANT_LP | VARIANT_CALC, null)) {
            stop.mLocation.SetNoneValue();
          }
          return true;
        }
        
        // <gradient>
        //    : linear-gradient( <linear-gradient-line>? <color-stops> ')'
        //    | radial-gradient( <radial-gradient-line>? <color-stops> ')'
        //
        // <linear-gradient-line> : [ to [left | right] || [top | bottom] ] ,
        //                        | <legacy-gradient-line>
        // <radial-gradient-line> : [ <shape> || <size> ] [ at <position> ]? ,
        //                        | [ at <position> ] ,
        //                        | <legacy-gradient-line>? <legacy-shape-size>?
        // <shape> : circle | ellipse
        // <size> : closest-side | closest-corner | farthest-side | farthest-corner
        //        | <length> | [<length> | <percentage>]{2}
        //
        // <legacy-gradient-line> : [ <position> || <angle>] ,
        //
        // <legacy-shape-size> : [ <shape> || <legacy-size> ] ,
        // <legacy-size> : closest-side | closest-corner | farthest-side
        //               | farthest-corner | contain | cover
        //
        // <color-stops> : <color-stop> , <color-stop> [, <color-stop>]*
        internal bool ParseLinearGradient(ref nsCSSValue aValue, bool aIsRepeating,
                                           bool aIsLegacy)
        {
          nsCSSValueGradient cssGradient
            = new nsCSSValueGradient(false, aIsRepeating);
        
          if (!GetToken(true)) {
            return false;
          }
        
          if (mToken.mType == nsCSSTokenType.Ident &&
              mToken.mIdentStr.LowerCaseEqualsLiteral("to")) {
        
            // "to" syntax doesn't allow explicit "center"
            if (!ParseBoxPositionValues(ref cssGradient.mBgPos, false, false)) {
              SkipUntil(')');
              return false;
            }
        
            // [ to [left | right] || [top | bottom] ] ,
            nsCSSValue xValue = cssGradient.mBgPos.mXValue;
            nsCSSValue yValue = cssGradient.mBgPos.mYValue;
            if (xValue.GetUnit() != nsCSSUnit.Enumerated ||
                0 == (xValue.GetIntValue() & (nsStyle.BG_POSITION_LEFT |
                                          nsStyle.BG_POSITION_CENTER |
                                          nsStyle.BG_POSITION_RIGHT)) ||
                yValue.GetUnit() != nsCSSUnit.Enumerated ||
                0 == (yValue.GetIntValue() & (nsStyle.BG_POSITION_TOP |
                                          nsStyle.BG_POSITION_CENTER |
                                          nsStyle.BG_POSITION_BOTTOM))) {
              SkipUntil(')');
              return false;
            }
        
            if (!ExpectSymbol(',', true)) {
              SkipUntil(')');
              return false;
            }
        
            return ParseGradientColorStops(cssGradient, ref aValue);
          }
        
          if (!aIsLegacy) {
            UngetToken();
        
            // <angle> ,
            if (ParseVariant(ref cssGradient.mAngle, VARIANT_ANGLE, null) &&
                !ExpectSymbol(',', true)) {
              SkipUntil(')');
              return false;
            }
        
            return ParseGradientColorStops(cssGradient, ref aValue);
          }
        
          nsCSSTokenType ty = mToken.mType;
          string id = mToken.mIdentStr;
          UngetToken();
        
          // <legacy-gradient-line>
          bool haveGradientLine = IsLegacyGradientLine(ty, id);
          if (haveGradientLine) {
            cssGradient.mIsLegacySyntax = true;
            bool haveAngle =
              ParseVariant(ref cssGradient.mAngle, VARIANT_ANGLE, null);
        
            // if we got an angle, we might now have a comma, ending the gradient-line
            if (!haveAngle || !ExpectSymbol(',', true)) {
              if (!ParseBoxPositionValues(ref cssGradient.mBgPos, false)) {
                SkipUntil(')');
                return false;
              }
        
              if (!ExpectSymbol(',', true) &&
                  // if we didn't already get an angle, we might have one now,
                  // otherwise it's an error
                  (haveAngle ||
                   !ParseVariant(ref cssGradient.mAngle, VARIANT_ANGLE, null) ||
                   // now we better have a comma
                   !ExpectSymbol(',', true))) {
                SkipUntil(')');
                return false;
              }
            }
          }
        
          return ParseGradientColorStops(cssGradient, ref aValue);
        }
        
        internal bool ParseRadialGradient(ref nsCSSValue aValue, bool aIsRepeating,
                                           bool aIsLegacy)
        {
          nsCSSValueGradient cssGradient
            = new nsCSSValueGradient(true, aIsRepeating);
        
          // [ <shape> || <size> ]
          bool haveShape =
            ParseVariant(cssGradient.GetRadialShape(), cssGradient.SetRadialShape, VARIANT_KEYWORD,
                         nsCSSProps.kRadialGradientShapeKTable);
        
          bool haveSize = ParseVariant(cssGradient.GetRadialSize(), cssGradient.SetRadialSize, VARIANT_KEYWORD,
                                       aIsLegacy ?
                                       nsCSSProps.kRadialGradientLegacySizeKTable :
                                       nsCSSProps.kRadialGradientSizeKTable);
          if (haveSize) {
            if (!haveShape) {
              // <size> <shape>
              haveShape = ParseVariant(cssGradient.GetRadialShape(), cssGradient.SetRadialShape, VARIANT_KEYWORD,
                                       nsCSSProps.kRadialGradientShapeKTable);
            }
          } else if (!aIsLegacy) {
            // <length> | [<length> | <percentage>]{2}
            haveSize =
              ParseNonNegativeVariant(cssGradient.GetRadiusX(), cssGradient.SetRadiusX, VARIANT_LP, null);
            if (haveSize) {
              // vertical extent is optional
              bool haveYSize =
                ParseNonNegativeVariant(cssGradient.GetRadiusY(), cssGradient.SetRadiusY, VARIANT_LP, null);
              if (!haveShape) {
                var shapeValue = new nsCSSValue();
                haveShape = ParseVariant(ref shapeValue, VARIANT_KEYWORD,
                                         nsCSSProps.kRadialGradientShapeKTable);
              }
              int32_t shape =
                cssGradient.GetRadialShape().GetUnit() == nsCSSUnit.Enumerated ?
                cssGradient.GetRadialShape().GetIntValue() : -1;
              if (haveYSize
                    ? shape == nsStyle.GRADIENT_SHAPE_CIRCULAR
                    : cssGradient.GetRadiusX().GetUnit() == nsCSSUnit.Percent ||
                      shape == nsStyle.GRADIENT_SHAPE_ELLIPTICAL) {
                SkipUntil(')');
                return false;
              }
              cssGradient.mIsExplicitSize = true;
            }
          }
        
          if ((haveShape || haveSize) && ExpectSymbol(',', true)) {
            // [ <shape> || <size> ] ,
            return ParseGradientColorStops(cssGradient, ref aValue);
          }
        
          if (!GetToken(true)) {
            return false;
          }
        
          if (!aIsLegacy) {
            if (mToken.mType == nsCSSTokenType.Ident &&
                mToken.mIdentStr.LowerCaseEqualsLiteral("at")) {
              // [ <shape> || <size> ]? at <position> ,
              if (!ParseBoxPositionValues(ref cssGradient.mBgPos, false) ||
                  !ExpectSymbol(',', true)) {
                SkipUntil(')');
                return false;
              }
        
              return ParseGradientColorStops(cssGradient, ref aValue);
            }
        
            // <color-stops> only
            UngetToken();
            return ParseGradientColorStops(cssGradient, ref aValue);
          }
          Debug.Assert(!cssGradient.mIsExplicitSize);
        
          nsCSSTokenType ty = mToken.mType;
          string id = mToken.mIdentStr;
          UngetToken();
        
          // <legacy-gradient-line>
          bool haveGradientLine = false;
          // if we already encountered a shape or size,
          // we can not have a gradient-line in legacy syntax
          if (!haveShape && !haveSize) {
              haveGradientLine = IsLegacyGradientLine(ty, id);
          }
          if (haveGradientLine) {
            bool haveAngle =
              ParseVariant(ref cssGradient.mAngle, VARIANT_ANGLE, null);
        
            // if we got an angle, we might now have a comma, ending the gradient-line
            if (!haveAngle || !ExpectSymbol(',', true)) {
              if (!ParseBoxPositionValues(ref cssGradient.mBgPos, false)) {
                SkipUntil(')');
                return false;
              }
        
              if (!ExpectSymbol(',', true) &&
                  // if we didn't already get an angle, we might have one now,
                  // otherwise it's an error
                  (haveAngle ||
                   !ParseVariant(ref cssGradient.mAngle, VARIANT_ANGLE, null) ||
                   // now we better have a comma
                   !ExpectSymbol(',', true))) {
                SkipUntil(')');
                return false;
              }
            }
        
            if (cssGradient.mAngle.GetUnit() != nsCSSUnit.None) {
              cssGradient.mIsLegacySyntax = true;
            }
          }
        
          // radial gradients might have a shape and size here for legacy syntax
          if (!haveShape && !haveSize) {
            haveShape =
              ParseVariant(cssGradient.GetRadialShape(), cssGradient.SetRadialShape, VARIANT_KEYWORD,
                           nsCSSProps.kRadialGradientShapeKTable);
            haveSize =
              ParseVariant(cssGradient.GetRadialSize(), cssGradient.SetRadialSize, VARIANT_KEYWORD,
                           nsCSSProps.kRadialGradientLegacySizeKTable);
        
            // could be in either order
            if (!haveShape) {
              haveShape =
                ParseVariant(cssGradient.GetRadialShape(), cssGradient.SetRadialShape, VARIANT_KEYWORD,
                             nsCSSProps.kRadialGradientShapeKTable);
            }
          }
        
          if ((haveShape || haveSize) && !ExpectSymbol(',', true)) {
            SkipUntil(')');
            return false;
          }
        
          return ParseGradientColorStops(cssGradient, ref aValue);
        }
        
        internal bool IsLegacyGradientLine(nsCSSTokenType aType,
                                            string aId)
        {
          // N.B. ParseBoxPositionValues is not guaranteed to put back
          // everything it scanned if it fails, so we must only call it
          // if there is no alternative to consuming a <box-position>.
          // ParseVariant, as used here, will either succeed and consume
          // a single token, or fail and consume none, so we can be more
          // cavalier about calling it.
        
          bool haveGradientLine = false;
          switch (aType) {
          case nsCSSTokenType.Percentage:
          case nsCSSTokenType.Number:
          case nsCSSTokenType.Dimension:
            haveGradientLine = true;
            break;
        
          case nsCSSTokenType.Function:
            if (aId.LowerCaseEqualsLiteral("calc") ||
                aId.LowerCaseEqualsLiteral("-moz-calc")) {
              haveGradientLine = true;
              break;
            }
            // fall through
            goto case nsCSSTokenType.ID;
          case nsCSSTokenType.ID:
          case nsCSSTokenType.Hash:
            // this is a color
            break;
        
          case nsCSSTokenType.Ident: {
            // This is only a gradient line if it's a box position keyword.
            nsCSSKeyword kw = nsCSSKeywords.LookupKeyword(aId);
            int32_t junk = 0;
            if (kw != nsCSSKeyword.Unknown &&
                nsCSSProps.FindKeyword(kw, nsCSSProps.kBackgroundPositionKTable,
                                        ref junk)) {
              haveGradientLine = true;
            }
            break;
          }
        
            goto default;
          default:
            // error
            break;
          }
        
          return haveGradientLine;
        }
        
        internal bool ParseGradientColorStops(nsCSSValueGradient aGradient,
                                               ref nsCSSValue aValue)
        {
          // At least two color stops are required
          if (!ParseColorStop(aGradient) ||
              !ExpectSymbol(',', true) ||
              !ParseColorStop(aGradient)) {
            SkipUntil(')');
            return false;
          }
        
          // Additional color stops
          while (ExpectSymbol(',', true)) {
            if (!ParseColorStop(aGradient)) {
              SkipUntil(')');
              return false;
            }
          }
        
          if (!ExpectSymbol(')', true)) {
            SkipUntil(')');
            return false;
          }
        
          aValue.SetGradientValue(aGradient);
          return true;
        }
        
        internal int32_t ParseChoice(ref nsCSSValue[] aValues,
                                   nsCSSProperty[] aPropIDs, int32_t aNumIDs)
        {
          int32_t found = 0;
          using (/*var compound = */new nsAutoParseCompoundProperty(this)) {  
          
            int32_t loop = 0;
            for (loop = 0; loop < aNumIDs; loop++) {
              // Try each property parser in order
              int32_t hadFound = found;
              int32_t index = 0;
              for (index = 0; index < aNumIDs; index++) {
                int32_t bit = 1 << index;
                if ((found & bit) == 0) {
                  if (ParseSingleValueProperty(ref aValues[index], aPropIDs[(int)index])) {
                    found |= bit;
                    // It's more efficient to break since it will reset |hadFound|
                    // to |found|.  Furthermore, ParseListStyle depends on our going
                    // through the properties in order for each value..
                    break;
                  }
                }
              }
              if (found == hadFound) {  // found nothing new
                break;
              }
            }
            if (0 < found) {
              if (1 == found) { // only first property
                if (nsCSSUnit.Inherit == aValues[0].GetUnit()) { // one inherit, all inherit
                  for (loop = 1; loop < aNumIDs; loop++) {
                    aValues[loop].SetInheritValue();
                  }
                  found = ((1 << aNumIDs) - 1);
                }
                else if (nsCSSUnit.Initial == aValues[0].GetUnit()) { // one initial, all initial
                  for (loop = 1; loop < aNumIDs; loop++) {
                    aValues[loop].SetInitialValue();
                  }
                  found = ((1 << aNumIDs) - 1);
                }
              }
              else {  // more than one value, verify no inherits or initials
                for (loop = 0; loop < aNumIDs; loop++) {
                  if (nsCSSUnit.Inherit == aValues[loop].GetUnit()) {
                    found = -1;
                    break;
                  }
                  else if (nsCSSUnit.Initial == aValues[loop].GetUnit()) {
                    found = -1;
                    break;
                  }
                }
              }
            }
            return found;
          }
        }
        
        internal void AppendValue(nsCSSProperty aPropID, nsCSSValue aValue)
        {
          mTempData.AddLonghandProperty(aPropID, aValue);
        }
        
        /**
         * Parse a "box" property. Box properties have 1 to 4 values. When less
         * than 4 values are provided a standard mapping is used to replicate
         * existing values.
         */
        internal bool ParseBoxProperties(nsCSSProperty[] aPropIDs)
        {
          // Get up to four values for the property
          int32_t count = 0;
          var result = new nsCSSRect();
          for (Side index = nsStyle.SIDE_TOP; index <= nsStyle.SIDE_LEFT; index++) {
            if (! ParseSingleValueProperty(result.GetSide(index), v => result.SetSide(index, v),
                                           aPropIDs[(int)index])) {
              break;
            }
            count++;
          }
          if ((count == 0) || (false == ExpectEndProperty())) {
            return false;
          }
        
          if (1 < count) { // verify no more than single inherit or initial
            for (Side index = nsStyle.SIDE_TOP; index <= nsStyle.SIDE_LEFT; index++) {
              nsCSSUnit unit = (result.GetSide(index)).GetUnit();
              if (nsCSSUnit.Inherit == unit || nsCSSUnit.Initial == unit) {
                return false;
              }
            }
          }
        
          // Provide missing values by replicating some of the values found
          switch (count) {
            case 1: // Make right == top
              result.mRight = result.mTop;
              goto case 2;
            case 2: // Make bottom == top
              result.mBottom = result.mTop;
              goto case 3;
            case 3: // Make left == right
              result.mLeft = result.mRight;
            break;
          }
        
          for (Side index = nsStyle.SIDE_TOP; index <= nsStyle.SIDE_LEFT; index++) {
            AppendValue(aPropIDs[(int)index], result.GetSide(index));
          }
          return true;
        }
        
        // Similar to ParseBoxProperties, except there is only one property
        // with the result as its value, not four. Requires values be nonnegative.
        internal bool ParseGroupedBoxProperty(int32_t aVariantMask,
                                               /** outparam */ ref nsCSSValue aValue)
        {
          nsCSSRect result = aValue.SetRectValue();
        
          int32_t count = 0;
          for (Side index = nsStyle.SIDE_TOP; index <= nsStyle.SIDE_LEFT; index++) {
            if (!ParseNonNegativeVariant(result.GetSide(index), v => result.SetSide(index, v),
                                         aVariantMask, null)) {
              break;
            }
            count++;
          }
        
          if (count == 0) {
            return false;
          }
        
          // Provide missing values by replicating some of the values found
          switch (count) {
            case 1: // Make right == top
              result.mRight = result.mTop;
              goto case 2;
            case 2: // Make bottom == top
              result.mBottom = result.mTop;
              goto case 3;
            case 3: // Make left == right
              result.mLeft = result.mRight;
            break;
          }
        
          return true;
        }
        
        internal bool ParseDirectionalBoxProperty(nsCSSProperty aProperty,
                                                   int32_t aSourceType)
        {
          nsCSSProperty[] subprops = nsCSSProps.SubpropertyEntryFor(aProperty);
          Debug.Assert(subprops[3] == nsCSSProperty.Unknown,
                       "not box property with physical vs. logical cascading");
          var value = new nsCSSValue();
          if (!ParseSingleValueProperty(ref value, subprops[0]) ||
              !ExpectEndProperty())
            return false;
        
          AppendValue(subprops[0], value);
          var typeVal = new nsCSSValue(aSourceType, nsCSSUnit.Enumerated);
          AppendValue(subprops[1], typeVal);
          AppendValue(subprops[2], typeVal);
          return true;
        }
        
        internal bool ParseBoxCornerRadius(nsCSSProperty aPropID)
        {
          nsCSSValue dimenX = new nsCSSValue(), dimenY = new nsCSSValue();
          // required first value
          if (! ParseNonNegativeVariant(ref dimenX, VARIANT_HLP | VARIANT_CALC, null))
            return false;
        
          // optional second value (forbidden if first value is inherit/initial)
          if (dimenX.GetUnit() != nsCSSUnit.Inherit &&
              dimenX.GetUnit() != nsCSSUnit.Initial) {
            ParseNonNegativeVariant(ref dimenY, VARIANT_LP | VARIANT_CALC, null);
          }
        
          if (dimenX == dimenY || dimenY.GetUnit() == nsCSSUnit.Null) {
            AppendValue(aPropID, dimenX);
          } else {
            var value = new nsCSSValue();
            value.SetPairValue(dimenX, dimenY);
            AppendValue(aPropID, value);
          }
          return true;
        }
        
        internal bool ParseBoxCornerRadii(nsCSSProperty[] aPropIDs)
        {
          // Rectangles are used as scratch storage.
          // top => top-left, right => top-right,
          // bottom => bottom-right, left => bottom-left.
          nsCSSRect dimenX = new nsCSSRect(), dimenY = new nsCSSRect();
          int32_t countX = 0, countY = 0;
        
          for (Side side = nsStyle.SIDE_TOP; side <= nsStyle.SIDE_LEFT; side++) {
            if (! ParseNonNegativeVariant(dimenX.GetSide(side), v => dimenX.SetSide(side, v),
                                          (side > 0 ? 0 : VARIANT_INHERIT) |
                                            VARIANT_LP | VARIANT_CALC,
                                          null))
              break;
            countX++;
          }
          if (countX == 0)
            return false;
        
          if (ExpectSymbol('/', true)) {
            for (Side side = nsStyle.SIDE_TOP; side <= nsStyle.SIDE_LEFT; side++) {
              if (! ParseNonNegativeVariant(dimenY.GetSide(side), v => dimenY.SetSide(side, v),
                                            VARIANT_LP | VARIANT_CALC, null))
                break;
              countY++;
            }
            if (countY == 0)
              return false;
          }
          if (!ExpectEndProperty())
            return false;
        
          // if 'initial' or 'inherit' was used, it must be the only value
          if (countX > 1 || countY > 0) {
            nsCSSUnit unit = dimenX.mTop.GetUnit();
            if (nsCSSUnit.Inherit == unit || nsCSSUnit.Initial == unit)
              return false;
          }
        
          // if we have no Y-values, use the X-values
          if (countY == 0) {
            dimenY = dimenX;
            countY = countX;
          }
        
          // Provide missing values by replicating some of the values found
          switch (countX) {
            case 1: dimenX.mRight = dimenX.mTop;  // top-right same as top-left, and
              goto case 2;
            case 2: dimenX.mBottom = dimenX.mTop; // bottom-right same as top-left, and 
              goto case 3;
            case 3: dimenX.mLeft = dimenX.mRight; // bottom-left same as top-right
            break;
          }
        
          switch (countY) {
            case 1: dimenY.mRight = dimenY.mTop;  // top-right same as top-left, and
              goto case 2;
            case 2: dimenY.mBottom = dimenY.mTop; // bottom-right same as top-left, and 
              goto case 3;
            case 3: dimenY.mLeft = dimenY.mRight; // bottom-left same as top-right
            break;
          }
        
          for (Side side = nsStyle.SIDE_TOP; side <= nsStyle.SIDE_LEFT; side++) {
            nsCSSValue x = dimenX.GetSide(side);
            nsCSSValue y = dimenY.GetSide(side);
        
            if (x == y) {
              AppendValue(aPropIDs[(int)side], x);
            } else {
              var pair = new nsCSSValue();
              pair.SetPairValue(x, y);
              AppendValue(aPropIDs[(int)side], pair);
            }
          }
          return true;
        }
        
        // These must be in CSS order (top,right,bottom,left) for indexing to work
        static nsCSSProperty[] kBorderStyleIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderTopStyle,
          nsCSSProperty.BorderRightStyleValue,
          nsCSSProperty.BorderBottomStyle,
          nsCSSProperty.BorderLeftStyleValue
        };
        static nsCSSProperty[] kBorderWidthIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderTopWidth,
          nsCSSProperty.BorderRightWidthValue,
          nsCSSProperty.BorderBottomWidth,
          nsCSSProperty.BorderLeftWidthValue
        };
        static nsCSSProperty[] kBorderColorIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderTopColor,
          nsCSSProperty.BorderRightColorValue,
          nsCSSProperty.BorderBottomColor,
          nsCSSProperty.BorderLeftColorValue
        };
        static nsCSSProperty[] kBorderRadiusIDs = new nsCSSProperty[] {
          nsCSSProperty.BorderTopLeftRadius,
          nsCSSProperty.BorderTopRightRadius,
          nsCSSProperty.BorderBottomRightRadius,
          nsCSSProperty.BorderBottomLeftRadius
        };
        static nsCSSProperty[] kOutlineRadiusIDs = new nsCSSProperty[] {
          nsCSSProperty.MozOutlineRadiusTopLeft,
          nsCSSProperty.MozOutlineRadiusTopRight,
          nsCSSProperty.MozOutlineRadiusBottomRight,
          nsCSSProperty.MozOutlineRadiusBottomLeft
        };
        
        internal bool ParseProperty(nsCSSProperty aPropID)
        {
          // Can't use AutoRestore<bool> because it's a bitfield.
          Debug.Assert(!mHashlessColorQuirk,
                            "hashless color quirk should not be set");
          Debug.Assert(!mUnitlessLengthQuirk,
                            "unitless length quirk should not be set");
          if (mNavQuirkMode) {
            mHashlessColorQuirk =
              nsCSSProps.PropHasFlags(aPropID, nsCSSProps.HASHLESS_COLOR_QUIRK);
            mUnitlessLengthQuirk =
              nsCSSProps.PropHasFlags(aPropID, nsCSSProps.UNITLESS_LENGTH_QUIRK);
          }
        
          Debug.Assert(aPropID < nsCSSProperty.PropertyCount, "index out of range");
          bool result;
          switch (nsCSSProps.PropertyParseType(aPropID)) {
            case nsCSSProps.PARSE_INACCESSIBLE: {
              // The user can't use these
              { if (!mSuppressErrors) mReporter.ReportUnexpected("PEInaccessibleProperty2"); };
              result = false;
              break;
            }
              goto case nsCSSProps.PARSE_FUNCTION;
            case nsCSSProps.PARSE_FUNCTION: {
              result = ParsePropertyByFunction(aPropID);
              break;
            }
              goto case nsCSSProps.PARSE_VALUE;
            case nsCSSProps.PARSE_VALUE: {
              result = false;
              var value = new nsCSSValue();
              if (ParseSingleValueProperty(ref value, aPropID)) {
                if (ExpectEndProperty()) {
                  AppendValue(aPropID, value);
                  result = true;
                }
                // XXX Report errors?
              }
              // XXX Report errors?
              break;
            }
              goto case nsCSSProps.PARSE_VALUE_LIST;
            case nsCSSProps.PARSE_VALUE_LIST: {
              result = ParseValueList(aPropID);
              break;
            }
              goto default;
            default: {
              result = false;
              Debug.Assert(false,
                                "Property's flags field in nsCSSPropList.h is missing one of the nsCSSProps.PARSE_* constants");
              break;
            }
            break;
          }
        
          if (mNavQuirkMode) {
            mHashlessColorQuirk = false;
            mUnitlessLengthQuirk = false;
          }
        
          return result;
        }
        
        internal bool ParsePropertyByFunction(nsCSSProperty aPropID)
        {
          switch (aPropID) {  // handle shorthand or multiple properties
          case nsCSSProperty.Background:
            return ParseBackground();
          case nsCSSProperty.BackgroundRepeat:
            return ParseBackgroundRepeat();
          case nsCSSProperty.BackgroundPosition:
            return ParseBackgroundPosition();
          case nsCSSProperty.BackgroundSize:
            return ParseBackgroundSize();
          case nsCSSProperty.Border:
            return ParseBorderSide(kBorderTopIDs, true);
          case nsCSSProperty.BorderColor:
            return ParseBorderColor();
          case nsCSSProperty.BorderSpacing:
            return ParseBorderSpacing();
          case nsCSSProperty.BorderStyle:
            return ParseBorderStyle();
          case nsCSSProperty.BorderBottom:
            return ParseBorderSide(kBorderBottomIDs, false);
          case nsCSSProperty.BorderEnd:
            return ParseDirectionalBorderSide(kBorderEndIDs,
                                              nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderLeft:
            return ParseDirectionalBorderSide(kBorderLeftIDs,
                                              nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderRight:
            return ParseDirectionalBorderSide(kBorderRightIDs,
                                              nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderStart:
            return ParseDirectionalBorderSide(kBorderStartIDs,
                                              nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderTop:
            return ParseBorderSide(kBorderTopIDs, false);
          case nsCSSProperty.BorderBottomColors:
          case nsCSSProperty.BorderLeftColors:
          case nsCSSProperty.BorderRightColors:
          case nsCSSProperty.BorderTopColors:
            return ParseBorderColors(aPropID);
          case nsCSSProperty.BorderImageSlice:
            { bool? _ = null; return ParseBorderImageSlice(true, ref _); }
            goto case nsCSSProperty.BorderImageWidth;
          case nsCSSProperty.BorderImageWidth:
            return ParseBorderImageWidth(true);
          case nsCSSProperty.BorderImageOutset:
            return ParseBorderImageOutset(true);
          case nsCSSProperty.BorderImageRepeat:
            return ParseBorderImageRepeat(true);
          case nsCSSProperty.BorderImage:
            return ParseBorderImage();
          case nsCSSProperty.BorderWidth:
            return ParseBorderWidth();
          case nsCSSProperty.BorderEndColor:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderEndColor,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderLeftColor:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderLeftColor,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderRightColor:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderRightColor,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderStartColor:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderStartColor,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderEndWidth:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderEndWidth,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderLeftWidth:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderLeftWidth,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderRightWidth:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderRightWidth,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderStartWidth:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderStartWidth,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderEndStyle:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderEndStyle,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderLeftStyle:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderLeftStyle,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderRightStyle:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderRightStyle,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.BorderStartStyle:
            return ParseDirectionalBoxProperty(nsCSSProperty.BorderStartStyle,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.BorderRadius:
            return ParseBoxCornerRadii(kBorderRadiusIDs);
          case nsCSSProperty.MozOutlineRadius:
            return ParseBoxCornerRadii(kOutlineRadiusIDs);
        
          case nsCSSProperty.BorderTopLeftRadius:
          case nsCSSProperty.BorderTopRightRadius:
          case nsCSSProperty.BorderBottomRightRadius:
          case nsCSSProperty.BorderBottomLeftRadius:
          case nsCSSProperty.MozOutlineRadiusTopLeft:
          case nsCSSProperty.MozOutlineRadiusTopRight:
          case nsCSSProperty.MozOutlineRadiusBottomRight:
          case nsCSSProperty.MozOutlineRadiusBottomLeft:
            return ParseBoxCornerRadius(aPropID);
        
          case nsCSSProperty.BoxShadow:
          case nsCSSProperty.TextShadow:
            return ParseShadowList(aPropID);
        
          case nsCSSProperty.Clip:
            return ParseRect(nsCSSProperty.Clip);
          case nsCSSProperty.MozColumns:
            return ParseColumns();
          case nsCSSProperty.MozColumnRule:
            return ParseBorderSide(kColumnRuleIDs, false);
          case nsCSSProperty.Content:
            return ParseContent();
          case nsCSSProperty.CounterIncrement:
          case nsCSSProperty.CounterReset:
            return ParseCounterData(aPropID);
          case nsCSSProperty.Cursor:
            return ParseCursor();
        #if MOZ_FLEXBOX
            goto case nsCSSProperty.Flex;
          case nsCSSProperty.Flex:
            return ParseFlex();
        #endif // MOZ_FLEXBOX
            goto case nsCSSProperty.Font;
          case nsCSSProperty.Font:
            return ParseFont();
          case nsCSSProperty.ImageRegion:
            return ParseRect(nsCSSProperty.ImageRegion);
          case nsCSSProperty.ListStyle:
            return ParseListStyle();
          case nsCSSProperty.Margin:
            return ParseMargin();
          case nsCSSProperty.MarginEnd:
            return ParseDirectionalBoxProperty(nsCSSProperty.MarginEnd,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.MarginLeft:
            return ParseDirectionalBoxProperty(nsCSSProperty.MarginLeft,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.MarginRight:
            return ParseDirectionalBoxProperty(nsCSSProperty.MarginRight,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.MarginStart:
            return ParseDirectionalBoxProperty(nsCSSProperty.MarginStart,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.Outline:
            return ParseOutline();
          case nsCSSProperty.Overflow:
            return ParseOverflow();
          case nsCSSProperty.Padding:
            return ParsePadding();
          case nsCSSProperty.PaddingEnd:
            return ParseDirectionalBoxProperty(nsCSSProperty.PaddingEnd,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.PaddingLeft:
            return ParseDirectionalBoxProperty(nsCSSProperty.PaddingLeft,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.PaddingRight:
            return ParseDirectionalBoxProperty(nsCSSProperty.PaddingRight,
                                               nsStyle.BOXPROP_SOURCE_PHYSICAL);
          case nsCSSProperty.PaddingStart:
            return ParseDirectionalBoxProperty(nsCSSProperty.PaddingStart,
                                               nsStyle.BOXPROP_SOURCE_LOGICAL);
          case nsCSSProperty.Quotes:
            return ParseQuotes();
          case nsCSSProperty.Size:
            return ParseSize();
          case nsCSSProperty.TextDecoration:
            return ParseTextDecoration();
          case nsCSSProperty.Transform:
            return ParseTransform(false);
          case nsCSSProperty.MozTransform:
            return ParseTransform(true);
          case nsCSSProperty.TransformOrigin:
            return ParseTransformOrigin(false);
          case nsCSSProperty.PerspectiveOrigin:
            return ParseTransformOrigin(true);
          case nsCSSProperty.Transition:
            return ParseTransition();
          case nsCSSProperty.Animation:
            return ParseAnimation();
          case nsCSSProperty.TransitionProperty:
            return ParseTransitionProperty();
          case nsCSSProperty.Fill:
          case nsCSSProperty.Stroke:
            return ParsePaint(aPropID);
          case nsCSSProperty.StrokeDasharray:
            return ParseDasharray();
          case nsCSSProperty.Marker:
            return ParseMarker();
          case nsCSSProperty.PaintOrder:
            return ParsePaintOrder();
          default:
            Debug.Assert(false, "should not be called");
            return false;
          }
        }
        
        // Bits used in determining which background position info we have
        
        internal bool ParseSingleValueProperty(ref nsCSSValue aValue,
                                                nsCSSProperty aPropID)
        {
          if (aPropID == nsCSSProperty.ExtraXNoneValue) {
            return ParseVariant(ref aValue, VARIANT_NONE | VARIANT_INHERIT, null);
          }
        
          if (aPropID == nsCSSProperty.ExtraXAutoValue) {
            return ParseVariant(ref aValue, VARIANT_AUTO | VARIANT_INHERIT, null);
          }
        
          if (aPropID < 0 || aPropID >= nsCSSProperty.PropertyCountNoShorthands) {
            Debug.Assert(false, "not a single value property");
            return false;
          }
        
          if (nsCSSProps.PropHasFlags(aPropID, nsCSSProps.VALUE_PARSER_FUNCTION)) {
            switch (aPropID) {
              case nsCSSProperty.FontFamily:
                return ParseFamily(ref aValue);
              case nsCSSProperty.FontFeatureSettings:
                return ParseFontFeatureSettings(ref aValue);
              case nsCSSProperty.FontWeight:
                return ParseFontWeight(ref aValue);
              case nsCSSProperty.Marks:
                return ParseMarks(ref aValue);
              case nsCSSProperty.TextDecorationLine:
                return ParseTextDecorationLine(ref aValue);
              case nsCSSProperty.TextOverflow:
                return ParseTextOverflow(ref aValue);
              default:
                Debug.Assert(false, "should not reach here");
                return false;
            }
          }
        
          uint32_t variant = nsCSSProps.ParserVariant(aPropID);
          if (variant == 0) {
            Debug.Assert(false, "not a single value property");
            return false;
          }
        
          // We only allow 'script-level' when unsafe rules are enabled, because
          // otherwise it could interfere with rulenode optimizations if used in
          // a non-MathML-enabled document.
          if (aPropID == nsCSSProperty.ScriptLevel && !mUnsafeRulesEnabled)
            return false;
        
          int32_t[] kwtable = nsCSSProps.kKeywordTableTable[(int)aPropID];
          switch (nsCSSProps.ValueRestrictions(aPropID)) {
            default:
              Debug.Assert(false, "should not be reached");
              goto case 0;
            case 0:
              return ParseVariant(ref aValue, variant, kwtable);
            case nsCSSProps.VALUE_NONNEGATIVE:
              return ParseNonNegativeVariant(ref aValue, variant, kwtable);
            case nsCSSProps.VALUE_AT_LEAST_ONE:
              return ParseOneOrLargerVariant(ref aValue, variant, kwtable);
          }
        }
        
        // nsFont.EnumerateFamilies callback for ParseFontDescriptorValue
        
        static bool
        ExtractFirstFamily(string aFamily,
                           bool aGeneric,
                           object aData)
        {
          ExtractFirstFamilyData realData = (ExtractFirstFamilyData) aData;
          if (aGeneric || realData.mFamilyName.Length() > 0) {
            realData.mGood = false;
            return false;
          }
          realData.mFamilyName = aFamily.ToString();
          realData.mGood = true;
          return true;
        }
        
        // font-descriptor: descriptor ':' value ';'
        // caller has advanced mToken to point at the descriptor
        internal bool ParseFontDescriptorValue(nsCSSFontDesc aDescID,
                                                ref nsCSSValue aValue)
        {
          switch (aDescID) {
            // These four are similar to the properties of the same name,
            // possibly with more restrictions on the values they can take.
            
          case nsCSSFontDesc.Family: {
            if (!ParseFamily(ref aValue) ||
                aValue.GetUnit() != nsCSSUnit.Families)
              return false;
        
            // the style parameters to the nsFont constructor are ignored,
            // because it's only being used to call EnumerateFamilies
            string valueStr = "";
            aValue.GetStringValue(ref valueStr);
            var font = new nsFont(valueStr, 0, 0, 0, 0, 0, 0);
            var dat = new ExtractFirstFamilyData();
        
            font.EnumerateFamilies(ExtractFirstFamily, (object) dat);
            if (!dat.mGood)
              return false;
        
            aValue.SetStringValue(dat.mFamilyName, nsCSSUnit.String);
            return true;
          }
        
            goto case nsCSSFontDesc.Style;
          case nsCSSFontDesc.Style:
            // property is VARIANT_HMK|VARIANT_SYSFONT
            return ParseVariant(ref aValue, VARIANT_KEYWORD | VARIANT_NORMAL,
                                nsCSSProps.kFontStyleKTable);
        
          case nsCSSFontDesc.Weight:
            return (ParseFontWeight(ref aValue) &&
                    aValue.GetUnit() != nsCSSUnit.Inherit &&
                    aValue.GetUnit() != nsCSSUnit.Initial &&
                    (aValue.GetUnit() != nsCSSUnit.Enumerated ||
                     (aValue.GetIntValue() != nsStyle.FONT_WEIGHT_BOLDER &&
                      aValue.GetIntValue() != nsStyle.FONT_WEIGHT_LIGHTER)));
        
          case nsCSSFontDesc.Stretch:
            // property is VARIANT_HK|VARIANT_SYSFONT
            return ParseVariant(ref aValue, VARIANT_KEYWORD,
                                nsCSSProps.kFontStretchKTable);
        
            // These two are unique to @font-face and have their own special grammar.
            goto case nsCSSFontDesc.Src;
          case nsCSSFontDesc.Src:
            return ParseFontSrc(ref aValue);
        
          case nsCSSFontDesc.UnicodeRange:
            return ParseFontRanges(ref aValue);
        
          case nsCSSFontDesc.FontFeatureSettings:
            return ParseFontFeatureSettings(ref aValue);
        
          case nsCSSFontDesc.FontLanguageOverride:
            return ParseVariant(ref aValue, VARIANT_NORMAL | VARIANT_STRING, null);
        
          case nsCSSFontDesc.UNKNOWN:
          case nsCSSFontDesc.COUNT:
            Debug.Fail("bad nsCSSFontDesc code");
            break;
          }
          // explicitly do NOT have a default case to let the compiler
          // help find missing descriptors
          return false;
        }
        
        internal void InitBoxPropsAsPhysical(nsCSSProperty[] aSourceProperties)
        {
          var physical = new nsCSSValue(nsStyle.BOXPROP_SOURCE_PHYSICAL, nsCSSUnit.Enumerated);
          AppendValues(aSourceProperties, physical);
        }
        
        static nsCSSValue
        BoxPositionMaskToCSSValue(int32_t aMask, bool isX)
        {
          int32_t val = nsStyle.BG_POSITION_CENTER;
          if (isX) {
            if ((aMask & BG_LEFT) != 0) {
              val = nsStyle.BG_POSITION_LEFT;
            }
            else if ((aMask & BG_RIGHT) != 0) {
              val = nsStyle.BG_POSITION_RIGHT;
            }
          }
          else {
            if ((aMask & BG_TOP) != 0) {
              val = nsStyle.BG_POSITION_TOP;
            }
            else if ((aMask & BG_BOTTOM) != 0) {
              val = nsStyle.BG_POSITION_BOTTOM;
            }
          }
        
          return new nsCSSValue(val, nsCSSUnit.Enumerated);
        }
        
        internal bool ParseBackground()
        {
          using (/*var compound = */new nsAutoParseCompoundProperty(this)) {  
          
            // background-color can only be set once, so it's not a list.
            var color = new nsCSSValue();
          
            // Check first for inherit/initial.
            if (ParseVariant(ref color, VARIANT_INHERIT, null)) {
              // must be alone
              if (!ExpectEndProperty()) {
                return false;
              }
              AppendValues(nsCSSProps.SubpropertyEntryFor(nsCSSProperty.Background), color);
              return true;
            }
          
            nsCSSValue image = new nsCSSValue(), repeat = new nsCSSValue(), attachment = new nsCSSValue(), clip = new nsCSSValue(), origin = new nsCSSValue(), position = new nsCSSValue(), size = new nsCSSValue();
            var state = new BackgroundParseState(color, image.SetListValue(), 
                                       repeat.SetPairListValue(),
                                       attachment.SetListValue(), clip.SetListValue(),
                                       origin.SetListValue(), position.SetListValue(),
                                       size.SetPairListValue());
          
            for (;;) {
              if (!ParseBackgroundItem(state)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              // If we saw a color, this must be the last item.
              if (color.GetUnit() != nsCSSUnit.Null) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectEndValue", mToken); };
                return false;
              }
              // Otherwise, a comma is mandatory.
              if (!ExpectSymbol(',', true)) {
                return false;
              }
              // Chain another entry on all the lists.
              state.mImage.mNext = new nsCSSValueList();
              state.mImage = state.mImage.mNext;
              state.mRepeat.mNext = new nsCSSValuePairList();
              state.mRepeat = state.mRepeat.mNext;
              state.mAttachment.mNext = new nsCSSValueList();
              state.mAttachment = state.mAttachment.mNext;
              state.mClip.mNext = new nsCSSValueList();
              state.mClip = state.mClip.mNext;
              state.mOrigin.mNext = new nsCSSValueList();
              state.mOrigin = state.mOrigin.mNext;
              state.mPosition.mNext = new nsCSSValueList();
              state.mPosition = state.mPosition.mNext;
              state.mSize.mNext = new nsCSSValuePairList();
              state.mSize = state.mSize.mNext;
            }
          
            // If we get to this point without seeing a color, provide a default.
            if (color.GetUnit() == nsCSSUnit.Null) {
              color.SetColorValue(nscolor.RGBA(0,0,0,0));
            }
          
            AppendValue(nsCSSProperty.BackgroundImage,      image);
            AppendValue(nsCSSProperty.BackgroundRepeat,     repeat);
            AppendValue(nsCSSProperty.BackgroundAttachment, attachment);
            AppendValue(nsCSSProperty.BackgroundClip,       clip);
            AppendValue(nsCSSProperty.BackgroundOrigin,     origin);
            AppendValue(nsCSSProperty.BackgroundPosition,   position);
            AppendValue(nsCSSProperty.BackgroundSize,       size);
            AppendValue(nsCSSProperty.BackgroundColor,      color);
            return true;
          }
        }
        
        // Parse one item of the background shorthand property.
        internal bool ParseBackgroundItem(BackgroundParseState aState)
        
        {
          // Fill in the values that the shorthand will set if we don't find
          // other values.
          aState.mImage.mValue.SetNoneValue();
          aState.mRepeat.mXValue.SetIntValue(nsStyle.BG_REPEAT_REPEAT,
                                              nsCSSUnit.Enumerated);
          aState.mRepeat.mYValue.Reset();
          aState.mAttachment.mValue.SetIntValue(nsStyle.BG_ATTACHMENT_SCROLL,
                                                 nsCSSUnit.Enumerated);
          aState.mClip.mValue.SetIntValue(nsStyle.BG_CLIP_BORDER,
                                           nsCSSUnit.Enumerated);
          aState.mOrigin.mValue.SetIntValue(nsStyle.BG_ORIGIN_PADDING,
                                             nsCSSUnit.Enumerated);
          nsCSSValue[] positionArr = new nsCSSValue[4];
          aState.mPosition.mValue.SetArrayValue(positionArr, nsCSSUnit.Array);
          positionArr[1].SetPercentValue(0.0f);
          positionArr[3].SetPercentValue(0.0f);
          aState.mSize.mXValue.SetAutoValue();
          aState.mSize.mYValue.SetAutoValue();
        
          bool haveColor = false,
               haveImage = false,
               haveRepeat = false,
               haveAttach = false,
               havePositionAndSize = false,
               haveOrigin = false,
               haveSomething = false;
        
          while (GetToken(true)) {
            nsCSSTokenType tt = mToken.mType;
            UngetToken(); // ...but we'll still cheat and use mToken
            if (tt == nsCSSTokenType.Symbol) {
              // ExpectEndProperty only looks for symbols, and nothing else will
              // show up as one.
              break;
            }
        
            if (tt == nsCSSTokenType.Ident) {
              nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(mToken.mIdentStr);
              int32_t dummy = 0;
              if (keyword == nsCSSKeyword.Inherit ||
                  keyword == nsCSSKeyword.MozInitial ||
                  keyword == nsCSSKeyword.Initial) {
                return false;
              } else if (keyword == nsCSSKeyword.None) {
                if (haveImage)
                  return false;
                haveImage = true;
                if (!ParseSingleValueProperty(ref aState.mImage.mValue,
                                              nsCSSProperty.BackgroundImage)) {
                  Debug.Fail("should be able to parse");
                  return false;
                }
              } else if (nsCSSProps.FindKeyword(keyword,
                           nsCSSProps.kBackgroundAttachmentKTable, ref dummy)) {
                if (haveAttach)
                  return false;
                haveAttach = true;
                if (!ParseSingleValueProperty(ref aState.mAttachment.mValue,
                                              nsCSSProperty.BackgroundAttachment)) {
                  Debug.Fail("should be able to parse");
                  return false;
                }
              } else if (nsCSSProps.FindKeyword(keyword,
                           nsCSSProps.kBackgroundRepeatKTable, ref dummy)) {
                if (haveRepeat)
                  return false;
                haveRepeat = true;
                var scratch = new nsCSSValuePair();
                if (!ParseBackgroundRepeatValues(ref scratch)) {
                  Debug.Fail("should be able to parse");
                  return false;
                }
                aState.mRepeat.mXValue = scratch.mXValue;
                aState.mRepeat.mYValue = scratch.mYValue;
              } else if (nsCSSProps.FindKeyword(keyword,
                           nsCSSProps.kBackgroundPositionKTable, ref dummy)) {
                if (havePositionAndSize)
                  return false;
                havePositionAndSize = true;
                if (!ParseBackgroundPositionValues(ref aState.mPosition.mValue, false)) {
                  return false;
                }
                if (ExpectSymbol('/', true)) {
                  var scratch = new nsCSSValuePair();
                  if (!ParseBackgroundSizeValues(ref scratch)) {
                    return false;
                  }
                  aState.mSize.mXValue = scratch.mXValue;
                  aState.mSize.mYValue = scratch.mYValue;
                }
              } else if (nsCSSProps.FindKeyword(keyword,
                           nsCSSProps.kBackgroundOriginKTable, ref dummy)) {
                if (haveOrigin)
                  return false;
                haveOrigin = true;
                if (!ParseSingleValueProperty(ref aState.mOrigin.mValue,
                                              nsCSSProperty.BackgroundOrigin)) {
                  Debug.Fail("should be able to parse");
                  return false;
                }
        
                // The spec allows a second box value (for background-clip),
                // immediately following the first one (for background-origin).
        
                // 'background-clip' and 'background-origin' use the same keyword table
                Debug.Assert(nsCSSProps.kKeywordTableTable[
                             (int)nsCSSProperty.BackgroundOrigin] ==
                           nsCSSProps.kBackgroundOriginKTable);
                Debug.Assert(nsCSSProps.kKeywordTableTable[
                             (int)nsCSSProperty.BackgroundClip] ==
                           nsCSSProps.kBackgroundOriginKTable);
        
                if (!ParseSingleValueProperty(ref aState.mClip.mValue,
                                              nsCSSProperty.BackgroundClip)) {
                  // When exactly one <box> value is set, it is used for both
                  // 'background-origin' and 'background-clip'.
                  // See assertions above showing these values are compatible.
                  aState.mClip.mValue = aState.mOrigin.mValue;
                }
              } else {
                if (haveColor)
                  return false;
                haveColor = true;
                if (!ParseSingleValueProperty(ref aState.mColor,
                                              nsCSSProperty.BackgroundColor)) {
                  return false;
                }
              }
            } else if (tt == nsCSSTokenType.URL ||
                       (tt == nsCSSTokenType.Function &&
                        (mToken.mIdentStr.LowerCaseEqualsLiteral("linear-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("radial-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("repeating-linear-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("repeating-radial-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-linear-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-radial-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-repeating-linear-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-repeating-radial-gradient") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-image-rect") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-element")))) {
              if (haveImage)
                return false;
              haveImage = true;
              if (!ParseSingleValueProperty(ref aState.mImage.mValue,
                                            nsCSSProperty.BackgroundImage)) {
                return false;
              }
            } else if (tt == nsCSSTokenType.Dimension ||
                       tt == nsCSSTokenType.Number ||
                       tt == nsCSSTokenType.Percentage ||
                       (tt == nsCSSTokenType.Function &&
                        (mToken.mIdentStr.LowerCaseEqualsLiteral("calc") ||
                         mToken.mIdentStr.LowerCaseEqualsLiteral("-moz-calc")))) {
              if (havePositionAndSize)
                return false;
              havePositionAndSize = true;
              if (!ParseBackgroundPositionValues(ref aState.mPosition.mValue, false)) {
                return false;
              }
              if (ExpectSymbol('/', true)) {
                var scratch = new nsCSSValuePair();
                if (!ParseBackgroundSizeValues(ref scratch)) {
                  return false;
                }
                aState.mSize.mXValue = scratch.mXValue;
                aState.mSize.mYValue = scratch.mYValue;
              }
            } else {
              if (haveColor)
                return false;
              haveColor = true;
              // Note: This parses 'inherit' and 'initial', but
              // we've already checked for them, so it's ok.
              if (!ParseSingleValueProperty(ref aState.mColor,
                                            nsCSSProperty.BackgroundColor)) {
                return false;
              }
            }
            haveSomething = true;
          }
        
          return haveSomething;
        }
        
        // This function is very similar to ParseBackgroundPosition and
        // ParseBackgroundSize.
        internal bool ParseValueList(nsCSSProperty aPropID)
        {
          // aPropID is a single value prop-id
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // 'initial' and 'inherit' stand alone, no list permitted.
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList item = value.SetListValue();
            for (;;) {
              if (!ParseSingleValueProperty(ref item.mValue, aPropID)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              if (!ExpectSymbol(',', true)) {
                return false;
              }
              item.mNext = new nsCSSValueList();
              item = item.mNext;
            }
          }
          AppendValue(aPropID, value);
          return true;
        }
        
        internal bool ParseBackgroundRepeat()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // 'initial' and 'inherit' stand alone, no list permitted.
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            var valuePair = new nsCSSValuePair();
            if (!ParseBackgroundRepeatValues(ref valuePair)) {
              return false;
            }
            nsCSSValuePairList item = value.SetPairListValue();
            for (;;) {
              item.mXValue = valuePair.mXValue;
              item.mYValue = valuePair.mYValue;
              if (CheckEndProperty()) {
                break;
              }
              if (!ExpectSymbol(',', true)) {
                return false;
              }
              if (!ParseBackgroundRepeatValues(ref valuePair)) {
                return false;
              }
              item.mNext = new nsCSSValuePairList();
              item = item.mNext;
            }
          }
        
          AppendValue(nsCSSProperty.BackgroundRepeat, value);
          return true;
        }
        
        internal bool ParseBackgroundRepeatValues(ref nsCSSValuePair aValue) 
        {
          nsCSSValue xValue = aValue.mXValue;
          nsCSSValue yValue = aValue.mYValue;
          
          if (ParseEnum(ref xValue, nsCSSProps.kBackgroundRepeatKTable)) {
            int32_t value = xValue.GetIntValue();
            // For single values set yValue as nsCSSUnit.Null.
            if (value == nsStyle.BG_REPEAT_REPEAT_X ||
                value == nsStyle.BG_REPEAT_REPEAT_Y ||
                !ParseEnum(ref yValue, nsCSSProps.kBackgroundRepeatPartKTable)) {
              // the caller will fail cases like "repeat-x no-repeat"
              // by expecting a list separator or an end property.
              yValue.Reset();
            }
            return true;
          }
          
          return false;
        }
        
        // This function is very similar to ParseBackgroundList and ParseBackgroundSize.
        internal bool ParseBackgroundPosition()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // 'initial' and 'inherit' stand alone, no list permitted.
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            var itemValue = new nsCSSValue();
            if (!ParseBackgroundPositionValues(ref itemValue, false)) {
              return false;
            }
            nsCSSValueList item = value.SetListValue();
            for (;;) {
              item.mValue = itemValue;
              if (CheckEndProperty()) {
                break;
              }
              if (!ExpectSymbol(',', true)) {
                return false;
              }
              if (!ParseBackgroundPositionValues(ref itemValue, false)) {
                return false;
              }
              item.mNext = new nsCSSValueList();
              item = item.mNext;
            }
          }
          AppendValue(nsCSSProperty.BackgroundPosition, value);
          return true;
        }
        
        /**
         * BoxPositionMaskToCSSValue and ParseBoxPositionValues are used
         * for parsing the CSS 2.1 background-position syntax (which has at
         * most two values).  (Compare to the css3-background syntax which
         * takes up to four values.)  Some current CSS specifications that
         * use background-position-like syntax still use this old syntax.
         **
         * Parses two values that correspond to positions in a box.  These can be
         * values corresponding to percentages of the box, raw offsets, or keywords
         * like "top," "left center," etc.
         *
         * @param aOut The nsCSSValuePair in which to place the result.
         * @param aAcceptsInherit If true, 'inherit' and 'initial' are legal values
         * @param aAllowExplicitCenter If true, 'center' is a legal value
         * @return Whether or not the operation succeeded.
         */
        bool ParseBoxPositionValues(ref nsCSSValuePair aOut,
                                                   bool aAcceptsInherit,
                                                   bool aAllowExplicitCenter = true)
        {
          // First try a percentage or a length value
          nsCSSValue xValue = aOut.mXValue,
                     yValue = aOut.mYValue;
          int32_t variantMask =
            (aAcceptsInherit ? VARIANT_INHERIT : 0) | VARIANT_LP | VARIANT_CALC;
          if (ParseVariant(ref xValue, variantMask, null)) {
            if (nsCSSUnit.Inherit == xValue.GetUnit() ||
                nsCSSUnit.Initial == xValue.GetUnit()) {  // both are inherited or both are set to initial
              yValue = xValue;
              return true;
            }
            // We have one percentage/length/calc. Get the optional second
            // percentage/length/calc/keyword.
            if (ParseVariant(ref yValue, VARIANT_LP | VARIANT_CALC, null)) {
              // We have two numbers
              return true;
            }
        
            if (ParseEnum(ref yValue, nsCSSProps.kBackgroundPositionKTable)) {
              int32_t yVal = yValue.GetIntValue();
              if (!((yVal & BG_CTB) != 0)) {
                // The second keyword can only be 'center', 'top', or 'bottom'
                return false;
              }
              yValue = BoxPositionMaskToCSSValue(yVal, false);
              return true;
            }
        
            // If only one percentage or length value is given, it sets the
            // horizontal position only, and the vertical position will be 50%.
            yValue.SetPercentValue(0.5f);
            return true;
          }
        
          // Now try keywords. We do this manually to allow for the first
          // appearance of "center" to apply to the either the x or y
          // position (it's ambiguous so we have to disambiguate). Each
          // allowed keyword value is assigned it's own bit. We don't allow
          // any duplicate keywords other than center. We try to get two
          // keywords but it's okay if there is only one.
          int32_t mask = 0;
          if (ParseEnum(ref xValue, nsCSSProps.kBackgroundPositionKTable)) {
            int32_t bit = xValue.GetIntValue();
            mask |= bit;
            if (ParseEnum(ref xValue, nsCSSProps.kBackgroundPositionKTable)) {
              bit = xValue.GetIntValue();
              if ((mask & (bit & ~BG_CENTER)) != 0) {
                // Only the 'center' keyword can be duplicated.
                return false;
              }
              mask |= bit;
            }
            else {
              // Only one keyword.  See if we have a length, percentage, or calc.
              if (ParseVariant(ref yValue, VARIANT_LP | VARIANT_CALC, null)) {
                if (!((mask & BG_CLR) != 0)) {
                  // The first keyword can only be 'center', 'left', or 'right'
                  return false;
                }
        
                xValue = BoxPositionMaskToCSSValue(mask, true);
                return true;
              }
            }
          }
        
          // Check for bad input. Bad input consists of no matching keywords,
          // or pairs of x keywords or pairs of y keywords.
          if ((mask == 0) || (mask == (BG_TOP | BG_BOTTOM)) ||
              (mask == (BG_LEFT | BG_RIGHT)) ||
              (!aAllowExplicitCenter && ((mask & BG_CENTER) != 0))) {
            return false;
          }
        
          // Create style values
          xValue = BoxPositionMaskToCSSValue(mask, true);
          yValue = BoxPositionMaskToCSSValue(mask, false);
          return true;
        }
        
        bool ParseBackgroundPositionValues(ref nsCSSValue aOut,
                                                          bool aAcceptsInherit)
        {
          // css3-background allows positions to be defined as offsets
          // from an edge. There can be 2 keywords and 2 offsets given. These
          // four 'values' are stored in an array in the following order:
          // [keyword offset keyword offset]. If a keyword or offset isn't
          // parsed the value of the corresponding array element is set
          // to nsCSSUnit.Null by a call to nsCSSValue.Reset().
          if (aAcceptsInherit && ParseVariant(ref aOut, VARIANT_INHERIT, null)) {
            return true;
          }
        
          nsCSSValue[] value = new nsCSSValue[4];
          aOut.SetArrayValue(value, nsCSSUnit.Array);
        
          // The following clarifies organisation of the array.
          nsCSSValue xEdge   = value[0],
                     xOffset = value[1],
                     yEdge   = value[2],
                     yOffset = value[3];
        
          // Parse all the values into the array.
          uint32_t valueCount = 0;
          for (int32_t i = 0; i < 4; i++) {
            if (!ParseVariant(ref value[i], VARIANT_LPCALC | VARIANT_KEYWORD,
                              nsCSSProps.kBackgroundPositionKTable)) {
              break;
            }
            ++valueCount;
          }
        
          switch (valueCount) {
            case 4:
              // "If three or four values are given, then each <percentage> or <length>
              // represents an offset and must be preceded by a keyword, which specifies
              // from which edge the offset is given."
              if (nsCSSUnit.Enumerated != xEdge.GetUnit() ||
                  BG_CENTER == xEdge.GetIntValue() ||
                  nsCSSUnit.Enumerated == xOffset.GetUnit() ||
                  nsCSSUnit.Enumerated != yEdge.GetUnit() ||
                  BG_CENTER == yEdge.GetIntValue() ||
                  nsCSSUnit.Enumerated == yOffset.GetUnit()) {
                return false;
              }
              break;
            case 3:
              // "If three or four values are given, then each <percentage> or<length>
              // represents an offset and must be preceded by a keyword, which specifies
              // from which edge the offset is given." ... "If three values are given,
              // the missing offset is assumed to be zero."
              if (nsCSSUnit.Enumerated != value[1].GetUnit()) {
                // keyword offset keyword
                // Second value is non-keyword, thus first value must be a non-center
                // keyword.
                if (nsCSSUnit.Enumerated != value[0].GetUnit() ||
                    BG_CENTER == value[0].GetIntValue()) {
                  return false;
                }
        
                // Remaining value must be a keyword.
                if (nsCSSUnit.Enumerated != value[2].GetUnit()) {
                  return false;
                }
        
                yOffset.Reset(); // Everything else is in the correct position.
              } else if (nsCSSUnit.Enumerated != value[2].GetUnit()) {
                // keyword keyword offset
                // Third value is non-keyword, thus second value must be non-center
                // keyword.
                if (BG_CENTER == value[1].GetIntValue()) {
                  return false;
                }
        
                // Remaining value must be a keyword.
                if (nsCSSUnit.Enumerated != value[0].GetUnit()) {
                  return false;
                }
        
                // Move the values to the correct position in the array.
                value[3] = value[2]; // yOffset
                value[2] = value[1]; // yEdge
                value[1].Reset(); // xOffset
              } else {
                return false;
              }
              break;
            case 2:
              // "If two values are given and at least one value is not a keyword, then
              // the first value represents the horizontal position (or offset) and the
              // second represents the vertical position (or offset)"
              if (nsCSSUnit.Enumerated == value[0].GetUnit()) {
                if (nsCSSUnit.Enumerated == value[1].GetUnit()) {
                  // keyword keyword
                  value[2] = value[1]; // move yEdge to correct position
                  xOffset.Reset();
                  yOffset.Reset();
                } else {
                  // keyword offset
                  // First value must represent horizontal position.
                  if (((BG_TOP | BG_BOTTOM) & value[0].GetIntValue()) != 0) {
                    return false;
                  }
                  value[3] = value[1]; // move yOffset to correct position
                  xOffset.Reset();
                  yEdge.Reset();
                }
              } else {
                if (nsCSSUnit.Enumerated == value[1].GetUnit()) {
                  // offset keyword
                  // Second value must represent vertical position.
                  if (((BG_LEFT | BG_RIGHT) & value[1].GetIntValue()) != 0) {
                    return false;
                  }
                  value[2] = value[1]; // move yEdge to correct position
                  value[1] = value[0]; // move xOffset to correct position
                  xEdge.Reset();
                  yOffset.Reset();
                } else {
                  // offset offset
                  value[3] = value[1]; // move yOffset to correct position
                  value[1] = value[0]; // move xOffset to correct position
                  xEdge.Reset();
                  yEdge.Reset();
                }
              }
              break;
            case 1:
              // "If only one value is specified, the second value is assumed to be
              // center."
              if (nsCSSUnit.Enumerated == value[0].GetUnit()) {
                xOffset.Reset();
              } else {
                value[1] = value[0]; // move xOffset to correct position
                xEdge.Reset();
              }
              yEdge.SetIntValue(nsStyle.BG_POSITION_CENTER, nsCSSUnit.Enumerated);
              yOffset.Reset();
              break;
            default:
              return false;
          }
        
          // For compatibility with CSS2.1 code the edges can be unspecified.
          // Unspecified edges are recorded as NULL.
          Debug.Assert((nsCSSUnit.Enumerated == xEdge.GetUnit()  ||
                        nsCSSUnit.Null       == xEdge.GetUnit()) &&
                       (nsCSSUnit.Enumerated == yEdge.GetUnit()  ||
                        nsCSSUnit.Null       == yEdge.GetUnit()) &&
                        nsCSSUnit.Enumerated != xOffset.GetUnit()  &&
                        nsCSSUnit.Enumerated != yOffset.GetUnit(),
                        "Unexpected units");
        
          // Keywords in first and second pairs can not both be vertical or
          // horizontal keywords. (eg. left right, bottom top). Additionally,
          // non-center keyword can not be duplicated (eg. left left).
          int32_t xEdgeEnum =
                  xEdge.GetUnit() == nsCSSUnit.Enumerated ? xEdge.GetIntValue() : 0;
          int32_t yEdgeEnum =
                  yEdge.GetUnit() == nsCSSUnit.Enumerated ? yEdge.GetIntValue() : 0;
          if ((xEdgeEnum | yEdgeEnum) == (BG_LEFT | BG_RIGHT) ||
              (xEdgeEnum | yEdgeEnum) == (BG_TOP | BG_BOTTOM) ||
              ((xEdgeEnum & yEdgeEnum & ~BG_CENTER) != 0)) {
            return false;
          }
        
          // The values could be in an order that is different than expected.
          // eg. x contains vertical information, y contains horizontal information.
          // Swap if incorrect order.
          if (((xEdgeEnum & (BG_TOP | BG_BOTTOM)) != 0) ||
              ((yEdgeEnum & (BG_LEFT | BG_RIGHT)) != 0)) {
            nsCSSValue swapEdge = xEdge;
            nsCSSValue swapOffset = xOffset;
            xEdge = yEdge;
            xOffset = yOffset;
            yEdge = swapEdge;
            yOffset = swapOffset;
          }
        
          return true;
        }
        
        // This function is very similar to ParseBackgroundList and
        // ParseBackgroundPosition.
        internal bool ParseBackgroundSize()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // 'initial' and 'inherit' stand alone, no list permitted.
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            var valuePair = new nsCSSValuePair();
            if (!ParseBackgroundSizeValues(ref valuePair)) {
              return false;
            }
            nsCSSValuePairList item = value.SetPairListValue();
            for (;;) {
              item.mXValue = valuePair.mXValue;
              item.mYValue = valuePair.mYValue;
              if (CheckEndProperty()) {
                break;
              }
              if (!ExpectSymbol(',', true)) {
                return false;
              }
              if (!ParseBackgroundSizeValues(ref valuePair)) {
                return false;
              }
              item.mNext = new nsCSSValuePairList();
              item = item.mNext;
            }
          }
          AppendValue(nsCSSProperty.BackgroundSize, value);
          return true;
        }
        
        /**
         * Parses two values that correspond to lengths for the background-size
         * property.  These can be one or two lengths (or the 'auto' keyword) or
         * percentages corresponding to the element's dimensions or the single keywords
         * 'contain' or 'cover'.  'initial' and 'inherit' must be handled by the caller
         * if desired.
         *
         * @param aOut The nsCSSValuePair in which to place the result.
         * @return Whether or not the operation succeeded.
         */
        
        bool ParseBackgroundSizeValues(ref nsCSSValuePair aOut)
        {
          // First try a percentage or a length value
          nsCSSValue xValue = aOut.mXValue,
                     yValue = aOut.mYValue;
          if (ParseNonNegativeVariant(ref xValue, BG_SIZE_VARIANT, null)) {
            // We have one percentage/length/calc/auto. Get the optional second
            // percentage/length/calc/keyword.
            if (ParseNonNegativeVariant(ref yValue, BG_SIZE_VARIANT, null)) {
              // We have a second percentage/length/calc/auto.
              return true;
            }
        
            // If only one percentage or length value is given, it sets the
            // horizontal size only, and the vertical size will be as if by 'auto'.
            yValue.SetAutoValue();
            return true;
          }
        
          // Now address 'contain' and 'cover'.
          if (!ParseEnum(ref xValue, nsCSSProps.kBackgroundSizeKTable))
            return false;
          yValue.Reset();
          return true;
        }
        
        internal bool ParseBorderColor()
        {
          /*TODO: static*/ nsCSSProperty[] kBorderColorSources = {
            nsCSSProperty.BorderLeftColorLtrSource,
            nsCSSProperty.BorderLeftColorRtlSource,
            nsCSSProperty.BorderRightColorLtrSource,
            nsCSSProperty.BorderRightColorRtlSource,
            nsCSSProperty.Unknown
          };
        
          // do this now, in case 4 values weren't specified
          InitBoxPropsAsPhysical(kBorderColorSources);
          return ParseBoxProperties(kBorderColorIDs);
        }
        
        internal void SetBorderImageInitialValues()
        {
          // border-image-source: none
          var source = new nsCSSValue();
          source.SetNoneValue();
          AppendValue(nsCSSProperty.BorderImageSource, source);
        
          // border-image-slice: 100%
          var sliceBoxValue = new nsCSSValue();
          nsCSSRect sliceBox = sliceBoxValue.SetRectValue();
          sliceBox.SetAllSidesTo(new nsCSSValue(1.0f, nsCSSUnit.Percent));
          var slice = new nsCSSValue();
          nsCSSValueList sliceList = slice.SetListValue();
          sliceList.mValue = sliceBoxValue;
          AppendValue(nsCSSProperty.BorderImageSlice, slice);
        
          // border-image-width: 1
          var width = new nsCSSValue();
          nsCSSRect widthBox = width.SetRectValue();
          widthBox.SetAllSidesTo(new nsCSSValue(1.0f, nsCSSUnit.Number));
          AppendValue(nsCSSProperty.BorderImageWidth, width);
        
          // border-image-outset: 0
          var outset = new nsCSSValue();
          nsCSSRect outsetBox = outset.SetRectValue();
          outsetBox.SetAllSidesTo(new nsCSSValue(0.0f, nsCSSUnit.Number));
          AppendValue(nsCSSProperty.BorderImageOutset, outset);
        
          // border-image-repeat: repeat
          var repeat = new nsCSSValue();
          var repeatPair = new nsCSSValuePair();
          repeatPair.SetBothValuesTo(new nsCSSValue(nsStyle.BORDER_IMAGE_REPEAT_STRETCH,
                                                nsCSSUnit.Enumerated));
          repeat.SetPairValue(repeatPair);
          AppendValue(nsCSSProperty.BorderImageRepeat, repeat);
        }
        
        internal bool ParseBorderImageSlice(bool aAcceptsInherit,
                                             ref bool? aConsumedTokens)
        {
          // border-image-slice: initial | [<number>|<percentage>]{1,4} && fill?
          var value = new nsCSSValue();
        
          if (aConsumedTokens != null) {
            aConsumedTokens = true;
          }
        
          if (aAcceptsInherit && ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // Keyword "inherit" can not be mixed, so we are done.
            AppendValue(nsCSSProperty.BorderImageSlice, value);
            return true;
          }
        
          // Try parsing "fill" value.
          var imageSliceFillValue = new nsCSSValue();
          bool hasFill = ParseEnum(ref imageSliceFillValue,
                                   nsCSSProps.kBorderImageSliceKTable);
        
          // Parse the box dimensions.
          var imageSliceBoxValue = new nsCSSValue();
          if (!ParseGroupedBoxProperty(VARIANT_PN, ref imageSliceBoxValue)) {
            if (!hasFill && aConsumedTokens != null) {
              aConsumedTokens = false;
            }
        
            return false;
          }
        
          // Try parsing "fill" keyword again if the first time failed because keyword
          // and slice dimensions can be in any order.
          if (!hasFill) {
            hasFill = ParseEnum(ref imageSliceFillValue,
                                nsCSSProps.kBorderImageSliceKTable);
          }
        
          nsCSSValueList borderImageSlice = value.SetListValue();
          // Put the box value into the list.
          borderImageSlice.mValue = imageSliceBoxValue;
        
          if (hasFill) {
            // Put the "fill" value into the list.
            borderImageSlice.mNext = new nsCSSValueList();
            borderImageSlice.mNext.mValue = imageSliceFillValue;
          }
        
          AppendValue(nsCSSProperty.BorderImageSlice, value);
          return true;
        }
        
        internal bool ParseBorderImageWidth(bool aAcceptsInherit)
        {
          // border-image-width: initial | [<length>|<number>|<percentage>|auto]{1,4}
          var value = new nsCSSValue();
        
          if (aAcceptsInherit && ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // Keyword "inherit" can no be mixed, so we are done.
            AppendValue(nsCSSProperty.BorderImageWidth, value);
            return true;
          }
        
          // Parse the box dimensions.
          if (!ParseGroupedBoxProperty(VARIANT_ALPN, ref value)) {
            return false;
          }
        
          AppendValue(nsCSSProperty.BorderImageWidth, value);
          return true;
        }
        
        internal bool ParseBorderImageOutset(bool aAcceptsInherit)
        {
          // border-image-outset: initial | [<length>|<number>]{1,4}
          var value = new nsCSSValue();
        
          if (aAcceptsInherit && ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // Keyword "inherit" can not be mixed, so we are done.
            AppendValue(nsCSSProperty.BorderImageOutset, value);
            return true;
          }
        
          // Parse the box dimensions.
          if (!ParseGroupedBoxProperty(VARIANT_LN, ref value)) {
            return false;
          }
        
          AppendValue(nsCSSProperty.BorderImageOutset, value);
          return true;
        }
        
        internal bool ParseBorderImageRepeat(bool aAcceptsInherit)
        {
          var value = new nsCSSValue();
          if (aAcceptsInherit && ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // Keyword "inherit" can not be mixed, so we are done.
            AppendValue(nsCSSProperty.BorderImageRepeat, value);
            return true;
          }
        
          var result = new nsCSSValuePair();
          if (!ParseEnum(ref result.mXValue, nsCSSProps.kBorderImageRepeatKTable)) {
            return false;
          }
        
          // optional second keyword, defaults to first
          if (!ParseEnum(ref result.mYValue, nsCSSProps.kBorderImageRepeatKTable)) {
            result.mYValue = result.mXValue;
          }
        
          value.SetPairValue(result);
          AppendValue(nsCSSProperty.BorderImageRepeat, value);
          return true;
        }
        
        internal bool ParseBorderImage()
        {
          using (/*var compound = */new nsAutoParseCompoundProperty(this)) {  
          
            // border-image: inherit | initial |
            // <border-image-source> ||
            // <border-image-slice>
            //   [ / <border-image-width> |
            //     / <border-image-width>? / <border-image-outset> ]? ||
            // <border-image-repeat>
          
            var value = new nsCSSValue();
            if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
              AppendValue(nsCSSProperty.BorderImageSource, value);
              AppendValue(nsCSSProperty.BorderImageSlice, value);
              AppendValue(nsCSSProperty.BorderImageWidth, value);
              AppendValue(nsCSSProperty.BorderImageOutset, value);
              AppendValue(nsCSSProperty.BorderImageRepeat, value);
              // Keyword "inherit" (and "initial") can't be mixed, so we are done.
              return true;
            }
          
            // No empty property.
            if (CheckEndProperty()) {
              return false;
            }
          
            // Shorthand properties are required to set everything they can.
            SetBorderImageInitialValues();
          
            bool foundSource = false;
            bool foundSliceWidthOutset = false;
            bool foundRepeat = false;
          
            // This loop is used to handle the parsing of border-image properties which
            // can appear in any order.
            var imageSourceValue = new nsCSSValue();
            while (!CheckEndProperty()) {
              // <border-image-source>
              if (!foundSource && ParseVariant(ref imageSourceValue, VARIANT_UO, null)) {
                AppendValue(nsCSSProperty.BorderImageSource, imageSourceValue);
                foundSource = true;
                continue;
              }
          
              // <border-image-slice>
              // ParseBorderImageSlice is weird.  It may consume tokens and then return
              // false, because it parses a property with two required components that
              // can appear in either order.  Since the tokens that were consumed cannot
              // parse as anything else we care about, this isn't a problem.
              if (!foundSliceWidthOutset) {
                bool? sliceConsumedTokens = false;
                if (ParseBorderImageSlice(false, ref sliceConsumedTokens)) {
                  foundSliceWidthOutset = true;
          
                  // [ / <border-image-width>?
                  if (ExpectSymbol('/', true)) {
                    bool foundBorderImageWidth = ParseBorderImageWidth(false);
          
                    // [ / <border-image-outset>
                    if (ExpectSymbol('/', true)) {
                      if (!ParseBorderImageOutset(false)) {
                        return false;
                      }
                    } else if (!foundBorderImageWidth) {
                      // If this part has an trailing slash, the whole declaration is 
                      // invalid.
                      return false;
                    }
                  }
          
                  continue;
                } else {
                  // If we consumed some tokens for <border-image-slice> but did not
                  // successfully parse it, we have an error.
                  if (sliceConsumedTokens != null) {
                    return false;
                  }
                }
              }
          
              // <border-image-repeat>
              if (!foundRepeat && ParseBorderImageRepeat(false)) {
                foundRepeat = true;
                continue;
              }
          
              return false;
            }
          
            return true;
          }
        }
        
        internal bool ParseBorderSpacing()
        {
          nsCSSValue xValue = new nsCSSValue(), yValue = new nsCSSValue();
          if (!ParseNonNegativeVariant(ref xValue, VARIANT_HL | VARIANT_CALC, null)) {
            return false;
          }
        
          // If we have one length, get the optional second length.
          // set the second value equal to the first.
          if (xValue.IsLengthUnit() || xValue.IsCalcUnit()) {
            ParseNonNegativeVariant(ref yValue, VARIANT_LENGTH | VARIANT_CALC, null);
          }
        
          if (!ExpectEndProperty()) {
            return false;
          }
        
          if (yValue == xValue || yValue.GetUnit() == nsCSSUnit.Null) {
            AppendValue(nsCSSProperty.BorderSpacing, xValue);
          } else {
            var pair = new nsCSSValue();
            pair.SetPairValue(xValue, yValue);
            AppendValue(nsCSSProperty.BorderSpacing, pair);
          }
          return true;
        }
        
        internal bool ParseBorderSide(nsCSSProperty[] aPropIDs,
                                       bool aSetAllSides)
        {
          uint32_t numProps = 3;
          var values = new nsCSSValue[numProps];
        
          int32_t found = ParseChoice(ref values, aPropIDs, numProps);
          if ((found < 1) || (false == ExpectEndProperty())) {
            return false;
          }
        
          if ((found & 1) == 0) { // Provide default border-width
            values[0].SetIntValue(nsStyle.BORDER_WIDTH_MEDIUM, nsCSSUnit.Enumerated);
          }
          if ((found & 2) == 0) { // Provide default border-style
            values[1].SetIntValue(nsStyle.BORDER_STYLE_NONE, nsCSSUnit.Enumerated);
          }
          if ((found & 4) == 0) { // text color will be used
            values[2].SetIntValue(nsStyle.COLOR_MOZ_USE_TEXT_COLOR, nsCSSUnit.Enumerated);
          }
        
          if (aSetAllSides) {
            /*TODO: static*/ nsCSSProperty[] kBorderSources = {
              nsCSSProperty.BorderLeftColorLtrSource,
              nsCSSProperty.BorderLeftColorRtlSource,
              nsCSSProperty.BorderRightColorLtrSource,
              nsCSSProperty.BorderRightColorRtlSource,
              nsCSSProperty.BorderLeftStyleLtrSource,
              nsCSSProperty.BorderLeftStyleRtlSource,
              nsCSSProperty.BorderRightStyleLtrSource,
              nsCSSProperty.BorderRightStyleRtlSource,
              nsCSSProperty.BorderLeftWidthLtrSource,
              nsCSSProperty.BorderLeftWidthRtlSource,
              nsCSSProperty.BorderRightWidthLtrSource,
              nsCSSProperty.BorderRightWidthRtlSource,
              nsCSSProperty.Unknown
            };
        
            InitBoxPropsAsPhysical(kBorderSources);
        
            // Parsing "border" shorthand; set all four sides to the same thing
            for (int32_t index = 0; index < 4; index++) {
              Debug.Assert(numProps == 3, "This code needs updating");
              AppendValue(kBorderWidthIDs[index], values[0]);
              AppendValue(kBorderStyleIDs[index], values[1]);
              AppendValue(kBorderColorIDs[index], values[2]);
            }
        
            /*TODO: static*/ nsCSSProperty[] kBorderColorsProps = {
              nsCSSProperty.BorderTopColors,
              nsCSSProperty.BorderRightColors,
              nsCSSProperty.BorderBottomColors,
              nsCSSProperty.BorderLeftColors
            };
        
            // Set the other properties that the border shorthand sets to their
            // initial values.
            var extraValue = new nsCSSValue();
            switch (values[0].GetUnit()) {
            case nsCSSUnit.Inherit:
            case nsCSSUnit.Initial:
              extraValue = values[0];
              // Set value of border-image properties to initial/inherit
              AppendValue(nsCSSProperty.BorderImageSource, extraValue);
              AppendValue(nsCSSProperty.BorderImageSlice, extraValue);
              AppendValue(nsCSSProperty.BorderImageWidth, extraValue);
              AppendValue(nsCSSProperty.BorderImageOutset, extraValue);
              AppendValue(nsCSSProperty.BorderImageRepeat, extraValue);
              break;
            default:
              extraValue.SetNoneValue();
              SetBorderImageInitialValues();
              break;
            }
            for (Side side = nsStyle.SIDE_TOP; side <= nsStyle.SIDE_LEFT; side++) {
              AppendValue(kBorderColorsProps[(int)side], extraValue);
            }
          }
          else {
            // Just set our one side
            for (int32_t index = 0; index < numProps; index++) {
              AppendValue(aPropIDs[(int)index], values[index]);
            }
          }
          return true;
        }
        
        internal bool ParseDirectionalBorderSide(nsCSSProperty[] aPropIDs,
                                                  int32_t aSourceType)
        {
          uint32_t numProps = 3;
          var values = new nsCSSValue[numProps];
        
          int32_t found = ParseChoice(ref values, aPropIDs, numProps);
          if ((found < 1) || (false == ExpectEndProperty())) {
            return false;
          }
        
          if ((found & 1) == 0) { // Provide default border-width
            values[0].SetIntValue(nsStyle.BORDER_WIDTH_MEDIUM, nsCSSUnit.Enumerated);
          }
          if ((found & 2) == 0) { // Provide default border-style
            values[1].SetIntValue(nsStyle.BORDER_STYLE_NONE, nsCSSUnit.Enumerated);
          }
          if ((found & 4) == 0) { // text color will be used
            values[2].SetIntValue(nsStyle.COLOR_MOZ_USE_TEXT_COLOR, nsCSSUnit.Enumerated);
          }
          for (int32_t index = 0; index < numProps; index++) {
            nsCSSProperty[] subprops =
              nsCSSProps.SubpropertyEntryFor(aPropIDs[index + numProps]);
            Debug.Assert(subprops[3] == nsCSSProperty.Unknown,
                         "not box property with physical vs. logical cascading");
            AppendValue(subprops[0], values[index]);
            var typeVal = new nsCSSValue(aSourceType, nsCSSUnit.Enumerated);
            AppendValue(subprops[1], typeVal);
            AppendValue(subprops[2], typeVal);
          }
          return true;
        }
        
        internal bool ParseBorderStyle()
        {
          /*TODO: static*/ nsCSSProperty[] kBorderStyleSources = {
            nsCSSProperty.BorderLeftStyleLtrSource,
            nsCSSProperty.BorderLeftStyleRtlSource,
            nsCSSProperty.BorderRightStyleLtrSource,
            nsCSSProperty.BorderRightStyleRtlSource,
            nsCSSProperty.Unknown
          };
        
          // do this now, in case 4 values weren't specified
          InitBoxPropsAsPhysical(kBorderStyleSources);
          return ParseBoxProperties(kBorderStyleIDs);
        }
        
        internal bool ParseBorderWidth()
        {
          /*TODO: static*/ nsCSSProperty[] kBorderWidthSources = {
            nsCSSProperty.BorderLeftWidthLtrSource,
            nsCSSProperty.BorderLeftWidthRtlSource,
            nsCSSProperty.BorderRightWidthLtrSource,
            nsCSSProperty.BorderRightWidthRtlSource,
            nsCSSProperty.Unknown
          };
        
          // do this now, in case 4 values weren't specified
          InitBoxPropsAsPhysical(kBorderWidthSources);
          return ParseBoxProperties(kBorderWidthIDs);
        }
        
        internal bool ParseBorderColors(nsCSSProperty aProperty)
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT | VARIANT_NONE, null)) {
            // 'inherit', 'initial', and 'none' are only allowed on their own
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              if (!ParseVariant(ref cur.mValue, VARIANT_COLOR | VARIANT_KEYWORD,
                                nsCSSProps.kBorderColorKTable)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(aProperty, value);
          return true;
        }
        
        // Parse the top level of a calc() expression.
        internal bool ParseCalc(ref nsCSSValue aValue, int32_t aVariantMask)
        {
          // Parsing calc expressions requires, in a number of cases, looking
          // for a token that is *either* a value of the property or a number.
          // This can be done without lookahead when we assume that the property
          // values cannot themselves be numbers.
          Debug.Assert(!((aVariantMask & VARIANT_NUMBER) != 0), "unexpected variant mask");
          Debug.Assert(aVariantMask != 0, "unexpected variant mask");
        
          bool oldUnitlessLengthQuirk = mUnitlessLengthQuirk;
          mUnitlessLengthQuirk = false;
        
          // One-iteration loop so we can break to the error-handling case.
          do {
            // The toplevel of a calc() is always an nsCSSValue[] of length 1.
            nsCSSValue[] arr = new nsCSSValue[1];
        
            if (!ParseCalcAdditiveExpression(ref arr[0], ref aVariantMask))
              break;
        
            if (!ExpectSymbol(')', true))
              break;
        
            aValue.SetArrayValue(arr, nsCSSUnit.Calc);
            mUnitlessLengthQuirk = oldUnitlessLengthQuirk;
            return true;
          } while (false);
        
          SkipUntil(')');
          mUnitlessLengthQuirk = oldUnitlessLengthQuirk;
          return false;
        }
        
        // We optimize away the <value-expression> production given that
        // ParseVariant consumes initial whitespace and we call
        // ExpectSymbol(')') with true for aSkipWS.
        //  * If aVariantMask is VARIANT_NUMBER, this function parses the
        //    <number-additive-expression> production.
        //  * If aVariantMask does not contain VARIANT_NUMBER, this function
        //    parses the <value-additive-expression> production.
        //  * Otherwise (VARIANT_NUMBER and other bits) this function parses
        //    whichever one of the productions matches ***and modifies
        //    aVariantMask*** to reflect which one it has parsed by either
        //    removing VARIANT_NUMBER or removing all other bits.
        // It does so iteratively, but builds the correct recursive
        // data structure.
        internal bool ParseCalcAdditiveExpression(ref nsCSSValue aValue,
                                                   ref int32_t aVariantMask)
        {
          Debug.Assert(aVariantMask != 0, "unexpected variant mask");
          nsCSSValue storage = aValue;
          for (;;) {
            bool haveWS = false;
            if (!ParseCalcMultiplicativeExpression(ref storage, ref aVariantMask, ref haveWS))
              return false;
        
            if (!haveWS || !GetToken(false))
              return true;
            nsCSSUnit unit = 0;
            if (mToken.IsSymbol('+')) {
              unit = nsCSSUnit.CalcPlus;
            } else if (mToken.IsSymbol('-')) {
              unit = nsCSSUnit.CalcMinus;
            } else {
              UngetToken();
              return true;
            }
            if (!RequireWhitespace())
              return false;
        
            nsCSSValue[] arr = new nsCSSValue[2];
            arr[0] = aValue;
            storage = arr[1];
            aValue.SetArrayValue(arr, unit);
          }
        }
        
        //  * If aVariantMask is VARIANT_NUMBER, this function parses the
        //    <number-multiplicative-expression> production.
        //  * If aVariantMask does not contain VARIANT_NUMBER, this function
        //    parses the <value-multiplicative-expression> production.
        //  * Otherwise (VARIANT_NUMBER and other bits) this function parses
        //    whichever one of the productions matches ***and modifies
        //    aVariantMask*** to reflect which one it has parsed by either
        //    removing VARIANT_NUMBER or removing all other bits.
        // It does so iteratively, but builds the correct recursive data
        // structure.
        // This function always consumes *trailing* whitespace when it returns
        // true; whether there was any such whitespace is returned in the
        // aHadFinalWS parameter.
        internal bool ParseCalcMultiplicativeExpression(ref nsCSSValue aValue,
                                                         ref int32_t aVariantMask,
                                                         ref bool aHadFinalWS)
        {
          Debug.Assert(aVariantMask != 0, "unexpected variant mask");
          bool gotValue = false; // already got the part with the unit
          bool afterDivision = false;
        
          nsCSSValue storage = aValue;
          for (;;) {
            int32_t variantMask = 0;
            if (afterDivision || gotValue) {
              variantMask = VARIANT_NUMBER;
            } else {
              variantMask = aVariantMask | VARIANT_NUMBER;
            }
            if (!ParseCalcTerm(ref storage, ref variantMask))
              return false;
            Debug.Assert(variantMask != 0,
                              "ParseCalcTerm did not set variantMask appropriately");
            
        
            if ((variantMask & VARIANT_NUMBER) != 0) {
              // Simplify the value immediately so we can check for division by
              // zero.
              var ops = new ReduceNumberCalcOps();
              float number = CommonUtil.ComputeCalc(storage, ops);
              if (number == 0.0 && afterDivision)
                return false;
              storage.SetFloatValue(number, nsCSSUnit.Number);
            } else {
              gotValue = true;
        
              if (storage != aValue) {
                // Simplify any numbers in the Times_L position (which are
                // not simplified by the check above).
                Debug.Assert(storage == aValue.GetArrayValue().Item(1),
                                  "unexpected relationship to current storage");
                nsCSSValue leftValue = aValue.GetArrayValue().Item(0);
                var ops = new ReduceNumberCalcOps();
                float number = CommonUtil.ComputeCalc(leftValue, ops);
                leftValue.SetFloatValue(number, nsCSSUnit.Number);
              }
            }
        
            bool hadWS = RequireWhitespace();
            if (!GetToken(false)) {
              aHadFinalWS = hadWS;
              break;
            }
            nsCSSUnit unit = 0;
            if (mToken.IsSymbol('*')) {
              unit = gotValue ? nsCSSUnit.CalcTimesR : nsCSSUnit.CalcTimesL;
              afterDivision = false;
            } else if (mToken.IsSymbol('/')) {
              unit = nsCSSUnit.CalcDivided;
              afterDivision = true;
            } else {
              UngetToken();
              aHadFinalWS = hadWS;
              break;
            }
        
            nsCSSValue[] arr = new nsCSSValue[2];
            arr[0] = aValue;
            storage = arr[1];
            aValue.SetArrayValue(arr, unit);
          }
        
          // Adjust aVariantMask (see comments above function) to reflect which
          // option we took.
          if ((aVariantMask & VARIANT_NUMBER) != 0) {
            if (gotValue) {
              aVariantMask &= ~((int32_t)(VARIANT_NUMBER));
            } else {
              aVariantMask = VARIANT_NUMBER;
            }
          } else {
            if (!gotValue) {
              // We had to find a value, but we didn't.
              return false;
            }
          }
        
          return true;
        }
        
        //  * If aVariantMask is VARIANT_NUMBER, this function parses the
        //    <number-term> production.
        //  * If aVariantMask does not contain VARIANT_NUMBER, this function
        //    parses the <value-term> production.
        //  * Otherwise (VARIANT_NUMBER and other bits) this function parses
        //    whichever one of the productions matches ***and modifies
        //    aVariantMask*** to reflect which one it has parsed by either
        //    removing VARIANT_NUMBER or removing all other bits.
        internal bool ParseCalcTerm(ref nsCSSValue aValue, ref int32_t aVariantMask)
        {
          Debug.Assert(aVariantMask != 0, "unexpected variant mask");
          if (!GetToken(true))
            return false;
          // Either an additive expression in parentheses...
          if (mToken.IsSymbol('(')) {
            if (!ParseCalcAdditiveExpression(ref aValue, ref aVariantMask) ||
                !ExpectSymbol(')', true)) {
              SkipUntil(')');
              return false;
            }
            return true;
          }
          // ... or just a value
          UngetToken();
          // Always pass VARIANT_NUMBER to ParseVariant so that unitless zero
          // always gets picked up 
          if (!ParseVariant(ref aValue, aVariantMask | VARIANT_NUMBER, null)) {
            return false;
          }
          // ...and do the VARIANT_NUMBER check ourselves.
          if (!((aVariantMask & VARIANT_NUMBER) != 0) && aValue.GetUnit() == nsCSSUnit.Number) {
            return false;
          }
          // If we did the value parsing, we need to adjust aVariantMask to
          // reflect which option we took (see above).
          if ((aVariantMask & VARIANT_NUMBER) != 0) {
            if (aValue.GetUnit() == nsCSSUnit.Number) {
              aVariantMask = VARIANT_NUMBER;
            } else {
              aVariantMask &= ~((int32_t)(VARIANT_NUMBER));
            }
          }
          return true;
        }
        
        // This function consumes all consecutive whitespace and returns whether
        // there was any.
        internal bool RequireWhitespace()
        {
          if (!GetToken(false))
            return false;
          if (mToken.mType != nsCSSTokenType.Whitespace) {
            UngetToken();
            return false;
          }
          // Skip any additional whitespace tokens.
          if (GetToken(true)) {
            UngetToken();
          }
          return true;
        }
        
        internal bool ParseRect(nsCSSProperty aPropID)
        {
          if (! GetToken(true)) {
            return false;
          }
        
          var val = new nsCSSValue();
        
          if (mToken.mType == nsCSSTokenType.Ident) {
            nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(mToken.mIdentStr);
            switch (keyword) {
              case nsCSSKeyword.Auto:
                if (!ExpectEndProperty()) {
                  return false;
                }
                val.SetAutoValue();
                break;
              case nsCSSKeyword.Inherit:
                if (!ExpectEndProperty()) {
                  return false;
                }
                val.SetInheritValue();
                break;
              case nsCSSKeyword.Initial:
              case nsCSSKeyword.MozInitial:
                if (!ExpectEndProperty()) {
                  return false;
                }
                val.SetInitialValue();
                break;
              default:
                UngetToken();
                return false;
            }
          } else if (mToken.mType == nsCSSTokenType.Function &&
                     mToken.mIdentStr.LowerCaseEqualsLiteral("rect")) {
            nsCSSRect rect = val.SetRectValue();
            bool useCommas = false;
            for (Side side = nsStyle.SIDE_TOP; side <= nsStyle.SIDE_LEFT; side++) {
              if (! ParseVariant(rect.GetSide(side), v => rect.SetSide(side, v),
                                 VARIANT_AL, null)) {
                return false;
              }
              if (side == 0) {
                useCommas = ExpectSymbol(',', true);
              } else if (useCommas && (int)side < 3) {
                // Skip optional commas between elements, but only if the first
                // separator was a comma.
                if (!ExpectSymbol(',', true)) {
                  return false;
                }
              }
            }
            if (!ExpectSymbol(')', true)) {
              return false;
            }
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            UngetToken();
            return false;
          }
        
          AppendValue(aPropID, val);
          return true;
        }
        
        internal bool ParseColumns()
        {
          // We use a similar "fake value" hack to ParseListStyle, because
          // "auto" is acceptable for both column-count and column-width.
          // If the fake "auto" value is found, and one of the real values isn't,
          // that means the fake auto value is meant for the real value we didn't
          // find.
          /*TODO: static*/ nsCSSProperty[] columnIDs = {
            nsCSSProperty.ExtraXAutoValue,
            nsCSSProperty.MozColumnCount,
            nsCSSProperty.MozColumnWidth
          };
          uint32_t numProps = columnIDs.Length;
        
          var values = new nsCSSValue[numProps];
          int32_t found = ParseChoice(ref values, columnIDs, numProps);
          if (found < 1 || !ExpectEndProperty()) {
            return false;
          }
          if ((found & (1|2|4)) == (1|2|4) &&
              values[0].GetUnit() ==  nsCSSUnit.Auto) {
            // We filled all 3 values, which is invalid
            return false;
          }
        
          if ((found & 2) == 0) {
            // Provide auto column-count
            values[1].SetAutoValue();
          }
          if ((found & 4) == 0) {
            // Provide auto column-width
            values[2].SetAutoValue();
          }
        
          // Start at index 1 to skip the fake auto value.
          for (int32_t index = 1; index < numProps; index++) {
            AppendValue(columnIDs[index], values[index]);
          }
          return true;
        }
        
        internal bool ParseContent()
        {
          // We need to divide the 'content' keywords into two classes for
          // ParseVariant's sake, so we can't just use nsCSSProps.kContentKTable.
          /*TODO: static*/ int32_t[] kContentListKWs = {
            (int32_t)nsCSSKeyword.OpenQuote, nsStyle.CONTENT_OPEN_QUOTE,
            (int32_t)nsCSSKeyword.CloseQuote, nsStyle.CONTENT_CLOSE_QUOTE,
            (int32_t)nsCSSKeyword.NoOpenQuote, nsStyle.CONTENT_NO_OPEN_QUOTE,
            (int32_t)nsCSSKeyword.NoCloseQuote, nsStyle.CONTENT_NO_CLOSE_QUOTE,
            (int32_t)nsCSSKeyword.Unknown,-1
          };
        
          /*TODO: static*/ int32_t[] kContentSolitaryKWs = {
            (int32_t)nsCSSKeyword.MozAltContent, nsStyle.CONTENT_ALT_CONTENT,
            (int32_t)nsCSSKeyword.Unknown,-1
          };
        
          // Verify that these two lists add up to the size of
          // nsCSSProps.kContentKTable.
          
        
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_HMK | VARIANT_NONE,
                           kContentSolitaryKWs)) {
            // 'inherit', 'initial', 'normal', 'none', and 'alt-content' must be alone
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              if (!ParseVariant(ref cur.mValue, VARIANT_CONTENT, kContentListKWs)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(nsCSSProperty.Content, value);
          return true;
        }
        
        internal bool ParseCounterData(nsCSSProperty aPropID)
        {
          var value = new nsCSSValue();
          if (!ParseVariant(ref value, VARIANT_INHERIT | VARIANT_NONE, null)) {
            if (!GetToken(true) || mToken.mType != nsCSSTokenType.Ident) {
              return false;
            }
        
            nsCSSValuePairList cur = value.SetPairListValue();
            for (;;) {
              cur.mXValue.SetStringValue(mToken.mIdentStr, nsCSSUnit.Ident);
              if (!GetToken(true)) {
                break;
              }
              if (mToken.mType == nsCSSTokenType.Number && mToken.mIntegerValid) {
                cur.mYValue.SetIntValue(mToken.mInteger, nsCSSUnit.Integer);
              } else {
                UngetToken();
              }
              if (CheckEndProperty()) {
                break;
              }
              if (!GetToken(true) || mToken.mType != nsCSSTokenType.Ident) {
                return false;
              }
              cur.mNext = new nsCSSValuePairList();
              cur = cur.mNext;
            }
          }
          AppendValue(aPropID, value);
          return true;
        }
        
        internal bool ParseCursor()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT, null)) {
            // 'inherit' and 'initial' must be alone
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              if (!ParseVariant(ref cur.mValue, VARIANT_UK, nsCSSProps.kCursorKTable)) {
                return false;
              }
              if (cur.mValue.GetUnit() != nsCSSUnit.Url) { // keyword must be last
                if (ExpectEndProperty()) {
                  break;
                }
                return false;
              }
        
              // We have a URL, so make a value array with three values.
              nsCSSValue[] val = new nsCSSValue[3];
              val[0] = cur.mValue;
        
              // Parse optional x and y position of cursor hotspot (css3-ui).
              if (ParseVariant(ref val[1], VARIANT_NUMBER, null)) {
                // If we have one number, we must have two.
                if (!ParseVariant(ref val[2], VARIANT_NUMBER, null)) {
                  return false;
                }
              }
              cur.mValue.SetArrayValue(val, nsCSSUnit.Array);
        
              if (!ExpectSymbol(',', true)) { // url must not be last
                return false;
              }
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(nsCSSProperty.Cursor, value);
          return true;
        }
        
        internal bool ParseFont()
        {
          /*TODO: static*/ nsCSSProperty[] fontIDs = {
            nsCSSProperty.FontStyle,
            nsCSSProperty.FontVariant,
            nsCSSProperty.FontWeight
          };
        
          var family = new nsCSSValue();
          if (ParseVariant(ref family, VARIANT_HK, nsCSSProps.kFontKTable)) {
            if (ExpectEndProperty()) {
              if (nsCSSUnit.Inherit == family.GetUnit() ||
                  nsCSSUnit.Initial == family.GetUnit()) {
                AppendValue(nsCSSProperty.XSystemFont, new nsCSSValue(nsCSSUnit.None));
                AppendValue(nsCSSProperty.FontFamily, family);
                AppendValue(nsCSSProperty.FontStyle, family);
                AppendValue(nsCSSProperty.FontVariant, family);
                AppendValue(nsCSSProperty.FontWeight, family);
                AppendValue(nsCSSProperty.FontSize, family);
                AppendValue(nsCSSProperty.LineHeight, family);
                AppendValue(nsCSSProperty.FontStretch, family);
                AppendValue(nsCSSProperty.FontSizeAdjust, family);
                AppendValue(nsCSSProperty.FontFeatureSettings, family);
                AppendValue(nsCSSProperty.FontLanguageOverride, family);
              }
              else {
                AppendValue(nsCSSProperty.XSystemFont, family);
                var systemFont = new nsCSSValue(nsCSSUnit.SystemFont);
                AppendValue(nsCSSProperty.FontFamily, systemFont);
                AppendValue(nsCSSProperty.FontStyle, systemFont);
                AppendValue(nsCSSProperty.FontVariant, systemFont);
                AppendValue(nsCSSProperty.FontWeight, systemFont);
                AppendValue(nsCSSProperty.FontSize, systemFont);
                AppendValue(nsCSSProperty.LineHeight, systemFont);
                AppendValue(nsCSSProperty.FontStretch, systemFont);
                AppendValue(nsCSSProperty.FontSizeAdjust, systemFont);
                AppendValue(nsCSSProperty.FontFeatureSettings, systemFont);
                AppendValue(nsCSSProperty.FontLanguageOverride, systemFont);
              }
              return true;
            }
            return false;
          }
        
          // Get optional font-style, font-variant and font-weight (in any order)
          uint32_t numProps = 3;
          var values = new nsCSSValue[numProps];
          int32_t found = ParseChoice(ref values, fontIDs, numProps);
          if ((found < 0) || (nsCSSUnit.Inherit == values[0].GetUnit()) ||
              (nsCSSUnit.Initial == values[0].GetUnit())) { // illegal data
            return false;
          }
          if ((found & 1) == 0) {
            // Provide default font-style
            values[0].SetIntValue(nsFont.STYLE_NORMAL, nsCSSUnit.Enumerated);
          }
          if ((found & 2) == 0) {
            // Provide default font-variant
            values[1].SetIntValue(nsFont.VARIANT_NORMAL, nsCSSUnit.Enumerated);
          }
          if ((found & 4) == 0) {
            // Provide default font-weight
            values[2].SetIntValue(nsFont.WEIGHT_NORMAL, nsCSSUnit.Enumerated);
          }
        
          // Get mandatory font-size
          var size = new nsCSSValue();
          if (! ParseVariant(ref size, VARIANT_KEYWORD | VARIANT_LP, nsCSSProps.kFontSizeKTable)) {
            return false;
          }
        
          // Get optional "/" line-height
          var lineHeight = new nsCSSValue();
          if (ExpectSymbol('/', true)) {
            if (! ParseNonNegativeVariant(ref lineHeight,
                                          VARIANT_NUMBER | VARIANT_LP | VARIANT_NORMAL,
                                          null)) {
              return false;
            }
          }
          else {
            lineHeight.SetNormalValue();
          }
        
          // Get final mandatory font-family
          using (/*var compound = */new nsAutoParseCompoundProperty(this)) {  
            if (ParseFamily(ref family)) {
              if ((nsCSSUnit.Inherit != family.GetUnit()) && (nsCSSUnit.Initial != family.GetUnit()) &&
                  ExpectEndProperty()) {
                AppendValue(nsCSSProperty.XSystemFont, new nsCSSValue(nsCSSUnit.None));
                AppendValue(nsCSSProperty.FontFamily, family);
                AppendValue(nsCSSProperty.FontStyle, values[0]);
                AppendValue(nsCSSProperty.FontVariant, values[1]);
                AppendValue(nsCSSProperty.FontWeight, values[2]);
                AppendValue(nsCSSProperty.FontSize, size);
                AppendValue(nsCSSProperty.LineHeight, lineHeight);
                AppendValue(nsCSSProperty.FontStretch,
                            new nsCSSValue(nsFont.STRETCH_NORMAL, nsCSSUnit.Enumerated));
                AppendValue(nsCSSProperty.FontSizeAdjust, new nsCSSValue(nsCSSUnit.None));
                AppendValue(nsCSSProperty.FontFeatureSettings, new nsCSSValue(nsCSSUnit.Normal));
                AppendValue(nsCSSProperty.FontLanguageOverride, new nsCSSValue(nsCSSUnit.Normal));
                return true;
              }
            }
            return false;
          }
        }
        
        internal bool ParseFontWeight(ref nsCSSValue aValue)
        {
          if (ParseVariant(ref aValue, VARIANT_HKI | VARIANT_SYSFONT,
                           nsCSSProps.kFontWeightKTable)) {
            if (nsCSSUnit.Integer == aValue.GetUnit()) { // ensure unit value
              int32_t intValue = aValue.GetIntValue();
              if ((100 <= intValue) &&
                  (intValue <= 900) &&
                  (0 == (intValue % 100))) {
                return true;
              } else {
                UngetToken();
                return false;
              }
            }
            return true;
          }
          return false;
        }
        
        internal bool ParseOneFamily(StringBuilder aFamily, ref bool aOneKeyword)
        {
          if (!GetToken(true))
            return false;
        
          nsCSSToken tk = mToken;
        
          aOneKeyword = false;
          if (nsCSSTokenType.Ident == tk.mType) {
            aOneKeyword = true;
            aFamily.Append(tk.mIdentStr);
            for (;;) {
              if (!GetToken(false))
                break;
        
              if (nsCSSTokenType.Ident == tk.mType) {
                aOneKeyword = false;
                aFamily.Append(tk.mIdentStr);
              } else if (nsCSSTokenType.Whitespace == tk.mType) {
                // Lookahead one token and drop whitespace if we are ending the
                // font name.
                if (!GetToken(true))
                  break;
        
                UngetToken();
                if (nsCSSTokenType.Ident == tk.mType)
                  aFamily.Append(' ');
                else
                  break;
              } else {
                UngetToken();
                break;
              }
            }
            return true;
        
          } else if (nsCSSTokenType.String == tk.mType) {
            aFamily.Append(tk.mSymbol); // replace the quotes
            aFamily.Append(tk.mIdentStr); // XXX What if it had escaped quotes?
            aFamily.Append(tk.mSymbol);
            return true;
        
          } else {
            UngetToken();
            return false;
          }
        }
        
        internal bool ParseFamily(ref nsCSSValue aValue)
        {
          var family = new StringBuilder();
          bool single = false;
        
          // keywords only have meaning in the first position
          if (!ParseOneFamily(family, ref single))
            return false;
        
          // check for keywords, but only when keywords appear by themselves
          // i.e. not in compounds such as font-family: default blah;
          if (single) {
            nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(family);
            if (keyword == nsCSSKeyword.Inherit) {
              aValue.SetInheritValue();
              return true;
            }
            // 605231 - don't parse unquoted 'default' reserved keyword
            if (keyword == nsCSSKeyword.Default) {
              return false;
            }
            if (keyword == nsCSSKeyword.MozInitial || keyword == nsCSSKeyword.Initial) {
              aValue.SetInitialValue();
              return true;
            }
            if (keyword == nsCSSKeyword.MozUseSystemFont &&
                !IsParsingCompoundProperty()) {
              aValue.SetSystemFontValue();
              return true;
            }
          }
        
          for (;;) {
            if (!ExpectSymbol(',', true))
              break;
        
            family.Append(',');
        
            var nextFamily = new StringBuilder();
            if (!ParseOneFamily(nextFamily, ref single))
              return false;
        
            // at this point unquoted keywords are not allowed
            // as font family names but can appear within names
            if (single) {
              nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(nextFamily);
              switch (keyword) {
                case nsCSSKeyword.Inherit:
                case nsCSSKeyword.Initial:
                case nsCSSKeyword.Default:
                case nsCSSKeyword.MozInitial:
                case nsCSSKeyword.MozUseSystemFont:
                  return false;
                default:
                  break;
              }
            }
        
            family.Append(nextFamily);
          }
        
          if (family.IsEmpty()) {
            return false;
          }
          aValue.SetStringValue(family, nsCSSUnit.Families);
          return true;
        }
        
        // src: ( uri-src | local-src ) (',' ( uri-src | local-src ) )*
        // uri-src: uri [ 'format(' string ( ',' string )* ')' ]
        // local-src: 'local(' ( string | ident ) ')'
        
        internal bool ParseFontSrc(ref nsCSSValue aValue)
        {
          // could we maybe turn nsCSSValue[] into List<nsCSSValue>?
          var values = new List<nsCSSValue>();
          var cur = new nsCSSValue();
          for (;;) {
            if (!GetToken(true))
              break;
        
            if (mToken.mType == nsCSSTokenType.URL) {
              SetValueToURL(ref cur, mToken.mIdentStr);
              values.AppendElement(cur);
              if (!ParseFontSrcFormat(values))
                return false;
        
            } else if (mToken.mType == nsCSSTokenType.Function &&
                       mToken.mIdentStr.LowerCaseEqualsLiteral("local")) {
              // css3-fonts does not specify a formal grammar for local().
              // The text permits both unquoted identifiers and quoted
              // strings.  We resolve this ambiguity in the spec by
              // assuming that the appropriate production is a single
              // <family-name>, possibly surrounded by whitespace.
        
              var family = new StringBuilder();
              bool single = false;
              if (!ParseOneFamily(family, ref single)) {
                SkipUntil(')');
                return false;
              }
              if (!ExpectSymbol(')', true)) {
                SkipUntil(')');
                return false;
              }
        
              // the style parameters to the nsFont constructor are ignored,
              // because it's only being used to call EnumerateFamilies
              var font = new nsFont(family, 0, 0, 0, 0, 0, 0);
              var dat = new ExtractFirstFamilyData();
        
              font.EnumerateFamilies(ExtractFirstFamily, (object) dat);
              if (!dat.mGood)
                return false;
        
              cur.SetStringValue(dat.mFamilyName, nsCSSUnit.LocalFont);
              values.AppendElement(cur);
            } else {
              // We don't know what to do with this token; unget it and error out
              UngetToken();
              return false;
            }
        
            if (!ExpectSymbol(',', true))
              break;
          }
        
          if (values.Length() == 0)
            return false;
        
          nsCSSValue[] srcVals
            = new nsCSSValue[values.Length()];
        
          uint32_t i = 0;
          for (i = 0; i < values.Length(); i++)
            srcVals[i] = values[i];
          aValue.SetArrayValue(srcVals, nsCSSUnit.Array);
          return true;
        }
        
        internal bool ParseFontSrcFormat(List<nsCSSValue>  values)
        {
          if (!GetToken(true))
            return true; // EOF harmless here
          if (mToken.mType != nsCSSTokenType.Function ||
              !mToken.mIdentStr.LowerCaseEqualsLiteral("format")) {
            UngetToken();
            return true;
          }
        
          do {
            if (!GetToken(true))
              return false; // EOF - no need for SkipUntil
        
            if (mToken.mType != nsCSSTokenType.String) {
              UngetToken();
              SkipUntil(')');
              return false;
            }
        
            var cur = new nsCSSValue(mToken.mIdentStr, nsCSSUnit.FontFormat);
            values.AppendElement(cur);
          } while (ExpectSymbol(',', true));
        
          if (!ExpectSymbol(')', true)) {
            SkipUntil(')');
            return false;
          }
        
          return true;
        }
        
        // font-ranges: urange ( ',' urange )*
        internal bool ParseFontRanges(ref nsCSSValue aValue)
        {
          var ranges = new List<uint32_t>();
          for (;;) {
            if (!GetToken(true))
              break;
        
            if (mToken.mType != nsCSSTokenType.URange) {
              UngetToken();
              break;
            }
        
            // An invalid range token is a parsing error, causing the entire
            // descriptor to be ignored.
            if (!mToken.mIntegerValid)
              return false;
        
            uint32_t low = mToken.mInteger;
            uint32_t high = mToken.mInteger2;
        
            // A range that descends, or a range that is entirely outside the
            // current range of Unicode (U+0-10FFFF) is ignored, but does not
            // invalidate the descriptor.  A range that straddles the high end
            // is clipped.
            if (low <= 0x10FFFF && low <= high) {
              if (high > 0x10FFFF)
                high = 0x10FFFF;
        
              ranges.AppendElement(low);
              ranges.AppendElement(high);
            }
            if (!ExpectSymbol(',', true))
              break;
          }
        
          if (ranges.Length() == 0)
            return false;
        
          nsCSSValue[] srcVals
            = new nsCSSValue[ranges.Length()];
        
          for (uint32_t i = 0; i < ranges.Length(); i++)
            srcVals[i].SetIntValue(ranges[i], nsCSSUnit.Integer);
          aValue.SetArrayValue(srcVals, nsCSSUnit.Array);
          return true;
        }
        
        // font-feature-settings: normal | <feature-tag-value> [, <feature-tag-value>]*
        // <feature-tag-value> = <string> [ <integer> | on | off ]?
        
        // minimum - "tagx", "tagy", "tagz"
        // edge error case - "tagx" on 1, "tagx" "tagy", "tagx" -1, "tagx" big
        
        // pair value is always x = string, y = int
        
        // font feature tags must be four ASCII characters
        
        static bool
        ValidFontFeatureTag(string aTag)
        {
          if (aTag.Length() != FEATURE_TAG_LENGTH) {
            return false;
          }
          uint32_t i = 0;
          for (i = 0; i < FEATURE_TAG_LENGTH; i++) {
            uint32_t ch = aTag[i];
            if (ch < 0x20 || ch > 0x7e) {
              return false;
            }
          }
          return true;
        }
        
        internal bool ParseFontFeatureSettings(ref nsCSSValue aValue)
        {
          if (ParseVariant(ref aValue, VARIANT_INHERIT | VARIANT_NORMAL, null)) {
            return true;
          }
        
          nsCSSValuePairList cur = aValue.SetPairListValue();
          for (;;) {
            // feature tag
            if (!GetToken(true)) {
              return false;
            }
        
            if (mToken.mType != nsCSSTokenType.String ||
                !ValidFontFeatureTag(mToken.mIdentStr)) {
              UngetToken();
              return false;
            }
            cur.mXValue.SetStringValue(mToken.mIdentStr, nsCSSUnit.String);
        
            if (!GetToken(true)) {
              cur.mYValue.SetIntValue(1, nsCSSUnit.Integer);
              break;
            }
        
            // optional value or on/off keyword
            if (mToken.mType == nsCSSTokenType.Number && mToken.mIntegerValid &&
                mToken.mInteger >= 0) {
              cur.mYValue.SetIntValue(mToken.mInteger, nsCSSUnit.Integer);
            } else if (mToken.mType == nsCSSTokenType.Ident &&
                       mToken.mIdentStr.LowerCaseEqualsLiteral("on")) {
              cur.mYValue.SetIntValue(1, nsCSSUnit.Integer);
            } else if (mToken.mType == nsCSSTokenType.Ident &&
                       mToken.mIdentStr.LowerCaseEqualsLiteral("off")) {
              cur.mYValue.SetIntValue(0, nsCSSUnit.Integer);
            } else {
              // something other than value/on/off, set default value
              cur.mYValue.SetIntValue(1, nsCSSUnit.Integer);
              UngetToken();
            }
        
            if (!ExpectSymbol(',', true)) {
              break;
            }
        
            cur.mNext = new nsCSSValuePairList();
            cur = cur.mNext;
          }
        
          return true;
        }
        
        internal bool ParseListStyle()
        {
          // 'list-style' can accept 'none' for two different subproperties,
          // 'list-style-type' and 'list-style-position'.  In order to accept
          // 'none' as the value of either but still allow another value for
          // either, we need to ensure that the first 'none' we find gets
          // allocated to a dummy property instead.
          /*TODO: static*/ nsCSSProperty[] listStyleIDs = {
            nsCSSProperty.ExtraXNoneValue,
            nsCSSProperty.ListStyleType,
            nsCSSProperty.ListStylePosition,
            nsCSSProperty.ListStyleImage
          };
        
          var values = new nsCSSValue[listStyleIDs.Length];
          int32_t found =
            ParseChoice(ref values, listStyleIDs, listStyleIDs.Length);
          if (found < 1 || !ExpectEndProperty()) {
            return false;
          }
        
          if ((found & (1|2|8)) == (1|2|8)) {
            if (values[0].GetUnit() == nsCSSUnit.None) {
              // We found a 'none' plus another value for both of
              // 'list-style-type' and 'list-style-image'.  This is a parse
              // error, since the 'none' has to count for at least one of them.
              return false;
            } else {
              Debug.Assert(found == (1|2|4|8) && values[0] == values[1] &&
                           values[0] == values[2] && values[0] == values[3],
                           "should be a special value");
            }
          }
        
          // Provide default values
          if ((found & 2) == 0) {
            if ((found & 1) != 0) {
              values[1].SetIntValue(nsStyle.LIST_STYLE_NONE, nsCSSUnit.Enumerated);
            } else {
              values[1].SetIntValue(nsStyle.LIST_STYLE_DISC, nsCSSUnit.Enumerated);
            }
          }
          if ((found & 4) == 0) {
            values[2].SetIntValue(nsStyle.LIST_STYLE_POSITION_OUTSIDE,
                                  nsCSSUnit.Enumerated);
          }
          if ((found & 8) == 0) {
            values[3].SetNoneValue();
          }
        
          // Start at 1 to avoid appending fake value.
          for (uint32_t index = 1; index < listStyleIDs.Length; ++index) {
            AppendValue(listStyleIDs[index], values[index]);
          }
          return true;
        }
        
        internal bool ParseMargin()
        {
          /*TODO: static*/ nsCSSProperty[] kMarginSideIDs = {
            nsCSSProperty.MarginTop,
            nsCSSProperty.MarginRightValue,
            nsCSSProperty.MarginBottom,
            nsCSSProperty.MarginLeftValue
          };
          /*TODO: static*/ nsCSSProperty[] kMarginSources = {
            nsCSSProperty.MarginLeftLtrSource,
            nsCSSProperty.MarginLeftRtlSource,
            nsCSSProperty.MarginRightLtrSource,
            nsCSSProperty.MarginRightRtlSource,
            nsCSSProperty.Unknown
          };
        
          // do this now, in case 4 values weren't specified
          InitBoxPropsAsPhysical(kMarginSources);
          return ParseBoxProperties(kMarginSideIDs);
        }
        
        internal bool ParseMarks(ref nsCSSValue aValue)
        {
          if (ParseVariant(ref aValue, VARIANT_HK, nsCSSProps.kPageMarksKTable)) {
            if (nsCSSUnit.Enumerated == aValue.GetUnit()) {
              if (nsStyle.PAGE_MARKS_NONE != aValue.GetIntValue() &&
                  false == CheckEndProperty()) {
                var second = new nsCSSValue();
                if (ParseEnum(ref second, nsCSSProps.kPageMarksKTable)) {
                  // 'none' keyword in conjuction with others is not allowed
                  if (nsStyle.PAGE_MARKS_NONE != second.GetIntValue()) {
                    aValue.SetIntValue(aValue.GetIntValue() | second.GetIntValue(),
                                       nsCSSUnit.Enumerated);
                    return true;
                  }
                }
                return false;
              }
            }
            return true;
          }
          return false;
        }
        
        internal bool ParseOutline()
        {
          uint32_t numProps = 3;
          /*TODO: static*/ nsCSSProperty[] kOutlineIDs = {
            nsCSSProperty.OutlineColor,
            nsCSSProperty.OutlineStyle,
            nsCSSProperty.OutlineWidth
          };
        
          var values = new nsCSSValue[numProps];
          int32_t found = ParseChoice(ref values, kOutlineIDs, numProps);
          if ((found < 1) || (false == ExpectEndProperty())) {
            return false;
          }
        
          // Provide default values
          if ((found & 1) == 0) { // Provide default outline-color
            values[0].SetIntValue(nsStyle.COLOR_MOZ_USE_TEXT_COLOR, nsCSSUnit.Enumerated);
          }
          if ((found & 2) == 0) { // Provide default outline-style
            values[1].SetIntValue(nsStyle.BORDER_STYLE_NONE, nsCSSUnit.Enumerated);
          }
          if ((found & 4) == 0) { // Provide default outline-width
            values[2].SetIntValue(nsStyle.BORDER_WIDTH_MEDIUM, nsCSSUnit.Enumerated);
          }
        
          int32_t index = 0;
          for (index = 0; index < numProps; index++) {
            AppendValue(kOutlineIDs[index], values[index]);
          }
          return true;
        }
        
        internal bool ParseOverflow()
        {
          var overflow = new nsCSSValue();
          if (!ParseVariant(ref overflow, VARIANT_HK,
                            nsCSSProps.kOverflowKTable) ||
              !ExpectEndProperty())
            return false;
        
          var overflowX = new nsCSSValue(overflow);
          var overflowY = new nsCSSValue(overflow);
          if (nsCSSUnit.Enumerated == overflow.GetUnit())
            switch(overflow.GetIntValue()) {
              case nsStyle.OVERFLOW_SCROLLBARS_HORIZONTAL:
                overflowX.SetIntValue(nsStyle.OVERFLOW_SCROLL, nsCSSUnit.Enumerated);
                overflowY.SetIntValue(nsStyle.OVERFLOW_HIDDEN, nsCSSUnit.Enumerated);
                break;
              case nsStyle.OVERFLOW_SCROLLBARS_VERTICAL:
                overflowX.SetIntValue(nsStyle.OVERFLOW_HIDDEN, nsCSSUnit.Enumerated);
                overflowY.SetIntValue(nsStyle.OVERFLOW_SCROLL, nsCSSUnit.Enumerated);
                break;
            }
          AppendValue(nsCSSProperty.OverflowX, overflowX);
          AppendValue(nsCSSProperty.OverflowY, overflowY);
          return true;
        }
        
        internal bool ParsePadding()
        {
          /*TODO: static*/ nsCSSProperty[] kPaddingSideIDs = {
            nsCSSProperty.PaddingTop,
            nsCSSProperty.PaddingRightValue,
            nsCSSProperty.PaddingBottom,
            nsCSSProperty.PaddingLeftValue
          };
          /*TODO: static*/ nsCSSProperty[] kPaddingSources = {
            nsCSSProperty.PaddingLeftLtrSource,
            nsCSSProperty.PaddingLeftRtlSource,
            nsCSSProperty.PaddingRightLtrSource,
            nsCSSProperty.PaddingRightRtlSource,
            nsCSSProperty.Unknown
          };
        
          // do this now, in case 4 values weren't specified
          InitBoxPropsAsPhysical(kPaddingSources);
          return ParseBoxProperties(kPaddingSideIDs);
        }
        
        internal bool ParseQuotes()
        {
          var value = new nsCSSValue();
          if (!ParseVariant(ref value, VARIANT_HOS, null)) {
            return false;
          }
          if (value.GetUnit() != nsCSSUnit.String) {
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValue open = value;
            nsCSSValuePairList quotes = value.SetPairListValue();
            for (;;) {
              quotes.mXValue = open;
              // get mandatory close
              if (!ParseVariant(ref quotes.mYValue, VARIANT_STRING, null)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              // look for another open
              if (!ParseVariant(ref open, VARIANT_STRING, null)) {
                return false;
              }
              quotes.mNext = new nsCSSValuePairList();
              quotes = quotes.mNext;
            }
          }
          AppendValue(nsCSSProperty.Quotes, value);
          return true;
        }
        
        internal bool ParseSize()
        {
          nsCSSValue width = new nsCSSValue(), height = new nsCSSValue();
          if (!ParseVariant(ref width, VARIANT_AHKL, nsCSSProps.kPageSizeKTable)) {
            return false;
          }
          if (width.IsLengthUnit()) {
            ParseVariant(ref height, VARIANT_LENGTH, null);
          }
          if (!ExpectEndProperty()) {
            return false;
          }
        
          if (width == height || height.GetUnit() == nsCSSUnit.Null) {
            AppendValue(nsCSSProperty.Size, width);
          } else {
            var pair = new nsCSSValue();
            pair.SetPairValue(width, height);
            AppendValue(nsCSSProperty.Size, pair);
          }
          return true;
        }
        
        internal bool ParseTextDecoration()
        {
          const int eDecorationNone         = nsStyle.TEXT_DECORATION_LINE_NONE;
          const int eDecorationUnderline    = nsStyle.TEXT_DECORATION_LINE_UNDERLINE;
          const int eDecorationOverline     = nsStyle.TEXT_DECORATION_LINE_OVERLINE;
          const int eDecorationLineThrough  = nsStyle.TEXT_DECORATION_LINE_LINE_THROUGH;
          const int eDecorationBlink        = nsStyle.TEXT_DECORATION_LINE_BLINK;
          const int eDecorationPrefAnchors  = nsStyle.TEXT_DECORATION_LINE_PREF_ANCHORS;
        
          /*TODO: static*/ int32_t[] kTextDecorationKTable = {
            (int32_t)nsCSSKeyword.None,                   eDecorationNone,
            (int32_t)nsCSSKeyword.Underline,              eDecorationUnderline,
            (int32_t)nsCSSKeyword.Overline,               eDecorationOverline,
            (int32_t)nsCSSKeyword.LineThrough,           eDecorationLineThrough,
            (int32_t)nsCSSKeyword.Blink,                  eDecorationBlink,
            (int32_t)nsCSSKeyword.MozAnchorDecoration, eDecorationPrefAnchors,
            (int32_t)nsCSSKeyword.Unknown,-1
          };
        
          var value = new nsCSSValue();
          if (!ParseVariant(ref value, VARIANT_HK, kTextDecorationKTable)) {
            return false;
          }
        
          nsCSSValue blink = new nsCSSValue(), line = new nsCSSValue(), style = new nsCSSValue(), color = new nsCSSValue();
          switch (value.GetUnit()) {
            case nsCSSUnit.Enumerated: {
              // We shouldn't accept decoration line style and color via
              // text-decoration.
              color.SetIntValue(nsStyle.COLOR_MOZ_USE_TEXT_COLOR,
                                nsCSSUnit.Enumerated);
              style.SetIntValue(nsStyle.TEXT_DECORATION_STYLE_SOLID,
                                nsCSSUnit.Enumerated);
        
              int32_t intValue = value.GetIntValue();
              if (intValue == eDecorationNone) {
                blink.SetIntValue(nsStyle.TEXT_BLINK_NONE, nsCSSUnit.Enumerated);
                line.SetIntValue(nsStyle.TEXT_DECORATION_LINE_NONE,
                                 nsCSSUnit.Enumerated);
                break;
              }
        
              // look for more keywords
              var keyword = new nsCSSValue();
              int32_t index = 0;
              for (index = 0; index < 3; index++) {
                if (!ParseEnum(ref keyword, kTextDecorationKTable)) {
                  break;
                }
                int32_t newValue = keyword.GetIntValue();
                if (newValue == eDecorationNone || ((newValue & intValue) != 0)) {
                  // 'none' keyword in conjuction with others is not allowed, and
                  // duplicate keyword is not allowed.
                  return false;
                }
                intValue |= newValue;
              }
        
              blink.SetIntValue((intValue & eDecorationBlink) != 0 ?
                                  nsStyle.TEXT_BLINK_BLINK : nsStyle.TEXT_BLINK_NONE,
                                nsCSSUnit.Enumerated);
              line.SetIntValue((intValue & ~eDecorationBlink), nsCSSUnit.Enumerated);
              break;
            }
              goto default;
            default:
              blink = line = color = style = value;
              break;
          }
        
          AppendValue(nsCSSProperty.TextBlink, blink);
          AppendValue(nsCSSProperty.TextDecorationLine, line);
          AppendValue(nsCSSProperty.TextDecorationColor, color);
          AppendValue(nsCSSProperty.TextDecorationStyle, style);
        
          return true;
        }
        
        internal bool ParseTextDecorationLine(ref nsCSSValue aValue)
        {
          if (ParseVariant(ref aValue, VARIANT_HK, nsCSSProps.kTextDecorationLineKTable)) {
            if (nsCSSUnit.Enumerated == aValue.GetUnit()) {
              int32_t intValue = aValue.GetIntValue();
              if (intValue != nsStyle.TEXT_DECORATION_LINE_NONE) {
                // look for more keywords
                var keyword = new nsCSSValue();
                int32_t index = 0;
                for (index = 0; index < 2; index++) {
                  if (ParseEnum(ref keyword, nsCSSProps.kTextDecorationLineKTable)) {
                    int32_t newValue = keyword.GetIntValue();
                    if (newValue == nsStyle.TEXT_DECORATION_LINE_NONE ||
                        ((newValue & intValue) != 0)) {
                      // 'none' keyword in conjuction with others is not allowed, and
                      // duplicate keyword is not allowed.
                      return false;
                    }
                    intValue |= newValue;
                  }
                  else {
                    break;
                  }
                }
                aValue.SetIntValue(intValue, nsCSSUnit.Enumerated);
              }
            }
            return true;
          }
          return false;
        }
        
        internal bool ParseTextOverflow(ref nsCSSValue aValue)
        {
          if (ParseVariant(ref aValue, VARIANT_INHERIT, null)) {
            // 'inherit' and 'initial' must be alone
            return true;
          }
        
          var left = new nsCSSValue();
          if (!ParseVariant(ref left, VARIANT_KEYWORD | VARIANT_STRING,
                            nsCSSProps.kTextOverflowKTable))
            return false;
        
          var right = new nsCSSValue();
          if (ParseVariant(ref right, VARIANT_KEYWORD | VARIANT_STRING,
                            nsCSSProps.kTextOverflowKTable))
            aValue.SetPairValue(left, right);
          else {
            aValue = left;
          }
          return true;
        }
        
        ///////////////////////////////////////////////////////
        // transform Parsing Implementation
        
        /* Reads a function list of arguments.  Do not call this function
         * directly; it's mean to be caled from ParseFunction.
         */
        internal bool ParseFunctionInternals(int32_t[] aVariantMask,
                                              uint16_t aMinElems,
                                              uint16_t aMaxElems,
                                              List<nsCSSValue> aOutput)
        {
          for (uint16_t index = 0; index < aMaxElems; ++index) {
            var newValue = new nsCSSValue();
            if (!ParseVariant(ref newValue, aVariantMask[index], null))
              return false;
        
            aOutput.AppendElement(newValue);
        
            // See whether to continue or whether to look for end of function.
            if (!ExpectSymbol(',', true)) {
              // We need to read the closing parenthesis, and also must take care
              // that we haven't read too few symbols.
              return ExpectSymbol(')', true) && (index + 1) >= aMinElems;
            }
          }
        
          // If we're here, we finished looping without hitting the end, so we read too
          // many elements.
          return false;
        }
        
        /* Parses a function [ input of the form (a [, b]*) ] and stores it
         * as an nsCSSValue that holds a function of the form
         * function-name arg1 arg2 ... argN
         *
         * On error, the return value is false.
         *
         * @param aFunction The name of the function that we're reading.
         * @param aAllowedTypes An array of values corresponding to the legal
         *        types for each element in the function.  The zeroth element in the
         *        array corresponds to the first function parameter, etc.  The length
         *        of this array _must_ be greater than or equal to aMaxElems or the
         *        behavior is undefined.
         * @param aMinElems Minimum number of elements to read.  Reading fewer than
         *        this many elements will result in the function failing.
         * @param aMaxElems Maximum number of elements to read.  Reading more than
         *        this many elements will result in the function failing.
         * @param aValue (out) The value that was parsed.
         */
        internal bool ParseFunction(string aFunction,
                                     int32_t[] aAllowedTypes,
                                     uint16_t aMinElems, uint16_t aMaxElems,
                                     ref nsCSSValue aValue)
        {
        
          /* 2^16 - 2, so that if we have 2^16 - 2 transforms, we have 2^16 - 1
           * elements stored in the the nsCSSValue[].
           */
          const size_t MAX_ALLOWED_ELEMS = 0xFFFE;
        
          /* Make a copy of the function name, since the reference is _probably_ to
           * mToken.mIdentStr, which is going to get overwritten during the course of this
           * function.
           */
          string functionName = aFunction;
        
          /* Read in a list of values as an array, failing if we can't or if
           * it's out of bounds.
           */
          var foundValues = new List<nsCSSValue>();
          if (!ParseFunctionInternals(aAllowedTypes, aMinElems, aMaxElems,
                                      foundValues))
            return false;
        
          /* Now, convert this array into an nsCSSValue[] object.
           * We'll need N + 1 spots, one for the function name and the rest for the
           * arguments.  In case the user has given us more than 2^16 - 2 arguments,
           * we'll truncate them at 2^16 - 2 arguments.
           */
          uint16_t numElements = (uint16_t)(foundValues.Length() <= MAX_ALLOWED_ELEMS ?
                                  foundValues.Length() + 1 : MAX_ALLOWED_ELEMS);
          nsCSSValue[] convertedArray =
            new nsCSSValue[numElements];
        
          /* Copy things over. */
          convertedArray[0].SetStringValue(functionName, nsCSSUnit.Ident);
          for (uint16_t index = 0; index + 1 < numElements; ++index)
            convertedArray[index + 1] = foundValues[((size_t)(index))];
        
          /* Fill in the outparam value with the array. */
          aValue.SetArrayValue(convertedArray, nsCSSUnit.Function);
        
          /* Return it! */
          return true;
        }
        
        /**
         * Given a token, determines the minimum and maximum number of function
         * parameters to read, along with the mask that should be used to read
         * those function parameters.  If the token isn't a transform function,
         * returns an error.
         *
         * @param aToken The token identifying the function.
         * @param aMinElems [out] The minimum number of elements to read.
         * @param aMaxElems [out] The maximum number of elements to read
         * @param aVariantMask [out] The variant mask to use during parsing
         * @return Whether the information was loaded successfully.
         */
        static bool GetFunctionParseInformation(nsCSSKeyword aToken,
                                                bool aIsPrefixed,
                                                ref uint16_t aMinElems,
                                                ref uint16_t aMaxElems,
                                                ref int32_t[] aVariantMask,
                                                ref bool aIs3D)
        {
        /* These types represent the common variant masks that will be used to
           * parse out the individual functions.  The order in the enumeration
           * must match the order in which the masks are declared.
           */
          const int eLengthPercentCalc = 0;
          const int eLengthCalc = 1;
          const int eTwoLengthPercentCalcs = 2;
          const int eTwoLengthPercentCalcsOneLengthCalc = 3;
          const int eAngle = 4;
          const int eTwoAngles = 5;
          const int eNumber = 6;
          const int ePositiveLength = 7;
          const int eTwoNumbers = 8;
          const int eThreeNumbers = 9;
          const int eThreeNumbersOneAngle = 10;
          const int eMatrix = 11;
          const int eMatrixPrefixed = 12;
          const int eMatrix3d = 13;
          const int eMatrix3dPrefixed = 14;
          const int eNumVariantMasks = 15;
         
          const int32_t kMaxElemsPerFunction = 16;
          /*TODO: static*/ int32_t[][] kVariantMasks = {
            new[] {VARIANT_LPCALC},
            new[] {VARIANT_LENGTH|VARIANT_CALC},
            new[] {VARIANT_LPCALC, VARIANT_LPCALC},
            new[] {VARIANT_LPCALC, VARIANT_LPCALC, VARIANT_LENGTH|VARIANT_CALC},
            new[] {VARIANT_ANGLE_OR_ZERO},
            new[] {VARIANT_ANGLE_OR_ZERO, VARIANT_ANGLE_OR_ZERO},
            new[] {VARIANT_NUMBER},
            new[] {VARIANT_LENGTH|VARIANT_POSITIVE_DIMENSION},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_ANGLE_OR_ZERO},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_LPNCALC, VARIANT_LPNCALC},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER},
            new[] {VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER, VARIANT_NUMBER,
             VARIANT_LPNCALC, VARIANT_LPNCALC, VARIANT_LNCALC, VARIANT_NUMBER}};
        
        #if DEBUG
          /*TODO: static*/ uint8_t[] kVariantMaskLengths =
            {1, 1, 2, 3, 1, 2, 1, 1, 2, 3, 4, 6, 6, 16, 16};
        #endif
        
          int32_t variantIndex = eNumVariantMasks;
        
          aIs3D = false;
        
          switch (aToken) {
          case nsCSSKeyword.Translatex:
          case nsCSSKeyword.Translatey:
            /* Exactly one length or percent. */
            variantIndex = eLengthPercentCalc;
            aMinElems = 1;
            aMaxElems = 1;
            break;
          case nsCSSKeyword.Translatez:
            /* Exactly one length */
            variantIndex = eLengthCalc;
            aMinElems = 1;
            aMaxElems = 1;
            aIs3D = true;
            break;
          case nsCSSKeyword.Translate3d:
            /* Exactly two lengthds or percents and a number */
            variantIndex = eTwoLengthPercentCalcsOneLengthCalc;
            aMinElems = 3;
            aMaxElems = 3;
            aIs3D = true;
            break;
          case nsCSSKeyword.Scalez:
            aIs3D = true;
            goto case nsCSSKeyword.Scalex;
          case nsCSSKeyword.Scalex:
          case nsCSSKeyword.Scaley:
            /* Exactly one scale factor. */
            variantIndex = eNumber;
            aMinElems = 1;
            aMaxElems = 1;
            break;
          case nsCSSKeyword.Scale3d:
            /* Exactly three scale factors. */
            variantIndex = eThreeNumbers;
            aMinElems = 3;
            aMaxElems = 3;
            aIs3D = true;
            break;
          case nsCSSKeyword.Rotatex:
          case nsCSSKeyword.Rotatey:
            aIs3D = true;
            goto case nsCSSKeyword.Rotate;
          case nsCSSKeyword.Rotate:
          case nsCSSKeyword.Rotatez:
            /* Exactly one angle. */
            variantIndex = eAngle;
            aMinElems = 1;
            aMaxElems = 1;
            break;
          case nsCSSKeyword.Rotate3d:
            variantIndex = eThreeNumbersOneAngle;
            aMinElems = 4;
            aMaxElems = 4;
            aIs3D = true;
            break;
          case nsCSSKeyword.Translate:
            /* One or two lengths or percents. */
            variantIndex = eTwoLengthPercentCalcs;
            aMinElems = 1;
            aMaxElems = 2;
            break;
          case nsCSSKeyword.Skew:
            /* Exactly one or two angles. */
            variantIndex = eTwoAngles;
            aMinElems = 1;
            aMaxElems = 2;
            break;
          case nsCSSKeyword.Scale:
            /* One or two scale factors. */
            variantIndex = eTwoNumbers;
            aMinElems = 1;
            aMaxElems = 2;
            break;
          case nsCSSKeyword.Skewx:
            /* Exactly one angle. */
            variantIndex = eAngle;
            aMinElems = 1;
            aMaxElems = 1;
            break;
          case nsCSSKeyword.Skewy:
            /* Exactly one angle. */
            variantIndex = eAngle;
            aMinElems = 1;
            aMaxElems = 1;
            break;
          case nsCSSKeyword.Matrix:
            /* Six values, all numbers. */
            variantIndex = aIsPrefixed ? eMatrixPrefixed : eMatrix;
            aMinElems = 6;
            aMaxElems = 6;
            break;
          case nsCSSKeyword.Matrix3d:
            /* 16 matrix values, all numbers */
            variantIndex = aIsPrefixed ? eMatrix3dPrefixed : eMatrix3d;
            aMinElems = 6;
            aMaxElems = 6;
            aIs3D = true;
            break;
          case nsCSSKeyword.Perspective:
            /* Exactly one scale number. */
            variantIndex = ePositiveLength;
            aMinElems = 1;
            aMaxElems = 1;
            aIs3D = true;
            break;
          default:
            /* Oh dear, we didn't match.  Report an error. */
            return false;
          }
        
          Debug.Assert(aMinElems > 0, "Didn't update minimum elements!");
          Debug.Assert(aMaxElems > 0, "Didn't update maximum elements!");
          Debug.Assert(aMinElems <= aMaxElems, "aMinElems > aMaxElems!");
          Debug.Assert(variantIndex >= 0, "Invalid variant mask!");
          Debug.Assert(variantIndex < eNumVariantMasks, "Invalid variant mask!");
        #if DEBUG
          Debug.Assert(aMaxElems <= kVariantMaskLengths[variantIndex],
                       "Invalid aMaxElems for this variant mask.");
        #endif
        
          // Convert the index into a mask.
          aVariantMask = kVariantMasks[variantIndex];
        
          return true;
        }
        
        /* Reads a single transform function from the tokenizer stream, reporting an
         * error if something goes wrong.
         */
        internal bool ParseSingleTransform(bool aIsPrefixed,
                                            ref nsCSSValue aValue, ref bool aIs3D)
        {
          if (!GetToken(true))
            return false;
        
          if (mToken.mType != nsCSSTokenType.Function) {
            UngetToken();
            return false;
          }
        
          var variantMask = new int32_t[0];
          uint16_t minElems = 0, maxElems = 0;
          nsCSSKeyword keyword = nsCSSKeywords.LookupKeyword(mToken.mIdentStr);
        
          if (!GetFunctionParseInformation(keyword, aIsPrefixed, ref minElems, ref maxElems, ref variantMask, ref aIs3D))
            return false;
        
          // Bug 721136: Normalize the identifier to lowercase, except that things
          // like scaleX should have the last character capitalized.  This matches
          // what other browsers do.
          mToken.mIdentStr = mToken.mIdentStr.ToLower();
          switch (keyword) {
            case nsCSSKeyword.Rotatex:
            case nsCSSKeyword.Scalex:
            case nsCSSKeyword.Skewx:
            case nsCSSKeyword.Translatex:
              mToken.mIdentStr = mToken.mIdentStr.Substring(0, mToken.mIdentStr.Length - 1) + 'X';
              break;
        
            case nsCSSKeyword.Rotatey:
            case nsCSSKeyword.Scaley:
            case nsCSSKeyword.Skewy:
            case nsCSSKeyword.Translatey:
              mToken.mIdentStr = mToken.mIdentStr.Substring(0, mToken.mIdentStr.Length - 1) + 'Y';
              break;
        
            case nsCSSKeyword.Rotatez:
            case nsCSSKeyword.Scalez:
            case nsCSSKeyword.Translatez:
              mToken.mIdentStr = mToken.mIdentStr.Substring(0, mToken.mIdentStr.Length - 1) + 'Z';
              break;
        
            default:
              break;
          }
        
          return ParseFunction(mToken.mIdentStr, variantMask, minElems, maxElems, ref aValue);
        }
        
        /* Parses a transform property list by continuously reading in properties
         * and constructing a matrix from it.
         */
        bool ParseTransform(bool aIsPrefixed)
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT | VARIANT_NONE, null)) {
            // 'inherit', 'initial', and 'none' must be alone
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              bool is3D = false;
              if (!ParseSingleTransform(aIsPrefixed, ref cur.mValue, ref is3D)) {
                return false;
              }
              if (is3D && !nsLayoutUtils.Are3DTransformsEnabled()) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(nsCSSProperty.Transform, value);
          return true;
        }
        
        bool ParseTransformOrigin(bool aPerspective)
        {
          var position = new nsCSSValuePair();
          if (!ParseBoxPositionValues(ref position, true))
            return false;
        
          nsCSSProperty prop = nsCSSProperty.TransformOrigin;
          if (aPerspective) {
            if (!ExpectEndProperty()) {
              return false;
            }
            prop = nsCSSProperty.PerspectiveOrigin;
          }
        
          // Unlike many other uses of pairs, this position should always be stored
          // as a pair, even if the values are the same, so it always serializes as
          // a pair, and to keep the computation code simple.
          if (position.mXValue.GetUnit() == nsCSSUnit.Inherit ||
              position.mXValue.GetUnit() == nsCSSUnit.Initial) {
            Debug.Assert(position.mXValue == position.mYValue,
                              "inherit/initial only half?");
            AppendValue(prop, position.mXValue);
          } else {
            var value = new nsCSSValue();
            if (aPerspective) {
              value.SetPairValue(position.mXValue, position.mYValue);
            } else {
              var depth = new nsCSSValue();
              if (!nsLayoutUtils.Are3DTransformsEnabled() ||
                  // only try parsing if 3-D transforms are enabled
                  !ParseVariant(ref depth, VARIANT_LENGTH | VARIANT_CALC, null)) {
                depth.SetFloatValue(0.0f, nsCSSUnit.Pixel);
              }
              value.SetTripletValue(position.mXValue, position.mYValue, depth);
            }
        
            AppendValue(prop, value);
          }
          return true;
        }
        
        internal bool ParseTransitionProperty()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_INHERIT | VARIANT_NONE, null)) {
            // 'inherit', 'initial', and 'none' must be alone
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            // Accept a list of arbitrary identifiers.  They should be
            // CSS properties, but we want to accept any so that we
            // accept properties that we don't know about yet, e.g.
            // transition-property: invalid-property, left, opacity;
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              if (!ParseVariant(ref cur.mValue, VARIANT_IDENTIFIER | VARIANT_ALL, null)) {
                return false;
              }
              if (cur.mValue.GetUnit() == nsCSSUnit.Ident) {
                string str = cur.mValue.GetStringBufferValue();
                // Exclude 'none' and 'inherit' and 'initial' according to the
                // same rules as for 'counter-reset' in CSS 2.1.
                if (str.LowerCaseEqualsLiteral("none") ||
                    str.LowerCaseEqualsLiteral("inherit") ||
                    str.LowerCaseEqualsLiteral("initial")) {
                  return false;
                }
              }
              if (CheckEndProperty()) {
                break;
              }
              if (!ExpectSymbol(',', true)) {
                { if (!mSuppressErrors) mReporter.ReportUnexpected("PEExpectedComma", mToken); };
                return false;
              }
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(nsCSSProperty.TransitionProperty, value);
          return true;
        }
        
        internal bool ParseTransitionTimingFunctionValues(ref nsCSSValue aValue)
        {
          Debug.Assert(!mHavePushBack &&
                       mToken.mType == nsCSSTokenType.Function &&
                       mToken.mIdentStr.LowerCaseEqualsLiteral("cubic-bezier"),
                       "unexpected initial state");
        
          nsCSSValue[] val = new nsCSSValue[4];
        
          float x1 = 0, x2 = 0, y1 = 0, y2 = 0;
          if (!ParseTransitionTimingFunctionValueComponent(ref x1, ',', true) ||
              !ParseTransitionTimingFunctionValueComponent(ref y1, ',', false) ||
              !ParseTransitionTimingFunctionValueComponent(ref x2, ',', true) ||
              !ParseTransitionTimingFunctionValueComponent(ref y2, ')', false)) {
            return false;
          }
        
          val[0].SetFloatValue(x1, nsCSSUnit.Number);
          val[1].SetFloatValue(y1, nsCSSUnit.Number);
          val[2].SetFloatValue(x2, nsCSSUnit.Number);
          val[3].SetFloatValue(y2, nsCSSUnit.Number);
        
          aValue.SetArrayValue(val, nsCSSUnit.CubicBezier);
        
          return true;
        }
        
        internal bool ParseTransitionTimingFunctionValueComponent(ref float aComponent,
                                                                   char aStop,
                                                                   bool aCheckRange)
        {
          if (!GetToken(true)) {
            return false;
          }
          nsCSSToken tk = mToken;
          if (tk.mType == nsCSSTokenType.Number) {
            float num = tk.mNumber;
            if (aCheckRange && (num < 0.0 || num > 1.0)) {
              return false;
            }
            aComponent = num;
            if (ExpectSymbol(aStop, true)) {
              return true;
            }
          }
          return false;
        }
        
        internal bool ParseTransitionStepTimingFunctionValues(ref nsCSSValue aValue)
        {
          Debug.Assert(!mHavePushBack &&
                       mToken.mType == nsCSSTokenType.Function &&
                       mToken.mIdentStr.LowerCaseEqualsLiteral("steps"),
                       "unexpected initial state");
        
          nsCSSValue[] val = new nsCSSValue[2];
        
          if (!ParseOneOrLargerVariant(ref val[0], VARIANT_INTEGER, null)) {
            return false;
          }
        
          int32_t type = nsStyle.TRANSITION_TIMING_FUNCTION_STEP_END;
          if (ExpectSymbol(',', true)) {
            if (!GetToken(true)) {
              return false;
            }
            type = -1;
            if (mToken.mType == nsCSSTokenType.Ident) {
              if (mToken.mIdentStr.LowerCaseEqualsLiteral("start")) {
                type = nsStyle.TRANSITION_TIMING_FUNCTION_STEP_START;
              } else if (mToken.mIdentStr.LowerCaseEqualsLiteral("end")) {
                type = nsStyle.TRANSITION_TIMING_FUNCTION_STEP_END;
              }
            }
            if (type == -1) {
              UngetToken();
              return false;
            }
          }
          val[1].SetIntValue(type, nsCSSUnit.Enumerated);
        
          if (!ExpectSymbol(')', true)) {
            return false;
          }
        
          aValue.SetArrayValue(val, nsCSSUnit.Steps);
          return true;
        }
        
        static nsCSSValueList
        AppendValueToList(ref nsCSSValue aContainer,
                          nsCSSValueList aTail,
                          nsCSSValue aValue)
        {
          nsCSSValueList entry;
          if (aContainer.GetUnit() == nsCSSUnit.Null) {
            Debug.Assert(aTail == null, "should not have an entry");
            entry = aContainer.SetListValue();
          } else {
            Debug.Assert(aTail.mNext == null, "should not have a next entry");
            Debug.Assert(aContainer.GetUnit() == nsCSSUnit.List, "not a list");
            entry = new nsCSSValueList();
            aTail.mNext = entry;
          }
          entry.mValue = aValue;
          return entry;
        }
        internal  ParseAnimationOrTransitionShorthandResult
        ParseAnimationOrTransitionShorthand(
                         nsCSSProperty[] aProperties,
                         nsCSSValue[] aInitialValues,
                         ref nsCSSValue[] aValues,
                         size_t aNumProperties)
        {
          var tempValue = new nsCSSValue();
          // first see if 'inherit' or 'initial' is specified.  If one is,
          // it can be the only thing specified, so don't attempt to parse any
          // additional properties
          if (ParseVariant(ref tempValue, VARIANT_INHERIT, null)) {
            for (uint32_t i = 0; i < aNumProperties; ++i) {
              AppendValue(aProperties[i], tempValue);
            }
            return ParseAnimationOrTransitionShorthandResult.Inherit;
          }
        
          const size_t maxNumProperties = 7;
          Debug.Assert(aNumProperties <= maxNumProperties,
                            "can't handle this many properties");
          var cur = new nsCSSValueList[maxNumProperties];
          var parsedProperty = new bool[maxNumProperties];
        
          for (size_t i = 0; i < aNumProperties; ++i) {
            cur[i] = null;
          }
          bool atEOP = false; // at end of property?
          for (;;) { // loop over comma-separated transitions or animations
            // whether a particular subproperty was specified for this
            // transition or animation
            for (size_t i = 0; i < aNumProperties; ++i) {
              parsedProperty[i] = false;
            }
            for (;;) { // loop over values within a transition or animation
              bool foundProperty = false;
              // check to see if we're at the end of one full transition or
              // animation definition (either because we hit a comma or because
              // we hit the end of the property definition)
              if (ExpectSymbol(',', true))
                break;
              if (CheckEndProperty()) {
                atEOP = true;
                break;
              }
        
              // else, try to parse the next transition or animation sub-property
              for (uint32_t i = 0; !foundProperty && i < aNumProperties; ++i) {
                if (!parsedProperty[i]) {
                  // if we haven't found this property yet, try to parse it
                  if (ParseSingleValueProperty(ref tempValue, aProperties[i])) {
                    parsedProperty[i] = true;
                    cur[i] = AppendValueToList(ref aValues[i], cur[i], tempValue);
                    foundProperty = true;
                    break; // out of inner loop; continue looking for next sub-property
                  }
                }
              }
              if (!foundProperty) {
                // We're not at a ',' or at the end of the property, but we couldn't
                // parse any of the sub-properties, so the declaration is invalid.
                return ParseAnimationOrTransitionShorthandResult.Error;
              }
            }
        
            // We hit the end of the property or the end of one transition
            // or animation definition, add its components to the list.
            for (uint32_t i = 0; i < aNumProperties; ++i) {
              // If all of the subproperties were not explicitly specified, fill
              // in the missing ones with initial values.
              if (!parsedProperty[i]) {
                cur[i] = AppendValueToList(ref aValues[i], cur[i], aInitialValues[i]);
              }
            }
        
            if (atEOP)
              break;
            // else we just hit a ',' so continue parsing the next compound transition
          }
        
          return ParseAnimationOrTransitionShorthandResult.Values;
        }
        
        internal bool ParseTransition()
        {
          /*TODO: static*/ nsCSSProperty[] kTransitionProperties = {
            nsCSSProperty.TransitionDuration,
            nsCSSProperty.TransitionTimingFunction,
            // Must check 'transition-delay' after 'transition-duration', since
            // that's our assumption about what the spec means for the shorthand
            // syntax (the first time given is the duration, and the second
            // given is the delay).
            nsCSSProperty.TransitionDelay,
            // Must check 'transition-property' after
            // 'transition-timing-function' since 'transition-property' accepts
            // any keyword.
            nsCSSProperty.TransitionProperty
          };
          uint32_t numProps = kTransitionProperties.Length;
          // this is a shorthand property that accepts -property, -delay,
          // -duration, and -timing-function with some components missing.
          // there can be multiple transitions, separated with commas
        
          var initialValues = new nsCSSValue[numProps];
          initialValues[0].SetFloatValue(0.0, nsCSSUnit.Seconds);
          initialValues[1].SetIntValue(nsStyle.TRANSITION_TIMING_FUNCTION_EASE,
                                       nsCSSUnit.Enumerated);
          initialValues[2].SetFloatValue(0.0, nsCSSUnit.Seconds);
          initialValues[3].SetAllValue();
        
          var values = new nsCSSValue[numProps];
        
          ParseAnimationOrTransitionShorthandResult spres =
            ParseAnimationOrTransitionShorthand(kTransitionProperties, initialValues, ref values, numProps);
          if (spres != ParseAnimationOrTransitionShorthandResult.Values) {
            return spres != ParseAnimationOrTransitionShorthandResult.Error;
          }
        
          // Make two checks on the list for 'transition-property':
          //   + If there is more than one item, then none of the items can be
          //     'none' or 'all'.
          //   + None of the items can be 'inherit' or 'initial' (this is the case,
          //     like with counter-reset &c., where CSS 2.1 specifies 'initial', so
          //     we should check it without the -moz- prefix).
          {
            Debug.Assert(kTransitionProperties[3] ==
                                nsCSSProperty.TransitionProperty,
                              "array index mismatch");
            nsCSSValueList l = values[3].GetListValue();
            bool multipleItems = l.mNext != null;
            do {
              nsCSSValue val = l.mValue;
              if (val.GetUnit() == nsCSSUnit.None) {
                if (multipleItems) {
                  // This is a syntax error.
                  return false;
                }
        
                // Unbox a solitary 'none'.
                values[3].SetNoneValue();
                break;
              }
              if (val.GetUnit() == nsCSSUnit.Ident) {
                string str = val.GetStringBufferValue();
                if (str.EqualsLiteral("inherit") || str.EqualsLiteral("initial")) {
                  return false;
                }
              }
            } while ((l = l.mNext) != null);
          }
        
          // Save all parsed transition sub-properties in mTempData
          for (uint32_t i = 0; i < numProps; ++i) {
            AppendValue(kTransitionProperties[i], values[i]);
          }
          return true;
        }
        
        internal bool ParseAnimation()
        {
          /*TODO: static*/ nsCSSProperty[] kAnimationProperties = {
            nsCSSProperty.AnimationDuration,
            nsCSSProperty.AnimationTimingFunction,
            // Must check 'animation-delay' after 'animation-duration', since
            // that's our assumption about what the spec means for the shorthand
            // syntax (the first time given is the duration, and the second
            // given is the delay).
            nsCSSProperty.AnimationDelay,
            nsCSSProperty.AnimationDirection,
            nsCSSProperty.AnimationFillMode,
            nsCSSProperty.AnimationIterationCount,
            // Must check 'animation-name' after 'animation-timing-function',
            // 'animation-direction', 'animation-fill-mode',
            // 'animation-iteration-count', and 'animation-play-state' since
            // 'animation-name' accepts any keyword.
            nsCSSProperty.AnimationName
          };
          uint32_t numProps = kAnimationProperties.Length;
          // this is a shorthand property that accepts -property, -delay,
          // -duration, and -timing-function with some components missing.
          // there can be multiple animations, separated with commas
        
          var initialValues = new nsCSSValue[numProps];
          initialValues[0].SetFloatValue(0.0, nsCSSUnit.Seconds);
          initialValues[1].SetIntValue(nsStyle.TRANSITION_TIMING_FUNCTION_EASE,
                                       nsCSSUnit.Enumerated);
          initialValues[2].SetFloatValue(0.0, nsCSSUnit.Seconds);
          initialValues[3].SetIntValue(nsStyle.ANIMATION_DIRECTION_NORMAL, nsCSSUnit.Enumerated);
          initialValues[4].SetIntValue(nsStyle.ANIMATION_FILL_MODE_NONE, nsCSSUnit.Enumerated);
          initialValues[5].SetFloatValue(1.0f, nsCSSUnit.Number);
          initialValues[6].SetNoneValue();
        
          var values = new nsCSSValue[numProps];
        
          ParseAnimationOrTransitionShorthandResult spres =
            ParseAnimationOrTransitionShorthand(kAnimationProperties, initialValues, ref values, numProps);
          if (spres != ParseAnimationOrTransitionShorthandResult.Values) {
            return spres != ParseAnimationOrTransitionShorthandResult.Error;
          }
        
          // Save all parsed animation sub-properties in mTempData
          for (uint32_t i = 0; i < numProps; ++i) {
            AppendValue(kAnimationProperties[i], values[i]);
          }
          return true;
        }
        
        internal bool ParseShadowItem(ref nsCSSValue aValue, bool aIsBoxShadow)
        {
          // A shadow list item is an array, with entries in this sequence:
          const int IndexX = 0;
          const int IndexY = 1;
          const int IndexRadius = 2;
          const int IndexSpread = 3;
          const int IndexColor = 4;
          const int IndexInset = 5;
        
          
        
          nsCSSValue[] val = new nsCSSValue[6];
        
          if (aIsBoxShadow) {
            // Optional inset keyword (ignore errors)
            ParseVariant(ref val[IndexInset], VARIANT_KEYWORD,
                         nsCSSProps.kBoxShadowTypeKTable);
          }
        
          var xOrColor = new nsCSSValue();
          bool haveColor = false;
          if (!ParseVariant(ref xOrColor, VARIANT_COLOR | VARIANT_LENGTH | VARIANT_CALC,
                            null)) {
            return false;
          }
          if (xOrColor.IsLengthUnit() || xOrColor.IsCalcUnit()) {
            val[IndexX] = xOrColor;
          } else {
            // Must be a color (as string or color value)
            Debug.Assert(xOrColor.GetUnit() == nsCSSUnit.Ident ||
                         xOrColor.GetUnit() == nsCSSUnit.Color ||
                         xOrColor.GetUnit() == nsCSSUnit.EnumColor,
                         "Must be a color value");
            val[IndexColor] = xOrColor;
            haveColor = true;
        
            // X coordinate mandatory after color
            if (!ParseVariant(ref val[IndexX], VARIANT_LENGTH | VARIANT_CALC,
                              null)) {
              return false;
            }
          }
        
          // Y coordinate; mandatory
          if (!ParseVariant(ref val[IndexY], VARIANT_LENGTH | VARIANT_CALC,
                            null)) {
            return false;
          }
        
          // Optional radius. Ignore errors except if they pass a negative
          // value which we must reject. If we use ParseNonNegativeVariant
          // we can't tell the difference between an unspecified radius
          // and a negative radius.
          if (ParseVariant(ref val[IndexRadius], VARIANT_LENGTH | VARIANT_CALC,
                           null) &&
              val[IndexRadius].IsLengthUnit() &&
              val[IndexRadius].GetFloatValue() < 0) {
            return false;
          }
        
          if (aIsBoxShadow) {
            // Optional spread
            ParseVariant(ref val[IndexSpread], VARIANT_LENGTH | VARIANT_CALC, null);
          }
        
          if (!haveColor) {
            // Optional color
            ParseVariant(ref val[IndexColor], VARIANT_COLOR, null);
          }
        
          if (aIsBoxShadow && val[IndexInset].GetUnit() == nsCSSUnit.Null) {
            // Optional inset keyword
            ParseVariant(ref val[IndexInset], VARIANT_KEYWORD,
                         nsCSSProps.kBoxShadowTypeKTable);
          }
        
          aValue.SetArrayValue(val, nsCSSUnit.Array);
          return true;
        }
        
        internal bool ParseShadowList(nsCSSProperty aProperty)
        {
          using (/*var compound = */new nsAutoParseCompoundProperty(this)) {  
            bool isBoxShadow = aProperty == nsCSSProperty.BoxShadow;
          
            var value = new nsCSSValue();
            if (ParseVariant(ref value, VARIANT_INHERIT | VARIANT_NONE, null)) {
              // 'inherit', 'initial', and 'none' must be alone
              if (!ExpectEndProperty()) {
                return false;
              }
            } else {
              nsCSSValueList cur = value.SetListValue();
              for (;;) {
                if (!ParseShadowItem(ref cur.mValue, isBoxShadow)) {
                  return false;
                }
                if (CheckEndProperty()) {
                  break;
                }
                if (!ExpectSymbol(',', true)) {
                  return false;
                }
                cur.mNext = new nsCSSValueList();
                cur = cur.mNext;
              }
            }
            AppendValue(aProperty, value);
            return true;
          }
        }
        
        internal int32_t GetNamespaceIdForPrefix(string aPrefix)
        {
          if (!(!aPrefix.IsEmpty())) throw new ArgumentException("Must have a prefix here");
        
          int32_t nameSpaceID = nsNameSpace.Unknown;
          if (mNameSpaceMap != null) {
            // user-specified identifiers are case-sensitive (bug 416106)
            string prefix = String.Intern(aPrefix);
            if (prefix == null) {
              Debug.Fail("String.Intern failed - out of memory?");
            }
            nameSpaceID = mNameSpaceMap.FindNameSpaceID(prefix);
          }
          // else no declared namespaces
        
          if (nameSpaceID == nsNameSpace.Unknown) {   // unknown prefix, dump it
            { if (!mSuppressErrors) mReporter.ReportUnexpected("PEUnknownNamespacePrefix", aPrefix); };
          }
        
          return nameSpaceID;
        }
        
        internal void SetDefaultNamespaceOnSelector(nsCSSSelector aSelector)
        {
          if (mNameSpaceMap != null) {
            aSelector.SetNameSpace(mNameSpaceMap.FindNameSpaceID(null));
          } else {
            aSelector.SetNameSpace(nsNameSpace.Unknown); // wildcard
          }
        }
        
        internal bool ParsePaint(nsCSSProperty aPropID)
        {
          nsCSSValue x = new nsCSSValue(), y = new nsCSSValue();
          if (!ParseVariant(ref x, VARIANT_HCK | VARIANT_NONE | VARIANT_URL,
                            nsCSSProps.kObjectPatternKTable)) {
            return false;
          }
        
          bool canHaveFallback = x.GetUnit() == nsCSSUnit.Url ||
                                 x.GetUnit() == nsCSSUnit.Enumerated;
          if (canHaveFallback) {
            if (!ParseVariant(ref y, VARIANT_COLOR | VARIANT_NONE, null))
              y.SetNoneValue();
          }
          if (!ExpectEndProperty())
            return false;
        
          if (!canHaveFallback) {
            AppendValue(aPropID, x);
          } else {
            var val = new nsCSSValue();
            val.SetPairValue(x, y);
            AppendValue(aPropID, val);
          }
          return true;
        }
        
        internal bool ParseDasharray()
        {
          var value = new nsCSSValue();
          if (ParseVariant(ref value, VARIANT_HK | VARIANT_NONE,
                           nsCSSProps.kStrokeObjectValueKTable)) {
            // 'inherit', 'initial', and 'none' are only allowed on their own
            if (!ExpectEndProperty()) {
              return false;
            }
          } else {
            nsCSSValueList cur = value.SetListValue();
            for (;;) {
              if (!ParseNonNegativeVariant(ref cur.mValue, VARIANT_LPN, null)) {
                return false;
              }
              if (CheckEndProperty()) {
                break;
              }
              // skip optional commas between elements
              ExpectSymbol(',', true);
        
              cur.mNext = new nsCSSValueList();
              cur = cur.mNext;
            }
          }
          AppendValue(nsCSSProperty.StrokeDasharray, value);
          return true;
        }
        
        internal bool ParseMarker()
        {
          var marker = new nsCSSValue();
          if (ParseSingleValueProperty(ref marker, nsCSSProperty.MarkerEnd)) {
            if (ExpectEndProperty()) {
              AppendValue(nsCSSProperty.MarkerEnd, marker);
              AppendValue(nsCSSProperty.MarkerMid, marker);
              AppendValue(nsCSSProperty.MarkerStart, marker);
              return true;
            }
          }
          return false;
        }
        
        internal bool ParsePaintOrder()
        {
        
          /*TODO: static*/ int32_t[] kPaintOrderKTable = {
            (int32_t)nsCSSKeyword.Normal,  nsStyle.PAINT_ORDER_NORMAL,
            (int32_t)nsCSSKeyword.Fill,    nsStyle.PAINT_ORDER_FILL,
            (int32_t)nsCSSKeyword.Stroke,  nsStyle.PAINT_ORDER_STROKE,
            (int32_t)nsCSSKeyword.Markers, nsStyle.PAINT_ORDER_MARKERS,
            (int32_t)nsCSSKeyword.Unknown,-1
          };
        
          var value = new nsCSSValue();
          if (!ParseVariant(ref value, VARIANT_HK, kPaintOrderKTable)) {
            return false;
          }
        
          uint32_t seen = 0;
          uint32_t order = 0;
          uint32_t position = 0;
        
          // Ensure that even cast to a signed int32_t when stored in CSSValue,
          // we have enough space for the entire paint-order value.
        
          if (value.GetUnit() == nsCSSUnit.Enumerated) {
            uint32_t component = ((uint32_t)(value.GetIntValue()));
            if (component != nsStyle.PAINT_ORDER_NORMAL) {
              bool parsedOK = true;
              for (;;) {
                if (((seen & (1 << component)) != 0)) {
                  // Already seen this component.
                  UngetToken();
                  parsedOK = false;
                  break;
                }
                seen |= (1 << component);
                order |= (component << position);
                position += nsStyle.PAINT_ORDER_BITWIDTH;
                if (!ParseEnum(ref value, kPaintOrderKTable)) {
                  break;
                }
                component = value.GetIntValue();
                if (component == nsStyle.PAINT_ORDER_NORMAL) {
                  // Can't have "normal" in the middle of the list of paint components.
                  UngetToken();
                  parsedOK = false;
                  break;
                }
              }
        
              // Fill in the remaining paint-order components in the order of their
              // constant values.
              if (parsedOK) {
                for (component = 1;
                     component <= nsStyle.PAINT_ORDER_LAST_VALUE;
                     component++) {
                  if (!(((seen & (1 << component)) != 0))) {
                    order |= (component << position);
                    position += nsStyle.PAINT_ORDER_BITWIDTH;
                  }
                }
              }
            }
            value.SetIntValue(((int32_t)(order)), nsCSSUnit.Enumerated);
          }
        
          if (!ExpectEndProperty()) {
            return false;
          }
        
          AppendValue(nsCSSProperty.PaintOrder, value);
          return true;
        }
    }
}
