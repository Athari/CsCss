//
// Generated file. Do not edit manually.
//

using Alba.CsCss.Gfx;

namespace Alba.CsCss.Style
{
    internal partial class nsStyle
    {
        /* -*- Mode: C++; tab-width: 2; indent-tabs-mode: nil; c-basic-offset: 2 -*- */
        /* This Source Code Form is subject to the terms of the Mozilla Public
         * License, v. 2.0. If a copy of the MPL was not distributed with this
         * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
        
        /* constants used in the style struct data provided by nsStyleContext */
        
        // XXX fold this into nsStyleContext and group by nsStyleXXX struct
        
        // Indices into border/padding/margin arrays
        
        // Indices into "half corner" arrays (nsStyleCorners e.g.)
        public const int CORNER_TOP_LEFT_X = 0;
        public const int CORNER_TOP_LEFT_Y = 1;
        public const int CORNER_TOP_RIGHT_X = 2;
        public const int CORNER_TOP_RIGHT_Y = 3;
        public const int CORNER_BOTTOM_RIGHT_X = 4;
        public const int CORNER_BOTTOM_RIGHT_Y = 5;
        public const int CORNER_BOTTOM_LEFT_X = 6;
        public const int CORNER_BOTTOM_LEFT_Y = 7;
        
        // The results of these conversion macros are exhaustively checked in
        // nsStyleCoord.cpp.
        // Arguments must not have side effects.
        
        // {margin,border-{width,style,color},padding}-{left,right}-{ltr,rtl}-source
        public const int BOXPROP_SOURCE_PHYSICAL = 0;
        public const int BOXPROP_SOURCE_LOGICAL = 1;
        
        // box-sizing
        public const int BOX_SIZING_CONTENT = 0;
        public const int BOX_SIZING_PADDING = 1;
        public const int BOX_SIZING_BORDER = 2;
        
        // box-shadow
        public const int BOX_SHADOW_INSET = 0;
        
        // float-edge
        public const int FLOAT_EDGE_CONTENT = 0;
        public const int FLOAT_EDGE_MARGIN = 1;
        
        // user-focus
        public const int USER_FOCUS_NONE = 0;
        public const int USER_FOCUS_IGNORE = 1;
        public const int USER_FOCUS_NORMAL = 2;
        public const int USER_FOCUS_SELECT_ALL = 3;
        public const int USER_FOCUS_SELECT_BEFORE = 4;
        public const int USER_FOCUS_SELECT_AFTER = 5;
        public const int USER_FOCUS_SELECT_SAME = 6;
        public const int USER_FOCUS_SELECT_MENU = 7;
        
        // user-select
        public const int USER_SELECT_NONE = 0;
        public const int USER_SELECT_TEXT = 1;
        public const int USER_SELECT_ELEMENT = 2;
        public const int USER_SELECT_ELEMENTS = 3;
        public const int USER_SELECT_ALL = 4;
        public const int USER_SELECT_TOGGLE = 5;
        public const int USER_SELECT_TRI_STATE = 6;
        public const int USER_SELECT_AUTO = 7; // internal value - please use nsFrame::IsSelectable()
        public const int USER_SELECT_MOZ_ALL = 8; // force selection of all children, unless an ancestor has NONE set - bug 48096
        public const int USER_SELECT_MOZ_NONE = 9; // Like NONE, but doesn't change selection behavior for descendants whose user-select is not AUTO.
        
        // user-input
        public const int USER_INPUT_NONE = 0;
        public const int USER_INPUT_ENABLED = 1;
        public const int USER_INPUT_DISABLED = 2;
        public const int USER_INPUT_AUTO = 3;
        
        // user-modify
        public const int USER_MODIFY_READ_ONLY = 0;
        public const int USER_MODIFY_READ_WRITE = 1;
        public const int USER_MODIFY_WRITE_ONLY = 2;
        
        // box-align
        public const int BOX_ALIGN_STRETCH = 0;
        public const int BOX_ALIGN_START = 1;
        public const int BOX_ALIGN_CENTER = 2;
        public const int BOX_ALIGN_BASELINE = 3;
        public const int BOX_ALIGN_END = 4;
        
        // box-pack
        public const int BOX_PACK_START = 0;
        public const int BOX_PACK_CENTER = 1;
        public const int BOX_PACK_END = 2;
        public const int BOX_PACK_JUSTIFY = 3;
        
        // box-direction
        public const int BOX_DIRECTION_NORMAL = 0;
        public const int BOX_DIRECTION_REVERSE = 1;
        
        // box-orient
        public const int BOX_ORIENT_HORIZONTAL = 0;
        public const int BOX_ORIENT_VERTICAL = 1;
        
        // orient
        public const int ORIENT_HORIZONTAL = 0;
        public const int ORIENT_VERTICAL = 1;
        public const int ORIENT_AUTO = 2;
        
        // stack-sizing
        public const int STACK_SIZING_IGNORE = 0;
        public const int STACK_SIZING_STRETCH_TO_FIT = 1;
        
        // Azimuth - See nsStyleAural
        public const int AZIMUTH_LEFT_SIDE = 0x00;
        public const int AZIMUTH_FAR_LEFT = 0x01;
        public const int AZIMUTH_LEFT = 0x02;
        public const int AZIMUTH_CENTER_LEFT = 0x03;
        public const int AZIMUTH_CENTER = 0x04;
        public const int AZIMUTH_CENTER_RIGHT = 0x05;
        public const int AZIMUTH_RIGHT = 0x06;
        public const int AZIMUTH_FAR_RIGHT = 0x07;
        public const int AZIMUTH_RIGHT_SIDE = 0x08;
        public const int AZIMUTH_BEHIND = 0x80; // bits
        public const int AZIMUTH_LEFTWARDS = 0x10; // bits
        public const int AZIMUTH_RIGHTWARDS = 0x20; // bits
        
        // See nsStyleAural
        public const int ELEVATION_BELOW = 1;
        public const int ELEVATION_LEVEL = 2;
        public const int ELEVATION_ABOVE = 3;
        public const int ELEVATION_HIGHER = 4;
        public const int ELEVATION_LOWER = 5;
        
        // See nsStyleAural
        public const int PITCH_X_LOW = 1;
        public const int PITCH_LOW = 2;
        public const int PITCH_MEDIUM = 3;
        public const int PITCH_HIGH = 4;
        public const int PITCH_X_HIGH = 5;
        
        // See nsStyleAural
        public const int SPEAK_NONE = 0;
        public const int SPEAK_NORMAL = 1;
        public const int SPEAK_SPELL_OUT = 2;
        
        // See nsStyleAural
        public const int SPEAK_HEADER_ONCE = 0;
        public const int SPEAK_HEADER_ALWAYS = 1;
        
        // See nsStyleAural
        public const int SPEAK_NUMERAL_DIGITS = 0;
        public const int SPEAK_NUMERAL_CONTINUOUS = 1;
        
        // See nsStyleAural
        public const int SPEAK_PUNCTUATION_NONE = 0;
        public const int SPEAK_PUNCTUATION_CODE = 1;
        
        // See nsStyleAural
        public const int SPEECH_RATE_X_SLOW = 0;
        public const int SPEECH_RATE_SLOW = 1;
        public const int SPEECH_RATE_MEDIUM = 2;
        public const int SPEECH_RATE_FAST = 3;
        public const int SPEECH_RATE_X_FAST = 4;
        public const int SPEECH_RATE_FASTER = 10;
        public const int SPEECH_RATE_SLOWER = 11;
        
        // See nsStyleAural
        public const int VOLUME_SILENT = 0;
        public const int VOLUME_X_SOFT = 1;
        public const int VOLUME_SOFT = 2;
        public const int VOLUME_MEDIUM = 3;
        public const int VOLUME_LOUD = 4;
        public const int VOLUME_X_LOUD = 5;
        
        // See nsStyleColor
        public const int COLOR_MOZ_USE_TEXT_COLOR = 1;
        public const int COLOR_INHERIT_FROM_BODY = 2; /* Can't come from CSS directly */
        
        // See nsStyleColor
        public const int COLOR_CURRENTCOLOR = -1;
        public const int COLOR_MOZ_DEFAULT_COLOR = -2;
        public const int COLOR_MOZ_DEFAULT_BACKGROUND_COLOR = -3;
        public const int COLOR_MOZ_HYPERLINKTEXT = -4;
        public const int COLOR_MOZ_VISITEDHYPERLINKTEXT = -5;
        public const int COLOR_MOZ_ACTIVEHYPERLINKTEXT = -6;
        // Only valid as paints in SVG glyphs
        public const int COLOR_OBJECTFILL = -7;
        public const int COLOR_OBJECTSTROKE = -8;
        
        // See nsStyleDisplay
        public const int ANIMATION_DIRECTION_NORMAL = 0;
        public const int ANIMATION_DIRECTION_REVERSE = 1;
        public const int ANIMATION_DIRECTION_ALTERNATE = 2;
        public const int ANIMATION_DIRECTION_ALTERNATE_REVERSE = 3;
        
        // See nsStyleDisplay
        public const int ANIMATION_FILL_MODE_NONE = 0;
        public const int ANIMATION_FILL_MODE_FORWARDS = 1;
        public const int ANIMATION_FILL_MODE_BACKWARDS = 2;
        public const int ANIMATION_FILL_MODE_BOTH = 3;
        
        // See nsStyleDisplay
        public const int ANIMATION_ITERATION_COUNT_INFINITE = 0;
        
        // See nsStyleDisplay
        public const int ANIMATION_PLAY_STATE_RUNNING = 0;
        public const int ANIMATION_PLAY_STATE_PAUSED = 1;
        
        // See nsStyleBackground
        public const int BG_ATTACHMENT_SCROLL = 0;
        public const int BG_ATTACHMENT_FIXED = 1;
        
        // See nsStyleBackground
        // Code depends on these constants having the same values as BG_ORIGIN_*
        public const int BG_CLIP_BORDER = 0;
        public const int BG_CLIP_PADDING = 1;
        public const int BG_CLIP_CONTENT = 2;
        // A magic value that we use for our "pretend that background-clip is
        // 'padding' when we have a solid border" optimization.  This isn't
        // actually equal to NS_STYLE_BG_CLIP_PADDING because 
        // causes antialiasing seams between the background and border.  This
        // is a backend-only value.
        public const int BG_CLIP_MOZ_ALMOST_PADDING = 127;
        
        // See nsStyleBackground
        public const int BG_INLINE_POLICY_EACH_BOX = 0;
        public const int BG_INLINE_POLICY_CONTINUOUS = 1;
        public const int BG_INLINE_POLICY_BOUNDING_BOX = 2;
        
        // See nsStyleBackground
        // Code depends on these constants having the same values as BG_CLIP_*
        public const int BG_ORIGIN_BORDER = 0;
        public const int BG_ORIGIN_PADDING = 1;
        public const int BG_ORIGIN_CONTENT = 2;
        
        // See nsStyleBackground
        // The parser code depends on |ing these values together.
        public const int BG_POSITION_CENTER = (1<<0);
        public const int BG_POSITION_TOP = (1<<1);
        public const int BG_POSITION_BOTTOM = (1<<2);
        public const int BG_POSITION_LEFT = (1<<3);
        public const int BG_POSITION_RIGHT = (1<<4);
        
        // See nsStyleBackground
        public const int BG_REPEAT_NO_REPEAT = 0x00;
        public const int BG_REPEAT_REPEAT_X = 0x01;
        public const int BG_REPEAT_REPEAT_Y = 0x02;
        public const int BG_REPEAT_REPEAT = 0x03;
        
        // See nsStyleBackground
        public const int BG_SIZE_CONTAIN = 0;
        public const int BG_SIZE_COVER = 1;
        
        // See nsStyleTable
        public const int BORDER_COLLAPSE = 0;
        public const int BORDER_SEPARATE = 1;
        
        // Possible enumerated specified values of border-*-width, used by nsCSSMargin
        public const int BORDER_WIDTH_THIN = 0;
        public const int BORDER_WIDTH_MEDIUM = 1;
        public const int BORDER_WIDTH_THICK = 2;
        // XXX chopping block #define NS_STYLE_BORDER_WIDTH_LENGTH_VALUE      3
        
        // See nsStyleBorder mBorderStyle
        public const int BORDER_STYLE_NONE = 0;
        public const int BORDER_STYLE_GROOVE = 1;
        public const int BORDER_STYLE_RIDGE = 2;
        public const int BORDER_STYLE_DOTTED = 3;
        public const int BORDER_STYLE_DASHED = 4;
        public const int BORDER_STYLE_SOLID = 5;
        public const int BORDER_STYLE_DOUBLE = 6;
        public const int BORDER_STYLE_INSET = 7;
        public const int BORDER_STYLE_OUTSET = 8;
        public const int BORDER_STYLE_HIDDEN = 9;
        public const int BORDER_STYLE_AUTO = 10; // for outline-style only
        
        // See nsStyleBorder mBorderImage
        public const int BORDER_IMAGE_REPEAT_STRETCH = 0;
        public const int BORDER_IMAGE_REPEAT_REPEAT = 1;
        public const int BORDER_IMAGE_REPEAT_ROUND = 2;
        
        public const int BORDER_IMAGE_SLICE_NOFILL = 0;
        public const int BORDER_IMAGE_SLICE_FILL = 1;
        
        // See nsStyleDisplay
        public const int CLEAR_NONE = 0;
        public const int CLEAR_LEFT = 1;
        public const int CLEAR_RIGHT = 2;
        public const int CLEAR_LEFT_AND_RIGHT = 3;
        public const int CLEAR_LINE = 4;
        public const int CLEAR_BLOCK = 5;
        public const int CLEAR_COLUMN = 6;
        public const int CLEAR_PAGE = 7;
        public const int CLEAR_LAST_VALUE = CLEAR_PAGE;
        
        // See nsStyleContent
        public const int CONTENT_OPEN_QUOTE = 0;
        public const int CONTENT_CLOSE_QUOTE = 1;
        public const int CONTENT_NO_OPEN_QUOTE = 2;
        public const int CONTENT_NO_CLOSE_QUOTE = 3;
        public const int CONTENT_ALT_CONTENT = 4;
        
        // See nsStyleColor
        public const int CURSOR_AUTO = 1;
        public const int CURSOR_CROSSHAIR = 2;
        public const int CURSOR_DEFAULT = 3; // ie: an arrow
        public const int CURSOR_POINTER = 4; // for links
        public const int CURSOR_MOVE = 5;
        public const int CURSOR_E_RESIZE = 6;
        public const int CURSOR_NE_RESIZE = 7;
        public const int CURSOR_NW_RESIZE = 8;
        public const int CURSOR_N_RESIZE = 9;
        public const int CURSOR_SE_RESIZE = 10;
        public const int CURSOR_SW_RESIZE = 11;
        public const int CURSOR_S_RESIZE = 12;
        public const int CURSOR_W_RESIZE = 13;
        public const int CURSOR_TEXT = 14; // ie: i-beam
        public const int CURSOR_WAIT = 15;
        public const int CURSOR_HELP = 16;
        public const int CURSOR_COPY = 17; // CSS3
        public const int CURSOR_ALIAS = 18;
        public const int CURSOR_CONTEXT_MENU = 19;
        public const int CURSOR_CELL = 20;
        public const int CURSOR_GRAB = 21;
        public const int CURSOR_GRABBING = 22;
        public const int CURSOR_SPINNING = 23;
        public const int CURSOR_MOZ_ZOOM_IN = 24;
        public const int CURSOR_MOZ_ZOOM_OUT = 25;
        public const int CURSOR_NOT_ALLOWED = 26;
        public const int CURSOR_COL_RESIZE = 27;
        public const int CURSOR_ROW_RESIZE = 28;
        public const int CURSOR_NO_DROP = 29;
        public const int CURSOR_VERTICAL_TEXT = 30;
        public const int CURSOR_ALL_SCROLL = 31;
        public const int CURSOR_NESW_RESIZE = 32;
        public const int CURSOR_NWSE_RESIZE = 33;
        public const int CURSOR_NS_RESIZE = 34;
        public const int CURSOR_EW_RESIZE = 35;
        public const int CURSOR_NONE = 36;
        
        // See nsStyleVisibility
        public const int DIRECTION_LTR = 0;
        public const int DIRECTION_RTL = 1;
        public const int DIRECTION_INHERIT = 2;
        
        // See nsStyleDisplay
        public const int DISPLAY_NONE = 0;
        public const int DISPLAY_BLOCK = 1;
        public const int DISPLAY_INLINE = 2;
        public const int DISPLAY_INLINE_BLOCK = 3;
        public const int DISPLAY_LIST_ITEM = 4;
        public const int DISPLAY_TABLE = 8;
        public const int DISPLAY_INLINE_TABLE = 9;
        public const int DISPLAY_TABLE_ROW_GROUP = 10;
        public const int DISPLAY_TABLE_COLUMN = 11;
        public const int DISPLAY_TABLE_COLUMN_GROUP = 12;
        public const int DISPLAY_TABLE_HEADER_GROUP = 13;
        public const int DISPLAY_TABLE_FOOTER_GROUP = 14;
        public const int DISPLAY_TABLE_ROW = 15;
        public const int DISPLAY_TABLE_CELL = 16;
        public const int DISPLAY_TABLE_CAPTION = 17;
        public const int DISPLAY_BOX = 18;
        public const int DISPLAY_INLINE_BOX = 19;
        #if MOZ_XUL
        public const int DISPLAY_GRID = 20;
        public const int DISPLAY_INLINE_GRID = 21;
        public const int DISPLAY_GRID_GROUP = 22;
        public const int DISPLAY_GRID_LINE = 23;
        public const int DISPLAY_STACK = 24;
        public const int DISPLAY_INLINE_STACK = 25;
        public const int DISPLAY_DECK = 26;
        public const int DISPLAY_POPUP = 27;
        public const int DISPLAY_GROUPBOX = 28;
        #endif
        #if MOZ_FLEXBOX
        public const int DISPLAY_FLEX = 29;
        public const int DISPLAY_INLINE_FLEX = 30;
        #endif // MOZ_FLEXBOX
        
        #if MOZ_FLEXBOX
        // See nsStylePosition
        public const int ALIGN_ITEMS_FLEX_START = 0;
        public const int ALIGN_ITEMS_FLEX_END = 1;
        public const int ALIGN_ITEMS_CENTER = 2;
        public const int ALIGN_ITEMS_BASELINE = 3;
        public const int ALIGN_ITEMS_STRETCH = 4;
        
        // For convenience/clarity (since we use this default value in multiple places)
        public const int ALIGN_ITEMS_INITIAL_VALUE = ALIGN_ITEMS_STRETCH;
        
        // The "align-self" property accepts all of the normal "align-items" values
        // (above) plus a special 'auto' value that computes to the parent's
        // "align-items" value. Our computed style code internally represents 'auto'
        // with this enum until we actually evaluate it:
        public const int ALIGN_SELF_AUTO = 5;
        
        // See nsStylePosition
        public const int FLEX_DIRECTION_ROW = 0;
        public const int FLEX_DIRECTION_ROW_REVERSE = 1;
        public const int FLEX_DIRECTION_COLUMN = 2;
        public const int FLEX_DIRECTION_COLUMN_REVERSE = 3;
        
        // See nsStylePosition
        // NOTE: This is the initial value of the integer-valued 'order' property
        // (rather than an internal numerical representation of some keyword).
        public const int ORDER_INITIAL = 0;
        
        // See nsStylePosition
        public const int JUSTIFY_CONTENT_FLEX_START = 0;
        public const int JUSTIFY_CONTENT_FLEX_END = 1;
        public const int JUSTIFY_CONTENT_CENTER = 2;
        public const int JUSTIFY_CONTENT_SPACE_BETWEEN = 3;
        public const int JUSTIFY_CONTENT_SPACE_AROUND = 4;
        #endif // MOZ_FLEXBOX
        
        // See nsStyleDisplay
        public const int FLOAT_NONE = 0;
        public const int FLOAT_LEFT = 1;
        public const int FLOAT_RIGHT = 2;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FONT_STYLE_NORMAL = nsFont.STYLE_NORMAL;
        public const int FONT_STYLE_ITALIC = nsFont.STYLE_ITALIC;
        public const int FONT_STYLE_OBLIQUE = nsFont.STYLE_OBLIQUE;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FONT_VARIANT_NORMAL = nsFont.VARIANT_NORMAL;
        public const int FONT_VARIANT_SMALL_CAPS = nsFont.VARIANT_SMALL_CAPS;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FONT_WEIGHT_NORMAL = nsFont.WEIGHT_NORMAL;
        public const int FONT_WEIGHT_BOLD = nsFont.WEIGHT_BOLD;
        // The constants below appear only in style sheets and not computed style.
        public const int FONT_WEIGHT_BOLDER = (-1);
        public const int FONT_WEIGHT_LIGHTER = (-2);
        
        // See nsStyleFont
        public const int FONT_SIZE_XXSMALL = 0;
        public const int FONT_SIZE_XSMALL = 1;
        public const int FONT_SIZE_SMALL = 2;
        public const int FONT_SIZE_MEDIUM = 3;
        public const int FONT_SIZE_LARGE = 4;
        public const int FONT_SIZE_XLARGE = 5;
        public const int FONT_SIZE_XXLARGE = 6;
        public const int FONT_SIZE_XXXLARGE = 7; // Only used by <font size="7">. Not specifiable in CSS.
        public const int FONT_SIZE_LARGER = 8;
        public const int FONT_SIZE_SMALLER = 9;
        
        // See nsStyleFont
        // We should eventually stop 
        public const int FONT_STRETCH_ULTRA_CONDENSED = nsFont.STRETCH_ULTRA_CONDENSED;
        public const int FONT_STRETCH_EXTRA_CONDENSED = nsFont.STRETCH_EXTRA_CONDENSED;
        public const int FONT_STRETCH_CONDENSED = nsFont.STRETCH_CONDENSED;
        public const int FONT_STRETCH_SEMI_CONDENSED = nsFont.STRETCH_SEMI_CONDENSED;
        public const int FONT_STRETCH_NORMAL = nsFont.STRETCH_NORMAL;
        public const int FONT_STRETCH_SEMI_EXPANDED = nsFont.STRETCH_SEMI_EXPANDED;
        public const int FONT_STRETCH_EXPANDED = nsFont.STRETCH_EXPANDED;
        public const int FONT_STRETCH_EXTRA_EXPANDED = nsFont.STRETCH_EXTRA_EXPANDED;
        public const int FONT_STRETCH_ULTRA_EXPANDED = nsFont.STRETCH_ULTRA_EXPANDED;
        
        // See nsStyleFont - system fonts
        public const int FONT_CAPTION = 1; // css2
        public const int FONT_ICON = 2;
        public const int FONT_MENU = 3;
        public const int FONT_MESSAGE_BOX = 4;
        public const int FONT_SMALL_CAPTION = 5;
        public const int FONT_STATUS_BAR = 6;
        public const int FONT_WINDOW = 7; // css3
        public const int FONT_DOCUMENT = 8;
        public const int FONT_WORKSPACE = 9;
        public const int FONT_DESKTOP = 10;
        public const int FONT_INFO = 11;
        public const int FONT_DIALOG = 12;
        public const int FONT_BUTTON = 13;
        public const int FONT_PULL_DOWN_MENU = 14;
        public const int FONT_LIST = 15;
        public const int FONT_FIELD = 16;
        
        // defaults per MathML spec
        public const float MATHML_DEFAULT_SCRIPT_SIZE_MULTIPLIER = 0.71f;
        public const int MATHML_DEFAULT_SCRIPT_MIN_SIZE_PT = 8;
        
        // See nsStylePosition::mWidth, mMinWidth, mMaxWidth
        public const int WIDTH_MAX_CONTENT = 0;
        public const int WIDTH_MIN_CONTENT = 1;
        public const int WIDTH_FIT_CONTENT = 2;
        public const int WIDTH_AVAILABLE = 3;
        
        // See nsStylePosition.mPosition
        public const int POSITION_STATIC = 0;
        public const int POSITION_RELATIVE = 1;
        public const int POSITION_ABSOLUTE = 2;
        public const int POSITION_FIXED = 3;
        
        // See nsStylePosition.mClip
        public const int CLIP_AUTO = 0x00;
        public const int CLIP_RECT = 0x01;
        public const int CLIP_TYPE_MASK = 0x0F;
        public const int CLIP_LEFT_AUTO = 0x10;
        public const int CLIP_TOP_AUTO = 0x20;
        public const int CLIP_RIGHT_AUTO = 0x40;
        public const int CLIP_BOTTOM_AUTO = 0x80;
        
        // FRAME/FRAMESET/IFRAME specific values including backward compatibility. Boolean values with
        // the same meaning (e.g. 1 & yes) may need to be distinguished for correct mode processing
        public const int FRAME_YES = 0;
        public const int FRAME_NO = 1;
        public const int FRAME_0 = 2;
        public const int FRAME_1 = 3;
        public const int FRAME_ON = 4;
        public const int FRAME_OFF = 5;
        public const int FRAME_AUTO = 6;
        public const int FRAME_SCROLL = 7;
        public const int FRAME_NOSCROLL = 8;
        
        // See nsStylePosition.mOverflow
        public const int OVERFLOW_VISIBLE = 0;
        public const int OVERFLOW_HIDDEN = 1;
        public const int OVERFLOW_SCROLL = 2;
        public const int OVERFLOW_AUTO = 3;
        public const int OVERFLOW_CLIP = 4;
        public const int OVERFLOW_SCROLLBARS_HORIZONTAL = 5;
        public const int OVERFLOW_SCROLLBARS_VERTICAL = 6;
        
        // See nsStyleList
        public const int LIST_STYLE_NONE = 0;
        public const int LIST_STYLE_DISC = 1;
        public const int LIST_STYLE_CIRCLE = 2;
        public const int LIST_STYLE_SQUARE = 3;
        public const int LIST_STYLE_DECIMAL = 4;
        public const int LIST_STYLE_DECIMAL_LEADING_ZERO = 5;
        public const int LIST_STYLE_LOWER_ROMAN = 6;
        public const int LIST_STYLE_UPPER_ROMAN = 7;
        public const int LIST_STYLE_LOWER_GREEK = 8;
        public const int LIST_STYLE_LOWER_ALPHA = 9;
        public const int LIST_STYLE_LOWER_LATIN = 9; // == ALPHA
        public const int LIST_STYLE_UPPER_ALPHA = 10;
        public const int LIST_STYLE_UPPER_LATIN = 10; // == ALPHA
        public const int LIST_STYLE_HEBREW = 11;
        public const int LIST_STYLE_ARMENIAN = 12;
        public const int LIST_STYLE_GEORGIAN = 13;
        public const int LIST_STYLE_CJK_IDEOGRAPHIC = 14;
        public const int LIST_STYLE_HIRAGANA = 15;
        public const int LIST_STYLE_KATAKANA = 16;
        public const int LIST_STYLE_HIRAGANA_IROHA = 17;
        public const int LIST_STYLE_KATAKANA_IROHA = 18;
        public const int LIST_STYLE_MOZ_CJK_HEAVENLY_STEM = 24;
        public const int LIST_STYLE_MOZ_CJK_EARTHLY_BRANCH = 25;
        public const int LIST_STYLE_MOZ_TRAD_CHINESE_INFORMAL = 26;
        public const int LIST_STYLE_MOZ_TRAD_CHINESE_FORMAL = 27;
        public const int LIST_STYLE_MOZ_SIMP_CHINESE_INFORMAL = 28;
        public const int LIST_STYLE_MOZ_SIMP_CHINESE_FORMAL = 29;
        public const int LIST_STYLE_MOZ_JAPANESE_INFORMAL = 30;
        public const int LIST_STYLE_MOZ_JAPANESE_FORMAL = 31;
        public const int LIST_STYLE_MOZ_ARABIC_INDIC = 32;
        public const int LIST_STYLE_MOZ_PERSIAN = 33;
        public const int LIST_STYLE_MOZ_URDU = 34;
        public const int LIST_STYLE_MOZ_DEVANAGARI = 35;
        public const int LIST_STYLE_MOZ_GURMUKHI = 36;
        public const int LIST_STYLE_MOZ_GUJARATI = 37;
        public const int LIST_STYLE_MOZ_ORIYA = 38;
        public const int LIST_STYLE_MOZ_KANNADA = 39;
        public const int LIST_STYLE_MOZ_MALAYALAM = 40;
        public const int LIST_STYLE_MOZ_BENGALI = 41;
        public const int LIST_STYLE_MOZ_TAMIL = 42;
        public const int LIST_STYLE_MOZ_TELUGU = 43;
        public const int LIST_STYLE_MOZ_THAI = 44;
        public const int LIST_STYLE_MOZ_LAO = 45;
        public const int LIST_STYLE_MOZ_MYANMAR = 46;
        public const int LIST_STYLE_MOZ_KHMER = 47;
        public const int LIST_STYLE_MOZ_HANGUL = 48;
        public const int LIST_STYLE_MOZ_HANGUL_CONSONANT = 49;
        public const int LIST_STYLE_MOZ_ETHIOPIC_HALEHAME = 50;
        public const int LIST_STYLE_MOZ_ETHIOPIC_NUMERIC = 51;
        public const int LIST_STYLE_MOZ_ETHIOPIC_HALEHAME_AM = 52;
        public const int LIST_STYLE_MOZ_ETHIOPIC_HALEHAME_TI_ER = 53;
        public const int LIST_STYLE_MOZ_ETHIOPIC_HALEHAME_TI_ET = 54;
        
        // See nsStyleList
        public const int LIST_STYLE_POSITION_INSIDE = 0;
        public const int LIST_STYLE_POSITION_OUTSIDE = 1;
        
        // See nsStyleMargin
        public const int MARGIN_SIZE_AUTO = 0;
        
        // See nsStyleVisibility
        public const int POINTER_EVENTS_NONE = 0;
        public const int POINTER_EVENTS_VISIBLEPAINTED = 1;
        public const int POINTER_EVENTS_VISIBLEFILL = 2;
        public const int POINTER_EVENTS_VISIBLESTROKE = 3;
        public const int POINTER_EVENTS_VISIBLE = 4;
        public const int POINTER_EVENTS_PAINTED = 5;
        public const int POINTER_EVENTS_FILL = 6;
        public const int POINTER_EVENTS_STROKE = 7;
        public const int POINTER_EVENTS_ALL = 8;
        public const int POINTER_EVENTS_AUTO = 9;
        
        // See nsStyleDisplay
        public const int RESIZE_NONE = 0;
        public const int RESIZE_BOTH = 1;
        public const int RESIZE_HORIZONTAL = 2;
        public const int RESIZE_VERTICAL = 3;
        
        // See nsStyleText
        public const int TEXT_ALIGN_DEFAULT = 0;
        public const int TEXT_ALIGN_LEFT = 1;
        public const int TEXT_ALIGN_RIGHT = 2;
        public const int TEXT_ALIGN_CENTER = 3;
        public const int TEXT_ALIGN_JUSTIFY = 4;
        public const int TEXT_ALIGN_CHAR = 5; //align based on a certain character, for table cell
        public const int TEXT_ALIGN_END = 6;
        public const int TEXT_ALIGN_AUTO = 7;
        public const int TEXT_ALIGN_MOZ_CENTER = 8;
        public const int TEXT_ALIGN_MOZ_RIGHT = 9;
        public const int TEXT_ALIGN_MOZ_LEFT = 10;
        // NS_STYLE_TEXT_ALIGN_MOZ_CENTER_OR_INHERIT is only used in data structs; it
        // is never present in stylesheets or computed data.
        public const int TEXT_ALIGN_MOZ_CENTER_OR_INHERIT = 11;
        // Note: make sure that the largest NS_STYLE_TEXT_ALIGN_* value is smaller than
        // the smallest NS_STYLE_VERTICAL_ALIGN_* value below!
        
        // See nsStyleText
        public const int TEXT_BLINK_NONE = 0;
        public const int TEXT_BLINK_BLINK = 1;
        
        // See nsStyleText, nsStyleFont
        public const int TEXT_DECORATION_LINE_NONE = 0;
        public const int TEXT_DECORATION_LINE_UNDERLINE = nsFont.DECORATION_UNDERLINE;
        public const int TEXT_DECORATION_LINE_OVERLINE = nsFont.DECORATION_OVERLINE;
        public const int TEXT_DECORATION_LINE_LINE_THROUGH = nsFont.DECORATION_LINE_THROUGH;
        public const int TEXT_DECORATION_LINE_BLINK = 0x08;
        public const int TEXT_DECORATION_LINE_PREF_ANCHORS = 0x10;
        // OVERRIDE_ALL does not occur in stylesheets; it only comes from HTML
        // attribute mapping (and thus appears in computed data)
        public const int TEXT_DECORATION_LINE_OVERRIDE_ALL = 0x20;
        public const int TEXT_DECORATION_LINE_LINES_MASK = TEXT_DECORATION_LINE_UNDERLINE | TEXT_DECORATION_LINE_OVERLINE | TEXT_DECORATION_LINE_LINE_THROUGH;
        
        // See nsStyleText
        public const int TEXT_DECORATION_STYLE_NONE = 0; // not in CSS spec, mapped to -moz-none
        public const int TEXT_DECORATION_STYLE_DOTTED = 1;
        public const int TEXT_DECORATION_STYLE_DASHED = 2;
        public const int TEXT_DECORATION_STYLE_SOLID = 3;
        public const int TEXT_DECORATION_STYLE_DOUBLE = 4;
        public const int TEXT_DECORATION_STYLE_WAVY = 5;
        public const int TEXT_DECORATION_STYLE_MAX = TEXT_DECORATION_STYLE_WAVY;
        
        // See nsStyleTextOverflow
        public const int TEXT_OVERFLOW_CLIP = 0;
        public const int TEXT_OVERFLOW_ELLIPSIS = 1;
        public const int TEXT_OVERFLOW_STRING = 2;
        
        // See nsStyleText
        public const int TEXT_TRANSFORM_NONE = 0;
        public const int TEXT_TRANSFORM_CAPITALIZE = 1;
        public const int TEXT_TRANSFORM_LOWERCASE = 2;
        public const int TEXT_TRANSFORM_UPPERCASE = 3;
        public const int TEXT_TRANSFORM_FULLWIDTH = 4;
        
        // See nsStyleDisplay
        public const int TRANSITION_TIMING_FUNCTION_EASE = 0;
        public const int TRANSITION_TIMING_FUNCTION_LINEAR = 1;
        public const int TRANSITION_TIMING_FUNCTION_EASE_IN = 2;
        public const int TRANSITION_TIMING_FUNCTION_EASE_OUT = 3;
        public const int TRANSITION_TIMING_FUNCTION_EASE_IN_OUT = 4;
        public const int TRANSITION_TIMING_FUNCTION_STEP_START = 5;
        public const int TRANSITION_TIMING_FUNCTION_STEP_END = 6;
        
        // See nsStyleText
        // Note: these values pickup after the text-align values because there
        // are a few html cases where an object can have both types of
        // alignment applied with a single attribute
        public const int VERTICAL_ALIGN_BASELINE = 12;
        public const int VERTICAL_ALIGN_SUB = 13;
        public const int VERTICAL_ALIGN_SUPER = 14;
        public const int VERTICAL_ALIGN_TOP = 15;
        public const int VERTICAL_ALIGN_TEXT_TOP = 16;
        public const int VERTICAL_ALIGN_MIDDLE = 17;
        public const int VERTICAL_ALIGN_TEXT_BOTTOM = 18;
        public const int VERTICAL_ALIGN_BOTTOM = 19;
        public const int VERTICAL_ALIGN_MIDDLE_WITH_BASELINE = 20;
        
        // See nsStyleVisibility
        public const int VISIBILITY_HIDDEN = 0;
        public const int VISIBILITY_VISIBLE = 1;
        public const int VISIBILITY_COLLAPSE = 2;
        
        // See nsStyleText
        public const int TABSIZE_INITIAL = 8;
        
        // See nsStyleText
        public const int WHITESPACE_NORMAL = 0;
        public const int WHITESPACE_PRE = 1;
        public const int WHITESPACE_NOWRAP = 2;
        public const int WHITESPACE_PRE_WRAP = 3;
        public const int WHITESPACE_PRE_LINE = 4;
        public const int WHITESPACE_PRE_DISCARD_NEWLINES = 5;
        
        // See nsStyleText
        public const int WORDBREAK_NORMAL = 0;
        public const int WORDBREAK_BREAK_ALL = 1;
        public const int WORDBREAK_KEEP_ALL = 2;
        
        // See nsStyleText
        public const int WORDWRAP_NORMAL = 0;
        public const int WORDWRAP_BREAK_WORD = 1;
        
        // See nsStyleText
        public const int HYPHENS_NONE = 0;
        public const int HYPHENS_MANUAL = 1;
        public const int HYPHENS_AUTO = 2;
        
        // See nsStyleText
        public const int TEXT_SIZE_ADJUST_NONE = 0;
        public const int TEXT_SIZE_ADJUST_AUTO = 1;
        
        // See nsStyleText
        public const int LINE_HEIGHT_BLOCK_HEIGHT = 0;
        
        // See nsStyleText
        public const int UNICODE_BIDI_NORMAL = 0x0;
        public const int UNICODE_BIDI_EMBED = 0x1;
        public const int UNICODE_BIDI_ISOLATE = 0x2;
        public const int UNICODE_BIDI_OVERRIDE = 0x4;
        public const int UNICODE_BIDI_ISOLATE_OVERRIDE = 0x6;
        public const int UNICODE_BIDI_PLAINTEXT = 0x8;
        
        // See nsStyleTable (here for HTML 4.0 for now, should probably change to side flags)
        public const int TABLE_FRAME_NONE = 0;
        public const int TABLE_FRAME_ABOVE = 1;
        public const int TABLE_FRAME_BELOW = 2;
        public const int TABLE_FRAME_HSIDES = 3;
        public const int TABLE_FRAME_VSIDES = 4;
        public const int TABLE_FRAME_LEFT = 5;
        public const int TABLE_FRAME_RIGHT = 6;
        public const int TABLE_FRAME_BOX = 7;
        public const int TABLE_FRAME_BORDER = 8;
        
        // See nsStyleTable
        public const int TABLE_RULES_NONE = 0;
        public const int TABLE_RULES_GROUPS = 1;
        public const int TABLE_RULES_ROWS = 2;
        public const int TABLE_RULES_COLS = 3;
        public const int TABLE_RULES_ALL = 4;
        
        public const int TABLE_LAYOUT_AUTO = 0;
        public const int TABLE_LAYOUT_FIXED = 1;
        
        public const int TABLE_EMPTY_CELLS_HIDE = 0;
        public const int TABLE_EMPTY_CELLS_SHOW = 1;
        public const int TABLE_EMPTY_CELLS_SHOW_BACKGROUND = 2;
        
        public const int CAPTION_SIDE_TOP = 0;
        public const int CAPTION_SIDE_RIGHT = 1;
        public const int CAPTION_SIDE_BOTTOM = 2;
        public const int CAPTION_SIDE_LEFT = 3;
        public const int CAPTION_SIDE_TOP_OUTSIDE = 4;
        public const int CAPTION_SIDE_BOTTOM_OUTSIDE = 5;
        
        // constants for cell "scope" attribute
        public const int CELL_SCOPE_ROW = 0;
        public const int CELL_SCOPE_COL = 1;
        public const int CELL_SCOPE_ROWGROUP = 2;
        public const int CELL_SCOPE_COLGROUP = 3;
        
        // See nsStylePage
        public const int PAGE_MARKS_NONE = 0x00;
        public const int PAGE_MARKS_CROP = 0x01;
        public const int PAGE_MARKS_REGISTER = 0x02;
        
        // See nsStylePage
        public const int PAGE_SIZE_AUTO = 0;
        public const int PAGE_SIZE_PORTRAIT = 1;
        public const int PAGE_SIZE_LANDSCAPE = 2;
        
        // See nsStyleBreaks
        public const int PAGE_BREAK_AUTO = 0;
        public const int PAGE_BREAK_ALWAYS = 1;
        public const int PAGE_BREAK_AVOID = 2;
        public const int PAGE_BREAK_LEFT = 3;
        public const int PAGE_BREAK_RIGHT = 4;
        
        // See nsStyleColumn
        public const int COLUMN_COUNT_AUTO = 0;
        public const int COLUMN_COUNT_UNLIMITED = (-1);
        
        public const int COLUMN_FILL_AUTO = 0;
        public const int COLUMN_FILL_BALANCE = 1;
        
        // See nsStyleUIReset
        public const int IME_MODE_AUTO = 0;
        public const int IME_MODE_NORMAL = 1;
        public const int IME_MODE_ACTIVE = 2;
        public const int IME_MODE_DISABLED = 3;
        public const int IME_MODE_INACTIVE = 4;
        
        // See nsStyleGradient
        public const int GRADIENT_SHAPE_LINEAR = 0;
        public const int GRADIENT_SHAPE_ELLIPTICAL = 1;
        public const int GRADIENT_SHAPE_CIRCULAR = 2;
        
        public const int GRADIENT_SIZE_CLOSEST_SIDE = 0;
        public const int GRADIENT_SIZE_CLOSEST_CORNER = 1;
        public const int GRADIENT_SIZE_FARTHEST_SIDE = 2;
        public const int GRADIENT_SIZE_FARTHEST_CORNER = 3;
        public const int GRADIENT_SIZE_EXPLICIT_SIZE = 4;
        
        // See nsStyleSVG
        
        // dominant-baseline
        public const int DOMINANT_BASELINE_AUTO = 0;
        public const int DOMINANT_BASELINE_USE_SCRIPT = 1;
        public const int DOMINANT_BASELINE_NO_CHANGE = 2;
        public const int DOMINANT_BASELINE_RESET_SIZE = 3;
        public const int DOMINANT_BASELINE_IDEOGRAPHIC = 4;
        public const int DOMINANT_BASELINE_ALPHABETIC = 5;
        public const int DOMINANT_BASELINE_HANGING = 6;
        public const int DOMINANT_BASELINE_MATHEMATICAL = 7;
        public const int DOMINANT_BASELINE_CENTRAL = 8;
        public const int DOMINANT_BASELINE_MIDDLE = 9;
        public const int DOMINANT_BASELINE_TEXT_AFTER_EDGE = 10;
        public const int DOMINANT_BASELINE_TEXT_BEFORE_EDGE = 11;
        
        // fill-rule
        public const int FILL_RULE_NONZERO = 0;
        public const int FILL_RULE_EVENODD = 1;
        
        // image-rendering
        public const int IMAGE_RENDERING_AUTO = 0;
        public const int IMAGE_RENDERING_OPTIMIZESPEED = 1;
        public const int IMAGE_RENDERING_OPTIMIZEQUALITY = 2;
        public const int IMAGE_RENDERING_CRISPEDGES = 3;
        
        // mask-type
        public const int MASK_TYPE_LUMINANCE = 0;
        public const int MASK_TYPE_ALPHA = 1;
        
        // paint-order
        public const int PAINT_ORDER_NORMAL = 0;
        public const int PAINT_ORDER_FILL = 1;
        public const int PAINT_ORDER_STROKE = 2;
        public const int PAINT_ORDER_MARKERS = 3;
        public const int PAINT_ORDER_LAST_VALUE = PAINT_ORDER_MARKERS;
        // NS_STYLE_PAINT_ORDER_BITWIDTH is the number of bits required to store
        // a single paint-order component value.
        public const int PAINT_ORDER_BITWIDTH = 2;
        
        // shape-rendering
        public const int SHAPE_RENDERING_AUTO = 0;
        public const int SHAPE_RENDERING_OPTIMIZESPEED = 1;
        public const int SHAPE_RENDERING_CRISPEDGES = 2;
        public const int SHAPE_RENDERING_GEOMETRICPRECISION = 3;
        
        // stroke-linecap
        public const int STROKE_LINECAP_BUTT = 0;
        public const int STROKE_LINECAP_ROUND = 1;
        public const int STROKE_LINECAP_SQUARE = 2;
        
        // stroke-linejoin
        public const int STROKE_LINEJOIN_MITER = 0;
        public const int STROKE_LINEJOIN_ROUND = 1;
        public const int STROKE_LINEJOIN_BEVEL = 2;
        
        // stroke-dasharray, stroke-dashoffset, stroke-width
        public const int STROKE_PROP_OBJECTVALUE = 0;
        
        // text-anchor
        public const int TEXT_ANCHOR_START = 0;
        public const int TEXT_ANCHOR_MIDDLE = 1;
        public const int TEXT_ANCHOR_END = 2;
        
        // text-rendering
        public const int TEXT_RENDERING_AUTO = 0;
        public const int TEXT_RENDERING_OPTIMIZESPEED = 1;
        public const int TEXT_RENDERING_OPTIMIZELEGIBILITY = 2;
        public const int TEXT_RENDERING_GEOMETRICPRECISION = 3;
        
        // color-interpolation and color-interpolation-filters
        public const int COLOR_INTERPOLATION_AUTO = 0;
        public const int COLOR_INTERPOLATION_SRGB = 1;
        public const int COLOR_INTERPOLATION_LINEARRGB = 2;
        
        // vector-effect
        public const int VECTOR_EFFECT_NONE = 0;
        public const int VECTOR_EFFECT_NON_SCALING_STROKE = 1;
        
        // 3d Transforms - Backface visibility
        public const int BACKFACE_VISIBILITY_VISIBLE = 1;
        public const int BACKFACE_VISIBILITY_HIDDEN = 0;
        
        public const int TRANSFORM_STYLE_FLAT = 0;
        public const int TRANSFORM_STYLE_PRESERVE_3D = 1;
        
        // object {fill,stroke}-opacity for SVG glyphs
        public const int OBJECT_FILL_OPACITY = 0;
        public const int OBJECT_STROKE_OPACITY = 1;
        
        /*****************************************************************************
         * Constants for media features.                                             *
         *****************************************************************************/
        
        // orientation
        public const int ORIENTATION_PORTRAIT = 0;
        public const int ORIENTATION_LANDSCAPE = 1;
        
        // scan
        public const int SCAN_PROGRESSIVE = 0;
        public const int SCAN_INTERLACE = 1;
    }
}
