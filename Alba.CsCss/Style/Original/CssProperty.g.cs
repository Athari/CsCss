//
// Generated file. Do not edit manually.
//

using System.ComponentModel;

namespace Alba.CsCss.Style
{
    /// <summary>
    /// A property is a named style attribute or parameter for a markup element specified in a stylesheet declaration, e.g. color, background, font-family, margin etc., which is assigned a specific value. Properties are always followed by a colon to separate them from their value pair.
    /// </summary>
    public enum CssProperty
    {
        Unknown = -1,
        /// <summary>
        /// Longhand property "-moz-appearance".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "appearance" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-appearance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Appearance,
        /// <summary>
        /// Longhand property "-moz-outline-radius-topleft".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "outline-radius-topleft" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-outline-radius-topleft
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozOutlineRadiusTopLeft,
        /// <summary>
        /// Longhand property "-moz-outline-radius-topright".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "outline-radius-topright" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-outline-radius-topright
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozOutlineRadiusTopRight,
        /// <summary>
        /// Longhand property "-moz-outline-radius-bottomright".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "outline-radius-bottomright" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-outline-radius-bottomright
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozOutlineRadiusBottomRight,
        /// <summary>
        /// Longhand property "-moz-outline-radius-bottomleft".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "outline-radius-bottomleft" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-outline-radius-bottomleft
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozOutlineRadiusBottomLeft,
        /// <summary>
        /// Longhand property "-moz-tab-size".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "tab-size" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-tab-size
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozTabSize,
        /// <summary>
        /// Longhand property "-x-system-font".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "system-font" is not supported.
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-x-system-font
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        XSystemFont,
        /// <summary>
        /// Longhand property "animation-delay".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='CssValue.Float'>time</see> (<see cref='CssUnit.Seconds'/> etc.).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-delay
        /// </summary>
        AnimationDelay,
        /// <summary>
        /// Longhand property "animation-direction".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-direction
        /// </summary>
        AnimationDirection,
        /// <summary>
        /// Longhand property "animation-duration".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='CssValue.Float'>time</see> (<see cref='CssUnit.Seconds'/> etc.).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-duration
        /// </summary>
        AnimationDuration,
        /// <summary>
        /// Longhand property "animation-fill-mode".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-fill-mode
        /// </summary>
        AnimationFillMode,
        /// <summary>
        /// Longhand property "animation-iteration-count".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-iteration-count
        /// </summary>
        AnimationIterationCount,
        /// <summary>
        /// Longhand property "animation-name".
        /// The property contains a list of values of one of the following types:
        ///   none (<see cref='CssUnit.None'/>),
        ///   <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-name
        /// </summary>
        AnimationName,
        /// <summary>
        /// Longhand property "animation-play-state".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-play-state
        /// </summary>
        AnimationPlayState,
        /// <summary>
        /// Longhand property "animation-timing-function".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Array'>cubic-bezier() or steps()</see> (<see cref='CssUnit.CubicBezier'/> or <see cref='CssUnit.Steps'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation-timing-function
        /// </summary>
        AnimationTimingFunction,
        /// <summary>
        /// Longhand property "background-attachment".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-attachment
        /// </summary>
        BackgroundAttachment,
        /// <summary>
        /// Longhand property "background-clip".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-clip
        /// </summary>
        BackgroundClip,
        /// <summary>
        /// Longhand property "background-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-color
        /// </summary>
        BackgroundColor,
        /// <summary>
        /// Longhand property "background-image".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>), none (<see cref='CssUnit.None'/>), <see cref='CssValue.Gradient'>gradient</see> (<see cref='CssUnit.Gradient'/>), <see cref='CssValue.Array'>function</see> (<see cref='CssUnit.Function'/>), <see cref='CssValue.String'>element</see> (<see cref='CssUnit.Element'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-image
        /// </summary>
        BackgroundImage,
        /// <summary>
        /// Longhand property "-moz-background-inline-policy".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "background-inline-policy" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-background-inline-policy
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozBackgroundInlinePolicy,
        /// <summary>
        /// Longhand property "background-origin".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-origin
        /// </summary>
        BackgroundOrigin,
        /// <summary>
        /// Longhand property "background-position".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-position
        /// </summary>
        BackgroundPosition,
        /// <summary>
        /// Longhand property "background-repeat".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-repeat
        /// </summary>
        BackgroundRepeat,
        /// <summary>
        /// Longhand property "background-size".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background-size
        /// </summary>
        BackgroundSize,
        /// <summary>
        /// Longhand property "-moz-binding".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "binding" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-binding
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Binding,
        /// <summary>
        /// Longhand property "border-bottom-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom-color
        /// </summary>
        BorderBottomColor,
        /// <summary>
        /// Longhand property "-moz-border-bottom-colors".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-bottom-colors" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-bottom-colors
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderBottomColors,
        /// <summary>
        /// Longhand property "border-bottom-style".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom-style
        /// </summary>
        BorderBottomStyle,
        /// <summary>
        /// Longhand property "border-bottom-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom-width
        /// </summary>
        BorderBottomWidth,
        /// <summary>
        /// Longhand property "border-collapse".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-collapse
        /// </summary>
        BorderCollapse,
        /// <summary>
        /// Longhand property "border-end-color-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-end-color-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderEndColorValue,
        /// <summary>
        /// Longhand property "border-end-style-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-end-style-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderEndStyleValue,
        /// <summary>
        /// Longhand property "border-end-width-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-end-width-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderEndWidthValue,
        /// <summary>
        /// Longhand property "border-image-source".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image-source
        /// </summary>
        BorderImageSource,
        /// <summary>
        /// Longhand property "border-image-slice".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image-slice
        /// </summary>
        BorderImageSlice,
        /// <summary>
        /// Longhand property "border-image-width".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image-width
        /// </summary>
        BorderImageWidth,
        /// <summary>
        /// Longhand property "border-image-outset".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image-outset
        /// </summary>
        BorderImageOutset,
        /// <summary>
        /// Longhand property "border-image-repeat".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image-repeat
        /// </summary>
        BorderImageRepeat,
        /// <summary>
        /// Longhand property "border-left-color-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-color-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftColorValue,
        /// <summary>
        /// Longhand property "border-left-color-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-color-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftColorLtrSource,
        /// <summary>
        /// Longhand property "border-left-color-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-color-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftColorRtlSource,
        /// <summary>
        /// Longhand property "-moz-border-left-colors".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-left-colors" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-left-colors
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderLeftColors,
        /// <summary>
        /// Longhand property "border-left-style-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-style-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftStyleValue,
        /// <summary>
        /// Longhand property "border-left-style-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-style-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftStyleLtrSource,
        /// <summary>
        /// Longhand property "border-left-style-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-style-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftStyleRtlSource,
        /// <summary>
        /// Longhand property "border-left-width-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-width-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftWidthValue,
        /// <summary>
        /// Longhand property "border-left-width-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-width-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftWidthLtrSource,
        /// <summary>
        /// Longhand property "border-left-width-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-width-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderLeftWidthRtlSource,
        /// <summary>
        /// Longhand property "border-right-color-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-color-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightColorValue,
        /// <summary>
        /// Longhand property "border-right-color-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-color-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightColorLtrSource,
        /// <summary>
        /// Longhand property "border-right-color-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-color-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightColorRtlSource,
        /// <summary>
        /// Longhand property "-moz-border-right-colors".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-right-colors" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-right-colors
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderRightColors,
        /// <summary>
        /// Longhand property "border-right-style-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-style-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightStyleValue,
        /// <summary>
        /// Longhand property "border-right-style-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-style-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightStyleLtrSource,
        /// <summary>
        /// Longhand property "border-right-style-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-style-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightStyleRtlSource,
        /// <summary>
        /// Longhand property "border-right-width-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-width-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightWidthValue,
        /// <summary>
        /// Longhand property "border-right-width-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-width-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightWidthLtrSource,
        /// <summary>
        /// Longhand property "border-right-width-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-width-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderRightWidthRtlSource,
        /// <summary>
        /// Longhand property "border-spacing".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-spacing
        /// </summary>
        BorderSpacing,
        /// <summary>
        /// Longhand property "border-start-color-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-start-color-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderStartColorValue,
        /// <summary>
        /// Longhand property "border-start-style-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-start-style-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderStartStyleValue,
        /// <summary>
        /// Longhand property "border-start-width-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-start-width-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        BorderStartWidthValue,
        /// <summary>
        /// Longhand property "border-top-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top-color
        /// </summary>
        BorderTopColor,
        /// <summary>
        /// Longhand property "-moz-border-top-colors".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-top-colors" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-top-colors
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderTopColors,
        /// <summary>
        /// Longhand property "border-top-style".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top-style
        /// </summary>
        BorderTopStyle,
        /// <summary>
        /// Longhand property "border-top-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top-width
        /// </summary>
        BorderTopWidth,
        /// <summary>
        /// Longhand property "border-top-left-radius".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top-left-radius
        /// </summary>
        BorderTopLeftRadius,
        /// <summary>
        /// Longhand property "border-top-right-radius".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top-right-radius
        /// </summary>
        BorderTopRightRadius,
        /// <summary>
        /// Longhand property "border-bottom-right-radius".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom-right-radius
        /// </summary>
        BorderBottomRightRadius,
        /// <summary>
        /// Longhand property "border-bottom-left-radius".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom-left-radius
        /// </summary>
        BorderBottomLeftRadius,
        /// <summary>
        /// Longhand property "bottom".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/bottom
        /// </summary>
        Bottom,
        /// <summary>
        /// Longhand property "box-shadow".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/box-shadow
        /// </summary>
        BoxShadow,
        /// <summary>
        /// Longhand property "-moz-box-sizing".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-sizing" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-sizing
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxSizing,
        /// <summary>
        /// Longhand property "caption-side".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/caption-side
        /// </summary>
        CaptionSide,
        /// <summary>
        /// Longhand property "clear".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/clear
        /// </summary>
        Clear,
        /// <summary>
        /// Longhand property "clip".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/clip
        /// </summary>
        Clip,
        /// <summary>
        /// Longhand property "color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/color
        /// </summary>
        Color,
        /// <summary>
        /// Longhand property "-moz-column-count".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-count" is not supported.
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-count
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnCount,
        /// <summary>
        /// Longhand property "-moz-column-fill".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-fill" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-fill
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnFill,
        /// <summary>
        /// Longhand property "-moz-column-width".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-width" is not supported.
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-width
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnWidth,
        /// <summary>
        /// Longhand property "-moz-column-gap".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-gap" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   normal (<see cref='CssUnit.Normal'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-gap
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnGap,
        /// <summary>
        /// Longhand property "-moz-column-rule-color".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-rule-color" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-rule-color
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnRuleColor,
        /// <summary>
        /// Longhand property "-moz-column-rule-style".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-rule-style" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-rule-style
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnRuleStyle,
        /// <summary>
        /// Longhand property "-moz-column-rule-width".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-rule-width" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-rule-width
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnRuleWidth,
        /// <summary>
        /// Longhand property "content".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/content
        /// </summary>
        Content,
        /// <summary>
        /// Longhand property "counter-increment".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/counter-increment
        /// </summary>
        CounterIncrement,
        /// <summary>
        /// Longhand property "counter-reset".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/counter-reset
        /// </summary>
        CounterReset,
        /// <summary>
        /// Longhand property "cursor".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/cursor
        /// </summary>
        Cursor,
        /// <summary>
        /// Longhand property "direction".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/direction
        /// </summary>
        Direction,
        /// <summary>
        /// Longhand property "display".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/display
        /// </summary>
        Display,
        /// <summary>
        /// Longhand property "empty-cells".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/empty-cells
        /// </summary>
        EmptyCells,
        /// <summary>
        /// Longhand property "align-items".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/align-items
        /// </summary>
        AlignItems,
        /// <summary>
        /// Longhand property "align-self".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/align-self
        /// </summary>
        AlignSelf,
        /// <summary>
        /// Longhand property "flex-basis".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flex-basis
        /// </summary>
        FlexBasis,
        /// <summary>
        /// Longhand property "flex-direction".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flex-direction
        /// </summary>
        FlexDirection,
        /// <summary>
        /// Longhand property "flex-grow".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flex-grow
        /// </summary>
        FlexGrow,
        /// <summary>
        /// Longhand property "flex-shrink".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flex-shrink
        /// </summary>
        FlexShrink,
        /// <summary>
        /// Longhand property "order".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/order
        /// </summary>
        Order,
        /// <summary>
        /// Longhand property "justify-content".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/justify-content
        /// </summary>
        JustifyContent,
        /// <summary>
        /// Longhand property "float".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/float
        /// </summary>
        Float,
        /// <summary>
        /// Longhand property "-moz-float-edge".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "float-edge" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-float-edge
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FloatEdge,
        /// <summary>
        /// Longhand property "font-family".
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-family
        /// </summary>
        FontFamily,
        /// <summary>
        /// Longhand property "-moz-font-feature-settings".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "font-feature-settings" is not supported.
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-font-feature-settings
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FontFeatureSettings,
        /// <summary>
        /// Longhand property "-moz-font-language-override".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "font-language-override" is not supported.
        /// The property contains a single value of one of the following types:
        ///   normal (<see cref='CssUnit.Normal'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.String'>string</see> (<see cref='CssUnit.String'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-font-language-override
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FontLanguageOverride,
        /// <summary>
        /// Longhand property "font-size".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-size
        /// </summary>
        FontSize,
        /// <summary>
        /// Longhand property "font-size-adjust".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   none (<see cref='CssUnit.None'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-size-adjust
        /// </summary>
        FontSizeAdjust,
        /// <summary>
        /// Longhand property "font-stretch".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-stretch
        /// </summary>
        FontStretch,
        /// <summary>
        /// Longhand property "font-style".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-style
        /// </summary>
        FontStyle,
        /// <summary>
        /// Longhand property "font-variant".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-variant
        /// </summary>
        FontVariant,
        /// <summary>
        /// Longhand property "font-weight".
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font-weight
        /// </summary>
        FontWeight,
        /// <summary>
        /// Longhand property "-moz-force-broken-image-icon".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "force-broken-image-icon" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-force-broken-image-icon
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ForceBrokenImageIcon,
        /// <summary>
        /// Longhand property "height".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/height
        /// </summary>
        Height,
        /// <summary>
        /// Longhand property "-moz-image-region".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "image-region" is not supported.
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-image-region
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageRegion,
        /// <summary>
        /// Longhand property "ime-mode".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/ime-mode
        /// </summary>
        ImeMode,
        /// <summary>
        /// Longhand property "left".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/left
        /// </summary>
        Left,
        /// <summary>
        /// Longhand property "letter-spacing".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   normal (<see cref='CssUnit.Normal'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/letter-spacing
        /// </summary>
        LetterSpacing,
        /// <summary>
        /// Longhand property "line-height".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   normal (<see cref='CssUnit.Normal'/>),
        ///   system font (<see cref='CssUnit.SystemFont'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/line-height
        /// </summary>
        LineHeight,
        /// <summary>
        /// Longhand property "list-style-image".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/list-style-image
        /// </summary>
        ListStyleImage,
        /// <summary>
        /// Longhand property "list-style-position".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/list-style-position
        /// </summary>
        ListStylePosition,
        /// <summary>
        /// Longhand property "list-style-type".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/list-style-type
        /// </summary>
        ListStyleType,
        /// <summary>
        /// Longhand property "margin-bottom".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-bottom
        /// </summary>
        MarginBottom,
        /// <summary>
        /// Longhand property "margin-end-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-end-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginEndValue,
        /// <summary>
        /// Longhand property "margin-left-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-left-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginLeftValue,
        /// <summary>
        /// Longhand property "margin-left-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-left-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginLeftLtrSource,
        /// <summary>
        /// Longhand property "margin-left-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-left-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginLeftRtlSource,
        /// <summary>
        /// Longhand property "margin-right-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-right-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginRightValue,
        /// <summary>
        /// Longhand property "margin-right-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-right-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginRightLtrSource,
        /// <summary>
        /// Longhand property "margin-right-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-right-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginRightRtlSource,
        /// <summary>
        /// Longhand property "margin-start-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-start-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MarginStartValue,
        /// <summary>
        /// Longhand property "margin-top".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-top
        /// </summary>
        MarginTop,
        /// <summary>
        /// Longhand property "marker-offset".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marker-offset
        /// </summary>
        MarkerOffset,
        /// <summary>
        /// Longhand property "marks".
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marks
        /// </summary>
        Marks,
        /// <summary>
        /// Longhand property "max-height".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   none (<see cref='CssUnit.None'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/max-height
        /// </summary>
        MaxHeight,
        /// <summary>
        /// Longhand property "max-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   none (<see cref='CssUnit.None'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/max-width
        /// </summary>
        MaxWidth,
        /// <summary>
        /// Longhand property "min-height".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/min-height
        /// </summary>
        MinHeight,
        /// <summary>
        /// Longhand property "min-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/min-width
        /// </summary>
        MinWidth,
        /// <summary>
        /// Longhand property "opacity".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/opacity
        /// </summary>
        Opacity,
        /// <summary>
        /// Longhand property "-moz-orient".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "orient" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-orient
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Orient,
        /// <summary>
        /// Longhand property "orphans".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/orphans
        /// </summary>
        Orphans,
        /// <summary>
        /// Longhand property "outline-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/outline-color
        /// </summary>
        OutlineColor,
        /// <summary>
        /// Longhand property "outline-style".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/outline-style
        /// </summary>
        OutlineStyle,
        /// <summary>
        /// Longhand property "outline-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/outline-width
        /// </summary>
        OutlineWidth,
        /// <summary>
        /// Longhand property "outline-offset".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/outline-offset
        /// </summary>
        OutlineOffset,
        /// <summary>
        /// Longhand property "overflow-x".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/overflow-x
        /// </summary>
        OverflowX,
        /// <summary>
        /// Longhand property "overflow-y".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/overflow-y
        /// </summary>
        OverflowY,
        /// <summary>
        /// Longhand property "padding-bottom".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-bottom
        /// </summary>
        PaddingBottom,
        /// <summary>
        /// Longhand property "padding-end-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-end-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingEndValue,
        /// <summary>
        /// Longhand property "padding-left-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-left-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingLeftValue,
        /// <summary>
        /// Longhand property "padding-left-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-left-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingLeftLtrSource,
        /// <summary>
        /// Longhand property "padding-left-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-left-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingLeftRtlSource,
        /// <summary>
        /// Longhand property "padding-right-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-right-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingRightValue,
        /// <summary>
        /// Longhand property "padding-right-ltr-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-right-ltr-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingRightLtrSource,
        /// <summary>
        /// Longhand property "padding-right-rtl-source".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-right-rtl-source
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingRightRtlSource,
        /// <summary>
        /// Longhand property "padding-start-value".
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-start-value
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        PaddingStartValue,
        /// <summary>
        /// Longhand property "padding-top".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-top
        /// </summary>
        PaddingTop,
        /// <summary>
        /// Longhand property "page".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/page
        /// </summary>
        Page,
        /// <summary>
        /// Longhand property "page-break-after".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/page-break-after
        /// </summary>
        PageBreakAfter,
        /// <summary>
        /// Longhand property "page-break-before".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/page-break-before
        /// </summary>
        PageBreakBefore,
        /// <summary>
        /// Longhand property "page-break-inside".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/page-break-inside
        /// </summary>
        PageBreakInside,
        /// <summary>
        /// Longhand property "paint-order".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/paint-order
        /// </summary>
        PaintOrder,
        /// <summary>
        /// Longhand property "pointer-events".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/pointer-events
        /// </summary>
        PointerEvents,
        /// <summary>
        /// Longhand property "position".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/position
        /// </summary>
        Position,
        /// <summary>
        /// Longhand property "quotes".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/quotes
        /// </summary>
        Quotes,
        /// <summary>
        /// Longhand property "resize".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/resize
        /// </summary>
        Resize,
        /// <summary>
        /// Longhand property "right".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/right
        /// </summary>
        Right,
        /// <summary>
        /// Longhand property "size".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/size
        /// </summary>
        Size,
        /// <summary>
        /// Longhand property "table-layout".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/table-layout
        /// </summary>
        TableLayout,
        /// <summary>
        /// Longhand property "text-align".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-align
        /// </summary>
        TextAlign,
        /// <summary>
        /// Longhand property "-moz-text-align-last".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-align-last" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-align-last
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextAlignLast,
        /// <summary>
        /// Longhand property "-moz-text-blink".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-blink" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-blink
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextBlink,
        /// <summary>
        /// Longhand property "-moz-text-decoration-color".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-decoration-color" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-decoration-color
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextDecorationColor,
        /// <summary>
        /// Longhand property "-moz-text-decoration-line".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-decoration-line" is not supported.
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-decoration-line
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextDecorationLine,
        /// <summary>
        /// Longhand property "-moz-text-decoration-style".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-decoration-style" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-decoration-style
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextDecorationStyle,
        /// <summary>
        /// Longhand property "text-indent".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-indent
        /// </summary>
        TextIndent,
        /// <summary>
        /// Longhand property "text-overflow".
        /// The property contains a single value of one of the following types:
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-overflow
        /// </summary>
        TextOverflow,
        /// <summary>
        /// Longhand property "text-shadow".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-shadow
        /// </summary>
        TextShadow,
        /// <summary>
        /// Longhand property "-moz-text-size-adjust".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "text-size-adjust" is not supported.
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   none (<see cref='CssUnit.None'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-text-size-adjust
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        TextSizeAdjust,
        /// <summary>
        /// Longhand property "text-transform".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-transform
        /// </summary>
        TextTransform,
        /// <summary>
        /// Longhand property "transform".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transform
        /// </summary>
        Transform,
        /// <summary>
        /// Longhand property "transform-origin".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transform-origin
        /// </summary>
        TransformOrigin,
        /// <summary>
        /// Longhand property "perspective-origin".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/perspective-origin
        /// </summary>
        PerspectiveOrigin,
        /// <summary>
        /// Longhand property "perspective".
        /// The property contains a single value of one of the following types:
        ///   none (<see cref='CssUnit.None'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/perspective
        /// </summary>
        Perspective,
        /// <summary>
        /// Longhand property "transform-style".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transform-style
        /// </summary>
        TransformStyle,
        /// <summary>
        /// Longhand property "backface-visibility".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/backface-visibility
        /// </summary>
        BackfaceVisibility,
        /// <summary>
        /// Longhand property "top".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/top
        /// </summary>
        Top,
        /// <summary>
        /// Longhand property "transition-delay".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='CssValue.Float'>time</see> (<see cref='CssUnit.Seconds'/> etc.).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transition-delay
        /// </summary>
        TransitionDelay,
        /// <summary>
        /// Longhand property "transition-duration".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='CssValue.Float'>time</see> (<see cref='CssUnit.Seconds'/> etc.).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transition-duration
        /// </summary>
        TransitionDuration,
        /// <summary>
        /// Longhand property "transition-property".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transition-property
        /// </summary>
        TransitionProperty,
        /// <summary>
        /// Longhand property "transition-timing-function".
        /// The property contains a list of values of one of the following types:
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Array'>cubic-bezier() or steps()</see> (<see cref='CssUnit.CubicBezier'/> or <see cref='CssUnit.Steps'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transition-timing-function
        /// </summary>
        TransitionTimingFunction,
        /// <summary>
        /// Longhand property "unicode-bidi".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/unicode-bidi
        /// </summary>
        UnicodeBidi,
        /// <summary>
        /// Longhand property "-moz-user-focus".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "user-focus" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-user-focus
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UserFocus,
        /// <summary>
        /// Longhand property "-moz-user-input".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "user-input" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-user-input
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UserInput,
        /// <summary>
        /// Longhand property "-moz-user-modify".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "user-modify" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-user-modify
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UserModify,
        /// <summary>
        /// Longhand property "-moz-user-select".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "user-select" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-user-select
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UserSelect,
        /// <summary>
        /// Longhand property "vertical-align".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/vertical-align
        /// </summary>
        VerticalAlign,
        /// <summary>
        /// Longhand property "visibility".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/visibility
        /// </summary>
        Visibility,
        /// <summary>
        /// Longhand property "white-space".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/white-space
        /// </summary>
        WhiteSpace,
        /// <summary>
        /// Longhand property "widows".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/widows
        /// </summary>
        Widows,
        /// <summary>
        /// Longhand property "width".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/width
        /// </summary>
        Width,
        /// <summary>
        /// Longhand property "-moz-window-shadow".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "window-shadow" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-window-shadow
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozWindowShadow,
        /// <summary>
        /// Longhand property "word-break".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/word-break
        /// </summary>
        WordBreak,
        /// <summary>
        /// Longhand property "word-spacing".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   normal (<see cref='CssUnit.Normal'/>),
        ///   <see cref='CssValue.Array'>calc()</see> (<see cref='CssUnit.Calc'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/word-spacing
        /// </summary>
        WordSpacing,
        /// <summary>
        /// Longhand property "word-wrap".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/word-wrap
        /// </summary>
        WordWrap,
        /// <summary>
        /// Longhand property "-moz-hyphens".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "hyphens" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-hyphens
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Hyphens,
        /// <summary>
        /// Longhand property "z-index".
        /// The property contains a single value of one of the following types:
        ///   auto (<see cref='CssUnit.Auto'/>),
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/z-index
        /// </summary>
        ZIndex,
        /// <summary>
        /// Longhand property "-moz-box-align".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-align" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-align
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxAlign,
        /// <summary>
        /// Longhand property "-moz-box-direction".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-direction" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-direction
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxDirection,
        /// <summary>
        /// Longhand property "-moz-box-flex".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-flex" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-flex
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxFlex,
        /// <summary>
        /// Longhand property "-moz-box-orient".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-orient" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-orient
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxOrient,
        /// <summary>
        /// Longhand property "-moz-box-pack".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-pack" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-pack
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxPack,
        /// <summary>
        /// Longhand property "-moz-box-ordinal-group".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "box-ordinal-group" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-box-ordinal-group
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BoxOrdinalGroup,
        /// <summary>
        /// Longhand property "-moz-stack-sizing".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "stack-sizing" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-stack-sizing
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        StackSizing,
        /// <summary>
        /// Longhand property "-moz-script-level".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "script-level" is not supported.
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Int'>integer</see> (<see cref='CssUnit.Integer'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-script-level
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ScriptLevel,
        /// <summary>
        /// Longhand property "-moz-script-size-multiplier".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "script-size-multiplier" is not supported.
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-script-size-multiplier
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ScriptSizeMultiplier,
        /// <summary>
        /// Longhand property "-moz-script-min-size".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "script-min-size" is not supported.
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-script-min-size
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        ScriptMinSize,
        /// <summary>
        /// Longhand property "clip-path".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/clip-path
        /// </summary>
        ClipPath,
        /// <summary>
        /// Longhand property "clip-rule".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/clip-rule
        /// </summary>
        ClipRule,
        /// <summary>
        /// Longhand property "color-interpolation".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/color-interpolation
        /// </summary>
        ColorInterpolation,
        /// <summary>
        /// Longhand property "color-interpolation-filters".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/color-interpolation-filters
        /// </summary>
        ColorInterpolationFilters,
        /// <summary>
        /// Longhand property "dominant-baseline".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/dominant-baseline
        /// </summary>
        DominantBaseline,
        /// <summary>
        /// Longhand property "fill".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/fill
        /// </summary>
        Fill,
        /// <summary>
        /// Longhand property "fill-opacity".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/fill-opacity
        /// </summary>
        FillOpacity,
        /// <summary>
        /// Longhand property "fill-rule".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/fill-rule
        /// </summary>
        FillRule,
        /// <summary>
        /// Longhand property "filter".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/filter
        /// </summary>
        Filter,
        /// <summary>
        /// Longhand property "flood-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flood-color
        /// </summary>
        FloodColor,
        /// <summary>
        /// Longhand property "flood-opacity".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flood-opacity
        /// </summary>
        FloodOpacity,
        /// <summary>
        /// Longhand property "image-rendering".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/image-rendering
        /// </summary>
        ImageRendering,
        /// <summary>
        /// Longhand property "lighting-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/lighting-color
        /// </summary>
        LightingColor,
        /// <summary>
        /// Longhand property "marker-end".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marker-end
        /// </summary>
        MarkerEnd,
        /// <summary>
        /// Longhand property "marker-mid".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marker-mid
        /// </summary>
        MarkerMid,
        /// <summary>
        /// Longhand property "marker-start".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marker-start
        /// </summary>
        MarkerStart,
        /// <summary>
        /// Longhand property "mask".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Uri'>URL</see> (<see cref='CssUnit.Url'/>),
        ///   none (<see cref='CssUnit.None'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/mask
        /// </summary>
        Mask,
        /// <summary>
        /// Longhand property "mask-type".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/mask-type
        /// </summary>
        MaskType,
        /// <summary>
        /// Longhand property "shape-rendering".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/shape-rendering
        /// </summary>
        ShapeRendering,
        /// <summary>
        /// Longhand property "stop-color".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Color'>color</see> (<see cref='CssUnit.Color'/>), <see cref='CssValue.String'>identifier</see> (<see cref='CssUnit.Ident'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stop-color
        /// </summary>
        StopColor,
        /// <summary>
        /// Longhand property "stop-opacity".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stop-opacity
        /// </summary>
        StopOpacity,
        /// <summary>
        /// Longhand property "stroke".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke
        /// </summary>
        Stroke,
        /// <summary>
        /// Longhand property "stroke-dasharray".
        /// See implementation for a list of possible values.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-dasharray
        /// </summary>
        StrokeDasharray,
        /// <summary>
        /// Longhand property "stroke-dashoffset".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-dashoffset
        /// </summary>
        StrokeDashoffset,
        /// <summary>
        /// Longhand property "stroke-linecap".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-linecap
        /// </summary>
        StrokeLinecap,
        /// <summary>
        /// Longhand property "stroke-linejoin".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-linejoin
        /// </summary>
        StrokeLinejoin,
        /// <summary>
        /// Longhand property "stroke-miterlimit".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-miterlimit
        /// </summary>
        StrokeMiterlimit,
        /// <summary>
        /// Longhand property "stroke-opacity".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-opacity
        /// </summary>
        StrokeOpacity,
        /// <summary>
        /// Longhand property "stroke-width".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='CssValue.Float'>length</see>,
        ///   <see cref='CssValue.Percent'>percent</see> (<see cref='CssUnit.Percent'/>),
        ///   <see cref='CssValue.Float'>number</see> (<see cref='CssUnit.Number'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/stroke-width
        /// </summary>
        StrokeWidth,
        /// <summary>
        /// Longhand property "text-anchor".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-anchor
        /// </summary>
        TextAnchor,
        /// <summary>
        /// Longhand property "text-rendering".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-rendering
        /// </summary>
        TextRendering,
        /// <summary>
        /// Longhand property "vector-effect".
        /// The property contains a single value of one of the following types:
        ///   inherit (<see cref='CssUnit.Initial'/> or <see cref='CssUnit.Inherit'/>),
        ///   <see cref='nsCSSKeywords'>keyword</see> (<see cref='CssUnit.Enumerated'/>).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/vector-effect
        /// </summary>
        VectorEffect,
        /// <summary>
        /// Longhand property "-x-lang".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "lang" is not supported.
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-x-lang
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        XLang,
        /// <summary>
        /// Longhand property "-x-span".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "span" is not supported.
        /// The property is internal, its value cannot be specified in a CSS file.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-x-span
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        XSpan,
        PropertyCountNoShorthands,
        [EditorBrowsable(EditorBrowsableState.Never)]
        PropertyCountDummy1 = PropertyCountNoShorthands - 1,
        /// <summary>
        /// Shorthand property "-moz-outline-radius".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "outline-radius" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-outline-radius
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozOutlineRadius,
        /// <summary>
        /// Shorthand property "animation".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/animation
        /// </summary>
        Animation,
        /// <summary>
        /// Shorthand property "background".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/background
        /// </summary>
        Background,
        /// <summary>
        /// Shorthand property "border".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border
        /// </summary>
        Border,
        /// <summary>
        /// Shorthand property "border-bottom".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-bottom
        /// </summary>
        BorderBottom,
        /// <summary>
        /// Shorthand property "border-color".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-color
        /// </summary>
        BorderColor,
        /// <summary>
        /// Shorthand property "-moz-border-end".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-end" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-end
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderEnd,
        /// <summary>
        /// Shorthand property "-moz-border-end-color".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-end-color" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-end-color
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderEndColor,
        /// <summary>
        /// Shorthand property "-moz-border-end-style".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-end-style" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-end-style
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderEndStyle,
        /// <summary>
        /// Shorthand property "-moz-border-end-width".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-end-width" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-end-width
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderEndWidth,
        /// <summary>
        /// Shorthand property "border-image".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-image
        /// </summary>
        BorderImage,
        /// <summary>
        /// Shorthand property "border-left".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left
        /// </summary>
        BorderLeft,
        /// <summary>
        /// Shorthand property "border-left-color".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-color
        /// </summary>
        BorderLeftColor,
        /// <summary>
        /// Shorthand property "border-left-style".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-style
        /// </summary>
        BorderLeftStyle,
        /// <summary>
        /// Shorthand property "border-left-width".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-left-width
        /// </summary>
        BorderLeftWidth,
        /// <summary>
        /// Shorthand property "border-right".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right
        /// </summary>
        BorderRight,
        /// <summary>
        /// Shorthand property "border-right-color".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-color
        /// </summary>
        BorderRightColor,
        /// <summary>
        /// Shorthand property "border-right-style".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-style
        /// </summary>
        BorderRightStyle,
        /// <summary>
        /// Shorthand property "border-right-width".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-right-width
        /// </summary>
        BorderRightWidth,
        /// <summary>
        /// Shorthand property "-moz-border-start".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-start" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-start
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderStart,
        /// <summary>
        /// Shorthand property "-moz-border-start-color".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-start-color" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-start-color
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderStartColor,
        /// <summary>
        /// Shorthand property "-moz-border-start-style".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-start-style" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-start-style
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderStartStyle,
        /// <summary>
        /// Shorthand property "-moz-border-start-width".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "border-start-width" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-start-width
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        BorderStartWidth,
        /// <summary>
        /// Shorthand property "border-style".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-style
        /// </summary>
        BorderStyle,
        /// <summary>
        /// Shorthand property "border-top".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-top
        /// </summary>
        BorderTop,
        /// <summary>
        /// Shorthand property "border-width".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-width
        /// </summary>
        BorderWidth,
        /// <summary>
        /// Shorthand property "border-radius".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/border-radius
        /// </summary>
        BorderRadius,
        /// <summary>
        /// Shorthand property "-moz-columns".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "columns" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-columns
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumns,
        /// <summary>
        /// Shorthand property "-moz-column-rule".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "column-rule" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-column-rule
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozColumnRule,
        /// <summary>
        /// Shorthand property "flex".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/flex
        /// </summary>
        Flex,
        /// <summary>
        /// Shorthand property "font".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/font
        /// </summary>
        Font,
        /// <summary>
        /// Shorthand property "list-style".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/list-style
        /// </summary>
        ListStyle,
        /// <summary>
        /// Shorthand property "margin".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin
        /// </summary>
        Margin,
        /// <summary>
        /// Shorthand property "-moz-margin-end".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "margin-end" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-margin-end
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MarginEnd,
        /// <summary>
        /// Shorthand property "margin-left".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-left
        /// </summary>
        MarginLeft,
        /// <summary>
        /// Shorthand property "margin-right".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/margin-right
        /// </summary>
        MarginRight,
        /// <summary>
        /// Shorthand property "-moz-margin-start".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "margin-start" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-margin-start
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MarginStart,
        /// <summary>
        /// Shorthand property "outline".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/outline
        /// </summary>
        Outline,
        /// <summary>
        /// Shorthand property "overflow".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/overflow
        /// </summary>
        Overflow,
        /// <summary>
        /// Shorthand property "padding".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding
        /// </summary>
        Padding,
        /// <summary>
        /// Shorthand property "-moz-padding-end".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "padding-end" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-padding-end
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        PaddingEnd,
        /// <summary>
        /// Shorthand property "padding-left".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-left
        /// </summary>
        PaddingLeft,
        /// <summary>
        /// Shorthand property "padding-right".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/padding-right
        /// </summary>
        PaddingRight,
        /// <summary>
        /// Shorthand property "-moz-padding-start".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property "padding-start" is not supported.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-padding-start
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        PaddingStart,
        /// <summary>
        /// Shorthand property "text-decoration".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/text-decoration
        /// </summary>
        TextDecoration,
        /// <summary>
        /// Shorthand property "transition".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/transition
        /// </summary>
        Transition,
        /// <summary>
        /// Shorthand property "marker".
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/marker
        /// </summary>
        Marker,
        /// <summary>
        /// Shorthand property "-moz-transform".
        /// It is specific to Mozilla Firefox (experimental or internal).
        /// Unprefixed property is <see cref="Transform">"transform"</see>.
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transform
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        MozTransform,
        PropertyCount,
        [EditorBrowsable(EditorBrowsableState.Never)]
        PropertyCountDummy2 = PropertyCount - 1,
        /// <summary>
        /// Property "-moz-transform-origin" in an alias for <see cref="TransformOrigin"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transform-origin
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransformOrigin,
        /// <summary>
        /// Property "-moz-perspective-origin" in an alias for <see cref="PerspectiveOrigin"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-perspective-origin
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozPerspectiveOrigin,
        /// <summary>
        /// Property "-moz-perspective" in an alias for <see cref="Perspective"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-perspective
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozPerspective,
        /// <summary>
        /// Property "-moz-transform-style" in an alias for <see cref="TransformStyle"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transform-style
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransformStyle,
        /// <summary>
        /// Property "-moz-backface-visibility" in an alias for <see cref="BackfaceVisibility"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-backface-visibility
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozBackfaceVisibility,
        /// <summary>
        /// Property "-moz-border-image" in an alias for <see cref="BorderImage"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-border-image
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozBorderImage,
        /// <summary>
        /// Property "-moz-transition" in an alias for <see cref="Transition"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transition
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransition,
        /// <summary>
        /// Property "-moz-transition-delay" in an alias for <see cref="TransitionDelay"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transition-delay
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransitionDelay,
        /// <summary>
        /// Property "-moz-transition-duration" in an alias for <see cref="TransitionDuration"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transition-duration
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransitionDuration,
        /// <summary>
        /// Property "-moz-transition-property" in an alias for <see cref="TransitionProperty"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transition-property
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransitionProperty,
        /// <summary>
        /// Property "-moz-transition-timing-function" in an alias for <see cref="TransitionTimingFunction"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-transition-timing-function
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozTransitionTimingFunction,
        /// <summary>
        /// Property "-moz-animation" in an alias for <see cref="Animation"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimation,
        /// <summary>
        /// Property "-moz-animation-delay" in an alias for <see cref="AnimationDelay"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-delay
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationDelay,
        /// <summary>
        /// Property "-moz-animation-direction" in an alias for <see cref="AnimationDirection"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-direction
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationDirection,
        /// <summary>
        /// Property "-moz-animation-duration" in an alias for <see cref="AnimationDuration"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-duration
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationDuration,
        /// <summary>
        /// Property "-moz-animation-fill-mode" in an alias for <see cref="AnimationFillMode"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-fill-mode
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationFillMode,
        /// <summary>
        /// Property "-moz-animation-iteration-count" in an alias for <see cref="AnimationIterationCount"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-iteration-count
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationIterationCount,
        /// <summary>
        /// Property "-moz-animation-name" in an alias for <see cref="AnimationName"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-name
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationName,
        /// <summary>
        /// Property "-moz-animation-play-state" in an alias for <see cref="AnimationPlayState"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-play-state
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationPlayState,
        /// <summary>
        /// Property "-moz-animation-timing-function" in an alias for <see cref="AnimationTimingFunction"/>.
        /// It is specific to Mozilla Firefox (obsolete).
        /// Online documentation: https://developer.mozilla.org/docs/Web/CSS/-moz-animation-timing-function
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        AliasMozAnimationTimingFunction,
        PropertyCountWithAliases,
        [EditorBrowsable(EditorBrowsableState.Never)]
        PropertyCountDummy3 = PropertyCountWithAliases - 1,
        //ExtraNoProperties,
        //ExtraAllProperties,
        ExtraXNoneValue,
        ExtraXAutoValue,
    }
}
