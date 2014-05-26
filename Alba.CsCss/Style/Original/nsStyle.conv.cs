//
// Generated file. Do not edit manually.
//

using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    public partial class CssStyle
    {
        /* -*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
        /* This Source Code Form is subject to the terms of the Mozilla Public
         * License, v. 2.0. If a copy of the MPL was not distributed with this
         * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
        
        /* constants used in the style struct data provided by nsStyleContext */
        
        // XXX fold this into nsStyleContext and group by nsStyleXXX struct
        
        // Indices into border/padding/margin arrays
        
        // Indices into "half corner" arrays (nsStyleCorners e.g.)
        public const int CornerTopLeftX = 0;
        public const int CornerTopLeftY = 1;
        public const int CornerTopRightX = 2;
        public const int CornerTopRightY = 3;
        public const int CornerBottomRightX = 4;
        public const int CornerBottomRightY = 5;
        public const int CornerBottomLeftX = 6;
        public const int CornerBottomLeftY = 7;
        
        // The results of these conversion macros are exhaustively checked in
        // nsStyleCoord.cpp.
        // Arguments must not have side effects.
        
        // {margin,border-{width,style,color},padding}-{left,right}-{ltr,rtl}-source
        public const int BoxpropSourcePhysical = 0;
        public const int BoxpropSourceLogical = 1;
        
        // box-sizing
        public const int BoxSizingContent = 0;
        public const int BoxSizingPadding = 1;
        public const int BoxSizingBorder = 2;
        
        // box-shadow
        public const int BoxShadowInset = 0;
        
        // float-edge
        public const int FloatEdgeContent = 0;
        public const int FloatEdgeMargin = 1;
        
        // user-focus
        public const int UserFocusNone = 0;
        public const int UserFocusIgnore = 1;
        public const int UserFocusNormal = 2;
        public const int UserFocusSelectAll = 3;
        public const int UserFocusSelectBefore = 4;
        public const int UserFocusSelectAfter = 5;
        public const int UserFocusSelectSame = 6;
        public const int UserFocusSelectMenu = 7;
        
        // user-select
        public const int UserSelectNone = 0;
        public const int UserSelectText = 1;
        public const int UserSelectElement = 2;
        public const int UserSelectElements = 3;
        public const int UserSelectAll = 4;
        public const int UserSelectToggle = 5;
        public const int UserSelectTriState = 6;
        public const int UserSelectAuto = 7; // internal value - please use nsFrame::IsSelectable()
        public const int UserSelectMozAll = 8; // force selection of all children, unless an ancestor has NONE set - bug 48096
        public const int UserSelectMozNone = 9; // Like NONE, but doesn't change selection behavior for descendants whose user-select is not AUTO.
        
        // user-input
        public const int UserInputNone = 0;
        public const int UserInputEnabled = 1;
        public const int UserInputDisabled = 2;
        public const int UserInputAuto = 3;
        
        // user-modify
        public const int UserModifyReadOnly = 0;
        public const int UserModifyReadWrite = 1;
        public const int UserModifyWriteOnly = 2;
        
        // box-align
        public const int BoxAlignStretch = 0;
        public const int BoxAlignStart = 1;
        public const int BoxAlignCenter = 2;
        public const int BoxAlignBaseline = 3;
        public const int BoxAlignEnd = 4;
        
        // box-pack
        public const int BoxPackStart = 0;
        public const int BoxPackCenter = 1;
        public const int BoxPackEnd = 2;
        public const int BoxPackJustify = 3;
        
        // box-direction
        public const int BoxDirectionNormal = 0;
        public const int BoxDirectionReverse = 1;
        
        // box-orient
        public const int BoxOrientHorizontal = 0;
        public const int BoxOrientVertical = 1;
        
        // orient
        public const int OrientHorizontal = 0;
        public const int OrientVertical = 1;
        public const int OrientAuto = 2;
        
        // stack-sizing
        public const int StackSizingIgnore = 0;
        public const int StackSizingStretchToFit = 1;
        
        // Azimuth - See nsStyleAural
        public const int AzimuthLeftSide = 0x00;
        public const int AzimuthFarLeft = 0x01;
        public const int AzimuthLeft = 0x02;
        public const int AzimuthCenterLeft = 0x03;
        public const int AzimuthCenter = 0x04;
        public const int AzimuthCenterRight = 0x05;
        public const int AzimuthRight = 0x06;
        public const int AzimuthFarRight = 0x07;
        public const int AzimuthRightSide = 0x08;
        public const int AzimuthBehind = 0x80; // bits
        public const int AzimuthLeftwards = 0x10; // bits
        public const int AzimuthRightwards = 0x20; // bits
        
        // See nsStyleAural
        public const int ElevationBelow = 1;
        public const int ElevationLevel = 2;
        public const int ElevationAbove = 3;
        public const int ElevationHigher = 4;
        public const int ElevationLower = 5;
        
        // See nsStyleAural
        public const int PitchXLow = 1;
        public const int PitchLow = 2;
        public const int PitchMedium = 3;
        public const int PitchHigh = 4;
        public const int PitchXHigh = 5;
        
        // See nsStyleAural
        public const int SpeakNone = 0;
        public const int SpeakNormal = 1;
        public const int SpeakSpellOut = 2;
        
        // See nsStyleAural
        public const int SpeakHeaderOnce = 0;
        public const int SpeakHeaderAlways = 1;
        
        // See nsStyleAural
        public const int SpeakNumeralDigits = 0;
        public const int SpeakNumeralContinuous = 1;
        
        // See nsStyleAural
        public const int SpeakPunctuationNone = 0;
        public const int SpeakPunctuationCode = 1;
        
        // See nsStyleAural
        public const int SpeechRateXSlow = 0;
        public const int SpeechRateSlow = 1;
        public const int SpeechRateMedium = 2;
        public const int SpeechRateFast = 3;
        public const int SpeechRateXFast = 4;
        public const int SpeechRateFaster = 10;
        public const int SpeechRateSlower = 11;
        
        // See nsStyleAural
        public const int VolumeSilent = 0;
        public const int VolumeXSoft = 1;
        public const int VolumeSoft = 2;
        public const int VolumeMedium = 3;
        public const int VolumeLoud = 4;
        public const int VolumeXLoud = 5;
        
        // See nsStyleColor
        public const int ColorMozUseTextColor = 1;
        public const int ColorInheritFromBody = 2; /* Can't come from CSS directly */
        
        // See nsStyleColor
        public const int ColorCurrentcolor = -1;
        public const int ColorMozDefaultColor = -2;
        public const int ColorMozDefaultBackgroundColor = -3;
        public const int ColorMozHyperlinktext = -4;
        public const int ColorMozVisitedhyperlinktext = -5;
        public const int ColorMozActivehyperlinktext = -6;
        // Only valid as paints in SVG glyphs
        public const int ColorObjectfill = -7;
        public const int ColorObjectstroke = -8;
        
        // See nsStyleDisplay
        public const int AnimationDirectionNormal = 0;
        public const int AnimationDirectionReverse = 1;
        public const int AnimationDirectionAlternate = 2;
        public const int AnimationDirectionAlternateReverse = 3;
        
        // See nsStyleDisplay
        public const int AnimationFillModeNone = 0;
        public const int AnimationFillModeForwards = 1;
        public const int AnimationFillModeBackwards = 2;
        public const int AnimationFillModeBoth = 3;
        
        // See nsStyleDisplay
        public const int AnimationIterationCountInfinite = 0;
        
        // See nsStyleDisplay
        public const int AnimationPlayStateRunning = 0;
        public const int AnimationPlayStatePaused = 1;
        
        // See nsStyleBackground
        public const int BgAttachmentScroll = 0;
        public const int BgAttachmentFixed = 1;
        
        // See nsStyleBackground
        // Code depends on these constants having the same values as BG_ORIGIN_*
        public const int BgClipBorder = 0;
        public const int BgClipPadding = 1;
        public const int BgClipContent = 2;
        // A magic value that we use for our "pretend that background-clip is
        // 'padding' when we have a solid border" optimization.  This isn't
        // actually equal to NS_STYLE_BG_CLIP_PADDING because 
        // causes antialiasing seams between the background and border.  This
        // is a backend-only value.
        public const int BgClipMozAlmostPadding = 127;
        
        // See nsStyleBackground
        public const int BgInlinePolicyEachBox = 0;
        public const int BgInlinePolicyContinuous = 1;
        public const int BgInlinePolicyBoundingBox = 2;
        
        // See nsStyleBackground
        // Code depends on these constants having the same values as BG_CLIP_*
        public const int BgOriginBorder = 0;
        public const int BgOriginPadding = 1;
        public const int BgOriginContent = 2;
        
        // See nsStyleBackground
        // The parser code depends on |ing these values together.
        public const int BgPositionCenter = (1<<0);
        public const int BgPositionTop = (1<<1);
        public const int BgPositionBottom = (1<<2);
        public const int BgPositionLeft = (1<<3);
        public const int BgPositionRight = (1<<4);
        
        // See nsStyleBackground
        public const int BgRepeatNoRepeat = 0x00;
        public const int BgRepeatRepeatX = 0x01;
        public const int BgRepeatRepeatY = 0x02;
        public const int BgRepeatRepeat = 0x03;
        
        // See nsStyleBackground
        public const int BgSizeContain = 0;
        public const int BgSizeCover = 1;
        
        // See nsStyleTable
        public const int BorderCollapse = 0;
        public const int BorderSeparate = 1;
        
        // Possible enumerated specified values of border-*-width, used by nsCSSMargin
        public const int BorderWidthThin = 0;
        public const int BorderWidthMedium = 1;
        public const int BorderWidthThick = 2;
        // XXX chopping block #define NS_STYLE_BORDER_WIDTH_LENGTH_VALUE      3
        
        // See nsStyleBorder mBorderStyle
        public const int BorderStyleNone = 0;
        public const int BorderStyleGroove = 1;
        public const int BorderStyleRidge = 2;
        public const int BorderStyleDotted = 3;
        public const int BorderStyleDashed = 4;
        public const int BorderStyleSolid = 5;
        public const int BorderStyleDouble = 6;
        public const int BorderStyleInset = 7;
        public const int BorderStyleOutset = 8;
        public const int BorderStyleHidden = 9;
        public const int BorderStyleAuto = 10; // for outline-style only
        
        // See nsStyleBorder mBorderImage
        public const int BorderImageRepeatStretch = 0;
        public const int BorderImageRepeatRepeat = 1;
        public const int BorderImageRepeatRound = 2;
        
        public const int BorderImageSliceNofill = 0;
        public const int BorderImageSliceFill = 1;
        
        // See nsStyleDisplay
        public const int ClearNone = 0;
        public const int ClearLeft = 1;
        public const int ClearRight = 2;
        public const int ClearLeftAndRight = 3;
        public const int ClearLine = 4;
        public const int ClearBlock = 5;
        public const int ClearColumn = 6;
        public const int ClearPage = 7;
        public const int ClearLastValue = ClearPage;
        
        // See nsStyleContent
        public const int ContentOpenQuote = 0;
        public const int ContentCloseQuote = 1;
        public const int ContentNoOpenQuote = 2;
        public const int ContentNoCloseQuote = 3;
        public const int ContentAltContent = 4;
        
        // See nsStyleColor
        public const int CursorAuto = 1;
        public const int CursorCrosshair = 2;
        public const int CursorDefault = 3; // ie: an arrow
        public const int CursorPointer = 4; // for links
        public const int CursorMove = 5;
        public const int CursorEResize = 6;
        public const int CursorNeResize = 7;
        public const int CursorNwResize = 8;
        public const int CursorNResize = 9;
        public const int CursorSeResize = 10;
        public const int CursorSwResize = 11;
        public const int CursorSResize = 12;
        public const int CursorWResize = 13;
        public const int CursorText = 14; // ie: i-beam
        public const int CursorWait = 15;
        public const int CursorHelp = 16;
        public const int CursorCopy = 17; // CSS3
        public const int CursorAlias = 18;
        public const int CursorContextMenu = 19;
        public const int CursorCell = 20;
        public const int CursorGrab = 21;
        public const int CursorGrabbing = 22;
        public const int CursorSpinning = 23;
        public const int CursorMozZoomIn = 24;
        public const int CursorMozZoomOut = 25;
        public const int CursorNotAllowed = 26;
        public const int CursorColResize = 27;
        public const int CursorRowResize = 28;
        public const int CursorNoDrop = 29;
        public const int CursorVerticalText = 30;
        public const int CursorAllScroll = 31;
        public const int CursorNeswResize = 32;
        public const int CursorNwseResize = 33;
        public const int CursorNsResize = 34;
        public const int CursorEwResize = 35;
        public const int CursorNone = 36;
        
        // See nsStyleVisibility
        public const int DirectionLtr = 0;
        public const int DirectionRtl = 1;
        public const int DirectionInherit = 2;
        
        // See nsStyleDisplay
        public const int DisplayNone = 0;
        public const int DisplayBlock = 1;
        public const int DisplayInline = 2;
        public const int DisplayInlineBlock = 3;
        public const int DisplayListItem = 4;
        public const int DisplayTable = 8;
        public const int DisplayInlineTable = 9;
        public const int DisplayTableRowGroup = 10;
        public const int DisplayTableColumn = 11;
        public const int DisplayTableColumnGroup = 12;
        public const int DisplayTableHeaderGroup = 13;
        public const int DisplayTableFooterGroup = 14;
        public const int DisplayTableRow = 15;
        public const int DisplayTableCell = 16;
        public const int DisplayTableCaption = 17;
        public const int DisplayBox = 18;
        public const int DisplayInlineBox = 19;
        #if MOZ_XUL
        public const int DisplayGrid = 20;
        public const int DisplayInlineGrid = 21;
        public const int DisplayGridGroup = 22;
        public const int DisplayGridLine = 23;
        public const int DisplayStack = 24;
        public const int DisplayInlineStack = 25;
        public const int DisplayDeck = 26;
        public const int DisplayPopup = 27;
        public const int DisplayGroupbox = 28;
        #endif
        #if MOZ_FLEXBOX
        public const int DisplayFlex = 29;
        public const int DisplayInlineFlex = 30;
        #endif // MOZ_FLEXBOX
        
        #if MOZ_FLEXBOX
        // See nsStylePosition
        public const int AlignItemsFlexStart = 0;
        public const int AlignItemsFlexEnd = 1;
        public const int AlignItemsCenter = 2;
        public const int AlignItemsBaseline = 3;
        public const int AlignItemsStretch = 4;
        
        // For convenience/clarity (since we use this default value in multiple places)
        public const int AlignItemsInitialValue = AlignItemsStretch;
        
        // The "align-self" property accepts all of the normal "align-items" values
        // (above) plus a special 'auto' value that computes to the parent's
        // "align-items" value. Our computed style code internally represents 'auto'
        // with this enum until we actually evaluate it:
        public const int AlignSelfAuto = 5;
        
        // See nsStylePosition
        public const int FlexDirectionRow = 0;
        public const int FlexDirectionRowReverse = 1;
        public const int FlexDirectionColumn = 2;
        public const int FlexDirectionColumnReverse = 3;
        
        // See nsStylePosition
        // NOTE: This is the initial value of the integer-valued 'order' property
        // (rather than an internal numerical representation of some keyword).
        public const int OrderInitial = 0;
        
        // See nsStylePosition
        public const int JustifyContentFlexStart = 0;
        public const int JustifyContentFlexEnd = 1;
        public const int JustifyContentCenter = 2;
        public const int JustifyContentSpaceBetween = 3;
        public const int JustifyContentSpaceAround = 4;
        #endif // MOZ_FLEXBOX
        
        // See nsStyleDisplay
        public const int FloatNone = 0;
        public const int FloatLeft = 1;
        public const int FloatRight = 2;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FontStyleNormal = nsFont.STYLE_NORMAL;
        public const int FontStyleItalic = nsFont.STYLE_ITALIC;
        public const int FontStyleOblique = nsFont.STYLE_OBLIQUE;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FontVariantNormal = nsFont.VARIANT_NORMAL;
        public const int FontVariantSmallCaps = nsFont.VARIANT_SMALL_CAPS;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FontWeightNormal = nsFont.WEIGHT_NORMAL;
        public const int FontWeightBold = nsFont.WEIGHT_BOLD;
        // The constants below appear only in style sheets and not computed style.
        public const int FontWeightBolder = (-1);
        public const int FontWeightLighter = (-2);
        
        // See nsStyleFont
        public const int FontSizeXxsmall = 0;
        public const int FontSizeXsmall = 1;
        public const int FontSizeSmall = 2;
        public const int FontSizeMedium = 3;
        public const int FontSizeLarge = 4;
        public const int FontSizeXlarge = 5;
        public const int FontSizeXxlarge = 6;
        public const int FontSizeXxxlarge = 7; // Only used by <font size="7">. Not specifiable in CSS.
        public const int FontSizeLarger = 8;
        public const int FontSizeSmaller = 9;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FontStretchUltraCondensed = nsFont.STRETCH_ULTRA_CONDENSED;
        public const int FontStretchExtraCondensed = nsFont.STRETCH_EXTRA_CONDENSED;
        public const int FontStretchCondensed = nsFont.STRETCH_CONDENSED;
        public const int FontStretchSemiCondensed = nsFont.STRETCH_SEMI_CONDENSED;
        public const int FontStretchNormal = nsFont.STRETCH_NORMAL;
        public const int FontStretchSemiExpanded = nsFont.STRETCH_SEMI_EXPANDED;
        public const int FontStretchExpanded = nsFont.STRETCH_EXPANDED;
        public const int FontStretchExtraExpanded = nsFont.STRETCH_EXTRA_EXPANDED;
        public const int FontStretchUltraExpanded = nsFont.STRETCH_ULTRA_EXPANDED;
        
        // See nsStyleFont - system fonts
        public const int FontCaption = 1; // css2
        public const int FontIcon = 2;
        public const int FontMenu = 3;
        public const int FontMessageBox = 4;
        public const int FontSmallCaption = 5;
        public const int FontStatusBar = 6;
        public const int FontWindow = 7; // css3
        public const int FontDocument = 8;
        public const int FontWorkspace = 9;
        public const int FontDesktop = 10;
        public const int FontInfo = 11;
        public const int FontDialog = 12;
        public const int FontButton = 13;
        public const int FontPullDownMenu = 14;
        public const int FontList = 15;
        public const int FontField = 16;
        
        // defaults per MathML spec
        public const float MathmlDefaultScriptSizeMultiplier = 0.71f;
        public const int MathmlDefaultScriptMinSizePt = 8;
        
        // See nsStylePosition::mWidth, mMinWidth, mMaxWidth
        public const int WidthMaxContent = 0;
        public const int WidthMinContent = 1;
        public const int WidthFitContent = 2;
        public const int WidthAvailable = 3;
        
        // See nsStylePosition.mPosition
        public const int PositionStatic = 0;
        public const int PositionRelative = 1;
        public const int PositionAbsolute = 2;
        public const int PositionFixed = 3;
        
        // See nsStylePosition.mClip
        public const int ClipAuto = 0x00;
        public const int ClipRect = 0x01;
        public const int ClipTypeMask = 0x0F;
        public const int ClipLeftAuto = 0x10;
        public const int ClipTopAuto = 0x20;
        public const int ClipRightAuto = 0x40;
        public const int ClipBottomAuto = 0x80;
        
        // FRAME/FRAMESET/IFRAME specific values including backward compatibility. Boolean values with
        // the same meaning (e.g. 1 & yes) may need to be distinguished for correct mode processing
        public const int FrameYes = 0;
        public const int FrameNo = 1;
        public const int Frame0 = 2;
        public const int Frame1 = 3;
        public const int FrameOn = 4;
        public const int FrameOff = 5;
        public const int FrameAuto = 6;
        public const int FrameScroll = 7;
        public const int FrameNoscroll = 8;
        
        // See nsStylePosition.mOverflow
        public const int OverflowVisible = 0;
        public const int OverflowHidden = 1;
        public const int OverflowScroll = 2;
        public const int OverflowAuto = 3;
        public const int OverflowClip = 4;
        public const int OverflowScrollbarsHorizontal = 5;
        public const int OverflowScrollbarsVertical = 6;
        
        // See nsStyleList
        public const int ListStyleNone = 0;
        public const int ListStyleDisc = 1;
        public const int ListStyleCircle = 2;
        public const int ListStyleSquare = 3;
        public const int ListStyleDecimal = 4;
        public const int ListStyleDecimalLeadingZero = 5;
        public const int ListStyleLowerRoman = 6;
        public const int ListStyleUpperRoman = 7;
        public const int ListStyleLowerGreek = 8;
        public const int ListStyleLowerAlpha = 9;
        public const int ListStyleLowerLatin = 9; // == ALPHA
        public const int ListStyleUpperAlpha = 10;
        public const int ListStyleUpperLatin = 10; // == ALPHA
        public const int ListStyleHebrew = 11;
        public const int ListStyleArmenian = 12;
        public const int ListStyleGeorgian = 13;
        public const int ListStyleCjkIdeographic = 14;
        public const int ListStyleHiragana = 15;
        public const int ListStyleKatakana = 16;
        public const int ListStyleHiraganaIroha = 17;
        public const int ListStyleKatakanaIroha = 18;
        public const int ListStyleMozCjkHeavenlyStem = 24;
        public const int ListStyleMozCjkEarthlyBranch = 25;
        public const int ListStyleMozTradChineseInformal = 26;
        public const int ListStyleMozTradChineseFormal = 27;
        public const int ListStyleMozSimpChineseInformal = 28;
        public const int ListStyleMozSimpChineseFormal = 29;
        public const int ListStyleMozJapaneseInformal = 30;
        public const int ListStyleMozJapaneseFormal = 31;
        public const int ListStyleMozArabicIndic = 32;
        public const int ListStyleMozPersian = 33;
        public const int ListStyleMozUrdu = 34;
        public const int ListStyleMozDevanagari = 35;
        public const int ListStyleMozGurmukhi = 36;
        public const int ListStyleMozGujarati = 37;
        public const int ListStyleMozOriya = 38;
        public const int ListStyleMozKannada = 39;
        public const int ListStyleMozMalayalam = 40;
        public const int ListStyleMozBengali = 41;
        public const int ListStyleMozTamil = 42;
        public const int ListStyleMozTelugu = 43;
        public const int ListStyleMozThai = 44;
        public const int ListStyleMozLao = 45;
        public const int ListStyleMozMyanmar = 46;
        public const int ListStyleMozKhmer = 47;
        public const int ListStyleMozHangul = 48;
        public const int ListStyleMozHangulConsonant = 49;
        public const int ListStyleMozEthiopicHalehame = 50;
        public const int ListStyleMozEthiopicNumeric = 51;
        public const int ListStyleMozEthiopicHalehameAm = 52;
        public const int ListStyleMozEthiopicHalehameTiEr = 53;
        public const int ListStyleMozEthiopicHalehameTiEt = 54;
        
        // See nsStyleList
        public const int ListStylePositionInside = 0;
        public const int ListStylePositionOutside = 1;
        
        // See nsStyleMargin
        public const int MarginSizeAuto = 0;
        
        // See nsStyleVisibility
        public const int PointerEventsNone = 0;
        public const int PointerEventsVisiblepainted = 1;
        public const int PointerEventsVisiblefill = 2;
        public const int PointerEventsVisiblestroke = 3;
        public const int PointerEventsVisible = 4;
        public const int PointerEventsPainted = 5;
        public const int PointerEventsFill = 6;
        public const int PointerEventsStroke = 7;
        public const int PointerEventsAll = 8;
        public const int PointerEventsAuto = 9;
        
        // See nsStyleDisplay
        public const int ResizeNone = 0;
        public const int ResizeBoth = 1;
        public const int ResizeHorizontal = 2;
        public const int ResizeVertical = 3;
        
        // See nsStyleText
        public const int TextAlignDefault = 0;
        public const int TextAlignLeft = 1;
        public const int TextAlignRight = 2;
        public const int TextAlignCenter = 3;
        public const int TextAlignJustify = 4;
        public const int TextAlignChar = 5; //align based on a certain character, for table cell
        public const int TextAlignEnd = 6;
        public const int TextAlignAuto = 7;
        public const int TextAlignMozCenter = 8;
        public const int TextAlignMozRight = 9;
        public const int TextAlignMozLeft = 10;
        // NS_STYLE_TEXT_ALIGN_MOZ_CENTER_OR_INHERIT is only used in data structs; it
        // is never present in stylesheets or computed data.
        public const int TextAlignMozCenterOrInherit = 11;
        // Note: make sure that the largest NS_STYLE_TEXT_ALIGN_* value is smaller than
        // the smallest NS_STYLE_VERTICAL_ALIGN_* value below!
        
        // See nsStyleText
        public const int TextBlinkNone = 0;
        public const int TextBlinkBlink = 1;
        
        // See nsStyleText, nsStyleFont
        public const int TextDecorationLineNone = 0;
        public const int TextDecorationLineUnderline = nsFont.DECORATION_UNDERLINE;
        public const int TextDecorationLineOverline = nsFont.DECORATION_OVERLINE;
        public const int TextDecorationLineLineThrough = nsFont.DECORATION_LINE_THROUGH;
        public const int TextDecorationLineBlink = 0x08;
        public const int TextDecorationLinePrefAnchors = 0x10;
        // OVERRIDE_ALL does not occur in stylesheets; it only comes from HTML
        // attribute mapping (and thus appears in computed data)
        public const int TextDecorationLineOverrideAll = 0x20;
        public const int TextDecorationLineLinesMask = TextDecorationLineUnderline | TextDecorationLineOverline | TextDecorationLineLineThrough;
        
        // See nsStyleText
        public const int TextDecorationStyleNone = 0; // not in CSS spec, mapped to -moz-none
        public const int TextDecorationStyleDotted = 1;
        public const int TextDecorationStyleDashed = 2;
        public const int TextDecorationStyleSolid = 3;
        public const int TextDecorationStyleDouble = 4;
        public const int TextDecorationStyleWavy = 5;
        public const int TextDecorationStyleMax = TextDecorationStyleWavy;
        
        // See nsStyleTextOverflow
        public const int TextOverflowClip = 0;
        public const int TextOverflowEllipsis = 1;
        public const int TextOverflowString = 2;
        
        // See nsStyleText
        public const int TextTransformNone = 0;
        public const int TextTransformCapitalize = 1;
        public const int TextTransformLowercase = 2;
        public const int TextTransformUppercase = 3;
        public const int TextTransformFullwidth = 4;
        
        // See nsStyleDisplay
        public const int TransitionTimingFunctionEase = 0;
        public const int TransitionTimingFunctionLinear = 1;
        public const int TransitionTimingFunctionEaseIn = 2;
        public const int TransitionTimingFunctionEaseOut = 3;
        public const int TransitionTimingFunctionEaseInOut = 4;
        public const int TransitionTimingFunctionStepStart = 5;
        public const int TransitionTimingFunctionStepEnd = 6;
        
        // See nsStyleText
        // Note: these values pickup after the text-align values because there
        // are a few html cases where an object can have both types of
        // alignment applied with a single attribute
        public const int VerticalAlignBaseline = 12;
        public const int VerticalAlignSub = 13;
        public const int VerticalAlignSuper = 14;
        public const int VerticalAlignTop = 15;
        public const int VerticalAlignTextTop = 16;
        public const int VerticalAlignMiddle = 17;
        public const int VerticalAlignTextBottom = 18;
        public const int VerticalAlignBottom = 19;
        public const int VerticalAlignMiddleWithBaseline = 20;
        
        // See nsStyleVisibility
        public const int VisibilityHidden = 0;
        public const int VisibilityVisible = 1;
        public const int VisibilityCollapse = 2;
        
        // See nsStyleText
        public const int TabsizeInitial = 8;
        
        // See nsStyleText
        public const int WhitespaceNormal = 0;
        public const int WhitespacePre = 1;
        public const int WhitespaceNowrap = 2;
        public const int WhitespacePreWrap = 3;
        public const int WhitespacePreLine = 4;
        public const int WhitespacePreDiscardNewlines = 5;
        
        // See nsStyleText
        public const int WordbreakNormal = 0;
        public const int WordbreakBreakAll = 1;
        public const int WordbreakKeepAll = 2;
        
        // See nsStyleText
        public const int WordwrapNormal = 0;
        public const int WordwrapBreakWord = 1;
        
        // See nsStyleText
        public const int HyphensNone = 0;
        public const int HyphensManual = 1;
        public const int HyphensAuto = 2;
        
        // See nsStyleText
        public const int TextSizeAdjustNone = 0;
        public const int TextSizeAdjustAuto = 1;
        
        // See nsStyleText
        public const int LineHeightBlockHeight = 0;
        
        // See nsStyleText
        public const int UnicodeBidiNormal = 0x0;
        public const int UnicodeBidiEmbed = 0x1;
        public const int UnicodeBidiIsolate = 0x2;
        public const int UnicodeBidiOverride = 0x4;
        public const int UnicodeBidiIsolateOverride = 0x6;
        public const int UnicodeBidiPlaintext = 0x8;
        
        // See nsStyleTable (here for HTML 4.0 for now, should probably change to side flags)
        public const int TableFrameNone = 0;
        public const int TableFrameAbove = 1;
        public const int TableFrameBelow = 2;
        public const int TableFrameHsides = 3;
        public const int TableFrameVsides = 4;
        public const int TableFrameLeft = 5;
        public const int TableFrameRight = 6;
        public const int TableFrameBox = 7;
        public const int TableFrameBorder = 8;
        
        // See nsStyleTable
        public const int TableRulesNone = 0;
        public const int TableRulesGroups = 1;
        public const int TableRulesRows = 2;
        public const int TableRulesCols = 3;
        public const int TableRulesAll = 4;
        
        public const int TableLayoutAuto = 0;
        public const int TableLayoutFixed = 1;
        
        public const int TableEmptyCellsHide = 0;
        public const int TableEmptyCellsShow = 1;
        public const int TableEmptyCellsShowBackground = 2;
        
        public const int CaptionSideTop = 0;
        public const int CaptionSideRight = 1;
        public const int CaptionSideBottom = 2;
        public const int CaptionSideLeft = 3;
        public const int CaptionSideTopOutside = 4;
        public const int CaptionSideBottomOutside = 5;
        
        // constants for cell "scope" attribute
        public const int CellScopeRow = 0;
        public const int CellScopeCol = 1;
        public const int CellScopeRowgroup = 2;
        public const int CellScopeColgroup = 3;
        
        // See nsStylePage
        public const int PageMarksNone = 0x00;
        public const int PageMarksCrop = 0x01;
        public const int PageMarksRegister = 0x02;
        
        // See nsStylePage
        public const int PageSizeAuto = 0;
        public const int PageSizePortrait = 1;
        public const int PageSizeLandscape = 2;
        
        // See nsStyleBreaks
        public const int PageBreakAuto = 0;
        public const int PageBreakAlways = 1;
        public const int PageBreakAvoid = 2;
        public const int PageBreakLeft = 3;
        public const int PageBreakRight = 4;
        
        // See nsStyleColumn
        public const int ColumnCountAuto = 0;
        public const int ColumnCountUnlimited = (-1);
        
        public const int ColumnFillAuto = 0;
        public const int ColumnFillBalance = 1;
        
        // See nsStyleUIReset
        public const int ImeModeAuto = 0;
        public const int ImeModeNormal = 1;
        public const int ImeModeActive = 2;
        public const int ImeModeDisabled = 3;
        public const int ImeModeInactive = 4;
        
        // See nsStyleGradient
        public const int GradientShapeLinear = 0;
        public const int GradientShapeElliptical = 1;
        public const int GradientShapeCircular = 2;
        
        public const int GradientSizeClosestSide = 0;
        public const int GradientSizeClosestCorner = 1;
        public const int GradientSizeFarthestSide = 2;
        public const int GradientSizeFarthestCorner = 3;
        public const int GradientSizeExplicitSize = 4;
        
        // See nsStyleSVG
        
        // dominant-baseline
        public const int DominantBaselineAuto = 0;
        public const int DominantBaselineUseScript = 1;
        public const int DominantBaselineNoChange = 2;
        public const int DominantBaselineResetSize = 3;
        public const int DominantBaselineIdeographic = 4;
        public const int DominantBaselineAlphabetic = 5;
        public const int DominantBaselineHanging = 6;
        public const int DominantBaselineMathematical = 7;
        public const int DominantBaselineCentral = 8;
        public const int DominantBaselineMiddle = 9;
        public const int DominantBaselineTextAfterEdge = 10;
        public const int DominantBaselineTextBeforeEdge = 11;
        
        // fill-rule
        public const int FillRuleNonzero = 0;
        public const int FillRuleEvenodd = 1;
        
        // image-rendering
        public const int ImageRenderingAuto = 0;
        public const int ImageRenderingOptimizespeed = 1;
        public const int ImageRenderingOptimizequality = 2;
        public const int ImageRenderingCrispedges = 3;
        
        // mask-type
        public const int MaskTypeLuminance = 0;
        public const int MaskTypeAlpha = 1;
        
        // paint-order
        public const int PaintOrderNormal = 0;
        public const int PaintOrderFill = 1;
        public const int PaintOrderStroke = 2;
        public const int PaintOrderMarkers = 3;
        public const int PaintOrderLastValue = PaintOrderMarkers;
        // NS_STYLE_PAINT_ORDER_BITWIDTH is the number of bits required to store
        // a single paint-order component value.
        public const int PaintOrderBitwidth = 2;
        
        // shape-rendering
        public const int ShapeRenderingAuto = 0;
        public const int ShapeRenderingOptimizespeed = 1;
        public const int ShapeRenderingCrispedges = 2;
        public const int ShapeRenderingGeometricprecision = 3;
        
        // stroke-linecap
        public const int StrokeLinecapButt = 0;
        public const int StrokeLinecapRound = 1;
        public const int StrokeLinecapSquare = 2;
        
        // stroke-linejoin
        public const int StrokeLinejoinMiter = 0;
        public const int StrokeLinejoinRound = 1;
        public const int StrokeLinejoinBevel = 2;
        
        // stroke-dasharray, stroke-dashoffset, stroke-width
        public const int StrokePropObjectvalue = 0;
        
        // text-anchor
        public const int TextAnchorStart = 0;
        public const int TextAnchorMiddle = 1;
        public const int TextAnchorEnd = 2;
        
        // text-rendering
        public const int TextRenderingAuto = 0;
        public const int TextRenderingOptimizespeed = 1;
        public const int TextRenderingOptimizelegibility = 2;
        public const int TextRenderingGeometricprecision = 3;
        
        // color-interpolation and color-interpolation-filters
        public const int ColorInterpolationAuto = 0;
        public const int ColorInterpolationSrgb = 1;
        public const int ColorInterpolationLinearrgb = 2;
        
        // vector-effect
        public const int VectorEffectNone = 0;
        public const int VectorEffectNonScalingStroke = 1;
        
        // 3d Transforms - Backface visibility
        public const int BackfaceVisibilityVisible = 1;
        public const int BackfaceVisibilityHidden = 0;
        
        public const int TransformStyleFlat = 0;
        public const int TransformStylePreserve3d = 1;
        
        // object {fill,stroke}-opacity for SVG glyphs
        public const int ObjectFillOpacity = 0;
        public const int ObjectStrokeOpacity = 1;
        
        /*****************************************************************************
         * Constants for media features.                                             *
         *****************************************************************************/
        
        // orientation
        public const int OrientationPortrait = 0;
        public const int OrientationLandscape = 1;
        
        // scan
        public const int ScanProgressive = 0;
        public const int ScanInterlace = 1;
    }
}
